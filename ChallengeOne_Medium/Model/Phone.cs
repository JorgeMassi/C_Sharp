using System.Security.Cryptography.X509Certificates;

namespace ChallengeOne_Medium.Model
{
    internal class Dimension
    {
        public double Lenght { get; set; }
        public double Width { get; set; }
        public double Height { get; set; }
    }
    internal class Phone
    {
        public int Id { get; set; }
        public string Manufacturer { get; set; }
        public string Model { get; set; }
        public string OperatingSystem { get; set; }
        public bool isMobile { get; set; }
        public Dimension Dimension { get; set; }
    
        override
        public string ToString()
        {
            return "ID:\t" + Id + "\tManufacturer:\t" + Manufacturer + "\tModel:\t" + Model + "\tOperatingSystem:\t" + OperatingSystem + "isMobile" + isMobile + "Dimension" + Dimension;
        }

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public static implicit operator List<object>(Phone v)
        {
            throw new NotImplementedException();
        }
    }
}
