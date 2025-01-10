using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkingWithText
{
    internal class StringShorter
    {
        const int MaxLength= 20;
        public static string Summarize(string s)
        {
            if (s.Length <= MaxLength)
            {
                return s;
            }
            else
            {
                var list = new List<string>();
                var wordCount = 0;
                var words = s.Split(" ");
                foreach (var word in words)
                {
                    list.Add(word);
                    wordCount += word.Length + 1;
                    if (wordCount > MaxLength)
                    {
                        break;
                    }

                }

                return string.Join(" ", list)+"...";

            }

        }

    }
}
