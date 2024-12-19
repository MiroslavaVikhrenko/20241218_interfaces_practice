using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20241219_task6
{
    internal class SecretMessage : ICipher
    {
        public const string alphabet = "abcdefghijklmnopqrstuvwxyz ,.!:ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        public const string cipher = "bcdefghijklmnopqrstuvwxyza ,.!:BCDEFGHIJKLMNOPQRSTUVWXYZA";
        public string Text { get; set; }

        public string Encode()
        {
            StringBuilder s = new StringBuilder();
            for (int i = 0; i < Text.Length; i++)
            {
                char c = Text[i];

                for (int j = 0; j < alphabet.Length; j++)
                {
                    if (c == alphabet[j])
                    {
                        s.Append(cipher[j]);
                    }
                }
            }
            return s.ToString();
        }

        public string Decode(string str)
        {
            StringBuilder s = new StringBuilder();
            for (int i = 0; i < str.Length; i++)
            {
                char c = str[i];

                for (int j = 0; j < cipher.Length; j++)
                {
                    if (c == cipher[j])
                    {
                        s.Append(alphabet[j]);
                    }
                }
            }
            return s.ToString();
        }
    }
}
