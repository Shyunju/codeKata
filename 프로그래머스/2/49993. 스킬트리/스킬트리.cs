using System;
using System.Collections.Generic;
public class Solution
{
    public int solution(string skill, string[] skill_trees)
    {
        int answer = skill_trees.Length;

        char[] skills = skill.ToCharArray();
        for (int i = 0; i < skill_trees.Length; i++)
        {
            int min = skill_trees[i].IndexOf(skills[0]);
            for (int j = 1; j < skills.Length; j++)
            {
                int curSkill = skill_trees[i].IndexOf(skills[j]);

                if (curSkill < min && curSkill != -1)
                {
                    answer--;
                    break;
                }
                else if (min == -1 && curSkill != -1)
                {
                    answer--;
                    break;
                }
                min = curSkill;
            }
        }
        return answer;
    }
}