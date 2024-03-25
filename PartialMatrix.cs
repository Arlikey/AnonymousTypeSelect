/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnonymousTypeSelect;

public partial class Matrix
{
    public void FillMatrix()
    {
        Random random = new Random();
        for (int i = 0; i < Rows; i++)
        {
            for (int j = 0; j < Cols; j++)
            {
                Array[i, j] = random.NextSingle();
            }
        }
    }

    public void Show()
    {
        for (int i = 0; i < Rows; i++)
        {
            for (int j = 0; j < Cols; j++)
            {
                Console.Write(Array[i, j] + " ");
            }
            Console.WriteLine();
        }
    }

    public void MultiplyByNumber(int number)
    {
        for (int i = 0; i < Rows; i++)
        {
            for (int j = 0; j < Cols; j++)
            {
                Array[i, j] *= number;
            }
        }
    }

    public void SumMatrix(Matrix other)
    {
        if (other == null || (other.Cols * other.Rows) != Array.Length)
        {
            throw new Exception("Invalid Data!");
        }

        for (int i = 0; i < Rows; i++)
        {
            for (int j = 0; j < Cols; j++)
            {
                this.Array[i, j] += other.Array[i, j];
            }
        }
    }

    public void MulMatrix(Matrix other)
    {
        if (other == null || (other.Cols * other.Rows) != Array.Length)
        {
            throw new Exception("Invalid Data!");
        }

        for (int i = 0; i < Rows; i++)
        {
            for (int j = 0; j < Cols; j++)
            {
                this.Array[i, j] *= other.Array[i, j];
            }
        }
    }
}

*/