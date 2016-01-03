//
// Monitoria *Monitoring - Pontifícia Universidade Católica de Minas Gerais
// Unidade: São Gabriel
// Disciplina: Programação Orientada a Objetos
// *Discipline: Object-Oriented Programming
// Igor Octaviano
// https://github.com/igoroctaviano
//
// ConsoleCPPTest.cpp : Defines the entry point for the console application.

#include "stdafx.h"
#include <iostream>
#include <vector>
#include <conio.h>
#include <time.h>
#include <windows.h> // WinApi header
#include "Player.h"
#include "Item.h"
#define NUMITEMS 10

using namespace std; // std::cout, std::cin

void initItems(std::vector<Item* > *myItems){
		for(int i=0; i<(NUMITEMS); i++){
			int type = rand()%2;
			int x = rand()%70;
			int y = rand()%20;
			Item *auxItem;
			if(type%2){
				auxItem = new Item(x,y,10,'*',10,0);
				myItems->push_back(auxItem);
			}
			else{
			auxItem = new Item(x,y,-10,'*',12,0);
			myItems->push_back(auxItem);
			}
		}
}

void getInput(Player *p, std::vector<Item* > myItems){
	char movement;

	movement = _getch();
	if(movement=='x') exit(0);
	
	p->move(movement);

	for(int i=0;i<myItems.size();i++){
		if(p->checkPos((GameObject *)(myItems[i]))){
			p->eatItem((Item *)(myItems[i]));
			myItems[i]->setChar('\0');
			myItems[i]->value=0;
		}
	}
}


void printGUI(Player *p, std::vector<Item* > myItems){
		HANDLE hConsole = GetStdHandle(STD_OUTPUT_HANDLE);;
		int k = 15;
		COORD pos;
		pos.X = 0();
		pos.Y = 0();
		
		for(int i=0;i<myItems.size();i++){
			myItems[i]->Print();
		}
		p->Print();
		SetConsoleCursorPosition(hConsole, pos);
		SetConsoleTextAttribute(hConsole, k);	
		cout << "Pontos: "<<p->points<<"   ";

}
int main(){

	Player *LoneRanger = new Player(40,10);
	std::vector<Item *> objects;
	srand(time(NULL));

    initItems(&objects);
	

	while(1){
		getInput(LoneRanger, objects);
		printGUI(LoneRanger, objects);
	}
	getchar();
return 0;
}
