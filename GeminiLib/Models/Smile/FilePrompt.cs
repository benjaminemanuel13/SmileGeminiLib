﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#pragma warning disable CS8618

namespace GeminiLib.Smile
{
    public class FilePrompt : Prompt
    {
        public string MimeType { get; set; }

        public string FileUri { get; set; }
    }
}
