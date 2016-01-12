//
// Pontifícia Universidade Católica de Minas Gerais
// Unidade São Gabriel
// Disciplina: Programação Orientada a Objetos
// *Object-Oriented Programming
// 
// Igor Octaviano
// More? access: https://github.com/igoroctaviano/
// 
#include "stdafx.h"
#include <time.h>
#include <vector>
#include "Shape.h"
#include "Rectangles.h"
#include "Square.h"
#include  "Circle.h"
#include <iostream>
int _tmain(int argc, _TCHAR* argv[])
{
	std::vector<Shape *> vetFig;
	Rectangles *r;
	Square *s;
	Circle *c;

	srand(time(NULL));

	for(int i=0; i<10;++i){
		float x = (float)(rand()%10);
		float y = (float)(rand()%20);
		float a = x/y;
		float b = y/x;
		int type = rand()%3;

		switch(type){
			case 0: r = new Rectangles(a,b);
				std::cout<<r->myType().c_str()<<std::endl;				
				vetFig.push_back(r);
				break;
			case 1: s = new Square(a);
				std::cout<<s->myType().c_str()<<std::endl;
				vetFig.push_back(s);
				break;
			case 2: c = new Circle(b);
				std::cout<<c->myType().c_str()<<std::endl;
				vetFig.push_back(c);
				break;
			default: break;
		}
	}
	std::cout<<"Figuras criadas"<<std::endl;
	getchar();

	for(int i=0; i<10;++i){
		float area = vetFig[i]->area();
		std::cout<<vetFig[i]->myType().c_str()<<" - ";
		std::cout<<"Area: "<<area<<std::endl;
	}
	getchar();
	getchar();
	

}

