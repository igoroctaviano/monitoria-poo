#pragma once
#include "printable.h"
#include "GameObject.h"
#include <iostream>
#include <Windows.h>
using namespace std;

class Item :
	public Printable, public GameObject
{
public:
	int value;

	
	Item(int x, int y, int v, 
		char mc='#', int fc=14, int bc=0): 
		Printable(fc, bc, mc), 
		GameObject(x,y){
	
		this->value = v;
	}
	
	~Item(void);
	
	virtual void Print(){
		HANDLE hConsole = GetStdHandle(STD_OUTPUT_HANDLE);;
		int k = getForeColor()+getBackColor()*16;
		COORD pos;
		pos.X = getX();
		pos.Y = getY();
		
		SetConsoleCursorPosition(hConsole, pos);
		SetConsoleTextAttribute(hConsole, k);	
		cout << getChar();
	}
};


