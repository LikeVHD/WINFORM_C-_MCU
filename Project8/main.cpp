#include <iostream>
#include <cstdio>
using namespace std;

int main(void)
{

     constexpr size_t size = 1000;

     // Declare an array of doubles to be allocated on the stack
     double numbers[size] {0};

     // Assign a new value to the first element
     numbers[0] = 1;

     // Assign a value to each subsequent element
     // (numbers[1] is the second element in the array.)
     for (size_t i = 1; i < size; i++)
     {
          numbers[i] = numbers[i - 1] * 1.1;
     }

     // Access each element
     for (size_t i = 0; i < size; i++)
     {
          std::cout << numbers[i] << " ";
     }

     //FILE *file;
     //errno_t err;
     //err = fopen_s(&file, "C:/Users/Administrator/Desktop/cuong.txt", "r");
     //if (!err)
     //     cout << "File da duoc mo" << endl;
     //else
     //     cout << "File ko duoc mo" << endl;
     system("pause");
     return 0;
}