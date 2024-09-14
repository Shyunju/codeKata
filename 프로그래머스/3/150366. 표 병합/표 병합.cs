using System;
using System.Collections.Generic;

public class Solution
{
    string[] stringArray = new string[2501]; // 셀 안의 값
    int[] intArray = new int[2501]; // 인덱스배열 (병합 관리)
        // 셀이 가리키는 인덱스를 반환하는 메서드
    private int GetIndex(string r, string c)
    {
        int num = int.Parse(r) * 49 + int.Parse(c);
        return intArray[num];
    }

        // 셀 안의 값을 반환하는 메서드
    private string GetValue(int index)
    {
        return stringArray[intArray[index]];
    }

    public string[] solution(string[] commands)
    {
        var answerList = new List<string>();

        // 초기화
        for (int i = 1; i < intArray.Length; i++)
        {
            intArray[i] = i;
            stringArray[i] = "";
        }
            
        // 명령 순차 실행
        for (int i = 0; i < commands.GetLength(0); i++)
        {
            string[] strs = commands[i].Split(' ');
            switch (strs[0])
            {
                case "UPDATE":
                    CellUpdate(strs);
                    break;
                case "MERGE":
                    CellMerge(strs);
                    break;
                case "UNMERGE":
                    CellUnmerge(strs);
                    break;
                case "PRINT":
                    CellPrint(strs, answerList);
                    break;
            }
        }

        return answerList.ToArray();
    }

        // 셀 업데이트
    private void CellUpdate(string[] strs)
    {
        if (strs.Length == 3)
        {
            for (int i = 1; i < stringArray.Length; i++)
                if (stringArray[i] == strs[1])
                    stringArray[i] = strs[2];
        }
        else // strs.Length == 4
        {
                // 병합된 셀 모두 업데이트
            int index = GetIndex(strs[1], strs[2]);

            for (int i = 1; i < intArray.Length; i++)
                if (intArray[i] == index)
                    stringArray[i] = strs[3];
        }
    }

        // 셀 병합
    private void CellMerge(string[] strs)
    {
        int index1 = GetIndex(strs[1], strs[2]);
        int index2 = GetIndex(strs[3], strs[4]);

        if (stringArray[index1] == "" && stringArray[index2] != "")
        {
            // index2로 병합
            for (int i = 1; i < intArray.Length; i++)
                if (intArray[i] == index1)
                    intArray[i] = index2;
        }
        else
        {
            // index1로 병합
            for (int i = 1; i < intArray.Length; i++)
                if (intArray[i] == index2)
                    intArray[i] = index1;
        }

    }
    // 셀 병합 해제
    private void CellUnmerge(string[] strs)
    {
        int index = GetIndex(strs[1], strs[2]);
        string str = GetValue(index);

        for (int i = 1; i < intArray.Length; i++)
        {
            if (intArray[i] == index)
            {
                intArray[i] = i;
                stringArray[i] = "";
            }
        }

        // 해제를 명령한 셀에게 병합된 셀의 값을 넣음
        stringArray[GetIndex(strs[1], strs[2])] = str;
    }

    // 셀의 값을 answerList에 출력
    private void CellPrint(string[] strs, List<string> answerList)
    {
        int index = GetIndex(strs[1], strs[2]);
        string str = GetValue(index);

        if (str == "")
            str = "EMPTY";

        answerList.Add(str);
    }
}