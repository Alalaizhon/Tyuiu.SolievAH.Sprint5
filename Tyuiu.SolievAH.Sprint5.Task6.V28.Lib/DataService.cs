using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint5;
using System.IO;

namespace Tyuiu.SolievAH.Sprint5.Task6.V28.Lib
{
    public class DataService : ISprint5Task6V28
    {
        public int LoadFromDataFile(string path)
        {
            path = @"C:\DataSprint5\InPutDataFileTask6V28.txt";
            string fileContent = File.ReadAllText(path);
            MatchCollection nums = Regex.Matches(fileContent, @"\b\d{4}\b");
            return nums.Count;

            // https://pstrtns.screenshotmaker.repl.co/ ссылка с объяснением

        }
    }
}
