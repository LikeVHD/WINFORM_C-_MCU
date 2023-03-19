#include <iostream>
#include <conio.h>
#include <math.h>
using namespace std;

int main()
{
	int n;
	cout << "Nhap vao n: ";
	cin >> n;
	int tong  = 0;
	for (int i = 1; i <= n; i++)
	{
		tong += i;
	}

	cout << "Tong cac so tu 1 den N la: " << tong << endl;
	system("pause");
	return 0;
}