using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    public class Configuration
    {
        public static int LanguageId = int.Parse(ConfigurationSettings.AppSettings["ek_DefaultContentLanguage"]); // 1033;

    }
}
