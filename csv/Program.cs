using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csv
{
    class Program
    {
        static void Main(string[] args)
        {

            foreach (var item in ReadCsv1("airquality.csv"))
            {
                foreach(var column in item)
                {
                    Console.Write(column + ' ');
                }
                Console.WriteLine();
            }
        }
        static IEnumerable<string[]> ReadCsv1(string path)
        {    
            using (var textReader = new StreamReader(path))
            {
                while (true)
                {
                    var str = textReader.ReadLine();
                    if (str == null)
                        yield break;
                    string[] ar = str.Split(',');
                    for (int i = 0; i < ar.Length; i++)
                    {
                        if (ar[i] == "NA")
                        {
                            ar[i] = null;
                        }
                    }
                    yield return ar;
                }
            }
               
        }
    }
}
