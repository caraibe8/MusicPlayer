using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using System.Diagnostics;
using System.IO;
using System.Xml;
using Utiliy;

namespace MusicPlayerLib
{
    public class TextManager
    {
        private static Dictionary<StringKey, string> strings;


        static TextManager()
        {
            string pathTexts = Environment.CurrentDirectory + "/Display/Text/strings.xml";

            if (!File.Exists(pathTexts))
                throw new FileNotFoundException(pathTexts + "could not be found.");
            setStrings(pathTexts);
        }

        private static void setStrings(string pathTexts)
        {
            strings = new Dictionary<StringKey, string>();
            const string NodeName = "String";
            const string AttributeName = "Key";

            List<StringKey> missingKeys = new List<StringKey>((StringKey[])Enum.GetValues(typeof(StringKey)));

            XmlReader reader = XmlReader.Create(pathTexts);
            while (reader.Read())
            {
                if (reader.LocalName == NodeName)
                {
                    int keyIndex = missingKeys.FindIndex(k => k.ToString() == reader.GetAttribute(AttributeName));
                    if(keyIndex != -1)
                    {
                        strings.Add(missingKeys[keyIndex], reader.ReadElementContentAsString());
                        missingKeys.RemoveWithoutOrder(missingKeys[keyIndex]);
                    }
                }
            }
        }

        public static string GetString(StringKey key)
        {
            if (!strings.ContainsKey(key))
                return MsgKeyNotFound;
            return strings[key];
        }

        public enum StringKey
        {
            KeyNotFound,
            FileNotFoundTitle, FileNotFoundMsg,
            FolderNotFoundTitle, FolderNotFoundMsg,
            LoadFileBtnText, LoadPlaylistBtnText, ShowPlaylistBtnText
        }

        //Message when key not found
        private const string MsgKeyNotFound = "Missing text";
    }
}
