// See https://aka.ms/new-console-template for more information


using InterviewsAndAlgorithms.Facade;
using InterviewsAndAlgorithms.Singleton;

int[] tablica = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

//Singleton Pattern 
//We want to create one object and use it everywhere
//Facade Pattern
//Tworzymy jedną klasę fasadę która odpowiada za wszystkie zadania.
//We create one class of facade that is responsible for all tasks.

Singleton object1 = Singleton.GetInstance();
Singleton object2 = Singleton.GetInstance();


NetworkFacade networkFacade = new NetworkFacade("1.1.1.1.","UDP");

networkFacade.BuildNetworkLayer();
networkFacade.SendPAcketOverNetwork();