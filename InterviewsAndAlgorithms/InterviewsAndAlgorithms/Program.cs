// See https://aka.ms/new-console-template for more information


using InterviewsAndAlgorithms.Adapter;
using InterviewsAndAlgorithms.Adapter.DataProccessor;
using InterviewsAndAlgorithms.Adapter.Network;
using InterviewsAndAlgorithms.Facade;
using InterviewsAndAlgorithms.Proxy;
using InterviewsAndAlgorithms.Singleton;

int[] tablica = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

// 1 Singleton Pattern 
//We want to create one object and use it everywhere

// 2 Facade Pattern
//Tworzymy jedną klasę fasadę która odpowiada za wszystkie zadania.
//We create one class of facade that is responsible for all tasks.

// 3 AdapterPattern

//Converts interface of class into another interface a class expects 

//4  Proxy Pattern

//The Proxy class implements the interface so that it can act as substitute for Subject objects
//The Client object works through a Proxy object that controls the access to a RealSubject object.
ISuperSecretDatabase database = new SuperSecretDatabaseProxy("textdb","Password");
database.DisplayDatabaseName();

INetworkClient network = new NetworkClient();
network.SendRequest("9.6.6.6");
IDataProccessor dataPro = new DataProcessor();
dataPro.SendNetworkRequest("8.8.7","1234");
// 3 AdapterPattern
NetworkAdapter adapter = new NetworkAdapter(dataPro);
adapter.SendRequest("8.8.7");

Singleton object1 = Singleton.GetInstance();
Singleton object2 = Singleton.GetInstance();


NetworkFacade networkFacade = new NetworkFacade("1.1.1.1.","UDP");

networkFacade.BuildNetworkLayer();
networkFacade.SendPAcketOverNetwork();