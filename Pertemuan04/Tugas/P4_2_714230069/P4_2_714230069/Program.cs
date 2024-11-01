using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P4_2_714230069
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //isi value melalui constructor
            SoloArtist artist1 = new SoloArtist("IU", 2008, "Ballad/Pop");
            GroupArtist artist2 = new GroupArtist("BTS", 2013, 7);

            artist1.DisplayInfo();
            artist2.DisplayInfo();
        }
    }
}
