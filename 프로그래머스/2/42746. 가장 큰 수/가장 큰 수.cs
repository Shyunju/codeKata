using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
public class Solution
{
        const int MAX = 1000;  

        public string solution(int[] numbers)
        {
            int max_length = MAX.ToString().Length;

            StringBuilder sb = new StringBuilder();
            Dictionary<int, string> number_dic = new Dictionary<int, string>();

            for (int i = 0; i < numbers.Length; ++i)
            {              
                string num_str = numbers[i].ToString();
                while (num_str.Length < max_length)
                {
                    num_str += num_str;
                }
                if (num_str.Length > max_length)
                {
                    num_str = num_str.Substring(0, max_length);
                }

                number_dic.Add(i, num_str);
            }

            var result_dic = number_dic.OrderByDescending(x => x.Value);

            foreach (var key_value in result_dic)
            {
                sb.Append(numbers[key_value.Key]);
            }

            if (sb[0] == '0')
            {
                sb.Clear();
                sb.Append("0");
            }

            return sb.ToString();
        }
}