using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IBSolution.OBJECTS;
using IBSolution.IO.Input;
using System.Data;

namespace IBSolution.OBJECTS
{
    class Item
    {

        String Product_Number;
        String Product_Description;
        DateTime Last_Date_of_Support;
        DateTime Last_Date_of_Sale;
        String PAK_Serial_Number;
        String Parent_PAK_Serial_Number;
        String Major_Minor;
        String Instance_Number;
        String Parent_Instance_Number;
        String Installed_Base_Status;
        String End_Customer_GU;
        String End_Customer_GU_Name;
        String End_Customer_ID;
        String End_Customer_Name;
        String End_Customer_Address;
        String End_Customer_City;
        String End_Customer_State;
        String End_Customer_Province;
        String End_Customer_County;
        String End_Customer_Country;
        String End_Customer_Zip_Postal_Code;
        String Potential_Takeover;
        String Host_MAC_ID;
        String Carton_ID;
        String Quantity;
        String SO_Number;
        String PO_Number;
        String Replacement_Serial_Number;
        String Product_Family;
        String Product_Group;
        String Product_Sub_Type;
        String Item_Type;
        String Warranty_Type;
        String Warranty_Status;
        DateTime Warranty_End_Date;
        DateTime Ship_Date;
        String End_User_GU;
        String Reseller_GU;
        String Product_Bill_To_ID;
        String Product_Bill_to_Name;
        String Product_Bill_To_Address;
        String Product_Bill_To_City;
        String Product_Bill_To_State;
        String Product_Bill_To_Province;
        String Product_Bill_To_County;
        String Product_Bill_To_Country;
        String Product_Bill_To_Postal_Code;
        String Product_Ship_to_ID;
        String Product_Ship_to_Name;
        String Product_Ship_to_Address;
        String Product_Ship_To_City;
        String Product_Ship_To_State;
        String Product_Ship_To_Province;
        String Product_Ship_To_County;
        String Product_Ship_To_Country;
        String Product_Ship_To_Postal_Code;
        String Distributor_Bill_To_ID;
        String Distributor_Bill_To_Name;
        String Distributor_Bill_To_GU_Name;
        String Distributor_Bill_To_GU_ID;
        String Distributor_Bill_To_Address;
        String Distributor_Bill_To_City;
        String Distributor_Bill_To_State;
        String Distributor_Bill_To_Province;
        String Distributor_Bill_To_County;
        String Distributor_Bill_To_Country;
        String Distributor_Bill_To_Postal_Code;
        String Cisco_Capital_Bill_to_ID;
        String Smart_Account_Virtual_Account;
        String Eligible_for_quoting;
        String Reason_for_ineligibility;
        List<Coverage> Coverages;

        //Hopper Specifics
        String Source_Data_File = "";
        String Single_Source_File = "Not Set";
        Boolean In_Source_Data = false;
        String Colour_ID = "";
        String Hostname = "";
        String Configuration_Group = "";
        String Name = "";
        String Subscription = "";
        String List_Value = "";
        String Combined_Price = "";
        String Installed_At_AddressLine2 = "";
        String Ref1 = "";
        String Ref2 = "";
        String Ref3 = "";
        String Ref4 = "";
        String Covered = "";

        //Loki Specifics

        String Config_Alignment;
        Boolean LDOS;
        Boolean LDOS_Config;
        int Number_of_Coverages = 1;

        //Error Tracking
        Boolean Review = false;

        /*
         *  min value: Date = {1/1/0001 12:00:00 AM}
         * */
        public Item(DataTableReader Elements)
        {
            this.Coverages = new List<Coverage>();
            this.Product_Number = Elements.GetValue(0).ToString();
            this.Product_Description = Elements.GetValue(1).ToString();
            this.Last_Date_of_Support = (Elements.GetValue(2).ToString() == "") ? DateTime.MinValue : DateTime.Parse(Elements.GetValue(2).ToString());
            this.Last_Date_of_Sale = (Elements.GetValue(3).ToString() == "") ? DateTime.MinValue : DateTime.Parse(Elements.GetValue(3).ToString());
            this.PAK_Serial_Number = Elements.GetValue(4).ToString();
            this.Parent_PAK_Serial_Number = Elements.GetValue(5).ToString();
            this.Major_Minor = Elements.GetValue(6).ToString();
            this.Instance_Number = Elements.GetValue(7).ToString();
            this.Parent_Instance_Number = Elements.GetValue(8).ToString();
            this.Installed_Base_Status = Elements.GetValue(9).ToString();
            this.End_Customer_GU = Elements.GetValue(10).ToString();
            this.End_Customer_GU_Name = Elements.GetValue(11).ToString();
            this.End_Customer_ID = Elements.GetValue(12).ToString();
            this.End_Customer_Name = Elements.GetValue(13).ToString();
            this.End_Customer_Address = Elements.GetValue(14).ToString();
            this.End_Customer_City = Elements.GetValue(15).ToString();
            this.End_Customer_State = Elements.GetValue(16).ToString();
            this.End_Customer_Province = Elements.GetValue(17).ToString();
            this.End_Customer_County = Elements.GetValue(18).ToString();
            this.End_Customer_Country = Elements.GetValue(19).ToString();
            this.End_Customer_Zip_Postal_Code = Elements.GetValue(20).ToString();
            Coverage Temp = new Coverage();
            this.Covered = (Elements.GetValue(25).ToString() == "") ? "Uncovered" : "Covered";
            Temp.Subscription_Service_SKU = Elements.GetValue(21).ToString();
            Temp.Subscription_Service_Description = Elements.GetValue(22).ToString();
            Temp.Subscription_Service_Level = Elements.GetValue(23).ToString();
            Temp.Coverage_Start_Date = (Elements.GetValue(24).ToString() == "") ? DateTime.MinValue : DateTime.Parse(Elements.GetValue(24).ToString());
            Temp.Coverage_End_Date = (Elements.GetValue(25).ToString() == "") ? DateTime.MinValue : DateTime.Parse(Elements.GetValue(25).ToString());
            Temp.Contract_Number = Elements.GetValue(26).ToString();
            Temp.Contract_Line_Status = Elements.GetValue(27).ToString();
            Temp.Covered_Line_Number = Elements.GetValue(28).ToString();
            this.Potential_Takeover = Elements.GetValue(29).ToString();
            this.Host_MAC_ID = Elements.GetValue(30).ToString();
            this.Carton_ID = Elements.GetValue(31).ToString();
            this.Quantity = Elements.GetValue(32).ToString();
            Temp.Contract_Line_Amount = Elements.GetValue(33).ToString();
            Temp.Contract_Bill_to_GU = Elements.GetValue(34).ToString();
            Temp.Contract_Bill_to_GU_Name = Elements.GetValue(35).ToString();
            Temp.Contract_Bill_to_ID = Elements.GetValue(36).ToString();
            Temp.Contract_Bill_to_Name = Elements.GetValue(37).ToString();
            Temp.Contract_Bill_to_Address = Elements.GetValue(38).ToString();
            Temp.Contract_Bill_to_City = Elements.GetValue(39).ToString();
            Temp.Contract_Bill_to_State = Elements.GetValue(40).ToString();
            Temp.Contract_Bill_to_Province = Elements.GetValue(41).ToString();
            Temp.Contract_Bill_to_County = Elements.GetValue(42).ToString();
            Temp.Contract_Bill_to_Country = Elements.GetValue(43).ToString();
            Temp.Contract_Bill_to_Zip_Postal_Code = Elements.GetValue(44).ToString();
            this.SO_Number = Elements.GetValue(45).ToString();
            this.PO_Number = Elements.GetValue(46).ToString();
            Temp.Maintenance_PO_Number = Elements.GetValue(47).ToString();
            Temp.Maintenance_SO_Number = Elements.GetValue(48).ToString();
            this.Replacement_Serial_Number = Elements.GetValue(49).ToString();
            this.Product_Family = Elements.GetValue(50).ToString();
            this.Product_Group = Elements.GetValue(51).ToString();
            this.Product_Sub_Type = Elements.GetValue(52).ToString();
            this.Item_Type = Elements.GetValue(53).ToString();
            this.Warranty_Type = Elements.GetValue(54).ToString();
            this.Warranty_Status = Elements.GetValue(55).ToString();
            this.Warranty_End_Date = (Elements.GetValue(56).ToString() == "") ? DateTime.MinValue : DateTime.Parse(Elements.GetValue(56).ToString());
            this.Ship_Date = (Elements.GetValue(57).ToString() == "") ? DateTime.MinValue : DateTime.Parse(Elements.GetValue(57).ToString());
            this.End_User_GU = Elements.GetValue(58).ToString();
            this.Reseller_GU = Elements.GetValue(59).ToString();
            this.Product_Bill_To_ID = Elements.GetValue(60).ToString();
            this.Product_Bill_to_Name = Elements.GetValue(61).ToString();
            this.Product_Bill_To_Address = Elements.GetValue(62).ToString();
            this.Product_Bill_To_City = Elements.GetValue(63).ToString();
            this.Product_Bill_To_State = Elements.GetValue(64).ToString();
            this.Product_Bill_To_Province = Elements.GetValue(65).ToString();
            this.Product_Bill_To_County = Elements.GetValue(66).ToString();
            this.Product_Bill_To_Country = Elements.GetValue(67).ToString();
            this.Product_Bill_To_Postal_Code = Elements.GetValue(68).ToString();
            this.Product_Ship_to_ID = Elements.GetValue(69).ToString();
            this.Product_Ship_to_Name = Elements.GetValue(70).ToString();
            this.Product_Ship_to_Address = Elements.GetValue(71).ToString();
            this.Product_Ship_To_City = Elements.GetValue(72).ToString();
            this.Product_Ship_To_State = Elements.GetValue(73).ToString();
            this.Product_Ship_To_Province = Elements.GetValue(74).ToString();
            this.Product_Ship_To_County = Elements.GetValue(75).ToString();
            this.Product_Ship_To_Country = Elements.GetValue(76).ToString();
            this.Product_Ship_To_Postal_Code = Elements.GetValue(77).ToString();
            this.Distributor_Bill_To_ID = Elements.GetValue(78).ToString();
            this.Distributor_Bill_To_Name = Elements.GetValue(79).ToString();
            this.Distributor_Bill_To_GU_Name = Elements.GetValue(80).ToString();
            this.Distributor_Bill_To_GU_ID = Elements.GetValue(81).ToString();
            this.Distributor_Bill_To_Address = Elements.GetValue(82).ToString();
            this.Distributor_Bill_To_City = Elements.GetValue(83).ToString();
            this.Distributor_Bill_To_State = Elements.GetValue(84).ToString();
            this.Distributor_Bill_To_Province = Elements.GetValue(85).ToString();
            this.Distributor_Bill_To_County = Elements.GetValue(86).ToString();
            this.Distributor_Bill_To_Country = Elements.GetValue(87).ToString();
            this.Distributor_Bill_To_Postal_Code = Elements.GetValue(88).ToString();
            this.Cisco_Capital_Bill_to_ID = Elements.GetValue(89).ToString();
            this.Smart_Account_Virtual_Account = Elements.GetValue(90).ToString();
            this.Eligible_for_quoting = Elements.GetValue(91).ToString();
            this.Reason_for_ineligibility = Elements.GetValue(92).ToString();
            this.LDOS = check_LDOS();
            this.LDOS_Config = check_LDOS_Config();
            this.Config_Alignment = check_Config_Alignment();
            this.Configuration_Group = Parent_Instance_Number;
            this.Coverages.Add(Temp);
        }

        public Boolean check_LDOS()
        {
            if ((this.Last_Date_of_Support > DateTime.MinValue) && (this.Last_Date_of_Support <= DateTime.Today)) return true;
            else return false;
        }

        public Boolean check_LDOS_Config()
        {
            if (this.Instance_Number == this.Parent_Instance_Number && this.LDOS == true) return true;
            else return false;
        }

        public String check_Config_Alignment()
        {
            if (this.Instance_Number == this.Parent_Instance_Number) return Parent_Instance_Number + ".0";
            else return Parent_Instance_Number + ".1";
        }

        public String getInstance()
        {
            return this.Instance_Number;
        }

        public String getParentInstance()
        {
            return this.Parent_Instance_Number;
        }

        public List<Coverage> GetCoverage()
        {
            return this.Coverages;
        }

        public int getNumber_of_Coverages()
        {
            return this.Number_of_Coverages;
        }

        public String getConfigurationAligment()
        {
            return this.Config_Alignment;
        }

        public DateTime getLDOSDate()
        {
            return this.Last_Date_of_Support;
        }

        public String getCoveredStatus()
        {
            return this.Covered;
        }

        public Boolean getReviewStatus()
        {
            return this.Review;
        }

        public String getSourceFile()
        {
            return this.Source_Data_File;
        }

        public String printToConsole()
        {
            return "\r\n" + this.Source_Data_File + " | " + this.PAK_Serial_Number + "|" + this.Product_Number + "|" + this.Instance_Number + "|" + this.Covered;
        }

        public String getSerial()
        {
            return this.PAK_Serial_Number;
        }

        public String printCoveragesToConsole()
        {
            String Result = "";
            foreach (Coverage entry in this.Coverages)
            {
                Result += ("\r\n" + entry.Contract_Number + "|" + entry.Contract_Bill_to_Name + "|" + entry.Coverage_Start_Date + "|" + entry.Coverage_End_Date + "|" + entry.Contract_Line_Status);
            }
            return Result;
        }

        public Boolean isLDOS()
        {
            return LDOS;
        }

        public Boolean isLDOSConfig()
        {
            return LDOS_Config;
        }

        public void setLDOSConfig()
        {
            this.LDOS_Config = true;
        }

        public void setReviewStatus()
        {
            this.Review = true;
        }

        public void SetNextCoverage(Coverage Next)
        {
            Number_of_Coverages += 1;
            this.Covered = (Next.Coverage_End_Date.ToString() == "") ? "Uncovered" : "Covered";
            this.Coverages.Add(Next);
        }

        public void SetSourceDataFile(String File)
        {
            this.Source_Data_File += (this.Source_Data_File == "") ? File : " & " + File;
        }

        public void SetInDataFile(Boolean b)
        {
            this.In_Source_Data = b;
        }

        public void toObjectArrayCoverages(Object[] Array)
        {
            int i = 1;
            while (i <= 5)
            {
                int y = 0;
                foreach (Coverage Cover in this.Coverages)
                {
                    if (i > Number_of_Coverages) return;
                    else
                    {
                        Array[43 + y] = Cover.Contract_Number;
                        Array[44 + y] = Cover.Contract_Bill_to_Name;
                        Array[45 + y] = Cover.Contract_Bill_to_Country;
                        Array[46 + y] = Cover.Subscription_Service_Level;
                        Array[47 + y] = Cover.Subscription_Service_Description;
                        Array[48 + y] = Cover.Contract_Line_Status;
                        Array[49 + y] = (Cover.Coverage_Start_Date == DateTime.MinValue) ? "" : Cover.Coverage_Start_Date.ToShortDateString();
                        Array[50 + y] = (Cover.Coverage_End_Date == DateTime.MinValue) ? "" : Cover.Coverage_End_Date.ToShortDateString();
                        i += 1;
                        y += 8;
                    }

                }
            }
        }

        public Object[] toObjectArray()
        {
            Object[] bifrost = new Object[]{
                this.Source_Data_File,
                this.Single_Source_File,
                this.Config_Alignment,
                this.In_Source_Data,
                this.Review,
                this.Colour_ID,
                this.Hostname,
                this.Name,
                this.Configuration_Group,
                this.PAK_Serial_Number,
                this.Product_Number,
                this.Product_Family,
                this.Product_Group,
                this.Product_Sub_Type,
                this.Subscription,
                this.Product_Description,
                this.List_Value,
                this.Quantity,
                this.Combined_Price,
                (this.Last_Date_of_Support==DateTime.MinValue) ? "" : this.Last_Date_of_Support.ToShortDateString(),
                this.Instance_Number,
                this.Parent_Instance_Number,
                this.Installed_Base_Status,
                (this.Ship_Date==DateTime.MinValue) ? "" : this.Ship_Date.ToShortDateString(),
                this.PO_Number,
                this.SO_Number,
                this.Product_Bill_to_Name,
                this.Product_Bill_To_ID,
                this.Product_Ship_to_ID,
                this.Product_Ship_to_Name,
                this.End_Customer_ID,
                this.End_Customer_Name,
                this.End_Customer_Address,
                this.Installed_At_AddressLine2,
                this.End_Customer_City,
                this.End_Customer_State,
                this.End_Customer_Zip_Postal_Code,
                this.End_Customer_Country,
                this.Ref1,
                this.Ref2,
                this.Ref3,
                this.Ref4,
                this.Covered,
                "", //1st ContractNumber
                "", //1st ContractBillToName
                "", //1st ContractBillToCountry
                "", //1st ServiceLevel
                "", //1st SL Description
                "", //1st ProductCoverageStatus
                "", //1st ProductCoverageStartDate
                "", //1st ProductCoverageEndDate
                "", //2nd ContractNumber
                "", //2nd ContractBillToName
                "", //2nd ContractBillToCountry
                "", //2nd ServiceLevel
                "", //2nd SL Description
                "", //2nd ProductCoverageStatus
                "", //2nd ProductCoverageStartDate
                "", //2nd ProductCoverageEndDate
                "", //3rd ContractNumber
                "", //3rd ContractBillToName
                "", //3rd ContractBillToCountry
                "", //3rd ServiceLevel
                "", //3rd SL Description
                "", //3rd ProductCoverageStatus
                "", //3rd ProductCoverageStartDate
                "", //3rd ProductCoverageEndDate
                "", //4th ContractNumber
                "", //4th ContractBillToName
                "", //4th ContractBillToCountry
                "", //4th ServiceLevel
                "", //4th SL Description
                "", //4th ProductCoverageStatus
                "", //4th ProductCoverageStartDate
                "", //4th ProductCoverageEndDate
                "", //5th ContractNumber
                "", //5th ContractBillToName
                "", //5th ContractBillToCountry
                "", //5th ServiceLevel
                "", //5th SL Description
                "", //5th ProductCoverageStatus
                "", //5th ProductCoverageStartDate
                "" //5th ProductCoverageEndDate
            };
            toObjectArrayCoverages(bifrost);
            return bifrost;
        }


    }
}
