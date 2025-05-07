using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#pragma warning disable CS8618

namespace GeminiLib.Google
{
    public enum FinishReason
    { }

    public class Candidate
    {
        public Content content { get; set; }

        public string finishReason { get; set; }

        public List<SafetyRating> safetyRatings { get; set; }

        public CitationMetadata citationMetadata { get; set; }

        public int tokenCount { get; set; }

        public int index { get; set; }
    }
}
