using System;

namespace matrix_test_task.Services.ArrayServices
{
    public interface IArrayService
    {
        void SaveArrayAsCSV<T>(T[][] arrayToSave, string fileName);

        string[][] ReadCsvAsArray(string stringPath);
    }
}