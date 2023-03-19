#define _CRT_SECURE_NO_WARNINGS
#include <stdio.h>
#include <conio.h>

int main(void)
{
	int a, b;
	FILE* fileIn;

	fileIn = fopen("input.txt", "r");
	fscanf(fileIn, "%d", &a);
	fscanf(fileIn, "%d", &b);

	fclose(fileIn);

	//printf("a = %d va b = %d", a, b);

	int Tong = a + b;
	int Hieu = a - b;
	int Tich = a * b;
	float Thuong = (float) a / b;

	FILE* fileOut;
	fileOut = fopen("out.txt", "w");
	fprintf(fileOut, "Tong cua 2 so A va B la: %d", Tong);
	fclose(fileOut);

	_getch();
	return 0;
}