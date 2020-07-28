using System;
using System.Dynamic;
using System.Text.RegularExpressions;
using System.Xml.Schema;

namespace inClass5
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Console.WriteLine("Hello World!");

            string original = "SupeRFlY";
            string lower = original.ToLower();
            bool determine;
            string newWord = "";

            Console.WriteLine(original);
            Console.WriteLine(lower);

            foreach (char c in original)
            {
                char newChar;

                if (Char.IsUpper(c))
                {
                    newChar = char.ToUpper(c);
                    newWord += newChar;
                    determine = true;
                }
                else
                {
                    newChar = c;
                    newWord += newChar;
                    determine = false;
                }
                Console.WriteLine(determine);
            }

            Console.WriteLine(newWord);
            */


            /*
            string[] colors = { "purple", "blue", "turquoise", "brown", "green" };


            bool successful = false;
            while (!successful)
            {
                try
                {
                    string input = GetUserInput();
                    int numberInput = int.Parse(input);
                    Console.WriteLine(colors[numberInput]);
                    

                    if (numberInput == 2)
                    {
                        throw new Exception("I told you not to give #2! Thanks.");
                    }
                    successful = true;
                }
                catch(IndexOutOfRangeException)
                {
                    Console.WriteLine("Hey! I need a number from 0-4. Thanks!");
                }
                catch(FormatException parseDontWorkOnNumbers)
                {
                    Console.WriteLine(parseDontWorkOnNumbers.Message);
                    Console.WriteLine("In English - I need a number. Thanks!");
                }
                catch (Exception exception)
                {
                    Console.WriteLine(exception.Message);
                    
                    Console.WriteLine("Something went wrong! Let's try again");
                }
                finally
                {
                    Console.WriteLine("That's a wrap!!");
                }
            }
            */





            /*
            //SAME THING USING METHODS
            string[] colors = { "purple", "blue", "turquoise", "brown", "green", "red", "orange", "yellow", "indigo", "violet", "rainbow!" };


            int numberInput = GetUserNumber($"Please give me a number between 0 & {colors.Length - 1}!", colors.Length - 1);

            Console.WriteLine(colors[numberInput]);
            */






            //REGULAR EXPRESSIONS
            Console.WriteLine("Hey! gimme a word that starts with b, ends with t, and only has vowels in between. ");
            string input = Console.ReadLine();

            //go to "Show Potential fixes", add "using System.Text.RegularExpressions;" up top
            if (Regex.IsMatch(input, @"\b(b[aeiou]{ 1,}t)\b"))
            {
                Console.WriteLine("Yay!");
            }
            else
            {
                Console.WriteLine("Boo!");
            }
        }

        public static bool VerifyNumberInRange (int maxIndex, int userNumber)
        {
            if (userNumber > maxIndex || userNumber < 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public static string GetUserInput (string message)
        {
            Console.WriteLine(message);
            string input = Console.ReadLine();

            return input;
        }

        public static int GetUserNumber (string message, int maxIndex)
        {
            while(true)
            {
                string input = GetUserInput(message);
                try
                {
                    int numberInput = int.Parse(input);

                    bool verifyNumberInRange = VerifyNumberInRange(maxIndex, numberInput);

                    if (verifyNumberInRange == true)
                    {
                        return numberInput;
                    }
                    else
                    {
                        throw new Exception("Number not in the Range");
                    }
                    
                }
                catch (FormatException)
                {
                    Console.WriteLine("Incorrect Format. " + message);
                }
                catch(Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
        }
    }
}
