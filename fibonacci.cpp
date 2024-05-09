#include<iostream>
using namespace std;
int main(){
	int n;
	int f1,f2;
	f1=1;
	f2=1;
	do{
		cout << "vui long nhap n >2"<<endl;
		cin >> n;
		if(n>2){
			cout << f1 << " "<<f2;
			int f;
		
			for(int i=3;i<n;i++){
				f=f1+f2;
				cout << " " << f;
				f1=f2;
				f2=f;
			}
		}
	}
	while(n<=2);
	}
