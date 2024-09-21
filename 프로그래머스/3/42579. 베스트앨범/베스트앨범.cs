using System;
using System.Linq;
using System.Collections.Generic;
public class Solution {
    public int[] solution(string[] genres, int[] plays) 
    {
        var zipList = Enumerable.Range(0, genres.Length)
                                .Select(i => new{ index = i, genre = genres[i], play = plays[i]})
                                .ToList();

        List<string> genreRank = zipList.GroupBy(g => g.genre)
                                        .OrderByDescending(g => g.Sum(t => t.play))
                                        .Select(g => g.Key)
                                        .ToList();

        var topTwoEnumerable = zipList.GroupBy(g => g.genre)
                                      .OrderBy(g => genreRank.IndexOf(g.Key))
                                      .Select(g => g.OrderByDescending(t => t.play).Take(2));

        return topTwoEnumerable.SelectMany(x => x).Select(x => x.index).ToArray();
    }
}