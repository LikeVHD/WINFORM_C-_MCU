#pragma once
#ifndef PhanSo_h
#define PhanSo_h
#include <stdio.h>
class PhanSo
{
public:
	// Cac ham khoi tao
	PhanSo();
	PhanSo(int, int);
	// Ham huy
	~PhanSo ();
	// Khai bao cac phuong thuc
	void RutGonPhanSo(void);	// Phuong thuc rut gon phan so
	PhanSo operator+(PhanSo);		// Phuong thuc cong 2 phan so
	PhanSo operator-(PhanSo);		// Phuong thuc tru 2 phan so
	PhanSo operator*(PhanSo);		// Phuong thuc nhan 2 phan so
	PhanSo operator/(PhanSo);		// Phuong thuc chia 2 phan so
//private:
	int tuSo;											// Thuoc tinh Tu So
	int mauSo;										// Thuoc tinh Mau So
	int ucln(int, int);								// Thuoc tinh tim UCLN
};
#endif

