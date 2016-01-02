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