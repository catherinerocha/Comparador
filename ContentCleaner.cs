using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comparador
{
    class ContentCleaner
    {
        public string ReplaceCharacters(string content, string checkbox)
        {

            switch (checkbox)
            {
                case "1":
                    content = content.Replace("\r", "");
                    break;
                case "2":
                    content = content.Replace(",", "\n");
                    break;
                case "3":
                    content = content.Replace(" ", "\n");
                    break;
                case "4":
                    content = content.Replace("-", "\n");
                    break;
            }

            return content;
        }
    }
}
