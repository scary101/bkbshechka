using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lostbkb
{
    class SmallNote
    {
        public string name;
        public string deck;
        public DateTime data;
    }
    class BigNote
    {
        public string name;
        public List<string> note = new List<string>(); 
        public void AddNumber(string zam)
        {
            note.Add(zam); 
        }

        public void PrintNumbers()
        {
            Console.WriteLine(name);
            foreach (string notessss in note)
            {
                Console.WriteLine(notessss); 
            }
        }

    }

}  

