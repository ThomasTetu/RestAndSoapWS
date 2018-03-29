using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOAPVelib
{
    class StationCache
    {
        internal DataTable cache { get; set; }

        public StationCache()
        {

            cache = new DataTable();
            cache.Columns.Add("Name", typeof(string));
            cache.Columns.Add("StationName", typeof(string));
            cache.Columns.Add("Station", typeof(Station));
            cache.Columns.Add("AddedDate", typeof(DateTime));
        }

        public void AddRow(Station s)
        {
            DataRow newRow = cache.NewRow();
            newRow["Name"] = s.city;
            newRow["StationName"] = s.name;
            newRow["Station"] = s;
            newRow["AddedDate"] = DateTime.Now;
            cache.Rows.Add(newRow);
            cache.AcceptChanges();
        }

        internal DataRowCollection GetRows() => cache.Rows;
    }
}
