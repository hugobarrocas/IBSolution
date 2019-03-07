using System;
using System.IO;
using System.Data.OleDb;
using System.Data;

namespace IBSolution.IO.Input
{
    public class InExcel
    {

        /*
        private Excel.Application xlApp = null;
        private Excel.Workbook xlWorkbook = null;
        private Excel._Worksheet xlWorksheet = null;
        private Excel.Range xlRange = null;
        private int LimitRow = 0;
        private int LimitCol = 0;
        private  int Row = 0;
        private int Col = 0;
        */
        private DataTable table = null;





        /**
         * creates a object based on the filepath
         * */
        public InExcel(String FilePath)
        {

            if (!File.Exists(FilePath))
            {
                Console.WriteLine("Ups!! file:" + FilePath + "is unreachable");

            }
            else
            {
                ImportExceltoDatatable(FilePath);
            }

        }


        /* opens a excel file using oleDbConnection
         * 
         * */

        private void ImportExceltoDatatable(string filepath)
        {



            DataTable dtTablesList = default(DataTable);
            string sSheetName = "";

            DataSet ds = new DataSet();
            string constring = "";
            OleDbDataAdapter dataAdapter;

            constring = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + filepath + ";Extended Properties=\"Excel 12.0;HDR=No;IMEX=1\"";
            OleDbConnection con = new OleDbConnection(constring);
            con.Open();
            dtTablesList = con.GetSchema("Tables");
            sSheetName = dtTablesList.Rows[0]["TABLE_NAME"].ToString();
            string sqlquery = "Select * From [" + sSheetName + "A7:CO]";
            dataAdapter = new OleDbDataAdapter(sqlquery, con);
            dataAdapter.Fill(ds);
            this.table = ds.Tables[0];

            con.Close();


        }


        public DataTable getTable()
        {
            return table;
        }





    }
}
