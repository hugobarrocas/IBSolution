using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IBSolution.IO.Input;
using IBSolution.OBJECTS;

namespace IBSolution.OBJECTS
{
    class MidwayStation
    {
        DataTableReader dr;
        HashMap<string, Item> Asgard;
        Boolean Test = false;
        Dictionary<string, List<string>> SourceFileitems;
        Dictionary<string, string> SerialtoInstance;
        List<string> NotPresent;
        DataTable WithMajorMinor = new HopperFormat().getTable();
        DataTable LDOS_Tab = new HopperFormat().getTable();
        DataTable Review_Tab = new HopperFormat().getTable();

        public MidwayStation(DataTableReader dr)
        {
            this.dr = dr;
            this.Asgard = new HashMap<string, Item>();

        }

        //Chevron 7 Encoded
        public void StartWork()
        {
            Console.WriteLine("\nChevron 7 Encoded\n\n0>--Welcome to the MidwayStation--<0");

            DateTime Start = DateTime.Now;
            TimeSpan End = DateTime.Now - Start;
            int TotalLines = 0;
            while (dr.Read())
            {

                Item temp = new Item(dr);
                if (!this.Asgard.ContainsKey(temp.getInstance()))
                {
                    this.Asgard.Add(temp.getInstance(), temp);
                }
                else double_Coverage(dr);
                TotalLines++;


            }
            if (Test) End = DateTime.Now - Start;
            if (Test) Console.WriteLine("\nLoki Took :" + End);
            if (Test) Console.WriteLine("\nLoki Processed " + TotalLines + " Items");
            doSingleSourcing();
            check_Ldos_Configurations();
            if (Test) print_double_Coverages();
            if (Test) print_LDOS();
            if (Test) print_Items();
            if (Test) print_Review();
            //Hopperfy();
            Hopperfy3Tabs();
            Console.WriteLine("\nLoki Processed " + TotalLines + " Items");
        }

        public void double_Coverage(DataTableReader Elements)
        {
            Coverage Double_Coverage = new Coverage(Elements);
            Asgard[Elements.GetValue(7).ToString()].SetNextCoverage(Double_Coverage);

        }

        public void list_double_Coverages()
        {
            int dups = 0;
            foreach (KeyValuePair<string, Item> entry in Asgard)
            {
                if (entry.Value.getNumber_of_Coverages() > 1)
                {
                    dups++;
                    Console.WriteLine("\n" + entry.Value.printToConsole());
                    Console.WriteLine(entry.Value.printCoveragesToConsole());// do something with entry.Value or entry.Key
                }
            }
            Console.WriteLine("\n There are " + dups + " in this file");
        }

        public void print_double_Coverages()
        {
            int dups = 0;

            using (System.IO.StreamWriter file =
            new System.IO.StreamWriter(@"C:\Test\WriteDupCoverages.txt"))
            {
                foreach (KeyValuePair<string, Item> entry in Asgard)
                {
                    if (entry.Value.getNumber_of_Coverages() > 1)
                    {
                        dups++;
                        file.WriteLine("\n" + entry.Value.printToConsole() + "\n" + entry.Value.printCoveragesToConsole());
                    }
                }
            }

            Console.WriteLine("\nThere are " + dups + " item with duplicate coverage in this file");
        }

        public void check_Ldos_Configurations()
        {
            foreach (KeyValuePair<string, Item> entry in Asgard)
            {
                if (Asgard.ContainsKey(entry.Value.getParentInstance()))
                {
                    if (Asgard[entry.Value.getParentInstance()].isLDOS()) entry.Value.setLDOSConfig();
                }
                else entry.Value.setReviewStatus();
            }
        }

        public void print_LDOS()
        {
            int LDOS = 0;

            using (System.IO.StreamWriter file =
            new System.IO.StreamWriter(@"C:\Test\WriteLinesLDOS.txt"))
            {
                foreach (KeyValuePair<string, Item> entry in Asgard)
                {
                    if (entry.Value.isLDOSConfig())
                    {
                        LDOS++;
                        file.WriteLine("\n" + entry.Value.printToConsole() + " | " + entry.Value.check_Config_Alignment() + " -> " + entry.Value.getLDOSDate() + " | " + entry.Value.isLDOS() + " | " + entry.Value.isLDOSConfig());
                    }
                }
            }

            Console.WriteLine("\nThere are " + LDOS + " items from LDOS configurations in this file");
        }

        public void print_Items()
        {
            int items = 0;

            using (System.IO.StreamWriter file =
            new System.IO.StreamWriter(@"C:\Test\WriteAllLines.txt"))
            {
                foreach (KeyValuePair<string, Item> entry in Asgard)
                {

                    items++;
                    if (entry.Value.getCoveredStatus() == "Covered")
                    {
                        file.WriteLine("\n" + entry.Value.printToConsole() + "\n" + entry.Value.printCoveragesToConsole());
                    }
                    else file.WriteLine("\n" + entry.Value.printToConsole());

                }
            }

            Console.WriteLine("\nThere are " + items + " unique items in this file");
        }

        public void print_Review()
        {
            int items = 0;

            using (System.IO.StreamWriter file =
            new System.IO.StreamWriter(@"C:\Test\WriteReviewLines.txt"))
            {
                foreach (KeyValuePair<string, Item> entry in Asgard)
                {


                    if (entry.Value.getReviewStatus())
                    {
                        items++;
                        file.WriteLine("\n" + entry.Value.printToConsole() + "\n" + entry.Value.printCoveragesToConsole());
                    }

                }
            }

            Console.WriteLine("\nThere are " + items + " Items to Review in this file");
        }

        public void getSourceFileitems(Dictionary<string, List<string>> IncomingSourceFileitems)
        {
            this.SourceFileitems = IncomingSourceFileitems;
        }

        public void doSerialToInstance()
        {
            this.SerialtoInstance = new Dictionary<string, string>();
            foreach (KeyValuePair<string, Item> entry in Asgard)
            {
                if (entry.Value.getSerial() != "")
                {
                    if (!SerialtoInstance.ContainsKey(entry.Value.getSerial()))
                    {
                        SerialtoInstance.Add(entry.Value.getSerial(), entry.Value.getInstance());
                    }
                }

            }
        }

        public void doSingleSourcing()
        {
            doSerialToInstance();
            this.NotPresent = new List<string>();
            foreach (KeyValuePair<string, List<string>> entry in SourceFileitems)
            {
                if (entry.Value[0] == "Instance Number")
                {
                    foreach (string instance in entry.Value)
                    {
                        if (this.Asgard.ContainsKey(instance))
                        {
                            this.Asgard[instance].SetSourceDataFile(entry.Key);
                            this.Asgard[instance].SetInDataFile(true);
                        }
                        else this.NotPresent.Add(instance);
                    }
                }

                else if (entry.Value[0] == "Serial Number")
                {
                    foreach (string Serial_Number in entry.Value)
                    {
                        if (SerialtoInstance.ContainsKey(Serial_Number))
                        {
                            string instance = SerialtoInstance[Serial_Number];
                            if (this.Asgard.ContainsKey(instance))
                            {
                                this.Asgard[instance].SetSourceDataFile(entry.Key);
                                this.Asgard[instance].SetInDataFile(true);
                            }
                        }
                        else this.NotPresent.Add(Serial_Number);
                    }
                }

            }
            doConfigurationSingleSourcing();

        }

        public void doConfigurationSingleSourcing()
        {
            foreach (KeyValuePair<string, Item> entry in Asgard)
            {
                if (entry.Value.getSourceFile() == "")
                {
                    if (Asgard.ContainsKey(entry.Value.getParentInstance()))
                    {
                        entry.Value.SetSourceDataFile("Child of Parent found in " + Asgard[entry.Value.getParentInstance()].getSourceFile());
                    }
                    else entry.Value.setReviewStatus();
                }

            }
        }

        public String Serial2Instance(String Serial)
        {

            foreach (KeyValuePair<string, Item> entry in Asgard)
            {
                if (entry.Value.getSerial() == Serial) return entry.Value.getInstance();
            }
            return "";

        }

        public void Hopperfy()
        {
            int items = 0;
            {
                foreach (KeyValuePair<string, Item> entry in Asgard)
                {
                    Object[] Line = entry.Value.toObjectArray();
                    this.WithMajorMinor.Rows.Add(Line);
                    items++;
                }
            }
            Console.WriteLine("\nHopperfied");
        }

        public DataTable[] getHopperFormat()
        {
            DataTable[] dataTables = new DataTable[]{
                this.WithMajorMinor
            };
            return dataTables;
        }

        public DataTable[] getHopperFormat3()
        {
            DataTable[] dataTables = new DataTable[]{
                this.WithMajorMinor,
                this.Review_Tab,
                this.LDOS_Tab
            };
            return dataTables;
        }

        public void Hopperfy3Tabs()
        {
            int WithMajorMinor_Items = 0;
            int LDOS_Items = 0;
            int Review_Items = 0;
            {
                foreach (KeyValuePair<string, Item> entry in Asgard)
                {
                    if (entry.Value.isLDOSConfig())
                    {
                        Object[] LDOS_Line = entry.Value.toObjectArray();
                        this.LDOS_Tab.Rows.Add(LDOS_Line);
                        LDOS_Items++;
                    }
                    else if (entry.Value.isReview())
                    {
                        Object[] Review_Line = entry.Value.toObjectArray();
                        this.LDOS_Tab.Rows.Add(Review_Line);
                        Review_Items++;
                    }
                    else
                    {
                        Object[] Line = entry.Value.toObjectArray();
                        this.WithMajorMinor.Rows.Add(Line);
                        WithMajorMinor_Items++;
                    }
                }
            }
            Console.WriteLine("\nHopperfied");
        }

    }
}
