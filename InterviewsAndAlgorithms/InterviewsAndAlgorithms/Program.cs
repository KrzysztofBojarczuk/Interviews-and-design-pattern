// See https://aka.ms/new-console-template for more information
using InterviewsAndAlgorithms.Delegates;




DelegateClass delegateClass = new DelegateClass();


Func<int, int,int> funcDelegate = delegateClass.Calc;

Console.WriteLine(funcDelegate(5,5));

Action actionDelgate = delegateClass.Show;

actionDelgate();

Predicate<int> predicateDelgate = delegateClass.GraterThenTen;

Console.WriteLine(predicateDelgate(15));