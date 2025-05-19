using System;

public class Solution {
    public bool solution(bool x1, bool x2, bool x3, bool x4) {
        bool a1 = x1 || x2;
        bool a2 = x3 || x4;
        return a1 && a2;
    }
}