// C10 NamespaceOverriding1.cpp: define el punto de entrada de la aplicación de consola.
//

#include "stdafx.h"
#include "NamespaceMath.h"
#include "NamespaceMath.h"
int main() {
	using namespace Math;
	Integer a; // Hides Math::a;
	a.setSign(negative);
	// Now scope resolution is necessary
	// to select Math::a :
	Math::a.setSign(positive);
} ///:~

