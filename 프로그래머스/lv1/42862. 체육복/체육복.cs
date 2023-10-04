using System;
using System.Collections;
using System.Collections.Generic;

public class Solution {
    public int solution(int n, int[] lost, int[] reserve) {
        List<int> lostList = new List<int>(lost);
        List<int> reserveList = new List<int>(reserve);
        lostList.Sort();
        reserveList.Sort();
        
        List<int> tempList = new List<int>(reserveList);
        
        for (int i = 0; i < tempList.Count; i++)
        {
            if (lostList.Contains(tempList[i]))
            {
                lostList.Remove(tempList[i]);
                reserveList.Remove(tempList[i]);
            }
        }
        
        for (int i = 0; i < reserveList.Count; i++)
        {           
            if (lostList.Contains(reserveList[i] - 1))
            {
                lostList.Remove(reserveList[i] - 1);
                continue;
            }
            
            if (lostList.Contains(reserveList[i] + 1))
            {
                lostList.Remove(reserveList[i] + 1);
                continue;
            }
        }
        
        return n - lostList.Count;
    }
}