#include <iostream>
using namespace std;
int demKiTuTrongChuoi(char*);
char str[] = "hello";	
int main(void)
{
	int so = demKiTuTrongChuoi(str);
	cout << "So ky tu trong chuoi: " << so  << endl;

	system("pause");
	return 0;
}

int demKiTuTrongChuoi(char* addr)
{
	int soKyTu = 0;
	char* addrChuoi = addr;
	while (*addrChuoi)
	{
		soKyTu++;
		addrChuoi++;
	}
	return soKyTu;
}