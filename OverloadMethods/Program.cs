using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace subject1
{
    class Program
    {

        class Insan
        {
            //this program about public method
            public string isim;
            public int yas;
            public void yurume()
            {
                Console.WriteLine("Yürüyor.");
            }
            public void isimVeYasDegistirme(string isim, int yas)
            {
                this.isim=isim;
                this.yas=yas;   
            }
            public string isimVeYasiSoyle()
            {
                return isim + " " + yas;

            }
        }
        


        static void Main(string[] args)
        {
            Insan i1 = new Insan();
            i1.isimVeYasDegistirme("Emre Çınar", 54);
            Console.WriteLine(i1.isimVeYasiSoyle());

            i1.yurume();
        }
    }
}
