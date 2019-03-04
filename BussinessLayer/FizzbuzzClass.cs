using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessLayer
{
    public class FizzbuzzClass
    {
        public List<string> logicFizzBuzz()
        {
            List<string> lstfizzbuzz = new List<string>();

            for (int i = 1; i <= 100; i++)
            {
                string strResult = "";

                if (i % 3 == 0) strResult = "Fizz ";
                if (i % 5 == 0) strResult += "Buzz";
                if (strResult.Length == 0) strResult = i.ToString().Trim();
                lstfizzbuzz.Add(strResult);

            }
            return lstfizzbuzz;
        }
    }
}
