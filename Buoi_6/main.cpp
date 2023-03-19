#include <iostream>
#include <stdio.h>
#include <Windows.h>
#include <setjmp.h>
using namespace std;

//Tính tích phân của 1 hàm bất kỳ trong đoạn a đến b
// Yêu cầu truyền vào a, b và địa chỉ hàm
// Bài này ứng dụng con trỏ hàm
float gx(float x)
{
	return x*x*x + x*x + 10
}

float tinhTichPhan(float a, float b, float (* func)(float))
{
	int sample = 1000;
	float h = (b - a)/sample;
	float result = 0;

	for (float i = a; i < b; i += h)
	{
		float db = func(i);
		float dl = func(i+h);
		result += h*(dl + db)/2;
	}
	return result;
}

int main()
{
	AddVector


	tinhTichPhan(1, 2, gx);
	system("pause");
	return 0;
}