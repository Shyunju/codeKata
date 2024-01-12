 using System;

    public class Solution
    {
        public int count = 0;

        public int solution(int[] numbers, int target)
        {
            Function(numbers, target, -1);

            return count;
        }

        public void Function(int[] numbers, int target, int index)
        {
            index++;
            
            if (numbers.Length == index)
            {
                int total = 0;
                foreach (int num in numbers)
                    total += num;

                if (total == target)
                    count++;

                return;
            }
            
            Function(numbers, target, index);
            numbers[index] *= -1;
            Function(numbers, target, index);
        }
    }