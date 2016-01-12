//
// Pontifícia Universidade Católica de Minas Gerais
// Unidade São Gabriel
// Disciplina: Programação Orientada a Objetos
// *Object-Oriented Programming
// 
// Igor Octaviano
// More? access: https://github.com/igoroctaviano/
// 
#pragma once
class Printable
{
private:
	int foreColor;
	int backColor;
	char myChar;

public:
	Printable(int f, int b, char c): foreColor(f), backColor(b), myChar(c){};
	~Printable(void);
	void setForeColor(int color){foreColor = color;}
	void setBackColor(int color){backColor = color;}
	void setChar(char ch){myChar = ch;}
	char getChar(){return myChar;}
	int getForeColor(){return foreColor;}
	int getBackColor(){return backColor;}
	virtual void Print()=0;
};

