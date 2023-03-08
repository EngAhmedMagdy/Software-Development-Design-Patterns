using DesignPrinciples.CreationalDesignPatterns;

Singleton singleton = new Singleton();
var instance1 = singleton.getInstance();
var instance2 = singleton.getInstance();

if (instance1 == instance2)
{
    Console.WriteLine("same instance");
}
else
{
    Console.WriteLine("diff instance");
}