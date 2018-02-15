#include <iostream>

using namespace std;

int main()
{
    int swap,imin,n=7,buf;
    int a[7]={10,-15,12,6,4,3,8};
    for(int i = 0;i<6 ;i++)
    for(int i=0;i< n;i++)
   for(int j=n-1;j >i;j--)
      if(a[j-1] >a[j])
       {
          buf=a[j-1];
          a[j-1]=a[j];
          a[j]=buf;
       }
 for(int i=0;i< n;i++)
    cout<< a[i]<< "\n";
    return 0;
}
