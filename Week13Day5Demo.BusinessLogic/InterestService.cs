using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week13Day5Demo.BusinessLogic
{
    public class InterestService
    {
        //public int SimpleInterest(double principle, int noOfMonths, double rateOfInterest)
        //{
        //    var interest = principle * (noOfMonths / 12) * rateOfInterest / 100;
        //    return (int)Math.Round(interest);
        //}

        //public int GetEmi(double loanAmount, int noOfMonths, double rateOfInterest)
        //{
        //    rateOfInterest /= 12 * 100; // one month interest
        //    t = t * 12; // one month period
        //    var emi = (loanAmount * rateOfInterest * Math.Pow(1 + rateOfInterest, noOfMonths)) / (Math.Pow(1 + rateOfInterest, noOfMonths) - 1);

        //    return (int)Math.Round(emi);
        //}

        public int SimpleInterest(double principle, int noOfYears, double rateOfInterest)
        {
            var interest = principle * noOfYears * rateOfInterest / 100;
            return (int)Math.Round(interest);
        }

        public int GetEmi(double loanAmount, int noOfYears, double rateOfInterest)
        {
            rateOfInterest /= 12 * 100; // one month interest
            noOfYears *= 12; // one month period
            var emi = (loanAmount * rateOfInterest * Math.Pow(1 + rateOfInterest, noOfYears)) / (Math.Pow(1 + rateOfInterest, noOfYears) - 1);

            return (int)Math.Round(emi);
        }
    }
}
