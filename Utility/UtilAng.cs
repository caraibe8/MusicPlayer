using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using static System.Math;
using static System.Convert;

namespace Utiliy
{
    public class Integers
    {
        public static int ReadInt32(string p_question)
        {
            int nb;
            do
            {
                Write(p_question);
            }
            while ((Int32.TryParse(ReadLine(), out nb)) == false);
            return nb;
        }
        public static int ReadInt32(string p_question, string p_errorMsg)
        {
            int nb;
            for (; ; )
            {
                Write(p_question);
                /***/
                if ((Int32.TryParse(ReadLine(), out nb))) break;
                /***/
                Write(p_errorMsg);
            }
            return nb;
        }

        public static int ReadPositiveInt32(string p_question)
        {
            int nb;
            for (; ; )
            {
                Write(p_question);
                /***/
                if ((Int32.TryParse(ReadLine(), out nb)))
                    if (nb >= 0) break;
                /***/
            }
            return nb;
        }
        public static int ReadPositiveInt32(string p_question, string p_errorMsg)
        {
            int nb;
            for (; ; )
            {
                Write(p_question);
                /***/
                if ((Int32.TryParse(ReadLine(), out nb)))
                    if (nb >= 0) break;
                /***/
                Write(p_errorMsg);
            }
            return nb;
        }

        public static int LireInt32Négatif(string p_question)
        {
            int nb;
            for (; ; )
            {
                Write(p_question);
                /***/
                if ((Int32.TryParse(ReadLine(), out nb)))
                    if (nb <= 0) break;
                /***/
            }
            return nb;
        }
        public static int LireInt32Négatif(string p_question, string p_msgErreur)
        {
            int nb;
            for (; ; )
            {
                Write(p_question);
                /***/
                if ((Int32.TryParse(ReadLine(), out nb)))
                    if (nb <= 0) break;
                /***/
                Write(p_msgErreur);
            }
            return nb;
        }

        public static int ReadMinimumInt32(string p_question, int p_minimum)
        {
            int nb;
            for (; ; )
            {
                Write(p_question);
                /***/
                if ((Int32.TryParse(ReadLine(), out nb)))
                    if (nb >= p_minimum) break;
                /***/
            }
            return nb;
        }
        public static int ReadMinimumInt32(string p_question, int p_minimum, string p_errorMsg)
        {
            int nb;
            for (; ; )
            {
                Write(p_question);
                /***/
                if ((Int32.TryParse(ReadLine(), out nb)))
                    if (nb >= p_minimum) break;
                /***/
                Write(p_errorMsg);
            }
            return nb;
        }

        public static int ReadMaximumInt32(string p_question, int p_maximum)
        {
            int nb;
            for (; ; )
            {
                Write(p_question);
                /***/
                if ((Int32.TryParse(ReadLine(), out nb)))
                    if (nb <= p_maximum) break;
                /***/
            }
            return nb;
        }
        public static int ReadMaximumInt32(string p_question, int p_maximum, string p_errorMsg)
        {
            int nb;
            for (; ; )
            {
                Write(p_question);
                /***/
                if ((Int32.TryParse(ReadLine(), out nb)))
                    if (nb <= p_maximum) break;
                /***/
                Write(p_errorMsg);
            }
            return nb;
        }

        public static int ReadInt32InInterval(string p_question, int p_minimum, int p_maximum)
        {
            int nb;
            for (; ; )
            {
                Write(p_question);
                /***/
                if ((Int32.TryParse(ReadLine(), out nb)))
                    if (nb >= p_minimum && nb <= p_maximum) break;
                /***/
            }
            return nb;
        }
        public static int ReadInt32InInterval(string p_question, int p_minimum, int p_maximum, string p_errorMsg)
        {
            int nb;
            for (; ; )
            {
                Write(p_question);
                /***/
                if ((Int32.TryParse(ReadLine(), out nb)))
                    if (nb >= p_minimum && nb <= p_maximum) break;
                /***/
                Write(p_errorMsg);
            }
            return nb;
        }

        public static int ReadOddInt32(string p_question)
        {
            int nb;
            for (; ; )
            {
                Write(p_question);
                /***/
                if (Int32.TryParse(ReadLine(), out nb))
                    if ((nb % 2) == 1) return nb;
                /***/
            }
        }
        public static int ReadOddInt32(string p_question, string p_errorMsg)
        {
            int nb;
            for (; ; )
            {
                Write(p_question);
                /***/
                if (Int32.TryParse(ReadLine(), out nb))
                    if ((nb % 2) == 1) return nb;
                /***/
                Write(p_errorMsg);
            }
        }

        public static int ReadEvenInt32(string p_question)
        {
            int nb;
            for (; ; )
            {
                Write(p_question);
                /***/
                if (Int32.TryParse(ReadLine(), out nb))
                    if ((nb % 2) == 0) return nb;
                /***/
            }
        }
        public static int ReadEvenInt32(string p_question, string p_errorMsg)
        {
            int nb;
            for (; ; )
            {
                Write(p_question);
                /***/
                if (Int32.TryParse(ReadLine(), out nb))
                    if ((nb % 2) == 0) return nb;
                /***/
                Write(p_errorMsg);
            }
        }
    }

    public class Doubles
    {
        public static double ReadDouble(string p_question)
        {
            double nb;
            for (; ; )
            {
                Write(p_question);
                /***/
                if ((Double.TryParse(ReadLine(), out nb))) break;
                /***/
            }
            return nb;
        }
        public static double ReadDouble(string p_question, string p_errorMsg)
        {
            double nb;
            for (; ; )
            {
                Write(p_question);
                /***/
                if ((Double.TryParse(ReadLine(), out nb))) break;
                /***/
                Write(p_errorMsg);
            }
            return nb;
        }

        public static double ReadPositiveDouble(string p_question)
        {
            double nb;
            for (; ; )
            {
                Write(p_question);
                /***/
                if ((Double.TryParse(ReadLine(), out nb)))
                    if (nb >= 0) break;
                /***/
            }
            return nb;
        }
        public static double ReadPositiveDouble(string p_question, string p_errorMsg)
        {
            double nb;
            for (; ; )
            {
                Write(p_question);
                /***/
                if ((Double.TryParse(ReadLine(), out nb)))
                    if (nb >= 0) break;
                /***/
                Write(p_errorMsg);
            }
            return nb;
        }

        public static double ReadNegativeDouble(string p_question)
        {
            double nb;
            for (; ; )
            {
                Write(p_question);
                /***/
                if ((Double.TryParse(ReadLine(), out nb)))
                    if (nb <= 0) break;
                /***/
            }
            return nb;
        }
        public static double ReadNegativeDouble(string p_question, string p_errorMsg)
        {
            double nb;
            for (; ; )
            {
                Write(p_question);
                /***/
                if ((Double.TryParse(ReadLine(), out nb)))
                    if (nb <= 0) break;
                /***/
                Write(p_errorMsg);
            }
            return nb;
        }

        public static double ReadMinimumDouble(string p_question, double p_minimum)
        {
            double nb;
            for (; ; )
            {
                Write(p_question);
                /***/
                if ((Double.TryParse(ReadLine(), out nb)))
                    if (nb >= p_minimum) break;
                /***/
            }
            return nb;
        }
        public static double ReadMinimumDouble(string p_question, double p_minimum, string p_errorMsg)
        {
            double nb;
            for (; ; )
            {
                Write(p_question);
                /***/
                if ((Double.TryParse(ReadLine(), out nb)))
                    if (nb >= p_minimum) break;
                /***/
                Write(p_errorMsg);
            }
            return nb;
        }

        public static double ReadMaximumDouble(string p_question, double p_minimum)
        {
            double nb;
            for (; ; )
            {
                Write(p_question);
                /***/
                if ((Double.TryParse(ReadLine(), out nb)))
                    if (nb <= p_minimum) break;
                /***/
            }
            return nb;
        }
        public static double ReadMaximumDouble(string p_question, double p_minimum, string p_errorMsg)
        {
            double nb;
            for (; ; )
            {
                Write(p_question);
                /***/
                if ((Double.TryParse(ReadLine(), out nb)))
                    if (nb <= p_minimum) break;
                /***/
                Write(p_errorMsg);
            }
            return nb;
        }

        public static double ReadDoubleInInterval(string p_question, double p_minimum, double p_maximum)
        {
            double nb;
            for (; ; )
            {
                Write(p_question);
                /***/
                if ((Double.TryParse(ReadLine(), out nb)))
                    if (nb >= p_minimum && nb <= p_maximum) break;
                /***/
            }
            return nb;
        }
        public static double ReadDoubleInInterval(string p_question, double p_minimum, double p_maximum, string p_errorMsg)
        {
            double nb;
            for (; ; )
            {
                Write(p_question);
                /***/
                if ((Double.TryParse(ReadLine(), out nb)))
                    if (nb >= p_minimum && nb <= p_maximum) break;
                /***/
                Write(p_errorMsg);
            }
            return nb;
        }
    }

    public class Characters
    {
        public static char ReadChar(string p_question)
        {
            char caractère;
            for (; ; )
            {
                Write(p_question);
                /***/
                if (Char.TryParse(ReadLine(), out caractère)) break;
                /***/
            }
            return caractère;
        }
        public static char ReadChar(string p_question, string p_errorMsg)
        {
            char caractère;
            for (; ; )
            {
                Write(p_question);
                /***/
                if (Char.TryParse(ReadLine(), out caractère)) break;
                /***/
                Write(p_errorMsg);
            }
            return caractère;
        }

        public static char ReadNormalizedChar(string p_question)
        {
            char caractère;
            for (; ; )
            {
                Write(p_question);
                /***/
                if (Char.TryParse(ReadLine(), out caractère)) break;
                /***/
            }
            return Char.ToUpper(caractère);
        }
        public static char ReadNormalizedChar(string p_question, string p_errorMsg)
        {
            char caractère;
            for (; ; )
            {
                Write(p_question);
                /***/
                if (Char.TryParse(ReadLine(), out caractère)) break;
                /***/
                Write(p_errorMsg);
            }
            return Char.ToUpper(caractère);
        }
        public static char ReadNormalizedChar(string p_question, bool uppercase)
        {
            char caractère;
            if (uppercase)
            {
                for (; ; )
                {
                    Write(p_question);
                    /***/
                    if (Char.TryParse(ReadLine(), out caractère)) break;
                    /***/
                }
                return Char.ToUpper(caractère);
            }
            for (; ; )
            {
                Write(p_question);
                /***/
                if (Char.TryParse(ReadLine(), out caractère)) break;
                /***/
            }
            return Char.ToLower(caractère);
        }
        public static char ReadNormalizedChar(string p_question, string p_errorMsg, bool uppercase)
        {
            char caractère;
            if (uppercase)
            {
                for (; ; )
                {
                    Write(p_question);
                    /***/
                    if (Char.TryParse(ReadLine(), out caractère)) break;
                    /***/
                    Write(p_errorMsg);
                }
                return Char.ToUpper(caractère);
            }
            for (; ; )
            {
                Write(p_question);
                /***/
                if (Char.TryParse(ReadLine(), out caractère)) break;
                /***/
                Write(p_errorMsg);
            }
            return Char.ToLower(caractère);
        }
    }

    public class Strings
    {
        public static string ReadString(string p_question)
        {
            Write(p_question);
            return ReadLine().Trim();
        }

        public static string ReadStringControledSize(string p_question, int p_minSize, int p_maxSize)
        {
            string texte;
            for (; ; )
            {
                Write(p_question);
                texte = ReadLine().Trim();
                /***/
                if (p_minSize <= texte.Length && p_maxSize >= texte.Length) break;
                /***/
            }
            return texte;
        }
        public static string ReadStringControledSize(string p_question, int p_minSize, int p_maxSize, string p_errorMsg)
        {
            string texte;
            for (; ; )
            {
                Write(p_question);
                texte = ReadLine().Trim();
                /***/
                if (p_minSize <= texte.Length && p_maxSize >= texte.Length) break;
                /***/
                WriteLine(p_errorMsg);
            }
            return texte;
        }

        public static string ReadStringNotEmpty(string p_question)
        {
            string texte;
            for (; ; )
            {
                Write(p_question);
                texte = ReadLine().Trim();
                /***/
                if (texte.Length > 0) break;
                /***/
            }
            return texte;
        }
        public static string ReadStringNotEmpty(string p_question, string p_errorMsg)
        {
            string texte;
            for (; ; )
            {
                Write(p_question);
                texte = ReadLine().Trim();
                /***/
                if (texte.Length > 0) break;
                /***/
                Write(p_errorMsg);
            }
            return texte;
        }
    }

    public class Boolean
    {
        public static bool AnswerYesNo(string p_question)
        {
            char réponse;
            for (; ; )
            {
                Write(p_question);
                /***/
                if (Char.TryParse(ReadLine(), out réponse))
                    if (Char.ToUpper(réponse) == 'Y' || Char.ToUpper(réponse) == 'N')
                        return réponse == 'Y';
                /***/
            }
        }
        public static bool AnswerYesNo(string p_question, string p_errorMsg)
        {
            char réponse;
            for (; ; )
            {
                Write(p_question);
                /***/
                if (Char.TryParse(ReadLine(), out réponse))
                    if (Char.ToUpper(réponse) == 'Y' || Char.ToUpper(réponse) == 'N')
                        return réponse == 'Y';
                /***/
                Write(p_errorMsg);
            }
        }
        public static bool IsPrimeNumber(int p_nb)
        {
            bool premier = p_nb % 2 != 0;
            int racineDuNombre = ToInt32(Sqrt(p_nb));
            for (int diviseur = 3; premier && diviseur <= racineDuNombre; diviseur += 2)
            {
                if (p_nb % diviseur == 0)
                    premier = false;
            }
            return premier;
        }
        public static bool IsValidDate(int p_year, int p_month, int p_day)
        {
            try
            {
                new DateTime(p_year, p_month, p_day);
            }
            catch
            {
                return false;
            }
            return true;
        }
        public static bool IsValidDate(string p_date, out DateTime p_result)
        {
            try
            {
                p_result = ToDateTime(p_date);
            }
            catch
            {
                p_result = new DateTime();
                return false;
            }
            return true;
        }
    }

    public static class Lists
    {
        /// <summary>
        /// Détermine et renvoi la plus petite valeur d'une liste.
        /// </summary>
        /// <param name="p_valeurs">Liste ne contenant que des valeurs réels ou entières</param>
        /// <param name="p_plusPetiteValeur">Plus petite valeur contenu dans la liste</param>
        /// <returns></returns>
        public static bool SmallestValue(List<double> p_values, out double p_smallestValue)
        {
            if (p_values.Count == 0)
            {
                p_smallestValue = 0;
                return false;
            }

            p_smallestValue = p_values[0];
            foreach (double i in p_values)
            {
                if (i < p_smallestValue)
                    p_smallestValue = i;
            }
            return true;
        }
        /// <summary>
        /// Détermine et renvoi la plus grande valeur d'une liste.
        /// </summary>
        /// <param name="p_valeurs">Liste ne contenant que des valeurs réels ou entières</param>
        /// <param name="p_plusGrandeValeur">Plus grande valeur contenu dans la liste</param>
        /// <returns></returns>
        public static bool BiggestValue(List<double> p_values, out double p_biggestValue)
        {
            if (p_values.Count == 0)
            {
                p_biggestValue = 0;
                return false;
            }
            p_biggestValue = p_values[0];
            foreach (double i in p_values)
            {
                if (i < p_biggestValue)
                    p_biggestValue = i;
            }
            return true;
        }

        public static void RemoveWithoutOrder<T>(this List<T> list, T valueToRemove)
        {
            int indiceARetirer = list.IndexOf(valueToRemove);
            list[indiceARetirer] = list[list.Count - 1];
            list.RemoveAt(list.Count - 1);
        }
        public static void RemoveAllWithoutOrder<T>(this List<T> list, Predicate<T> p_predicate)
        {
            int nbRetraits = 0;
            for (int i = 0; i != list.Count - nbRetraits;)
            {
                if (!p_predicate(list[i]))
                    ++i;
                else
                {
                    ++nbRetraits;
                    list[i] = list[list.Count - nbRetraits];
                }
            }
            list.RemoveRange(list.Count - nbRetraits, nbRetraits);
        }
    }

    public static class Time
    {
        public static DateTime ReadDate(string p_question)
        {
            for (; ; )
            {
                Write(p_question);
                /***/
                if (Boolean.IsValidDate(ReadLine(), out DateTime réponse)) return réponse;
                /***/
            }
        }

        public static DateTime ReadMinimumDate(string p_question, DateTime p_minDate)
        {
            for (; ; )
            {
                DateTime réponse = ReadDate(p_question);
                if (réponse >= p_minDate) return réponse;
            }
        }

        public static DateTime ReadDateInInterval(string p_question, DateTime p_minDate, DateTime p_maxDate)
        {
            for (; ; )
            {
                DateTime réponse = ReadDate(p_question);
                if (réponse >= p_minDate && réponse <= p_maxDate) return réponse;
            }
        }

        public static double GetAge(DateTime p_birthDate, DateTime p_currentDate = new DateTime())
        {
            if (p_currentDate == new DateTime())
                p_currentDate = DateTime.Today;

            return (p_currentDate - p_birthDate).TotalDays / 365.25;
        }

        public static double GetAgeWithSentinel(string p_question, string p_sentinel, DateTime p_currentDate = new DateTime())
        {
            if (p_currentDate == new DateTime())
                p_currentDate = DateTime.Today;
            for (; ; )
            {
                Write(p_question);

                string réponse = ReadLine();
                /***/
                if (réponse == p_sentinel) return -1;
                if (DateTime.TryParse(réponse, out DateTime dateNaissance))
                {
                    return (p_currentDate - dateNaissance).TotalDays / 365.25;
                }
                /***/
            }
        }
    }

    public static class Other
    {
        public static double ConvertOn100(int p_trueValue, int p_maxValue)
        {
            double pourcentage = 100 * p_trueValue / p_maxValue;
            return pourcentage;
        }
        public static double ConvertOn100(int p_trueValue, double p_maxValue)
        {
            double pourcentage = 100 * p_trueValue / p_maxValue;
            return pourcentage;
        }
        public static double ConvertOn100(double p_trueValue, int p_maxValue)
        {
            double pourcentage = 100 * p_trueValue / p_maxValue;
            return pourcentage;
        }
        public static double ConvertOn100(double p_trueValue, double p_maxValue)
        {
            double pourcentage = 100 * p_trueValue / p_maxValue;
            return pourcentage;
        }
        public static double ConvertOn100(double p_trueValue, double p_maxValue, bool integer)
        {
            double pourcentage;
            if (integer)
                return pourcentage = Math.Round(100 * p_trueValue / p_maxValue);
            return pourcentage = 100 * p_trueValue / p_maxValue;
        }
        public static double ConvertOn1(double p_trueValue, double p_maxValue)
        {
            double Sur1 = 1 * p_trueValue / p_maxValue;
            return Sur1;
        }
        public static double ConvertOnX(double p_trueValue, double p_maxValue, double p_x)
        {
            double valeurConverti = p_x * p_trueValue / p_maxValue;
            return valeurConverti;
        }
    }

    public class Stopwatch
    {
        public enum TimeMeasurement
        {
            Miliseconde, Seconde, Minute, Heure, Jour
        }

        public Stopwatch()
        {
            Start = DateTime.Now;
        }

        private DateTime Start { get; }
        private DateTime End { get; }

        public double StopStopwatch(TimeMeasurement mesureDeTemps)
        {


            return (End - Start).TotalMilliseconds;
        }
    }
}
