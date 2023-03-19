#include "phanso.h"

//------------------------------------
// Dinh nghia cac ham khoi tao
//------------------------------------
PhanSo::PhanSo()
{
	tuSo = 0;
	mauSo = 1;
}	// Ket thuc Ham khoi tao mac dinh

PhanSo::PhanSo(int tu, int mau)
{
	this->tuSo = tu;
	if (mau == 0)
	{
		printf("Mau so khong hop le !");
		return;
	}
	this->mauSo = mau;
}	// Ket thuc Ham khoi tao co tham so

PhanSo::~PhanSo()
{
	printf("Day la ham huy ! \r\n");
}	// Ket thuc Ham huy

//------------------------------------
// Dinh nghia cac phuong thuc
//------------------------------------

int PhanSo::ucln(int a, int b)
{
	int min = (a < b) ? a : b;

	for (int i = min; i > 1; i--)
	{
		if ((a % i == 0) && (b % i ==0))
		{
			return i;
		}
	}
	return 1;
}	//

/// <summary>
///  PHUONG THUC RUT GON PHAN SO
/// </summary>
/// <param name="input"></param>
void PhanSo::RutGonPhanSo()
{
	int UCLN = ucln(tuSo, mauSo);
	tuSo /= UCLN;
	mauSo /= UCLN;
}	//

/// <summary>
/// PHUONG THUC TINH TONG 2 PHAN SO
/// </summary>
/// <param name="input"></param>
/// <returns> Tong cua 2 phan so da duoc toi gian. </returns>
PhanSo PhanSo::operator+(PhanSo input)
{
	PhanSo kqTong;
	kqTong.tuSo = this->tuSo * input.mauSo + input.tuSo * this->mauSo;
	kqTong.mauSo = this->mauSo * input.mauSo;
	kqTong.RutGonPhanSo();
	return kqTong;
}	//

/// <summary>
///  PHUONG THUC TINH HIEU 2 PHAN SO
/// </summary>
/// <param name="input"></param>
/// <returns>Hieu cua 2 phan so da duoc toi gian. </returns>
PhanSo PhanSo::operator-(PhanSo input)
{
	PhanSo kqHieu;
	kqHieu.tuSo = this->tuSo * input.mauSo - input.tuSo * this->mauSo;
	kqHieu.mauSo = this->mauSo * input.mauSo;
	kqHieu.RutGonPhanSo();
	return kqHieu;
}	//

/// <summary>
///  PHUONG THUC TINH TICH 2 PHAN SO
/// </summary>
/// <param name="input"></param>
/// <returns> Tich cua 2 phan so da duoc toi gian. </returns>
PhanSo PhanSo::operator*(PhanSo input)
{
	PhanSo kqTich;
	kqTich.tuSo = this->tuSo * input.tuSo;
	kqTich.mauSo = this->mauSo * input.mauSo;
	kqTich.RutGonPhanSo();
	return kqTich;
}	//

/// <summary>
///  PHUONG THUC TINH THUONG 2 PHAN SO
/// </summary>
/// <param name="input"></param>
/// <returns> Thuong cua 2 phan so da duoc toi gian. </returns>
PhanSo PhanSo::operator/(PhanSo input)
{
	PhanSo kqThuong;
	kqThuong.tuSo = this->tuSo * input.mauSo;
	kqThuong.mauSo = this->mauSo * input.tuSo;
	kqThuong.RutGonPhanSo();
	return kqThuong;
}	//

