using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace string_manipulation
{
    class StringAid
    {
        private string _str;

        public StringAid()
        {
            _str = "This is a test string. You should submit something.";
        }

        public StringAid(string str)
        {
            _str = str;
        }

        public string Str
        {
            get { return _str; }
            set { _str = value; }
        }

        public string LongestWord()
        {
            int index = 0;
            string holder, word, longest = "";
            char c;

            holder = Str + " ";

            for (int i = 0; i < holder.Length; i++)
            {
                c = holder[i];

                if (c == ' ' || c == '.' || c == ',' || c == '!' || c == '?') 
                {
                    word = holder.Substring(index, i - index);

                    if (word.Length > longest.Length)
                    {
                        longest = word;
                    }

                    index = i + 1;
                }
            }

            return longest;
        }

        public bool feelingLucky()
        {
            string lucky = "lucky";
            string test;

            bool result = false;

            int tailEnd = lucky.Length;

            for (int i = 0; i < (Str.Length - 4); i++)
            {
                test = Str.Substring(i, tailEnd);

                if (test.ToLower() == lucky)
                {
                    result = true;
                }
            }

            return result;
        }
    }
}
