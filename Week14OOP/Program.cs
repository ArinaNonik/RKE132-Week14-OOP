﻿Console.WriteLine("Name your dog:");
string myDogName = Console.ReadLine();

Dog myDog = new Dog(myDogName);

Dog neighboursDog = new Dog("Good Boy");

Console.WriteLine($"My dogs name is {myDog.Name}.");
Console.WriteLine($"My neighbours dogs name is {neighboursDog.Name}.");

myDog.Rename("Bad Boy");

while (myDog.LevelOfHapiness != 5)
{
    myDog.Bark();
}

myDog.WagTail();



class Dog
{
    private string _name; //field
    private int _levelOfHapiness = 0;

    //constructor
    public Dog(string name)
    {
        _name = name;
        _levelOfHapiness = 0;
    }

    //getter
    public string Name
    {
        get { return _name; }

    }

    public int LevelOfHapiness
    {
        get { return _levelOfHapiness; }
    }

    public void Rename(string newName)
    {
        _name = newName;
        Console.WriteLine($"The dog has been renamed {newName}");
    }

    public void Bark()
    {
        Console.WriteLine("Woof woof!");
        _levelOfHapiness++;
    }

    public void WagTail()
    {
        Console.WriteLine("Wiggle wiggle!");
    }
}

