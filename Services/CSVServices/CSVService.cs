using System;
using System.IO;
using System.Linq;

namespace matrix_test_task.Services.CSVServices
{
    public class CSVService : ICSVService
    {
        public string[][] ReadCsvAsArray(string fileName)
        {
            string filePath = $"{fileName}.csv";
            var lines = File.ReadAllLines(filePath);
            var textlines = lines.Select(line => line.Split(',')).ToArray();

            return textlines;
        }
        public void SaveArrayAsCSV<T>(T[][] arrayToSave, string fileName)
        {
            string filePath = $"{fileName}.csv";
            try
            {
                using (StreamWriter file = new StreamWriter(filePath))
                {
                    foreach (T[] array in arrayToSave)
                    {
                        var res = String.Join(",", array);
                        file.Write(res);
                        file.Write(Environment.NewLine);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
    }
}