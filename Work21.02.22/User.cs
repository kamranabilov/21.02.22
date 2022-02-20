using System;
using System.Collections.Generic;
using System.Text;

namespace Work21._02._22
{
    class User
    {
        private string Username;
        private string Password;

        public User( string username, string password)
        {
            Username = username;
            Password = password;
        }
        public string username
        {
            get
            {
                return username;
            }
            set
            {
                while (true)
                {
                    if (value.Length > 6)
                    {
                        Console.WriteLine("Username-1 duzgun daxil et");
                        value = Console.ReadLine();
                    }
                    else
                    {
                        Username = value;
                        break;
                    }
                }
               
            }
        }

        public string password
        {
            get
            {
                return password;
            }
            set
            {
                //while (true)
                //{
                //    if (value.Length > 0)
                //    {
                //        Console.WriteLine("parol min 1 reqem ve boyuk herf olmalidir");
                //        value = Console.ReadLine();
                //    }
                //    else
                //    {
                //        bool checkUpper = false;
                //        bool checkDigit = false;
                //        for (int i = 0; i < value.Length; i++)
                //        {
                //            if (char.IsUpper(value[i]))
                //            {
                //                checkUpper = true;
                //            }
                //            if (char.IsDigit(value[i]))
                //            {
                //                checkDigit = true;
                //                break;
                //            }
                //        }
                //        if (checkUpper && checkDigit)
                //        {
                //            password = value;
                //            break;
                //        }
                //else
                //{
                //    Console.WriteLine("Parolu duzgun daxil et");
                //    value = Console.ReadLine();

                //}
                //    }
                //}

                static bool checkPassword(string input, int minumum)
                {
                    bool hasNum = false;
                    bool hasUpper = false;
                    char currentCharacter;



                    if (input.Length >= minumum)
                    {
                        return false;
                    }
                    for (int i = 0; i < input.Length; i++)
                    {
                        currentCharacter = input[i];
                        if (char.IsDigit(currentCharacter))
                        {
                            hasNum = true;
                        }
                        else if (char.IsUpper(currentCharacter))
                        {
                            hasUpper = true;
                        }
                        if (hasNum && hasUpper)
                        {
                            return true;
                        }
                    }

                    return false;
                }


            }
        }
    }
}
