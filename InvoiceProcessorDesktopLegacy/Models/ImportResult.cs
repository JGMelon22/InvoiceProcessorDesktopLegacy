using System.Collections.Generic;

namespace InvoiceProcessorDesktopLegacy.Models
{
    public class ImportResult
    {
        public bool Success { get; set; }

        public string Message { get; set; }

        public int ProcessedCount { get; set; }

        public int ErrorCount { get; set; }

        public List<string> Errors { get; set; }

        public ImportResult()
        {
            Errors = new List<string>();
        }
    }
}
