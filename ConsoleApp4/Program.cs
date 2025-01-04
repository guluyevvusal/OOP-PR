using System;

//public abstract class Vehicle
//{
//    public abstract void Drive(); // Reallaşdırılmamış metod
//}

//public class Car : Vehicle
//{
//    public override void Drive()
//    {
//        Console.WriteLine("Car is driving.");
//    }
//}


// For example, in a banking system, a common abstract class is created for different card types (Visa, Mastercard) and the specific behavior of each card is defined in subclasses.




//******************************************************************************************





//Encapsulation 

//public class BankAccount
//{
//    private decimal balance;

//    public decimal GetBalance()
//    {
//        return balance;
//    }


//    public void Deposit(decimal amount)
//    {
//        if(amount>0)
//        {
//            balance += amount;
//        }
//    }
//}



//For example, a password can be stored in a memory, but it is not possible to retrieve this password. Only authentication methods are used.



//************************************************************************************************




// Polymorphism 


// Method Overriding
//public class Animal
//{
//    public virtual void Speak() => Console.WriteLine("Animal speaks.");
//}

//public class Dog : Animal
//{
//    public override void Speak() => Console.WriteLine("Dog barks.");
//}


//For example, in an e-commerce system, the same methods work differently for different product types (e.g., tax calculation).


//************************************************************************************************



// Inheritance

//public class Person
//{
//    public string Name { get; set; }
//    public void Greet() => Console.WriteLine($"Hello, my name is {Name}.");
//}

//public class Student : Person
//{
//    public int StudentId { get; set; }
//}


//In a human resources system, an inheritance relationship can be implemented between an employee and a manager (the manager inherits the employee's characteristics).




//*******************************************************************************************





// Abstract Class

//public abstract class Shape
//{
//    public abstract double Area();
//    public void Display() => Console.WriteLine("This is a shape.");
//}

// Interface

//public interface IDrawable
//{
//    void Draw();
//}

// Usage

//public class Circle : Shape, IDrawable
//{
//    public double Radius { get; set; }
//    public override double Area() => Math.PI * Radius * Radius;
//    public void Draw() => Console.WriteLine("Drawing Circle.");
//}



//Abstract class: For a generic PaymentMethod in an e-commerce system.

//Interface: IPaymentGateway, where each payment provider has a different interface.