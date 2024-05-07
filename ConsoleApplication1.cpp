
// ConsoleApplication1.cpp : This file contains the 'main' function. Program execution begins and ends there.
//

#include <iostream>
#include <string>
//stuttura elemento ella lista
using namespace std;

struct nodo {
    int eta;
    string nome;
    string cognome;

	struct nodo* successivo;
};
int main()
{
	struct nodo* head = NULL;// abbiamo un puntatore a un elemento della lista, non ho elementi quindi punta a null
	//head in questo caso sta per andare a puntare a una nuova zona di memoria che conterrà le informazioni del primo nodo
    head = new nodo{ 12,"luca","bigoni",NULL };// TESTA PUNTA AL PIMO NODO
	head->successivo = new nodo{ 13,"marco","rossi",NULL };//IL SUCCESIVO DEL PRIMO NODO PUNTA AL SECONDO NODO
	head->successivo->successivo = new nodo{ 14,"gianni","verdi",NULL };
	head->successivo->successivo->successivo = new nodo{ 15,"mario","bianchi",NULL };

	//NON FARE!!!!!!!!
	/*while (head != NULL) {
		cout << head->nome << " " << head->cognome << " " << head->eta << endl;
		head = head->successivo;
	}*/
	//CORRETTO perchè alrimenti si perde il puntatore che fa riferimento al primo nodo
	//sempre tenere un puntatore alla testa della lista altrimenti non possiamo piu accedere alla lista
	struct nodo* temp = head;//tmp punta al primo nodo perchè head punta al primo nodo
	while (temp != NULL) {
		cout << temp->nome << " " << temp->cognome << " " << temp->eta << endl;
		temp = temp->successivo;
	}
}

// Run program: Ctrl + F5 or Debug > Start Without Debugging menu
// Debug program: F5 or Debug > Start Debugging menu

// Tips for Getting Started: 
//   1. Use the Solution Explorer window to add/manage files
//   2. Use the Team Explorer window to connect to source control
//   3. Use the Output window to see build output and other messages
//   4. Use the Error List window to view errors
//   5. Go to Project > Add New Item to create new code files, or Project > Add Existing Item to add existing code files to the project
//   6. In the future, to open this project again, go to File > Open > Project and select the .sln file
