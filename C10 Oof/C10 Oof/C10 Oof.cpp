// C10 Oof.cpp: define el punto de entrada de la aplicación de consola.
//

#include "stdafx.h"
// Second file
//{L} Out
#include <fstream>
extern std::ofstream out;
class Oof {
public:
	Oof() { out << "ouch"; }
} oof;
int main() {} ///:~