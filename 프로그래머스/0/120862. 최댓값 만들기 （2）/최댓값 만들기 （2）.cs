using System;

public class Solution {
    public int solution(int[] numbers) {
        Array.Sort(numbers);
        int plus = numbers[numbers.Length-1] * numbers[numbers.Length-2];
        int minus = numbers[0] * numbers[1];
        return plus > minus ? plus : minus;
    }
}