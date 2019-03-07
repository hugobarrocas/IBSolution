using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IBSolution.IO.Input
{
    class InText
    {
        Dictionary<string, List<string>> Fileitems;



        public InText(string DirPath)
        {

            if (!Directory.Exists(DirPath))
            {
                Console.WriteLine("Ups!! Directory: " + DirPath + "is unreachable");

            }
            else
            {
                this.Fileitems = new Dictionary<string, List<string>>();
                processFiles(DirPath);
            }

        }


        private void processFiles(string DirPath)
        {
            foreach (string file in Directory.EnumerateFiles(@DirPath, "*.txt"))
            {
                readFile(file);
            }
        }


        public Dictionary<string, List<string>> getDataFromfiles()
        {


            return Fileitems;
        }



        private void readFile(string FilePath)
        {
            List<string> linesFromfile = new List<string>(File.ReadAllLines(FilePath));
            Fileitems.Add(Path.GetFileNameWithoutExtension(FilePath), linesFromfile);
        }

    }
}
