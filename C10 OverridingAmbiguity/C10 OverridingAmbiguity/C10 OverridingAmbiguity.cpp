// C10 OverridingAmbiguity.cpp: define el punto de entrada de la aplicación de consola.
//

#include "stdafx.h"
#include "NamespaceMath.h"
#include "NamespaceOverriding2.h"
void s() {
	using namespace Math;
	using namespace Calculation;
	// Everything's ok until:
	//! divide(1, 2); // Ambiguity
}
int main() {} ///:~