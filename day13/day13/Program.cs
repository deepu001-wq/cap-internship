using System;

namespace day13
{
    class Program
    {
        static void Main1(string[] args)
        {

            Console.Write("Enter the string:");
            string Str = Console.ReadLine();
            int i, v_count, c_count, len;
            v_count = 0;
            c_count = 0;
            len = Str.Length;
            for (i = 0; i < len; i++)
            {
                if (Str[i] == 'a' || Str[i] == 'e' || Str[i] == 'i' || Str[i] == 'o' || Str[i] == 'u' || Str[i] == 'A' || Str[i] == 'E' || Str[i] == 'I' || Str[i] == 'O' || Str[i] == 'U')
                {
                    v_count++;
                }
                else if ((Str[i] >= 'a' && Str[i] <= 'z') || (Str[i] >= 'A' && Str[i] <= 'Z'))
                {
                    c_count++;
                }
                
            }
            Console.Write("\nVowel in the string: {0}\n", v_count);
            Console.Write("Consonant in the string: {0}\n\n", c_count);


        }
    }
}
        


