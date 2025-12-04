using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Solution
{
    // 금지된 주문을 저장하고 접두사 기반 카운트를 위한 Trie 노드 클래스
    private class TrieNode
    {
        // 26개의 소문자 알파벳('a'~'z')을 위한 자식 노드 배열
        public TrieNode[] children = new TrieNode[26];
        // 이 노드를 접두사로 하는, 현재 타겟 길이(targetLength)와 길이가 같은 금지된 주문의 개수
        public long count = 0; 
    }

    // Helper function for 26^L calculation
    private long SafePower(int baseNum, int exp)
    {
        if (exp < 0) return 0; // 음수 지수 처리
        long result = 1;
        for (int i = 0; i < exp; i++)
        {
            result *= baseNum;
        }
        return result;
    }

    // 최대 11글자 이하의 소문자 알파벳으로 만들어진 모든 문자열 중
    // 특정 주문(bans)이 삭제된 후의 n번째 주문을 찾는 함수입니다.
    // Trie 자료구조를 사용하여 시간 복잡도를 최적화합니다.
    public string solution(long n, string[] bans)
    {
        // 1. 금지된 주문 목록을 HashSet으로 변환합니다.
        var bannedSpells = new HashSet<string>(bans);
        long nRemaining = n;
        int maxLen = 11;

        // 2. 주문의 길이를 결정합니다 (targetLength).
        int targetLength = 0;
        
        // bannedSpells를 길이별로 그룹화하여 L 길이의 금지된 주문 개수를 빠르게 확인합니다.
        var bannedByLength = bannedSpells
            .Where(b => b.Length <= maxLen)
            .GroupBy(b => b.Length)
            .ToDictionary(g => g.Key, g => g.Count());

        for (int L = 1; L <= maxLen; L++)
        {
            // L 길이의 총 문자열 개수 (26^L)를 계산합니다.
            long totalSpellsOfLengthL = SafePower(26, L);
            
            // L 길이의 금지된 주문 개수
            int bannedCountOfLengthL = bannedByLength.ContainsKey(L) ? bannedByLength[L] : 0;
            
            // L 길이의 유효한 주문 개수
            long validCountOfLengthL = totalSpellsOfLengthL - bannedCountOfLengthL;

            if (nRemaining <= validCountOfLengthL)
            {
                // n번째 주문은 이 길이(L) 블록 내에 있습니다.
                targetLength = L;
                break;
            }
            nRemaining -= validCountOfLengthL; // 이 블록을 건너뛰고 n을 갱신
        }

        if (targetLength == 0)
        {
            // n이 전체 유효한 주문의 수를 초과하는 경우
            return ""; 
        }

        // 3-0. (최적화) 결정된 targetLength와 길이가 같은 금지된 주문만 포함하는 Trie를 구축합니다.
        var trieRoot = new TrieNode();
        // `Where(b => b.Length == targetLength)` 필터링은 정확합니다.
        var targetLengthBans = bannedSpells.Where(b => b.Length == targetLength);
        
        foreach (var spell in targetLengthBans)
        {
            var current = trieRoot;
            for (int i = 0; i < spell.Length; i++)
            {
                int charIndex = spell[i] - 'a';
                if (current.children[charIndex] == null)
                {
                    current.children[charIndex] = new TrieNode();
                }
                current = current.children[charIndex];
                current.count++; // 이 노드를 접두사로 하는, targetLength 길이의 금지된 주문 개수 증가
            }
        }

        // 3-1. 결정된 길이 (targetLength) 내에서 nRemaining 번째 주문을 찾습니다.
        StringBuilder result = new StringBuilder();
        TrieNode currentTrieNode = trieRoot;

        for (int i = 0; i < targetLength; i++)
        {
            // Trie 탐색이 중단되었을 경우, 나머지 문자는 모두 금지되지 않은 것으로 간주
            if (currentTrieNode == null)
            {
                // 이 경로로 시작하는 나머지 문자열은 모두 유효합니다.
                // 따라서 nRemaining 번째에 해당하는 문자를 바로 계산합니다.
                
                // 남은 문자열 개수 = 26^(suffixLength)
                int suffixLength = targetLength - i;
                long totalRemainingBlockCount = SafePower(26, suffixLength);
                
                // nRemaining이 1부터 시작하므로, 0-based 인덱스를 얻기 위해 -1을 합니다.
                long indexInBlock = nRemaining - 1; 

                // 현재 위치(i)부터 targetLength-1까지 문자를 결정합니다.
                for (int j = i; j < targetLength; j++)
                {
                    suffixLength = targetLength - (j + 1);
                    long divisor = SafePower(26, suffixLength);

                    // 해당 위치에 들어갈 문자의 0-based 인덱스
                    long charIndex = (divisor > 0) ? indexInBlock / divisor : 0;
                    
                    result.Append((char)('a' + charIndex));
                    
                    // 다음 문자를 결정하기 위해 나머지 인덱스를 갱신합니다.
                    indexInBlock %= divisor;
                }
                
                return result.ToString();
            }

            // Trie 탐색이 유효한 경우, 'a'부터 'z'까지 탐색합니다.
            for (char nextChar = 'a'; nextChar <= 'z'; nextChar++)
            {
                int charIndex = nextChar - 'a';
                TrieNode nextNode = currentTrieNode.children[charIndex];
                
                // 현재 접두사(result + nextChar)로 시작하는 문자열 블록 내의 총 문자열 개수
                int suffixLength = targetLength - (i + 1); 
                long totalBlockCount = SafePower(26, suffixLength);
                
                // 현재 블록 내의 금지된 주문 개수를 Trie를 사용하여 O(1)에 가져옵니다.
                long bannedInBlock = (nextNode != null) ? nextNode.count : 0;
                
                // 현재 블록 내의 유효한 주문 개수
                long validBlockCount = totalBlockCount - bannedInBlock;

                if (nRemaining <= validBlockCount)
                {
                    // nRemaining 번째 주문은 이 블록(nextChar) 내에 있습니다.
                    result.Append(nextChar);
                    
                    // Trie 노드를 다음 단계로 이동합니다.
                    if (nextNode == null)
                    {
                        // 이 경로로 시작하는 주문 중 targetLength 길이의 금지된 주문이 없다는 뜻입니다.
                        // 이후의 모든 문자는 금지되지 않으므로, 다음 루프부터는 Trie 탐색을 중단하고 
                        // 수학적 계산으로 전환하기 위해 currentTrieNode를 null로 설정합니다.
                        currentTrieNode = null; 
                    }
                    else
                    {
                        // Trie 경로를 계속 따라갑니다.
                        currentTrieNode = nextNode;
                    }
                    
                    // 다음 문자 위치 탐색으로 이동
                    goto next_char_position; 
                }
                else
                {
                    // nRemaining 번째 주문은 이 블록을 지나 다음 블록에 있습니다.
                    nRemaining -= validBlockCount;
                }
            }
            
            next_char_position:;
        }

        // targetLength가 0이 아니며, 루프 내에서 완전히 결정되지 않았을 경우 (Trie 경로가 끝까지 연결된 경우)
        // 이 부분은 Trie 경로가 끝까지 연결되어 루프가 종료될 때 실행됩니다.
        return result.ToString();
    }
}