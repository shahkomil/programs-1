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

class Solution {

    // Complete the hourglassSum function below.
    static int hourglassSum(int[][] arr) {
        int[] res = new int[16];
        for(int i=0;i<16;i++){
        
            int r = i/4;
            int c= i%4;
            
           res[i] = arr[r][c] +  arr[r][c+1]  +  arr[r][c+2] 
                              +  arr[r+1][c+1]  + 
                    arr[r+2][c]  +  arr[r+2][c+1]  +  arr[r+2][c+2];
        
    }
        int max = -100;
        for(int k=0;k<16;k++){
            if(res[k]>max){
                max = res[k];
            }
        }
        return max;
    }

    static void Main(string[] args) {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int[][] arr = new int[6][];

        for (int i = 0; i < 6; i++) {
            arr[i] = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp));
        }

        int result = hourglassSum(arr);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
