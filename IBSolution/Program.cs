using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IBSolution.IO.Input;
using IBSolution.OBJECTS;
using IBSolution.IO.Output;
using System.Windows.Forms;
using IBSolution.Graph;
using System.IO;
using System.Diagnostics;

namespace IBSolution
{

    class Program
    {
        public static string SourceFilesDir = "";
        public static string SniffileToWork = "";
        public static string filepath = "";
        // needs to be here  for win forms apps to disable comment 
        [STAThread]
        static void Main(string[] args)
        {
          
            // code for graphic mode  to disable comment
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Form beautyfier = new MainForm();
            Application.Run(beautyfier);
            //TODO: por proteccção para o caso dos Paths virem vazios 

            String Version = "V 0.2";

            string[] tablenames = new string[1];
            tablenames[0] = "WithMajorMinor";

            string[] tablenames3 = new string[3];
            tablenames3[0] = "WithMajorMinor";
            tablenames3[1] = "WithMajorMinorReview";
            tablenames3[2] = "LDOS and Config";

            
            Console.WriteLine("\n  u  " + "\n  o  " + "\n /|-º " + "\n / \\ Starting Program\n");
            if((SourceFilesDir=="" ) || (SniffileToWork =="") || (filepath ==""))
            {
                Console.WriteLine("Proper Environment was not setup:");
                Console.WriteLine("Bye Bye!");
                Console.ReadKey();
                System.Environment.Exit(1);
            }
            Console.WriteLine(Version);
            Console.WriteLine("\nLet the Trickery Begin!!!");
            Console.WriteLine("\nStart at " + DateTime.Now);
            Console.WriteLine("Sources to be consolidate from DIR:");
            Console.WriteLine(SourceFilesDir);
            Console.WriteLine("Line Details File Going to be used: " + Path.GetFileName(SniffileToWork));
            Console.WriteLine("target Directory:" );
              Console.WriteLine(Path.GetDirectoryName(filepath));
            Console.WriteLine("Final File: "+Path.GetFileName(filepath));
            Console.WriteLine("press enter to proceed or close to cancel");
            Console.ReadKey();
            //string SourceFilesDir = "";
            //string SniffileToWork = "";

            //Console.WriteLine("\nPlease insert the Filepath for Line details File");
            //SniffileToWork = Console.ReadLine();
            Console.WriteLine("\nFilepath for Source Files - Accepted\nChevron 1 Encoded\n");
            //Console.WriteLine("\nChevron 1 Encoded\n \nPlease insert the Directory path for Source Files");
            //SourceFilesDir = Console.ReadLine();

            Console.WriteLine("\nFilepath for Details File - Accepted\nChevron 2 Encoded\n");
            //Console.WriteLine("\nChevron 2 Encoded\n \nPlease insert the Filepath for Output File");
            //String filepath = Console.ReadLine();
            Console.WriteLine("\nFilepath for Output File - Accepted\nChevron 3 Encoded\n");
            //Console.WriteLine("\nChevron 3 Encoded\n");
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
            //OutExcel excelWriter = new OutExcel(filepath, tablenames, IBSolution.getHopperFormat());
            OutExcel excelWriter = new OutExcel(filepath, tablenames3, IBSolution.getHopperFormat3());
            Console.WriteLine("\nExcelWriter Ended at " + DateTime.Now);

            Console.WriteLine("\nProgram Ended at " + DateTime.Now);
            Console.WriteLine("\nProgram Done your File has been Stored in ");
            Console.WriteLine(filepath);

            Console.WriteLine("\n  u  " + "\n  o  " + "\n /|\\ " + "\n / \\ Please Press Enter to close");
            String bye = Console.ReadLine();
            Process.Start("explorer.exe", Path.GetDirectoryName(filepath));
            System.Environment.Exit(1);

        }
    }
}
