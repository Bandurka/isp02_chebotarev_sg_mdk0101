using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    class WorkShop
    {
        private string cipher { get; set; }
        private int numberOfEmployees { get; set; }

        public WorkShop(string workShopCipher, int workShopNumberOfEmployees)
        {
            cipher = workShopCipher;
            numberOfEmployees = workShopNumberOfEmployees;
        }

        public override string ToString()
        {
            return "WorkShop: " + cipher + " " + numberOfEmployees;
        }
    }
}
