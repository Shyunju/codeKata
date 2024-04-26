using System;

public class Solution {
    public string solution(string[] id_pw, string[,] db) {
        for(int i = 0; i < db.GetLength(0); i++)
        {
            if(id_pw[0].Equals(db[i,0]))
            {
                if(id_pw[1].Equals(db[i,1]))
                    return "login";
                return "wrong pw";
            }
        }
        return "fail";
    }
}