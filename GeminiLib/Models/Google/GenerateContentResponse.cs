using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#pragma warning disable CS8618

namespace GeminiLib.Google
{
    public class GenerateContentResponse
    {
        public List<Candidate> candidates { get; set; }

        public PromptFeedback promptFeedback { get; set; }

        public UsageMetadata usageMetadata { get; set; }
    }
}
