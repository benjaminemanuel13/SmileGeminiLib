
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#pragma warning disable CS8618

namespace GeminiLib.Google
{
    public class GenerateContentRequest
    {
        public List<Content> contents { get; set; }

        public GenerationConfig generationConfig { get; set; }
    }
}
