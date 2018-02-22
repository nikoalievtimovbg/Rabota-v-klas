#include <iostream>
#include <list>
using namespace std;
void nums()
{
    list<double>number;
    int number1;
    cin>>number1;
    number.push_front(2);
    number.push_front(1);
    number.push_back(3);
    number.push_back(4);
    list<double>::iterator it;
    it=number.begin();
    it++;
    it++;
    number.insert(it,number1);
    it=number.begin();
    while(it!=number.end()){
        cout<<*it<<" ";
        it++;
    }
}
int main()
{
    nums();
    return 0;
}
