using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime;

using System.Net.Http.Headers;
using System.Net.Http;
using GeminiLib.Google;
using GeminiLib.Smile;

#pragma warning disable CS0219
#pragma warning disable CS8600
#pragma warning disable CS8602

namespace GeminiLib.Services
{
    public class GeminiService
    {
        public static string APIKey { get; set; } = string.Empty;

        public GeminiService()
        {
        }

        public async Task<string> GenerateContentListed(Prompt[] prompts, string genModel = "gemini-2.0-flash", double temperature = 1.0)
        {
            var url = "https://generativelanguage.googleapis.com/v1beta/models/" + genModel + ":generateContent?key=" + APIKey;

            GenerateContentRequest req = new GenerateContentRequest()
            {
                contents = new List<Content>(){
                    new Content() {
                        role= "USER",
                        parts = new List<Part>()
                    }
                },
                generationConfig = new GenerationConfig()
                {
                    temperature = temperature
                }
            };

            foreach (var prompt in prompts)
            {
                if (prompt is TextPrompt)
                {
                    req.contents[0].parts.Add(new Part()
                    {
                        text = ((TextPrompt)prompt).Text
                    });
                }
                else if (prompt is InlinePrompt)
                {
                    var dat = prompt as InlinePrompt;

                    req.contents[0].parts.Add(new Part()
                    {
                        inlineData = new Blob()
                        {
                            mimeType = dat.MimeType,
                            data = Convert.ToBase64String(dat.Content)
                        }
                    });
                }
                else if (prompt is FilePrompt)
                {
                    var dat = prompt as FilePrompt;

                    req.contents[0].parts.Add(new Part()
                    {
                        fileData = new FileData()
                        {
                            mimeType = dat.MimeType,
                            fileUri = dat.FileUri
                        }
                    });
                }
            }

            string json = JsonConvert.SerializeObject(req);

            HttpClient client = new HttpClient();
            StringContent content = new StringContent(json, Encoding.UTF8, "application/json");

            var res = await client.PostAsync(url, content);

            if (res.IsSuccessStatusCode)
            {
                json = await res.Content.ReadAsStringAsync();

                GenerateContentResponse response = JsonConvert.DeserializeObject<GenerateContentResponse>(json);

                if (response.candidates[0].finishReason == "STOP")
                {
                    Part part = response.candidates[0].content.parts[0];
                    return part.text;
                }
            }

            return "FAILED";
        }
    }
}
