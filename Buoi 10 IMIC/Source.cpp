#include <stdio.h>
#include <conio.h>
#include <iostream>
using namespace std;

typedef float (*ham)(int);
float tinhTichPhanHamBatKy(int a, int b, ham addr)
{
	float ketQua = 0;
	int tanSoLayMau = 1000;
	float chieuCao = (float) (b - a) / (float) tanSoLayMau;
	for (int i = 0; i < tanSoLayMau; i++)
	{
		float dayL = addr(a + i * chieuCao);
		float dayB = addr(a + (i +1)* chieuCao);
		float dienTichHinhThang = (dayL + dayB) * chieuCao / 2;
	}
	return ketQua;
}

float fx(int x)
{
	return 2*x*x + 1;
}

int main(void)
{
	float tichPhan = tinhTichPhanHamBatKy(2, 5, fx);
	_getch();
	return 0;
}
