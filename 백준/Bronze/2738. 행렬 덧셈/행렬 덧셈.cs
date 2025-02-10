using System;

internal class Program
{
    static void Main(string[] args){
        string[] size = Console.ReadLine().Split();
        int n = int.Parse(size[0]);
        int m = int.Parse(size[1]);
        int[,] sum = new int[n,m];
        
        for(int i = 0; i < 2; i++){
            for(int j = 0; j < n; j++){
                string[] num = Console.ReadLine().Split();
                for(int k = 0; k < m; k++){
                    sum[j,k] += int.Parse(num[k]);
                }
            }            
        }
        for(int i = 0; i < n; i++){
            for(int j = 0; j < m; j++){
                Console.Write(sum[i,j] + " ");
            }
            Console.Write("\n");
        }


    }
}