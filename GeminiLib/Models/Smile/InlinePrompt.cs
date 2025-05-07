using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#pragma warning disable CS8618

namespace GeminiLib.Smile
{
    public class InlinePrompt : Prompt
    { 
        public string MimeType { get; set; }

        public byte[] Content { get; set; }
    }
}
