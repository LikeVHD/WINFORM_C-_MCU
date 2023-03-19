#include <iostream>
#include <cstdio>
#include <fstream>
using namespace std;

int main(void)
{
	ifstream fileInput("C:/Users/Administrator/Desktop/Document.txt");
	if (fileInput.fail())
	{
		cout << "Loi mo file nay" << endl;
	}
	while (!fileInput.eof())
	{
		//char n;
		//if (fileInput >> n)
		//	cout << n << " ";
		//else
		//	return -2;

		char temp[255];
		fileInput.getline(temp, 255);
		string line = temp;
		cout << line << endl;
	}
	fileInput.close();

	system("pause");
	return 0;
}