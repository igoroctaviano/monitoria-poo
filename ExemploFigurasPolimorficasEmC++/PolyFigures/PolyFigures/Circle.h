//
// Pontif�cia Universidade Cat�lica de Minas Gerais
// Unidade S�o Gabriel
// Disciplina: Programa��o Orientada a Objetos
// *Object-Oriented Programming
// 
// Igor Octaviano
// More? access: https://github.com/igoroctaviano/
// 
#pragma once
#include "shape.h"
#include <iostream>
class Circle :
	public Shape
{
private:
	float radius;
public:
	Circle(float r): radius(r){};
	~Circle(void);
	virtual float area() {return radius*radius*3.1415926;}
	std::string myType(){return "I'm a circle";}
	
};





