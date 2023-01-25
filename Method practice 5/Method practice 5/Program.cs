using System;

namespace Method_practice_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Task 1
            Console.WriteLine("Yazi daxil edin...");
            string word = Console.ReadLine();
            bool result = HasDigit(word);
            Console.WriteLine(result);
            #endregion

            #region Task 2
            Console.WriteLine("Yazi daxil edin...");
            string str = Console.ReadLine();
            bool fullName = HasFullName(str);
            Console.WriteLine(fullName);
            #endregion

            #region Task 3
            int[] numbers = { 2, 5, 8, 1, 8, 15, 34, 2, 15 };
            var newNumbers = MakeUniqueArray(numbers);
            Console.WriteLine("Elementleri tekrarlanmayan array...");
            for (int i = 0; i < newNumbers.Length; i++)
            {
                Console.WriteLine(newNumbers[i]);
            }
            #endregion

            #region Task 4
            string[] emails = { "Nigar@code.edu.az", "Hikmet@gmail.com", "Arzu.Agaksyeva@mail.ru", "aynz.alieva@gmail.com" };
            var domains = MakeDomains(emails);
            for (int i = 0; i < domains.Length; i++)
            {
                Console.WriteLine(domains[i]);
            }
            #endregion

            #region Task 5
            string sentences = "Obyekt anlayışı proqramlaşdırmada mühüm rol oynayır. Proqram obyektləri real həyatdakı obyektlərə çox bənzəyir. Kompüterin ekranındakı hər bir şeyə obyekt kimi baxmaq olar.";
            int count = CountSentences(sentences);
            Console.WriteLine(count);
            #endregion
        }

        //Verilmiş yazıda rəqəm olub olmadığını tapan metod
        static bool HasDigit(string str)
        {
            for (int i = 0; i < str.Length; i++)
            {
                if (Char.IsDigit(str[i]))
                {
                    return true;
                }
            }
            return false;
           
        }

        //Verilmiş yazının fullname olub olmadığını tapan metod
        //(fullname olması üçün iki sozdən ibarət olmalıdır və hər bir söz
        //böyük hərflə başlayıb kiçik hərflərlə davam etməlidir)
        static bool HasFullName(string str)
        {
            if (string.IsNullOrWhiteSpace(str))
            {
                return false;
            }
            str = str.Trim();
            var newStr = str.Split(' ');
            if (newStr.Length!=2)
            {
                return false;
            }
            if (!(Char.IsUpper(newStr[0][0]) && Char.IsUpper(newStr[1][0])))
            {
                return false;
            }
            for (int i = 0; i < newStr.Length; i++)
            {
                for (int j = 1; j < newStr[i].Length; j++)
                {
                    if (!Char.IsLower(newStr[i][j]))
                    {
                        return false;
                    }
                }
            }
            return true;
        }

        //Verilmiş ədədlər siyahısından yeni bir array düzəldib qaytaran metod.
        //Yeni arrayə elementlər təkrarlanmamaq şərti ilə yerləşdirilsin.
        static int[] MakeUniqueArray(int[] array)
        {
            int[] newArr = new int[0];
            for (int i = 0; i < array.Length; i++)
            {
                if (Array.IndexOf(newArr, array[i]) == -1)
                {
                    Array.Resize(ref newArr, newArr.Length + 1);
                    newArr[newArr.Length - 1] = array[i];
                }
            }
            return newArr;
        }

        //Verilmiş email-lər siyahısından domainlər siyahısı düzəldən metod.
        //Domainlər arrayondə təkrarlanmamlıdır domainlər!
        static string[] MakeDomains(string[] str)
        {
            string[] newStr = new string[0];

            for (int i = 0; i < str.Length; i++)
            {
                string domain = str[i].Substring(str[i].IndexOf('@'));
                if (Array.IndexOf(newStr, domain) == -1)
                {
                    Array.Resize( ref newStr, newStr.Length + 1);
                    newStr[newStr.Length - 1] = domain;
                }
            }
            return newStr;
        }

        //Verilmiş yazının içindəki cümlələrin sayını tapan metod.
        static int CountSentences(string str)
        {
            int count = 0;
            var newStr = str.Split(". ");
            for (int i = 0; i < newStr.Length; i++)
            {
                count++;
            }
            return count;
        }
    }
}
