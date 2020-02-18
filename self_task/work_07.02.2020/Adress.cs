using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    class Adress
    {
        private int index { get; set; }
        private string sity { get; set; }
        private string street { get; set; }
        private int hourse { get; set; }
        private int apartment { get; set; }

        public Adress( int adressIndex, string adressSity, string adressStreet,
                        int adressHourse, int adressApartment)
        {
            index = adressIndex;
            sity = adressSity;
            street = adressStreet;
            hourse = adressHourse;
            apartment = adressApartment;
        }

        public override string ToString()
        {
            return "Adress: " + index + " " + sity + " " + street + " " + hourse + " " + apartment;
        }
    }
}
