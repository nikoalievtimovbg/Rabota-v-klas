#include <iostream>

using namespace std;

int main()
{
    int n=7,br;
    int a[7]={123,1,6,9,142,145,12};
    for(int i = 1;i < 7;i++)
    {
        if(a[i]>0 && a[i]<100)
        {
            br++;
            cout<<"br:"<<a[i];
        }
    }
    return 0;
}
