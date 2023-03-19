#define  _CRT_SECURE_NO_WARNINGS
#include <stdio.h>
#include <conio.h>


int main(void)
{
	//Khai bao mang luu du lieu
	char fileData[] = "Xin chao cac ban dau dau qua !";
	char i = 0;

	//Mo file
	FILE* f = fopen("1.txt", "w");
	
	while (fileData[i] != 0)
	{
		fputc(fileData[i], f);
		i++;
	}
	fclose(f);
	_getch();
	return 0;
}