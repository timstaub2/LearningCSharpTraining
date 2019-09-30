using System;
using System.Collections.Generic;
using System.Text;

namespace While_Loop
{
    public static class ComputeTax
    {
        public static decimal Compute(decimal totalAmount)
           
        {
            if (totalAmount <= 0)
            return 0;
            decimal taxRate = .065m;

            decimal saleTax = totalAmount * taxRate;
            return saleTax;


        }
    }
}
