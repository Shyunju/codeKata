public class Solution {
    public bool solution(string s) {
        char[] chr = s.ToCharArray();
        if( 4 != chr. Length && 6 != chr.Length){
            return false;
        }
        for( int i = 0; i< chr.Length; i++){
            if(chr[i] > 58){
                return false;
            }
        }
        return true;
    }
}