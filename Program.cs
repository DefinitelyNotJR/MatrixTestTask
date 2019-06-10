using System;
using System.IO;
using System.Linq;
using matrix_test_task.Services.CSVServices;
using matrix_test_task.Services.MatrixServices;

namespace matrix_test_task
{

    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                RotateRandomMatrix();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            try
            {
                RotateCsvMatrix();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        private static void RotateCsvMatrix()
        {
            ICSVService _csvService = new CSVService();
            IMatrixService _matrixService = new MatrixService();

            var matrix = _csvService.ReadCsvAsArray("csvinput");
            var rotatedMatrix = _matrixService.RotateMatrix(_matrixService.TransposeMatrix(matrix));
            _csvService.SaveArrayAsCSV(rotatedMatrix, "csvoutput");
        }

        private static void RotateRandomMatrix()
        {
            ICSVService _csvService = new CSVService();
            IMatrixService _matrixService = new MatrixService();

            var matrix = _matrixService.RandomMatrix();
            _csvService.SaveArrayAsCSV(matrix, "randommatrix");
            var rotatedMatrix = _matrixService.RotateMatrix(_matrixService.TransposeMatrix(matrix));
            _csvService.SaveArrayAsCSV(rotatedMatrix, "randommatrixrotated");
        }
    }
}
