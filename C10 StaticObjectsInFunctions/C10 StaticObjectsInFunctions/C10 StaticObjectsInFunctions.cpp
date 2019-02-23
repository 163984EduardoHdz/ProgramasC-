// C10 StaticObjectsInFunctions.cpp: define el punto de entrada de la aplicación de consola.
//

#include "stdafx.h"
#include <iostream>
using namespace std;

class X {
	int i;
public:
	X(int ii = 0) : i(ii) {} // Default
	~X() { cout << "X::~X()" << endl; system("pause");
	}
};

void f() {
	static X x1(47);
	static X x2; // Default constructor required
}

int main() {
	f();	
} ///:~
