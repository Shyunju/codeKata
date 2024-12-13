#include <string>
#include <vector>
#include <algorithm>
using namespace std;

int dy[5]={1,-1,0,0,0};
int dx[5]={0,0,0,1,-1};
int minAns = 10000000;

void Calc(int maxSize, int nowIndex, vector<vector<int>> &topValue, vector<vector<int>> &clockHands)
{
    if (nowIndex<maxSize)
    {
        for (int i=0; i<=3; i++)
        {
            topValue[0][nowIndex]=i;
            Calc(maxSize,nowIndex+1,topValue,clockHands);
        }    
    }
    else
    {
        vector<vector<int>> realClockHands=clockHands;        
        int y=0,x=0,ny,nx;
        for (int i=0; i<maxSize; i++)
        {
            x=i;
            for (int j=0; j<5; j++)
            {
                ny=y+dy[j];
                nx=x+dx[j];
                if (ny>=0 &&ny<maxSize&&nx>=0&&nx<maxSize)
                {
                    realClockHands[ny][nx]+=topValue[0][i];
                    realClockHands[ny][nx]%=4;
                }
            }
        }
        
        for (int i=0; i<maxSize-1; i++)
        {
            y=i+1;
            for (int j=0; j<maxSize; j++)
            {
                x=j;
                if (realClockHands[i][j]!=0)
                {
                    int vvv=4-realClockHands[i][j];
                    topValue[y][j]=vvv;
                    for (int k=0; k<5; k++)
                    {
                        ny=y+dy[k];
                        nx=x+dx[k];
                        if (ny>=0 &&ny<maxSize&&nx>=0&&nx<maxSize)
                        {
                            realClockHands[ny][nx]+=vvv;
                            realClockHands[ny][nx]%=4;
                        }
                    } 
                }
                else
                {
                    topValue[y][j]=0;
                }
            }
        }
        int ttt=0;
        for (int i=0; i<maxSize; i++)
        {
            for (int j=0; j<maxSize; j++)
            {
                ttt+=topValue[i][j];
                if (realClockHands[i][j]!=0)
                {
                    return;
                }
            }
        }
        minAns=min(minAns,ttt);
    }
}

int solution(vector<vector<int>> clockHands) {
    //0=12, 1=3, 2=6, 3=9
    int sss=clockHands.size();
    vector<vector<int>> vvvv(sss,vector<int>(sss,0));
    Calc(sss, 0, vvvv, clockHands);
    
    return minAns;
}