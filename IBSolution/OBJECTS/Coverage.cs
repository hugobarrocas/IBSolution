using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IBSolution.IO.Input;
using System.Data;

namespace IBSolution.OBJECTS
{
    public class Coverage
    {
        Coverage next = null;
        Coverage previous = null;

        public String Subscription_Service_SKU;
        public String Subscription_Service_Description;
        public String Subscription_Service_Level;
        public DateTime Coverage_Start_Date;
        public DateTime Coverage_End_Date;
        public String Contract_Number;
        public String Contract_Line_Status;
        public String Covered_Line_Number;
        public String Contract_Line_Amount;
        public String Contract_Bill_to_GU;
        public String Contract_Bill_to_GU_Name;
        public String Contract_Bill_to_ID;
        public String Contract_Bill_to_Name;
        public String Contract_Bill_to_Address;
        public String Contract_Bill_to_City;
        public String Contract_Bill_to_State;
        public String Contract_Bill_to_Province;
        public String Contract_Bill_to_County;
        public String Contract_Bill_to_Country;
        public String Contract_Bill_to_Zip_Postal_Code;
        public String Maintenance_PO_Number;
        public String Maintenance_SO_Number;

        public Coverage() { }

        public Coverage(DataTableReader Elements)
        {
            this.Subscription_Service_SKU = Elements.GetValue(21).ToString();
            this.Subscription_Service_Description = Elements.GetValue(22).ToString();
            this.Subscription_Service_Level = Elements.GetValue(23).ToString();
            this.Coverage_Start_Date = (Elements.GetValue(24).ToString() == "") ? DateTime.MinValue : DateTime.Parse(Elements.GetValue(24).ToString());
            this.Coverage_End_Date = (Elements.GetValue(25).ToString() == "") ? DateTime.MinValue : DateTime.Parse(Elements.GetValue(25).ToString());
            this.Contract_Number = Elements.GetValue(26).ToString();
            this.Contract_Line_Status = Elements.GetValue(27).ToString();
            this.Covered_Line_Number = Elements.GetValue(28).ToString();
            this.Contract_Line_Amount = Elements.GetValue(33).ToString();
            this.Contract_Bill_to_GU = Elements.GetValue(34).ToString();
            this.Contract_Bill_to_GU_Name = Elements.GetValue(35).ToString();
            this.Contract_Bill_to_ID = Elements.GetValue(36).ToString();
            this.Contract_Bill_to_Name = Elements.GetValue(37).ToString();
            this.Contract_Bill_to_Address = Elements.GetValue(38).ToString();
            this.Contract_Bill_to_City = Elements.GetValue(39).ToString();
            this.Contract_Bill_to_State = Elements.GetValue(40).ToString();
            this.Contract_Bill_to_Province = Elements.GetValue(41).ToString();
            this.Contract_Bill_to_County = Elements.GetValue(42).ToString();
            this.Contract_Bill_to_Country = Elements.GetValue(43).ToString();
            this.Contract_Bill_to_Zip_Postal_Code = Elements.GetValue(44).ToString();
            this.Maintenance_PO_Number = Elements.GetValue(47).ToString();
            this.Maintenance_SO_Number = Elements.GetValue(48).ToString();
        }

        public void SetNextCoverage(Coverage NextOne)
        {
            this.next = NextOne;
        }

        public void SetPreviousCoverage(Coverage PreviousOne)
        {
            this.previous = PreviousOne;
        }

    }


}
