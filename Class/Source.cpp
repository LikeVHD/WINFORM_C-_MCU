#include <iostream>
#include "phanso.h"
using namespace std;

int main(void)
{
	PhanSo A(3, 4);
	PhanSo B(2, 5);
	
	printf("(A + B): co Tu so la %d va mau so la %d.\r\n", (A+B).tuSo, (A+B).mauSo);
	printf("(A - B): co Tu so la %d va mau so la %d.\r\n", (A-B).tuSo, (A-B).mauSo);
	printf("(A * B): co Tu so la %d va mau so la %d.\r\n", (A*B).tuSo, (A*B).mauSo);
	printf("(A / B): co Tu so la %d va mau so la %d.\r\n", (A/B).tuSo, (A/B).mauSo);

	system("pause");
	return 0;
}