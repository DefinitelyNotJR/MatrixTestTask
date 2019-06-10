using System;

namespace matrix_test_task.Services.CSVServices
{
    public interface ICSVService
    {
        void SaveArrayAsCSV<T>(T[][] arrayToSave, string fileName);

        string[][] ReadCsvAsArray(string stringPath);
    }
}