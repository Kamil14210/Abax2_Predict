using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace odczytTemperatury
{
    class SaveToFile
    {
        public void Saver_(string wartosc_zmiennej)
        {

            string path = @"input.txt";

            using (StreamWriter sw = File.AppendText(path))
            {
                sw.WriteLine(wartosc_zmiennej);
                sw.Close();
            }

        }
    }
}
