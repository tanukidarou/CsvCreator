namespace CsvCreator
{
    public class CsvFile
    {
        public string FileExtension { get; }
        public string Data { get; }

        public CsvFile(string data, string fileExtension)
        {
            Data = data;
            FileExtension = fileExtension;
        }
    }




}
