using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IBSolution.IO.Input;
using IBSolution.OBJECTS;
using System.Collections.Generic;
using IBSolution.IO.Output;
namespace IBSolution
{

    class Program
    {
        static void Main(string[] args)
        {

            String Version = "V 0.2";

            string[] tablenames = new string[1];
            tablenames[0] = "WithMajorMinor";
            Console.WriteLine("\n  u  " + "\n  o  " + "\n /|-º " + "\n / \\ Starting Program\n");

            Console.WriteLine(Version);
            Console.WriteLine("\nLet the Trickery Begin!!!");
            Console.WriteLine("\nStart at " + DateTime.Now);
            string SourceFilesDir = "";
            string SniffileToWork = "";

            Console.WriteLine("\nPlease insert the Filepath for Line details File");
            SniffileToWork = Console.ReadLine();
            Console.WriteLine("\nChevron 1 Encoded\n \nPlease insert the Directory path for Source Files");
            SourceFilesDir = Console.ReadLine();

            Console.WriteLine("\nChevron 2 Encoded\n \nPlease insert the Filepath for Output File");
            String filepath = Console.ReadLine();
            Console.WriteLine("\nChevron 3 Encoded\n");
            DataTable dt = null;
            DataTableReader dr = null;
            Dictionary<string, List<string>> SourceFileitems = null;

            Console.WriteLine("\nExcelReader Started at " + DateTime.Now);
            Console.WriteLine("\nPlease Wait...");
            InExcel excelReader = new InExcel(SniffileToWork);
            dt = excelReader.getTable();
            dr = dt.CreateDataReader();
            MidwayStation IBSolution = new MidwayStation(excelReader.getTable().CreateDataReader());
            Console.WriteLine("\nChevron 4 Encoded\n \nExcelReader Ended at " + DateTime.Now);

            Console.WriteLine("\nTextReader Started at " + DateTime.Now);
            InText textReader = new InText(SourceFilesDir);
            SourceFileitems = textReader.getDataFromfiles();
            Console.WriteLine("\nChevron 5 Encoded \nTextReader Ended at " + DateTime.Now);

            Console.WriteLine("\nChevron 6 Encoded \nMidwayStation Started at " + DateTime.Now);
            IBSolution.getSourceFileitems(SourceFileitems);
            IBSolution.StartWork();
            Console.WriteLine("\nMidwayStation Ended at " + DateTime.Now);

            Console.WriteLine("\nExcelWriter Started at " + DateTime.Now);
            Console.WriteLine("\nPlease Wait...");
            OutExcel excelWriter = new OutExcel(filepath, tablenames, IBSolution.getHopperFormat());
            Console.WriteLine("\nExcelWriter Ended at " + DateTime.Now);

            Console.WriteLine("\nProgram Ended at " + DateTime.Now);
            Console.WriteLine("\nProgram Done your File has been Stored in " + filepath);

            Console.WriteLine("\n  u  " + "\n  o  " + "\n /|\\ " + "\n / \\ Please Press Enter to close");
            String bye = Console.ReadLine();

        }
    }
}
