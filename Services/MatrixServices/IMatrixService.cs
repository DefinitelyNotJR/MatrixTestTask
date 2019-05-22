namespace matrix_test_task.Services.MatrixServices
{
    public interface IMatrixService
    {
        int[][] RandomMatrix();
        int[][] TransposeMatrix(string[][] csvMatrix);
        int[][] TransposeMatrix(int[][] csvMatrix);
        int[][] RotateMatrix(int[][] csvMatrix);
    }
}