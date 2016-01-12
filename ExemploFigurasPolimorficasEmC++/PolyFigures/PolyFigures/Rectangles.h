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
#include "quadrilateral.h"
class Rectangles :
	public Quadrilateral
{
private:
	float base;
	float height;
public:
	Rectangles(float b, float h):base(b), height(h){};
	~Rectangles(void);
	virtual float area(){return base*height;}
	std::string myType(){return "I'm a rectangle";}
};








