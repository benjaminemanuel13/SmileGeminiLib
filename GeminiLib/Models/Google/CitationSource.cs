using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#pragma warning disable CS8618

namespace GeminiLib.Google
{
    public class CitationSource
    {
        public int startIndex { get; set; }

        public int endIndex { get; set; }

        public string uri { get; set; }

        public string licence { get; set; }
    }
}
