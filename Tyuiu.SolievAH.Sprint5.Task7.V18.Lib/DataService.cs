using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint5;
using System.IO;
using System.Text.RegularExpressions;

namespace Tyuiu.SolievAH.Sprint5.Task7.V18.Lib
{
    public class DataService : ISprint5Task7V18
    {
        public string LoadDataAndSave(string path)
        {
            string pathSaveFile = $@"{Directory.GetCurrentDirectory()}\OutPutFileTask7.txt";
            FileInfo fileInfo = new FileInfo(pathSaveFile);
            bool fileExists = fileInfo.Exists;

            if (fileExists)
            {
                File.Delete(pathSaveFile);
            }

            path = @"C:\DataSprint5\InPutDataFileTask7V18.txt";
            string fileContent = File.ReadAllText(path);
            string replace = Regex.Replace(fileContent, @"н", "нн");
            File.AppendAllText(pathSaveFile, replace + Environment.NewLine);

            return pathSaveFile ;

            // https://pstrtns.screenshotmaker.repl.co/ 
        }
    }
}
