using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace P4_2_714230069
{
    internal class SoloArtist : KpopArtist
    {
        public string Genre { get; set; }

        public SoloArtist(string stageName, int debutYear, string genre) : base(stageName, debutYear)
        {
            this.Genre = genre;
        }

        public override void DisplayInfo()
        {
            Console.WriteLine("Solo Artist: {0}, Debut Year: {1}, Genre: {2}", StageName, DebutYear, Genre);
        }
    }
}
