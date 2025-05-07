using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#pragma warning disable CS8618

namespace GeminiLib.Google
{
    public enum BlockReason
    {
        BLOCK_REASON_INSPECIFIED,
        SAFETY,
        OTHER
    }

    public class PromptFeedback
    {
        public string blockReason { get; set; }

        public List<SafetyRating> safetyRatings { get; set; }
    }
}
