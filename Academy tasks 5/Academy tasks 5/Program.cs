using System;

namespace Academy_tasks_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] fullnames = { "Hikmet Abbas", "Tofiq Qulamov", "Nermin Abbasova" };

            string[] newArr = MakeName(fullnames);
            for (int i = 0; i < newArr.Length; i++)
            {
                Console.WriteLine(newArr[i]);
            }

            string name = "";
            do
            {
                Console.WriteLine("Adinizi daxil edin...");
                name = Console.ReadLine();

            } while (!Isname(name));


            string email = Console.ReadLine();
            do
            {
                Console.WriteLine("Email daxil edin...");
                email = Console.ReadLine();

            } while (!email.Contains('@'));


            string result = GetDomein(email);
            Console.WriteLine(result);

        }
        static string GetDomein(string email)
        {
            var atIndex = email.IndexOf('@');
            var domein = email.Substring(atIndex + 1);
            return domein;

        }

        static bool Isname(string str)
        {
            if (string.IsNullOrWhiteSpace(str))
            {
                return false;
            }

            if (!Char.IsUpper(str[0]))
            {
                return false;
            }

            for (int i = 1; i < str.Length; i++)
            {
                if (!Char.IsLower(str[i]))
                {
                    return false;
                }
            }
            return true;
        }

        static string[] MakeName(string[] fullnames)
        {

            string[] newArray = new string[fullnames.Length];
            int j = 0;
            for (int i = 0; i < fullnames.Length; i++)
            {
                newArray[j] = fullnames[i].Trim().Substring(0, fullnames[i].Trim().IndexOf(' '));
                j++;
            }
            return newArray;
        }

        static string[] MakeNewArr(string[] str)
        {
            string[] newStr = new string[0];

            for (int i = 0; i < str.Length; i++)
            {

                if (Array.IndexOf(newStr, str[i]) == -1)
                {
                    Array.Resize(ref newStr, newStr.Length + 1);
                    newStr[newStr.Length - 1] = str[i];
                }
            }
            return newStr;

        }

        static string MakeCapitalize(string word)
        {
            return char.ToUpper(word[0]) + word.Substring(1).ToLower();

        }
    }
}
