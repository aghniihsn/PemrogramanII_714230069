using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P4_1_714230069
{
    internal abstract class Product_714230069
    {
        //protected string myType = "Book";
        private string myType;
        private string myTitle;


        public Product_714230069()
        {
        }

        //jawaban pribadi no 14 sehingga variabel dapat diakses
        //public string GetMyType()
        //{
        //    return myType;
        //}

        //constructor
        public Product_714230069(string type, string title)
        {
            myType = type;
            myTitle = title;
        }

        //property untuk MyType
        public string MyType
        {
            get
            { return myType; }
            set
            { myType = value; }
        }

        //property untuk MyTitle
        public string MyTitle
        {
            get { return myTitle; }
            set { MyTitle = value; }
        }

        //metode abstrak untuk menampilkan informasi produk
        public abstract void DisplayInfo();
    }
}