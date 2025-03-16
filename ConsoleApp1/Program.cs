using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool enterHit = false;
            while(true)
            {
                DateTime latestPressedTime = DateTime.Now;
                string input = "";
                Console.WriteLine("Start typing using old phone keypad... (Press 'Enter' to finish)");
                while (true)
                {
                    
                    var inputKey = Console.ReadKey();
                    if(inputKey.Key == ConsoleKey.Enter)
                    {
                        enterHit = true;
                        break;
                    }
                    if (inputKey.KeyChar == '#')
                    {
                        break;
                    }
                    DateTime currentPressedTime = DateTime.Now;
                    if (inputKey.KeyChar != '*')
                    {
                        if ((currentPressedTime - latestPressedTime).TotalSeconds > 1)
                        {
                            input += " ";
                        }

                    }
                    latestPressedTime = currentPressedTime;
                    input += inputKey.KeyChar;
                }
                if(!enterHit )
                {
                    Console.WriteLine("\nInput value -> " + input + "#");
                    string output = OldPhonePad(input);
                    Console.WriteLine("Output value -> " + output.ToString() + "\n");
                }
                else
                {
                    break;
                }
            }
        }

        public static String OldPhonePad(string input)
        {
            input = input.Trim();

            var key = new string[]
            {
                " ",    //0
                "",    //1
                "ABC",    //2
                "DEF",    //3
                "GHI",    //4
                "JKL",    //5
                "MNO",    //6
                "PQRS",    //7
                "TUV",    //8
                "WXYZ",    //9
            };

            string[] splitInput = input.Split(' ');
            StringBuilder output = new StringBuilder();
            char prev = '0';
            foreach (string c in splitInput)
            {
                int count = 0;
                int index = 0;
                foreach (char ch in c)
                {
                    if (ch == '*')
                    {
                        prev = '0';
                        count = 0;
                    }
                    else if (char.IsDigit(ch))
                    {
                        if (prev == ch)
                        {
                            count++;
                        }
                        else
                        {
                            if (count >= 1)
                            {
                                index = prev - '0';
                                while (key[index].Count() < count)
                                {
                                    int keyCount = key[index].Count();
                                    count -= keyCount;
                                }

                                output.Append((key[index])[count - 1].ToString());
                                
                            }
                            count = 1;
                            prev = ch;
                        }
                    }
                }
                // eg. 227*
                if (count > 0)
                {
                    index = prev - '0';
                    while (key[index].Count() < count)
                    {
                        int keyCount = key[index].Count();
                        count -= keyCount;
                    }

                    output.Append((key[index])[count - 1].ToString());
                }
            }
            return output.ToString();
        }
    }
}
