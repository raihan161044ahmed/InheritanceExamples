

using InheritanceExamples;
using InheritanceExamples.AnimalSimulator;

List<Animal> zoo = new List<Animal>();

Animal anAnimal = new Tiger();
zoo.Add(anAnimal);
zoo.Add(new Duck());
zoo.Add(new Elephant());
zoo.Add(new Parrot());
zoo.Add(new Duck());
zoo.Add(new Eagle());
zoo.Add(new HummingBird());

foreach (var animal in zoo)
{
    Console.WriteLine(animal.Speak());
}
    Console.ReadKey();

Animal animal1 = new Eagle();

Bird eagle = new Eagle();
eagle.Speak();

Calculator calc = new Calculator();

calc.Add(1, 2);






Console.WriteLine("Hello, World!");
