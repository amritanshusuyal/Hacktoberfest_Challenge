#include<iostream>
#include<math.h>
using namespace std;

bool isPrime(int num){
	for(int i = 2;i<=sqrt(num);i++){
		if(num%i==0){
			return false;
		}
	}
	return true;
}
int main(){
	//Print all the prime number between two numbers?
    int a;
    int b;
    cin>>a;
    cin>>b;
    for (int i=a; i<=b;i++)
    {
    	if(isPrime(i))
    	{
    		cout<<i<<endl;
		}
	}

    return 0;
}