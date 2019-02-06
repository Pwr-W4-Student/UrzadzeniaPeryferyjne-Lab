// Lab1_mozaikowa.cpp : Defines the entry point for the console application.
//

#include "stdafx.h"
#include "iostream"
#include "fstream"
#include "string"
#include "sstream"

using namespace std;

char esc = 27;
char T = 73;
char zero = 0;
char stdwa = 120;
char czos = 48;
void print()
{
	fstream port;
	port.open("LPT3", ios::out);
	if (port.is_open())
		cout << "Port is open.";
	else
		cout << "It's not working.";
	//default
	port << esc << "@";

	//margin
	port << esc << "Q" << 4;

	//quality
	port << esc << "x0" << "Draf quality" << endl;
	port << esc << "x1" << "Letter quality" << endl;

	//fonts
	port << esc << "k0" << esc << "x1" << "Roman font" << " ABC123abc" << endl;
	port << esc << "k1" << esc << "x1" << "Sanserif font" << " ABC123abc" << endl;
	port << esc << "k2" << esc << "x1" << "Courier font" << " ABC123abc" << endl;

	//size
	port << esc << "h" << "2" << "Size" << " ABC123abc" << endl;

	//underlining
	port << esc << "-" << "1" << "Underline" << " ABC123abc" << endl;

	port << esc << "j";
	port << esc << endl;

	port.flush();
	port.close();
}

void defineChar(){
	fstream port;
	port.open("LPT3", ios::out);
	if (port.is_open())
		cout << "Port is open.";
	else
		cout << "It's not working!!!!!!!!!!!!!";
}

int _tmain(int argc, _TCHAR* argv[])
{
	print();
	defineChar();
	cin.get();
	return 0;
}

