// C10 StaticVariablesInfunctions.cpp: define el punto de entrada de la aplicación de consola.
//

#include "stdafx.h"
#include "require.h"
#include <iostream>
	using namespace std;

	char oneChar(const char* charArray = 0) {
		static const char* s;
		if (charArray) {
			s = charArray;
			return *s;
		}
		else
			require(s, "un-initialized s");
		if (*s == '\0')
			return 0;
		return *s++;
	}

	const char* a = "abcdefghijklmnopqrstuvwxyz"; //se agrego la palabra const ya que me marcaba
								//error al momento de compilarlo

	int main() {
		// oneChar(); // require() fails
		oneChar(a); // Initializes s to a
		char c;
		while ((c = oneChar()) != 0)
			cout << c << endl;
		system("pause");
	} ///:~

