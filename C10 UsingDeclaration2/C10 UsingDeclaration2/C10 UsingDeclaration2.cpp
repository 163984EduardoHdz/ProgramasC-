// C10 UsingDeclaration2.cpp: define el punto de entrada de la aplicación de consola.
//

#include "stdafx.h"
#include "UsingDeclaration.h"
namespace Q {
	using U::f;
	using V::g;
	// ...
}
void m() {
	using namespace Q;
	f(); // Calls U::f();
	g(); // Calls V::g();
}
int main() {} ///:~