// Cap 8 Pro 9.cpp: define el punto de entrada de la aplicación de consola.
//

#include "stdafx.h"

int main()
{
	double numbers[5] = { 0,1,2,3,4 };
	const double* u = &numbers[5];
	double const* v = &numbers[5];
	cout << "antes de aumentar el puntero: " << *v << endl;
	cout << "aumentando numbers[5] desde el puntero es igual a " << *v++ << endl;

	system("pause");

	return 0;
}
