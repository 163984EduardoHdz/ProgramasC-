// C10 LocalExtern.cpp: define el punto de entrada de la aplicación de consola.
//

#include "stdafx.h"
#include <iostream>

int main() {
	extern int i;
	std::cout << i;
	system("pause");
} ///:~

