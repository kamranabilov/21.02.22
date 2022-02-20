using System;

namespace Work21._02._22
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("username-i daxil et");
            string name = Console.ReadLine();
            Console.WriteLine("passwordu daxil et");
            string password = Console.ReadLine();

            //User user = new User(name, password);
            //Console.WriteLine("Username {LeoMessi}");
            //Console.WriteLine("Password {Messi123}");

            Console.WriteLine(("parol duzgun daxil edildi"));
            //Console.ReadLine();

        }

        //static bool checkPassword(string input, int minumum)
        //{
        //    bool hasNum = false;
        //    bool hasUpper = false;
        //    char currentCharacter;

        //    if (input.Length >= minumum)
        //    {
        //        return false;
        //    }
        //    for (int i = 0; i < input.Length; i++)
        //    {
        //        currentCharacter = input[i];
        //        if (char.IsDigit(currentCharacter))
        //        {
        //            hasNum = true;
        //        }
        //        else if (char.IsUpper(currentCharacter))
        //        {
        //            hasUpper = true;
        //        }
        //        if (hasNum && hasUpper)
        //        {
        //            return true;
        //        }
        //    }

        //    return false;
        //}


    }
}
