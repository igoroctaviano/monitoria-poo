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
#include <string>
class Shape
{
public:

	Shape(void);
	~Shape(void);
	virtual float area()=0;	
	std::string myType(){return "I'm a shape";}
};

