# OOP in c\#

## Class and Object

A class is a template for objects. An object is an instance of a class. We can have the Car class and an instance (example) of a Car is a BMW, Range rover, etc. Human is a class, and we can have, Dan, Peter, and Aunt May as humans. A class has attributes and methods. For a car, it may have some number of doors, color, some number of exhausts, etc. These are some of the attributes of a car. For the methods, which is about actions, a car can move, brake, blow horn, etc.

## Create a class and an object

```c#
class Car
{
    public string color = "red";
    public void PrintColor()
    {
        Console.WriteLine(color);
    }
}
```

This is a class called Car with one variable, also known as a field or attributes, color.

We can create an instance of this class by

```c#
Car car = new Car();
Console.WriteLine(car.color);
```

## Members

Fields and methods together are called the members of a class

## Constructor

A constructor is a special method that is used to initialize (create) an object.

```c#
class Car
{
    ...

    Car(string someColor)
    {
        color = someColor;
    }
}

// now we can do
Car car = new Car("Green");
```

## Access Modifierss

- public: opened to all others within and outside the class
- private: closed to all others outside the class but opened to, within
- protected: like private, but opened to outsider who have inherited it
- internal
- protected internal
- private protected

By default all members of a class are private

## Properties (get and set)

Encapsulation is concept that, sensitive information is hidden using the private access modifier. Properties provide get and set methods for fields.

```c#
class Boy
{
    private string name; // field


    public string Name // property that encapsulates 'name'
    {
        get { return name; }
        set { name = value; }
    }

    // private double height;
    public double Height { get; set; } // same as above but a short hand (automatic properties)
}
```

## Inheritance

Another class can have the members of another class by inheritance

## Sealed class

We can not inherit a sealed class

```c#
sealed class Haha {}

class Buha: Haha {} // will generate an error
```

## Polymorphism

```c#
class A {
    public void Method(){}
}

class B : A {}
// B b = new B(); b.Method();
// A b = new B(); b.Method();
// b will have the members in A

// b can have it own method
class C : A {
    public void Method(){}
}
// c.Method(); will call Method from C
// c will also have access to A's Method

// make A's Method virtual that of C override
// so that c.Method() will replace a.Method()
```

## Abstraction

This is the process of hiding concrete implementations. We have abtract class, of which we cannot create an instance of. We have to inherit the class and implement the methods if any. Abstarct methods exists in abstract classes and does not have a body. We have to override these methods.

```c#
abstract class Human{
    public abstract void Sing();
}

class Man: Human{
    public override void Sing() {
        Console.WriteLine("Hello, I am a singing human");
    }
}
```

## interfaces

Interfaces are just like abstract classes but with just method definitions and "Properties", not fields.

```c#
interface IEat
{
    public void Eat();
}

interface ISing
{
    public void Sing();
}

class Human: IEat, ISing
{
    public void Eat()
    {
        Console.WriteLine("I am eating");
    }

    public void Sing()
    {
        Console.WriteLine("I am eating");
    }
}

```
