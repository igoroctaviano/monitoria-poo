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
#include "rectangles.h"
class Square :
	public Rectangles
{
private:
	float side;
public:
	Square(float sq_side):Rectangles(sq_side, sq_side){
	   side = sq_side;
	};
	~Square(void);
	 float area(){return side*side;}
	 std::string myType(){return "I'm a square";}
};






