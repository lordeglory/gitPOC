// See https://aka.ms/new-console-template for more information
using githubPOC.A;
using githubPOC.B;

Console.WriteLine("Hello, World!");

// Create instances of Class1 from both namespaces
var aClass = new githubPOC.A.Class1();
var bClass = new githubPOC.B.Class1();

aClass.Method1();
bClass.Method1();
