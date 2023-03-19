#include <iostream>
#include <cstdio>
#include <stdio.h>
using namespace std;

int main()
{
	const char *filePath = "C:/Users/Administrator/Desktop/cuongtext.txt";
	FILE *file;
	file = fopen("file", "r");
	if (!file)
		cout << "Khong the mo file" << endl;
	else
		cout << "File da duoc mo" << endl;

	system("pause");
	return 0;
}
