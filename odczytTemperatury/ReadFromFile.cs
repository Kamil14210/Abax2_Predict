using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace odczytTemperatury
{
    class ReadFromFile
    {
        public void Reader_(string zmienna_odczytana)
        {
            string line;
            StreamReader sr = new StreamReader(@"Sample.txt");
            line = sr.ReadLine();
            while (line != null)
            {
                
                //Read the next line
                line = sr.ReadLine();
            }
        }
        }
}
