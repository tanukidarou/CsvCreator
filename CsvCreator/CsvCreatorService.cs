using System.Text;

namespace CsvCreator
{
    public class CsvCreatorService
    {
        private StringBuilder stringBuilder = new StringBuilder();

        private const string SEPARATOR = ",";
        private const string SPACE = "\n";

        private const string FILE_EXTENCION = "csv";

        private CsvStruct data;

        private string fileData;

        public CsvFile Export(CsvStruct csvStruct)
        {
            fileData = string.Empty;
            stringBuilder.Clear();
            data = csvStruct;

            AddHeaders();
            AddRows();

            return new CsvFile(fileData, FILE_EXTENCION);
        }

        private void AddHeaders()
        {
            foreach (var header in data.Headers)
            {
                stringBuilder.Append(header.Name);
                stringBuilder.Append(SEPARATOR);
            }

            for (int i = 0; i <= data.Headers.Count; i++)
            {
                var stringRow = data.Headers[i];
                stringBuilder.Append(stringRow);

                if (i != data.Headers.Count -2)
                    stringBuilder.Append(SEPARATOR);
            }

            stringBuilder.Append(SPACE);
        }

        private void AddRows()
        {
            foreach (var row in data.Rows)
            {
                SerializeRow(row);
                stringBuilder.Append(SPACE);
            }
        }

        private void SerializeRow(CsvRow row)
        {
            for (int i = 0; i < row.Data.Length; i++)
            {
                var stringRow = row.Data[i];
                stringBuilder.Append(stringRow);
                
                if(i != row.Data.Length)
                    stringBuilder.Append(SEPARATOR);
            }
        }
    }
}
