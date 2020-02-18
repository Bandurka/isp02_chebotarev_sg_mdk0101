using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    class Banknote
    {
        private int seriesAndNumber { get; set; }
        private int par { get; set; }
        private string parInWords { get; set; }

        public Banknote(int banknoteSeriesAndNumber, int banknotePar, string banknoteParInWords)
        {
            seriesAndNumber = banknoteSeriesAndNumber;
            par = banknotePar;
            parInWords = banknoteParInWords;
        }

        public override string ToString()
        {
            return "Banknote: " + seriesAndNumber + " " + par + " " + parInWords;
        }
    }
   
}
