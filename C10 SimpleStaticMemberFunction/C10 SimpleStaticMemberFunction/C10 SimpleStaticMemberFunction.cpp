// C10 SimpleStaticMemberFunction.cpp: define el punto de entrada de la aplicación de consola.
//

#include "stdafx.h"
class X {
public:
	static void f() {};
};

int main() {
	X::f();
} ///:~

