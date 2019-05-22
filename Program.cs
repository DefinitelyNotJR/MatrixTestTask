using System;
using System.IO;
using System.Linq;
using matrix_test_task.Services.ArrayServices;
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
            IArrayService _arrayService = new ArrayService();
            IMatrixService _matrixService = new MatrixService();

            var matrix = _arrayService.ReadCsvAsArray("csvinput");
            var rotatedMatrix = _matrixService.RotateMatrix(_matrixService.TransposeMatrix(matrix));
            _arrayService.SaveArrayAsCSV(rotatedMatrix, "csvoutput");
        }

        private static void RotateRandomMatrix()
        {
            IArrayService _arrayService = new ArrayService();
            IMatrixService _matrixService = new MatrixService();

            var matrix = _matrixService.RandomMatrix();
            _arrayService.SaveArrayAsCSV(matrix, "randommatrix");
            var rotatedMatrix = _matrixService.RotateMatrix(_matrixService.TransposeMatrix(matrix));
            _arrayService.SaveArrayAsCSV(rotatedMatrix, "randommatrixrotated");
        }
    }
}
