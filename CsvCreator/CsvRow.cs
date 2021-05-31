namespace CsvCreator
{
    public class CsvRow
    {
        public int Length { get { return Data.Length; } }
        public string[] Data { get; private set; }

        public CsvRow(string[] data)
        {
            Data = data;
        }
    }
}
