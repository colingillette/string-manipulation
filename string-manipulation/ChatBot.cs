using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace string_manipulation
{
    class ChatBot
    {
        private string _context;
        private string[] _keywords;

        public ChatBot(string context)
        {
            _context = context;
            _keywords = new string[] { "default", "default", "default", "default" };
        }

        public string Context
        {
            get { return _context; }
            set { _context = value; }
        }

        public string[] Keywords
        {
            get { return _keywords; }
            set { _keywords = value; }
        }

        public void SetContext()
        {
            
        }
    }
}
