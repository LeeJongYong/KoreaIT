using System;

namespace DotNetNote.Services
{
    public class CopyrightService
    {
        public string GetCopyrightString()
        {
            return $"Copyright {DateTime.Now.Year} all right reserved." +
                $" from Copyright. {GetHashCode()}";
        }

        public string CopyrightString { get; set; } = $"Copyright {DateTime.Now.Year} all right reserved.";
    }
}
