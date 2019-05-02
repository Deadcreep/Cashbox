using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cashbox.Models
{
    public class ResultModel
    {
        public int Cvv;
        public int CardNumber;
        public float OrderSum;
        public string ReturnUrl;
        public string OrderNumber;

        public override string ToString()
        {
            return Cvv.ToString() + CardNumber.ToString() + OrderSum.ToString() + ReturnUrl + OrderNumber;
        }

    }
}
