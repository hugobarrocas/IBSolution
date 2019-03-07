using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace IBSolution.OBJECTS
{
    class HopperFormat
    {
        DataTable HopperTable;

        String[] Headers =
        {"Source Data File",
        "Single Source File",
        "Sort ID",
        "In Source Data",
        "Needs Review",
        "Colour ID",
        "Hostname",
        "Name",
        "Configuration Group",
        "Serial Number",
        "Product ID",
        "Product Family",
        "Product Group",
        "Product SubType",
        "Subscription",
        "Product Description",
        "List Value",
        "Qty",
        "Combined Price (List Price x Qty)",
        "Last Date of Support",
        "Instance Number",
        "ParentNum",
        "Instance Status",
        "Ship Date",
        "Hardware PO Number",
        "HardwareSO Number",
        "Hardware BID",
        "Hardware BID Name",
        "ShipTo ID",
        "ShipTo Name",
        "Installed At CustomerName",
        "Installed At SiteID",
        "Installed At AddressLine1",
        "Installed At AddressLine2",
        "Installed At City",
        "Installed At State",
        "Installed At PostalCode",
        "Installed At Country",
        "Ref1",
        "Ref2",
        "Ref3",
        "Ref4",
        "Covered",
        "1st ContractNumber",
        "1st ContractBillToName",
        "1st ContractBillToCountry",
        "1st ServiceLevel",
        "1st SL Description",
        "1st ProductCoverageStatus",
        "1st ProductCoverageStartDate",
        "1st ProductCoverageEndDate",
        "2nd ContractNumber",
        "2nd ContractBillToName",
        "2nd ContractBillToCountry",
        "2nd ServiceLevel",
        "2nd SL Description",
        "2nd ProductCoverageStatus",
        "2nd ProductCoverageStartDate",
        "2nd ProductCoverageEndDate",
        "3rd ContractNumber",
        "3rd ContractBillToName",
        "3rd ContractBillToCountry",
        "3rd ServiceLevel",
        "3rd SL Description",
        "3rd ProductCoverageStatus",
        "3rd ProductCoverageStartDate",
        "3rd ProductCoverageEndDate",
        "4th ContractNumber",
        "4th ContractBillToName",
        "4th ContractBillToCountry",
        "4th ServiceLevel",
        "4th SL Description",
        "4th ProductCoverageStatus",
        "4th ProductCoverageStartDate",
        "4th ProductCoverageEndDate",
        "5th ContractNumber",
        "5th ContractBillToName",
        "5th ContractBillToCountry",
        "5th ServiceLevel",
        "5th SL Description",
        "5th ProductCoverageStatus",
        "5th ProductCoverageStartDate",
        "5th ProductCoverageEndDate"};

        public HopperFormat()
        {
            HopperTable = new DataTable();
            foreach (string Header in Headers)
            {
                this.HopperTable.Columns.Add(Header);
            }

        }

        public DataTable getTable()
        {
            return this.HopperTable;
        }

    }
}
