using Microsoft.VisualBasic;

namespace Anagram
{
    class Program
    {
        static void Main (string[] args)
        {
            //How to check if two Strings are anagrams of each other? (Example: "Listen" and "Silent")


            //Console.WriteLine ("Enter first string:");
            //string str1 = Console.ReadLine();
            //Console.WriteLine ("Enter second string:");
            //string str2 = Console.ReadLine();

            //char[] char1 = str1.ToLower().ToCharArray();
            //char[] char2 = str1.ToLower().ToCharArray();

            //Array.Sort(char1);
            //Array.Sort(char2);

            //string newWord1 = new string(char1);
            //string newWord2 = new string(char2);

            //if(newWord1 == newWord2)
            //{
            //    Console.WriteLine("The two strings are anagrams.");
            //}
            //else
            //{
            //    Console.WriteLine("The two strings are not anagrams.");
            //}

            //Console.ReadLine();


            // How to reverse String in C# using Iteration and Recursion?

            //string word = "Hello";
            //string result = "";
            //for(int i= word.Length -1; i >=0; i--)
            //{
            //    result += word[i];
            //}
            //Console.WriteLine(result); // Output: olleH


            // How to count number of words in a String?
            //int result = CountWordsInSentence( "Hello, how are you doing today?");
            //Console.WriteLine("The count of this words are: " + result);  // Output: 6

            // Palindrome
            string[] array =
            {
                "civic",
                "deleveled",
                "Hannah",
                "kayak",
                "level",
                "examiron",
                "racecar",
                "radar",
                "refer",
                "reviver",
                "easywcf",
                "rotator",
                "rotor",
                "sagas",
                "solos",
                "stats",
                "tenet",
                "Csharpstar",
                ""
            };
            foreach (string word in array)
            {
                bool isPalin = IsPalindrome(word);
                Console.WriteLine("The word " + word + " is palindrome? " + isPalin); 
            }

        }


        //How to count number of words in a String?
        public static int CountWordsInSentence(string sentence)
        {
            int result = 0;
            sentence = sentence.Trim();

            if (sentence == "") { return 0; }

            while (sentence.Contains("  "))
            {
                sentence = sentence.Replace("  ", " ");
            }

            foreach(string y in sentence.Split(' '))
            {
                result++;
            }

            return result;
        }

        public static bool IsPalindrome(string word)
        {
            int min = 0;
            int max = word.Length - 1;

            while(true)
                if(min > max) return true;
                else
                {
                    char a = word[min];
                    char b = word[max];
                    if(char.ToLower(a) != char.ToLower(b)) return false;
                    min++;
                    max--;
                }

        }

    }
}

