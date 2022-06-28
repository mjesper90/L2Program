using System; //We are using the "System" Library in this file to reach the "Console".

//To avoid name conflicts and encapsulate logical components we create or extend the Lesson_0 namespace
//If two "Class"-es is defined with the name "Car" but has nothing to do with each other, we could seperate them by wrapping them in seperate namespaces
//But what is a "Class"? See below.
namespace Lesson_0
{
    /* Snippet from https://docs.microsoft.com/en-us/dotnet/csharp/fundamentals/types/classes
        A type that is defined as a class is a reference type. 
        At run time, when you declare a variable of a reference type, 
        the variable contains the value null until you explicitly create an instance of the class by 
        using the new operator, or assign it an object of a compatible type that may have been created elsewhere
    */
    //Notes about Classes;
    //The first step to understanding object oriented programming is learning about the concept of instantianting an Object from a Class.
    //A good mental picture could be; A cake-recipe (Class) can be followed to create multiple cakes (Objects)
    //As we are using Unity, another more related picture could be how one Class could become thousands of bullets, monsters or whatnot.
    public class Lesson_0
    {
        /* snippet from https://docs.microsoft.com/en-us/dotnet/csharp/fundamentals/program-structure/main-command-line
            The Main method is the entry point of a C# application. (Libraries and services do not require a Main method as an entry point.) 
            When the application is started, the Main method is the first method that is invoked.
        */
        static public void Main(String[] args)
        {
            //Printing to the console
            Console.WriteLine("Main Method");
            //Creating a HelloWorld object refernce
            HelloWorldClass hw;
            //Instantiating a class / Creating an object, by calling/invoking its constructor via the "new" keyword.
            hw = new HelloWorldClass("HelloWorld");
            //Changing the objects value
            hw.APublicStringField = "I've changed the variable inside the instantiated object";
            //Calling/Invoking the objects method
            hw.PrintObjectToConsoleMethod();
        }
    }
    

    public class HelloWorldClass
    {
        /* 
            A public class variable of the type; string. Set with a value of "Lorem ipsum bla bla".
            As this variable is part of a class description, it is also known as a "Field".
        */
        public string APublicStringField = "Lorem ipsum bla bla";
        
        /* snippet from https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/constructors
            Whenever a class is created, its constructor is called. 
            A class may have multiple constructors that takes different parameters/arguments. 
            Constructors enable the programmer to set default values, limit instantiation, and write code that is flexible and easy to read.
        */
        /*
            A constructor is a method whose name is the same as the name of its class/type. 
            Its method signature includes only an optional access modifier, the method name and its parameter list; it does not include a return type. 
        */
        public HelloWorldClass(string AStringParameterToPrint)
        {
            this.APublicStringField = ("This is the constructor " + AStringParameterToPrint + " " + this.APublicStringField);
            this.PrintObjectToConsoleMethod();
            this.AddTwoWholeNumbersTogetherAndPrint(2, 2);
        }

        /*
            A method is a code block that contains a series of statements. 
            A program causes the statements to be executed by calling the method and specifying any required method arguments. 
            In C#, every executed instruction is performed in the context of a method.
        */
        /*
            Methods are declared in a class, or interface by 
            specifying the access level such as public or private, 
            the return value, 
            the name of the method, 
            any method parameters (if there is any). 
            These parts together are the signature of the method.
        */
        public string PrintObjectToConsoleMethod(){
            Console.WriteLine(this.APublicStringField); //Print the class variable to console
            return this.APublicStringField; //Return the field, as method requires it to return a string.
        }

        public void AddTwoWholeNumbersTogetherAndPrint(int number1, int number2){
            int sum = number1+number2;
            Console.WriteLine(sum);
        }
    }
}