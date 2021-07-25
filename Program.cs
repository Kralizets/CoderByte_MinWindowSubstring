using System;

namespace MinWindowSubstring
{
    class Program
    {
        public static string MinWindowSubstring(string[] strArr)
        {
            for (int i = strArr[1].Length; i <= strArr[0].Length; i++)
            {
                for (int j = 0; j + i <= strArr[0].Length; j++)
                {
                    string substr = strArr[0].Substring(j, i);

                    if (IsCorrect(substr, strArr[1]))
                        return substr;
                }
            }
            // code goes here  
            return strArr[0];

        }

        private static bool IsCorrect(string str, string substring)
        {
            bool isCorrect = false;
            for (int i = 0; i < substring.Length; i++)
            {
                isCorrect = false;
                for (int j = 0; j < str.Length; j++)
                {
                    if (substring[i].Equals(str[j]))
                    {
                        str = str.Remove(j, 1);
                        isCorrect = true;
                        break;
                    }
                }

                if (!isCorrect)
                    return isCorrect;
            }

            return isCorrect;
        }

        static void Main()
        {
            // keep this function call here
            Console.WriteLine(MinWindowSubstring(new string[] { "aaabaaddae", "aed" }));
        }
    }
}
