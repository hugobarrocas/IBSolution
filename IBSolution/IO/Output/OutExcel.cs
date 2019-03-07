using Microsoft.Office.Interop.Excel;
using System;

using System.Runtime.InteropServices;
using System.Reflection;

namespace IBSolution.IO.Output
{
    class OutExcel
    {
        private Application excel = new Application();
        private Workbooks workbooks = null;
        private Workbook workbook = null;
        private String FiletoSave = "";
        public OutExcel(String FilePath, string[] Sheetnames, System.Data.DataTable[] Tables)
        {
            excel.DisplayAlerts = false;
            excel.Visible = false;
            excel.ScreenUpdating = false;
            workbooks = excel.Workbooks;

            workbook = workbooks.Add(Type.Missing);
            FiletoSave = FilePath;
            AddToFile(Sheetnames, Tables);
        }


        private void AddToFile(string[] Sheetnames, System.Data.DataTable[] Tables)
        {

            for (int i = 0; i < Tables.Length; i++)
            {

                Sheets worksheets = workbook.Sheets;

                Worksheet worksheet = (Worksheet)worksheets[i + 1];
                worksheet.Name = Sheetnames[i];
                int rows = Tables[i].Rows.Count;
                int columns = Tables[i].Columns.Count;
                // Add the +1 to allow room for column headers.
                var data = new object[rows + 1, columns];
                for (var column = 0; column < columns; column++)
                {
                    data[0, column] = Tables[i].Columns[column].ColumnName;
                }
                // Insert the provided records.
                for (var row = 0; row < rows; row++)
                {
                    for (var column = 0; column < columns; column++)
                    {
                        data[row + 1, column] = Tables[i].Rows[row][column];
                    }

                }
                // Write this data to the excel worksheet.
                Range beginWrite = (Range)worksheet.Cells[1, 1];
                Range endWrite = (Range)worksheet.Cells[rows + 1, columns];
                Range sheetData = worksheet.Range[beginWrite, endWrite];
                sheetData.Value2 = data;

                // Additional row, column and table formatting.
                worksheet.Select();
                // sheetData.Worksheet.ListObjects.Add(XlListObjectSourceType.xlSrcRange,
                //   sheetData,
                // System.Type.Missing,
                // XlYesNoGuess.xlYes,
                // System.Type.Missing).Name = Sheetnames[i];
                sheetData.Select();
                //sheetData.Worksheet.ListObjects[Sheetnames[i]].TableStyle = tableStyle;
                //excel.Application.Range["2:2"].Select();
                // excel.ActiveWindow.FreezePanes = true;
                //excel.ActiveWindow.DisplayGridlines = false;
                //excel.Application.Cells.EntireColumn.AutoFit();
                //excel.Application.Cells.EntireRow.AutoFit();
                // Select the first cell in the worksheet.
                excel.Application.Range["$A$2"].Select();
                workbook.Sheets.Add(After: workbook.Sheets[workbook.Sheets.Count]);
            }

            // Turn off alerts to prevent asking for 'overwrite existing' and 'save changes' messages.
            excel.DisplayAlerts = false;

            // Save our workbook and close excel.
            string SaveFilePath = string.Format(@"{0}.xlsx", FiletoSave);
            //workbook.SaveAs(SaveFilePath, XlFileFormat.xlWorkbookNormal, Type.Missing, Type.Missing, Type.Missing, Type.Missing, XlSaveAsAccessMode.xlExclusive, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
            workbook.SaveAs(SaveFilePath, XlFileFormat.xlOpenXMLWorkbook, Missing.Value,
                        Missing.Value, false, false, XlSaveAsAccessMode.xlNoChange,
                        XlSaveConflictResolution.xlUserResolution, true,
                        Missing.Value, Missing.Value, Missing.Value);
            workbook.Close(false, Type.Missing, Type.Missing);
            //wondering if necessary 
            //excel.Quit();
            // Release our resources.
            Marshal.ReleaseComObject(workbook);
            Marshal.ReleaseComObject(workbooks);
            Marshal.ReleaseComObject(excel);
            Marshal.FinalReleaseComObject(excel);
        }


    }
}
