using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GlobalKineticSolution.Contracts;
namespace GlobalKineticSolution.Mappers
{
    public static class Mapper
    {


        public static string CointToCSVEntry(ICoin coin)
        {
            string result = string.Format("{0},{1}", coin.Amount, coin.Volume);
            return result;
        }

        public static decimal CSVEntriesToValue(List<string> csventries,int index)
        {
       
            return (csventries == null || csventries.Count == 0 || index < 0 || index > 1)? 
                new decimal(0.0): csventries.Select(x => Convert.ToDecimal(x.Split(',')[index])).Sum();
        }
    }
}
