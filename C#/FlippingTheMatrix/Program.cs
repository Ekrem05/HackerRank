using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;


    /*
     * Complete the 'flippingMatrix' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts 2D_INTEGER_ARRAY matrix as parameter.
     */

     static int flippingMatrix(List<List<int>> matrix)
    {
        for (int i = 0; i < matrix.Count - 1; i++)
        {

            if (matrix[i][0] + matrix[i][1] < matrix[i][2] + matrix[i][3])
            {
                int temp1 = matrix[i][0];
                int temp2 = matrix[i][1];
                matrix[i][0] = matrix[i][2];
                matrix[i][1] = matrix[i][3];
                matrix[i][2] = temp1;
                matrix[i][3] = temp2;

            }
                if (matrix[0][i] + matrix[1][i] < matrix[2][i] + matrix[3][i])
                {
                int temp1 = matrix[0][i];
                int temp2 = matrix[1][i];
                matrix[0][i] = matrix[2][i];
                matrix[1][i] = matrix[3][i];
                matrix[2][i] = temp1;
                matrix[3][i] = temp2;

                }
        }
        int sum = matrix[0][0] + matrix[0][1] + matrix[1][0] + matrix[1][1];
        return sum;
    }


       
        int q = Convert.ToInt32(Console.ReadLine().Trim());

        for (int qItr = 0; qItr < q; qItr++)
        {
            int n = Convert.ToInt32(Console.ReadLine().Trim());

            List<List<int>> matrix = new List<List<int>>();

            for (int i = 0; i < 2 * n; i++)
            {
                matrix.Add(Console.ReadLine().TrimEnd().Split(' ').ToList().Select(matrixTemp => Convert.ToInt32(matrixTemp)).ToList());
            }

            int result = flippingMatrix(matrix);

            Console.WriteLine(result);
        }

    
