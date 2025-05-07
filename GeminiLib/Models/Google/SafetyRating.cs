using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#pragma warning disable CS8618

namespace GeminiLib.Google
{
    public enum HarmCategory
    {

    }

    public enum HarmProbability
    {
        HARM_PROBABILITY_UNSPECIFIED,
        NEGLIGIBLE,
        LOW,
        MEDIUM,
        HIGH
    }

    public class SafetyRating
    {
        public string category { get; set; }

        public string probability { get; set; }

        public bool blocked { get; set; }
    }
}
