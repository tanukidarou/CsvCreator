using System.Collections.Generic;

namespace CsvCreator
{
    public class CsvStruct
    {
        public List<CsvHeader> Headers { get; private set; } = new List<CsvHeader>();
        public List<CsvRow> Rows { get; private set; } = new List<CsvRow>();

        public void AddHeader(CsvHeader header)
        {
            if (Headers.Contains(header))
                throw new System.Exception("Este headre ya existe");

            Headers.Add(header);
        }

        public void AddRow(CsvRow row)
        {
            if (row.Length != Headers.Count)
                throw new System.Exception("Los row no concuerda con los headers");

            Rows.Add(row);
        }
    }
}
