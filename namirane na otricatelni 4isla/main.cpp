#include <iostream>

using namespace std;

int main()
{
    int n=7,br;
    int a[7]={10,-15,12,6,-4,3,8};
    for(int i = 0;i<6 ;i++)
    {
     if(a[i]<0)
    {
     br++;
     cout<<"br:"<<a[i];
    }
    }
    return 0;
}
