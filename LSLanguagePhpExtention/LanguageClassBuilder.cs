using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSLanguagePhpExtention
{
    internal class LanguageClassBuilder
    {
        internal static string BuildClass(string lang,Dictionary<string,string> translations) {


            string translation_all = "";
            if (translations == null) NotificationManager.CreateNotification("");
            foreach (var translation in translations.Keys) {

                translation_all += Properties.Settings.Default.DefaultTranslation.Replace("{dictKey}", translation).Replace("{dictValue}", translations[translation].ToString());

            }

            string defaultLangString = Properties.Settings.Default.DefaultClass;
            return defaultLangString.Replace("{langKey}", lang).Replace("{translationAll}", translation_all);

        }
    }
}
