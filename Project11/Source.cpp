#include <stdio.h>
#include <conio.h>
//#include <iostream>
//using namespace std;


//1: Khai báo cấu trúc dữ liệu danh sách liên kết đơn.

struct node
{
	int data;
	struct node* pNext;
};
typedef struct node NODE;

typedef struct list
{
	NODE* pHead;
	NODE* pTail;
}LIST;

//2. Khởi tạo danh sách liên kết đơn.

void init(LIST &l)
{
	l.pHead = l.pTail = NULL;
}

//3. Tạo node trong danh sách

NODE* getNode(int x)
{
	//Cấp phát 1 node
	NODE* p = new NODE;
	if (p == NULL)
	{
		return NULL;
	}
	p->data = x; //Lưu x vào data.
	p->pNext = NULL; // Khởi tạo mối liên kết.
}

//4. Thêm node (thêm đầu hoặc thêm cuối)
// Thêm node p vao đầu danh sách
void addHead(LIST& l, NODE* p)
{
	if (l.pHead == NULL)
	{
		l.pHead = l.pTail = p;
	}
	else
	{
		p->pNext = l.pHead; 
		l.pHead = p;
	}
}
//Thêm node p vào cuối danh sách
void addTail(LIST& l, NODE* p)
{
	if (l.pHead == NULL)
	{
		l.pHead = l.pTail = p;
	}
	else
	{
		l.pTail->pNext = p;
		l.pTail = p;
	}
}

//5. Nhập dữ liệu cho danh sách

void input(LIST& l)
{

}

int main(void)
{

	_getch();
	return 0;
}