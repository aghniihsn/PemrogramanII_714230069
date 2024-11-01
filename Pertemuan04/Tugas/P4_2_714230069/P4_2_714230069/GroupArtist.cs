using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace P4_2_714230069
{
    internal class GroupArtist : KpopArtist
    {
        public int MembersCount { get; set; }

        public GroupArtist(string stageName, int debutYear, int membersCount): base(stageName, debutYear)
        {
            this.MembersCount = membersCount;
        }

        public override void DisplayInfo()
        {
            Console.WriteLine("K-Pop Group: {0}, Debut Year: {1}, Members Count: {2}", StageName, DebutYear, MembersCount);
        }
    }
}
