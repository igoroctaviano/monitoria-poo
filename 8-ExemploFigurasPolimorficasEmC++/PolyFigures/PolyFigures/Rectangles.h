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








