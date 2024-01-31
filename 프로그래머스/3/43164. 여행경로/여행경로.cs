using System;
using System.Collections.Generic;
using System.Linq;

public class Solution {

    private List<string> _airPortsList = new List<string>();

    public string[] solution(string[,] tickets) {
        string[] answer = new string[] {};
        List<string[]> vs = new List<string[]>();

        for (int i = 0; i < tickets.GetLength(0); i++)
        {
            vs.Add(new string[] { tickets[i, 0], tickets[i, 1]});
        }


        string airports = "ICN";
        FindAirport(airports, "ICN", vs.ToArray());

        _airPortsList.Sort();
        answer = _airPortsList.First().Split(',');

        return answer;
    }

    private void FindAirport(string airports, string lastAirPort, string[][] remainTickets)
    {
        foreach (string[] item in remainTickets.Where(s => s[0] == lastAirPort))
        {
            string tempAirports = string.Format("{0},{1}", airports, item[1]);
            if (remainTickets.Count() == 1)
            {
                _airPortsList.Add(tempAirports);
                return;
            }
            List<string[]> tempTickets = remainTickets.ToList();
            tempTickets.Remove(item);
            FindAirport(tempAirports, item[1], tempTickets.ToArray());
        }
    }
}