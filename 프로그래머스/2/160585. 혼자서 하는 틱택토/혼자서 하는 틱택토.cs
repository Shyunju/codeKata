using System;

public class Solution {
    public int solution(string[] board) {
        int cnt_o = 0; 
        int cnt_x = 0;
        for(int i = 0; i < 3; i++){
            for(int j = 0; j < 3; j++){
                if(board[i][j] == 'O') ++cnt_o;
                else if(board[i][j] == 'X') ++cnt_x;
            }
        }
        
        if(cnt_o > cnt_x + 1) return 0;
        if(cnt_x > cnt_o) return 0;
        
        int bingo_o = 0;
        int bingo_x = 0;
        
        //가로선
        for(int y = 0; y < 3; y++){
            if(board[y] == "OOO") ++bingo_o;
            else if(board[y] == "XXX") ++bingo_x;
        }
        //세로선\
        for(int x = 0; x < 3; x++){
            if(board[0][x] == 'O' && board[1][x] == 'O' && board[2][x] == 'O') ++bingo_o;
            else if(board[0][x] == 'X' && board[1][x] == 'X' && board[2][x] == 'X') ++bingo_x;
        }
        //대각선
        if(board[1][1] == 'O'){
            if(board[0][0] == 'O' && board[2][2] == 'O') ++bingo_o;
            if(board[0][2] == 'O' && board[2][0] == 'O') ++bingo_o;
        }
        else if(board[1][1] == 'X'){
            if(board[0][0] == 'X' && board[2][2] == 'X') ++bingo_x;
            if(board[0][2] == 'X' && board[2][0] == 'X') ++bingo_x;
        }
        
        if(bingo_o > 0 && bingo_x > 0) return 0;
        if(bingo_o > 0 && cnt_o == cnt_x) return 0;
        if(bingo_x > 0 && cnt_o > cnt_x) return 0;
        
        return 1;
    }
}