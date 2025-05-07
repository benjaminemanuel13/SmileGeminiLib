using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeminiLib.Google
{
    public class UsageMetadata
    {
        public int promptTokenCount { get; set; }

        public int candidatesTokenCount { get; set; }

        public int totalTokenCount { get; set; }
    }
}
