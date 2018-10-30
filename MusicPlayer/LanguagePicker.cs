using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace MusicPlayer
{
    class LanguagePicker
    {
        public static CultureInfo CultureInfo { get; private set; }

        public static void SetCultureInfo(CultureInfo cultureInfo)
        {
            if (CultureInfo != null)
                throw new AccessViolationException();
            CultureInfo = cultureInfo;
        }
    }
}
