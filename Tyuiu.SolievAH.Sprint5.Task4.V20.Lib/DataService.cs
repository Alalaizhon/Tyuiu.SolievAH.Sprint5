using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.SolievAH.Sprint5.Task4.V20.Lib
{
    public class DataService : ISprint5Task4V20
    {
        public double LoadFromDataFile(string path)
        {
            string strX = File.ReadAllText(path);
            double x = Convert.ToDouble(strX);
            double a1 = Math.Pow(x, 2);
            double a2 = Math.Sin(x);
            double res = Math.Round(Math.Pow(a1 / a2, 3), 3);
            return res;
        }
    }
}
