// See https://aka.ms/new-console-template for more information
using InterviewsAndAlgorithms.Delegates;
using InterviewsAndAlgorithms.ThreadNameSpace;





// thread = an execution path of a program
//          We can use multiple threads to perform,
//          different tasks of our program at the same time.
//          Current thread running is "main" thread
//          using System.Threading;

// wątek = ścieżka wykonania programu
// Możemy użyć wielu wątków do wykonania,
// różne zadania naszego programu w tym samym czasie.
// Bieżący wątek to „główny” wątek
// za pomocą System.Threading;

Thread mainThread = Thread.CurrentThread;

mainThread.Name = "Main Thread";


ThreadClass threadClass = new ThreadClass();


Thread thread1 = new Thread(() => threadClass.CountDown("Timer #1"));

Thread thread2 = new Thread(() => threadClass.CountUp("Timer #2"));
thread1.Start();

thread2.Start();

Console.WriteLine(mainThread.Name + " is complete!");


Console.ReadKey();
