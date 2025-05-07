using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#pragma warning disable CS8618

namespace GeminiLib.Google
{
    public class Part
    {
        public string text { get; set; }

        public Blob inlineData { get; set; }

        public FileData fileData { get; set; }
    }
}
