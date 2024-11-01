using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P4_2_714230069
{
    internal abstract class KpopArtist
    {
            private string stageName;
            private int debutYear;

            public string StageName
            {
                get { return stageName; }
                set { stageName = value; }
            }

            public int DebutYear
            {
                get { return debutYear; }
                set { debutYear = value; }
            }

            public KpopArtist(string stageName, int debutYear)
            {
                this.stageName = stageName;
                this.debutYear = debutYear;
            }

            public abstract void DisplayInfo();
        }
    }