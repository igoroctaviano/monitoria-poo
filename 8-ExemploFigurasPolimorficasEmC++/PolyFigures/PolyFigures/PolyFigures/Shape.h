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

