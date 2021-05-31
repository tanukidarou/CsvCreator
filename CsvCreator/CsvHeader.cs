using System;

namespace CsvCreator
{
    public class CsvHeader
    {
        public string Name { get; }

        public CsvHeader(string name)
        {
            Name = name;
        }

        public override bool Equals(object obj)
        {
            return obj is CsvHeader header &&
                   Name == header.Name;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Name);
        }
    }
}
