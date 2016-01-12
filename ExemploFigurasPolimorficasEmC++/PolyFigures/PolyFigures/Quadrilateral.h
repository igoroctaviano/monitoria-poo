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
#include "shape.h"
class Quadrilateral :
	public Shape
{
public:
	Quadrilateral(void);
	~Quadrilateral(void);
	virtual float area()=0;
};