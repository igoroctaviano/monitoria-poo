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
class GameObject
{
private:
	int posX;
	int posY;
public:
	GameObject(int x, int y): posX(x), posY(y){};
	~GameObject(void);
	void setX(int pos){posX= pos;}
	void setY(int pos){posY = pos;}
	int getX(){return posX;}
	int getY(){return posY;}
	
	bool checkPos(GameObject *other){
		int tx =this->getX();
		int otx = other->getX();

		int ty =this->getY();
		int oty = other->getY();

		if( (this->getX() == other->getX()) 
			&& (this->getY() == other->getY()) )	
			return true;
		else return false;
	};
};

