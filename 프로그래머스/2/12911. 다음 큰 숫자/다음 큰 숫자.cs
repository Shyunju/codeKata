using System;

class Solution 
{
    public int solution(int n) 
   {
       
            string n_string = Convert.ToString(n, 2);
            char[] n_char = n_string.ToCharArray();
            int one=0;

            for (int i = 0; i < n_char.Length; i++)
            {
                if (n_char[i] == '1')
                    one++;
            }
            int one1 = 0;
            while(true)
            {
                one1 = 0; 
                n++;
                n_string = Convert.ToString(n, 2);
                n_char = n_string.ToCharArray();

                for (int i = 0; i < n_char.Length; i++)
                {
                    if (n_char[i] == '1')
                        one1++;
                }
                
                if (one==one1)
                {
            
                    return n;
                    break;
                }

            }
    }
}