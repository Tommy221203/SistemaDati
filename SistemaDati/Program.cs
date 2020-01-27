using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace SistemaDati
{
    class Program
    {
        private static string line;
        static void Main(string[] args)
        {
            const string FILEREAD = "file.txt";
            const string FILEWRITE = "newfile.txt";
            HashSet<int> intList = new HashSet<int>();
            using (StreamReader r = new StreamReader(FILEREAD))
            {
                while ((line = r.ReadLine()) != null)
                {
                    int d = int.Parse(line);
                    intList.Add(d);
                }
            }
            using (StreamWriter w = new StreamWriter(FILEWRITE))
            {
                foreach(int s in intList)
                {
                    w.WriteLine(s);
                }
            }
        }
    }
}
