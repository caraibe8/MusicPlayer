using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using System.Diagnostics;
using System.IO;

namespace MusicPlayerLib
{
    public class LanguagePicker
    {
        private static readonly CultureInfo[] SupportedLanguages;

        private static readonly CultureInfo DefaultLanguage = CultureInfo.GetCultureInfo("English").Parent;

        private static readonly string PathLanguages;

        private static Dictionary<string, string> strings;

        public static CultureInfo CultureInfo { get; private set; }


        static LanguagePicker()
        {
            List<CultureInfo> supportedLanguage = new List<CultureInfo>();
            PathLanguages = Environment.CurrentDirectory;

            foreach (string filePath in System.IO.Directory.GetFiles(PathLanguages))
            {
                CultureInfo currentFilesLanguage;
                try
                {
                    currentFilesLanguage = CultureInfo.GetCultureInfo(filePath.Substring(filePath.LastIndexOf('/') + 1, filePath.LastIndexOf('.') - filePath.LastIndexOf('/')));
                }
                catch (CultureNotFoundException)
                {
                    continue;
                }
                supportedLanguage.Add(currentFilesLanguage);
            }

            SupportedLanguages = supportedLanguage.ToArray();
        }

        public static void SetCultureInfo(CultureInfo cultureInfo)
        {
            if (CultureInfo != null)
                throw new AccessViolationException();
            if (IsLanguageSupported(cultureInfo))
                CultureInfo = cultureInfo;
            else if (IsLanguageSupported(DefaultLanguage))
                CultureInfo = DefaultLanguage;
            else
                throw new FileNotFoundException();
        }

        public static string GetString(string key)
        {
            if (!strings.ContainsKey(key))
                return MsgKeyNotFound;
            return strings[key];

        }

        public static bool IsLanguageSupported(CultureInfo language) => SupportedLanguages.Contains(language);

        //Message when key not found
        private const string MsgKeyNotFound = "Missing text";

        //Keys
        public const string KeyFileNotFoundTitle = "TitleFileNotFound";
        public const string KeyFileNotFoundMsg = "MsgFileNotFound";

    }
}
