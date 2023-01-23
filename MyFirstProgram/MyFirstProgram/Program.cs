//Console.WriteLine("hey!");//output
//Console.WriteLine("i like pizza!");
//single-line comment
/*
    multi-line
    comment
*/
//Console.WriteLine("brocode");
//escape sequences
//// backslash
//\t tab
//\b backspace
//\n new line
//*/



////to create a variable: 1.decleration 2.initialization
//int x;//decleration
//x = 5;//initialization
//int y = 10;//combine 1 and 2
//int z = x + y;
//int age = 21; //whole integer
//double height = 300.5;//highly precise floating point number
//bool alive = true;//true or false values
//char symbol = '@';//a single character;
//string name = "bro";

//Console.WriteLine(x);
//Console.WriteLine(y);
//Console.WriteLine(z);
//Console.WriteLine("your age is " + age);//contatenation
//Console.WriteLine("your height is " + height + "cm");
//Console.WriteLine("are you alive?: " + alive);
//Console.WriteLine("hello " + name);

//string username = symbol + name;
//Console.WriteLine("your username is: " + username);



////constants are immutable values that are known at compile time and never change;
//const double pi = 3.14159;//adding security to the program
//Console.WriteLine(pi);



////typecasting is the ability to convert a value to a different data type as user input are strings
//double a = 3.14;
//int b = Convert.ToInt32(a);//convert it an important class whose module is toint32()
//Console.WriteLine(b.GetType());//get the type of the value

//int c = 123;
//double d = Convert.ToDouble(c) + 0.1;
//Console.WriteLine(d.GetType());

//int e = 321;
//string f = Convert.ToString(e);
//Console.WriteLine(f.GetType());

//string g = "$";
//char h = Convert.ToChar(g);
//Console.WriteLine(h.GetType());

//string i = "true";
//bool j = Convert.ToBoolean(i);
//Console.WriteLine(j.GetType());

//Console.WriteLine("what is your name?: ");
//string n = Console.ReadLine();//accept user input
//Console.WriteLine("what is your age?: ");
//int ag = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("hello " + n);
//Console.WriteLine("you are " + ag + " year/s old");


//int friends = 10;
////Addition
//friends = friends + 1;
//friends += 1;
//friends++;// Increment to add 1

////Subtraction
//friends = friends - 1;
//friends -= 1;
//friends--; //Decrement to subtract 1

////Multiplication
//friends = friends * 2;
//friends *= 2;

////Division
//friends = friends / 2;
//friends /= 2;

////Remainder
//int remainder = friends % 2;

//Console.WriteLine(remainder);

//double x = 3.99;
//double y = 5;

//double a = Math.Pow(x, 3); x Raised to the power of z
//double b = Math.Sqrt(x); Square root of x
//double c = Math.Abs(x); Convert to a positive number
//double d = Math.Round(x); Rounds a number to the nearest integer
//double e = Math.Ceiling(x); Always rounds up
//double f = Math.Floor(x); Always rounds down
//double g = Math.Max(x, y); Finds the maximum value between 2 values
//double h = Math.Min(x, y); Finds the lowest value between 2 values

//Console.WriteLine(h);


////Random numbers

//Random random = new Random();

//int num1 = random.Next(1, 7);
//int num2 = random.Next(1, 7);
//int num3 = random.Next(1, 7);
//double num = random.NextDouble();
//Console.WriteLine(num1);
//Console.WriteLine(num2);
//Console.WriteLine(num3);

////HYPOTENUSE PROGRAM

//Console.WriteLine("Enter side A: ");
//double a = Convert.ToDouble(Console.ReadLine());

//Console.WriteLine("Enter side B: ");
//double b = Convert.ToDouble(Console.ReadLine());

//double c = Math.Sqrt((a * a) + (b * b));
//Console.WriteLine("The hypotenuse is "+c);


////String Methods

//String fullName = "Bro Code";
//String phoneNumber = "123-456-7890";
//fullName = fullName.ToUpper();//Convert all characters in a string to uppercase
//fullName = fullName.ToLower();//Convert all characters in a string to lowercase
//Console.WriteLine(fullName);
//phoneNumber = phoneNumber.Replace("-","");//Replace a specific character in a string with another character
//Console.WriteLine(phoneNumber);
//String userName = fullName.Insert(0,"Mr.");//Insert any character/s at a specific index in a string without overwriting
//Console.WriteLine(userName);
//Console.WriteLine(fullName.Length);//Returns the length of a string NO PARENTHESES
//String firstName = fullName.Substring(0,3);//Selecting a specific length of characters from a starting index
//String lastName = fullName.Substring(4,4);
//Console.WriteLine(firstName);
//Console.WriteLine(lastName);

////CONDITIONAL STATEMENTS
////Conditional Operators
//// < Less than
//// > Greater than
//// == Equal to
//// != Not Equal to
//// >= Greater than and Equal to
//// <= Lesser than and Equal to

////Order of conditional statements does matter as code is read top to bottom

//Console.WriteLine("Please enter your age: ");
//int age = Convert.ToInt32(Console.ReadLine());
//if (age > 100)
//{
//    Console.WriteLine("You are too old to sign up!");
//}
//else if (age >= 18)
//{
//    Console.WriteLine("You are now signed up!");
//}
//else if (age < 0)
//{
//    Console.WriteLine("You haven't been born yet!");
//}
//else 
//{
//    Console.WriteLine("You need to be 18+ to sign up!");
//}
//Console.WriteLine("Please enter your name: ");
//String name = Console.ReadLine();

//if (name != "")
//{
//    Console.WriteLine("Hello " + name);
//}
//else{
//    Console.WriteLine("You did not enter your name!");
//}

////SWITCH STATEMENT more efficient comapred to conditional statements

//Console.WriteLine("What is it today?: ");
//String day = Console.ReadLine();

//switch(day) {
//    case "Monday":
//        //The specific case is compared to the value stored in the varaible passed as an arguement
//        Console.WriteLine("It's Monday");
//        break;
//    case "Tuesday":
//        Console.WriteLine("It's Tuesday");
//        break;
//    case "Wednesday":
//        Console.WriteLine("It's Wednesday");
//        break;
//    case "Thursday":
//        Console.WriteLine("It's Thursday");
//        break;
//    case "Friday":
//        Console.WriteLine("It's Friday");
//        break;
//    case "Saturday":
//        Console.WriteLine("It's Saturday");
//        break;
//    case "Sunday":
//        Console.WriteLine("It's Sunday");
//        break;
//    default:
//        //Executed only when all the other cases aren't
//        Console.WriteLine(day+" is not a day!");
//        break;
//}

////Logical Operator used to check if more than 1 condition is true/false
////  && (AND)
////  || (OR)

//Console.WriteLine("What is the temperature outside?: (C)");
//double temp = Convert.ToDouble(Console.ReadLine());

//if (temp >= 10 && temp <= 25)
//{
//    //BOTH CONDITIONS NEED TO EVALUATE TO TRUE
//    Console.WriteLine("It's warm outside.");
//}
//else if (temp <= -50 || temp >= 50)
//{
//    //ONLY 1 CONDITION NEEDS TO EVALUATE TO TRUE
//    Console.WriteLine("DO NOT GO OUTSIDE!");
//}


////WHILE LOOP repeats code while a condition reamins true

//Console.Write("Enter you name: ");
//String name = "";

//while (name == "") {
//    Console.Write("Enter you name: ");
//    name = Console.ReadLine();
//};
//Console.WriteLine("Hello " + name);



////FOR LOOP repeats code a finite amount of time

////  for(COUNTER, CONDITION, INCREMENT(i++) or DECREMENT(i--)
//for (int i = 1;i <= 10;i+=3) {
//    Console.WriteLine(i);
//}
//for (int i = 10; i > 0; i--) {
//    Console.WriteLine(i);
//}
//Console.WriteLine("HAPPY NEW YEAR!");

////NESTED LOOPS loops inside loops

//Console.Write("How many rows?: ");
//int rows = Convert.ToInt32(Console.ReadLine());
//Console.Write("How many columns?: ");
//int columns = Convert.ToInt32(Console.ReadLine());
//Console.Write("What symbol?: ");
//String symbol= Console.ReadLine();

//for (int i = 0; i < rows; i++) {
//    for (int j = 0; j < columns; j++) {
//        Console.Write(symbol);
//    }
//    Console.WriteLine();
//}

////GUESS RANDOM NUMBER

//Random random = new Random();

//bool playAgain = true;

//int min = 1;
//int max = 100;
//int guess;
//int number;
//int guesses;
//String response;

//while (playAgain) {
//    guess = 0;
//    guesses = 0;
//    response = "";
//    number = random.Next(min,max+1);
//    while (guess != number) {
//        Console.WriteLine("Guess a number between "+min+" - "+max+" : ");
//        guess = Convert.ToInt32(Console.ReadLine());
//        Console.WriteLine("Guess "+guess);

//        if (guess > number)
//        {
//            Console.WriteLine(guess + " is too high!");
//        }
//        else if (guess < number)
//        {
//            Console.WriteLine(guess + " is too low!");
//        }
//        guesses++;
//    }
//    Console.WriteLine("Number: " + number);
//    Console.WriteLine("YOU WIN!");
//    Console.WriteLine("Guesses: "+guesses);
//    Console.WriteLine("Would you like to play again (Y/N)?: ");
//    response = Console.ReadLine();
//    response = response.ToUpper();
//    if (response == "Y")
//    {
//        playAgain = true;
//    }
//    else {
//        playAgain = false;
//    }
//}
//Console.WriteLine("Thanks for playing...I guess");

////ROCK,PAPER SCISSORS

//Random random = new Random();
//bool playAgain = true;
//String player;
//String computer;
//String answer;

//while (playAgain)
//{
//    player = "";
//    computer = "";
//    answer = "";
//    while (player != "ROCK" && player != "PAPER" && player != "SCISSORS")
//    {
//        Console.Write("Enter ROCK, PAPER or SCISSORS: ");
//        player = Console.ReadLine();
//        player = player.ToUpper();
//        switch (random.Next(1, 4))
//        {
//            case 1:
//                computer = "ROCK";
//                break;
//            case 2:
//                computer = "PAPER";
//                break;
//            case 3:
//                computer = "SCISSORS";
//                break;
//        }
//        switch (player) {
//            case "ROCK":
//                if (computer == "ROCK")
//                {
//                    Console.WriteLine("It's a draw!");
//                }
//                else if (computer == "PAPER")
//                {
//                    Console.WriteLine("You lose!");
//                }
//                else {
//                    Console.WriteLine("You win!");
//                }
//                break;
//            case "PAPER":
//                if (computer == "ROCK")
//                {
//                    Console.WriteLine("You win!");
//                }
//                else if (computer == "PAPER")
//                {
//                    Console.WriteLine("It's a draw!");
//                }
//                else
//                {
//                    Console.WriteLine("You lose!");
//                }
//                break;
//            case "SCISSORS":
//                if (computer == "ROCK")
//                {
//                    Console.WriteLine("You lose!");
//                }
//                else if (computer == "PAPER")
//                {
//                    Console.WriteLine("You win!");
//                }
//                else
//                {
//                    Console.WriteLine("It's a draw!");
//                }
//                break;
//        }
//        Console.WriteLine("Would you like to play again?(Y/N): ");
//        answer = Console.ReadLine();
//        answer = answer.ToUpper();

//        if (answer == "Y")
//        {
//            playAgain = true;
//        }
//        else {
//            playAgain = false;
//        }
//    }
//    Console.WriteLine("Thanks for playing!");
//}

////CALCULATOR PROGRAM
//do
//{
//    double num1 = 0;
//    double num2 = 0;
//    double result = 0;

//    Console.WriteLine("---------------------------");
//    Console.WriteLine("Calculator Program");
//    Console.WriteLine("---------------------------");

//    Console.WriteLine("Enter number 1: ");
//    num1 = Convert.ToDouble(Console.ReadLine());

//    Console.WriteLine("Enter number 2: ");
//    num2 = Convert.ToDouble(Console.ReadLine());

//    Console.WriteLine("Enter an option: ");
//    Console.WriteLine("\t+ : Add");
//    Console.WriteLine("\t- : Subtract");
//    Console.WriteLine("\t* : Multiply");
//    Console.WriteLine("\t/ : Divide");
//    Console.Write("Enter an option: ");
//    switch (Console.ReadLine())
//    {
//        case "+":
//            result = num1 + num2;
//            Console.WriteLine($"Your result: {num1} + {num2} = " + result);
//            break;
//        case "-":
//            result = num1 - num2;
//            Console.WriteLine($"Your result: {num1} - {num2} = " + result);
//            break;
//        case "*":
//            result = num1 * num2;
//            Console.WriteLine($"Your result: {num1} * {num2} = " + result);
//            break;
//        case "/":
//            result = num1 / num2;
//            Console.WriteLine($"Your result: {num1} / {num2} = " + result);
//            break;
//        default:
//            Console.WriteLine("That was not a valid option!");
//            break;
//    }
//    Console.WriteLine("Would you like to continue?(Y/N): ");
//} while (Console.ReadLine().ToUpper() == "Y");
//Console.WriteLine("Bye!");

////ARRAYS a variable that can store multiple values

////String[] cars = { "BMW" ,"Mustang","Corvette"};

////Array initialized with a fixed size
//String[] cars = new string[3];

////To change a array value
//cars[0] = "Tesla";

////To access a arrays element be specific with the index otherwise the data type is displayed
//Console.WriteLine(cars[0]);
//Console.WriteLine(cars[1]);
//Console.WriteLine(cars[2]);

////Easiest way to display array values
//for (int i =0; i < cars.Length;i++) {
//    Console.WriteLine(cars[i]);
//}

////FOREACH LOOPS a simpler way to iterate over an array

//String[] cars = { "BMW", "Mustang", "Corvette" };

////Only iterating through an array in increments
//foreach (String car in cars) {
//    Console.WriteLine(car);
//}

////METHOD performs a section of code whenevver it's called "invoked" allowing us to reuse code multiple times

//String name = "Bro";
//int age = 21;

////Arguements are provided for methods to use
//singHappyBirthday(name,age);
//singHappyBirthday(name, age);
//singHappyBirthday(name, age);

////Parameters are what methods expect users to provide to be used
//static void singHappyBirthday(String birthdayBoy,int yearsOld) {
//    Console.WriteLine("Happy birthday to you!");
//    Console.WriteLine("Happy birthday to you!");
//    Console.WriteLine("Happy birthday dear "+ birthdayBoy + "!");
//    Console.WriteLine("You are "+ yearsOld + " years old!");
//    Console.WriteLine("Happy birthday to you!");
//    Console.WriteLine();
//}

////Return returns data back to the place the methods is invoked

//double x;
//double y;
//double result;

//Console.WriteLine("Enter in number 1: ");
//x = Convert.ToDouble(Console.ReadLine());

//Console.WriteLine("Enter in number 2: ");
//y = Convert.ToDouble(Console.ReadLine());

//result = Multiply(x, y);
//Console.WriteLine(result);

////void needs to be replaced in order for return to work and the data type returned needs to be specific
//static double Multiply(double x, double y)
//{
//    return x * y;
//}

////METHOD OVERLOADING
////methods can share the same name but have different paramters (data types or amount of paramters)
////their name and parameters create a unique signature
////methods must have a unique signature
//namespace MyFirstProgram
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            double total;
//            total = Multiply(2, 3, 4);
//            Console.WriteLine(total);
//        }
//        static double Multiply(double a, double b)
//        {
//            return a * b;
//        }
//        //Method overloading only works inside a class
//        static double Multiply(double a, double b, double c)
//        {
//            return a * b * c;
//        }
//    }
//}

////PARAMS KEYWORD a method parameter that takes a varaible number of arguement. The parameter type must be a single - dimensional array

//double total = CheckOut(3.99, 5.75, 15);
//Console.WriteLine(total);

////params should be used when you don't know how many values will be passed into the method
//static double CheckOut(params double[] prices) {
//    double total = 0;
//    foreach (double price in prices)
//    {
//        total += price;
//    }
//    return total;
//}

////EXCEPTIONS are errors produced during execution
//// try code that can produce an error
//// catch handles exception when they occur
//// finally always executes regardless if exception caught or not

//double x;
//double y;
//double result;

//try
//{
//    Console.WriteLine("Enter number 1: "); ;
//    x = Convert.ToInt32(Console.ReadLine());

//    Console.WriteLine("Enter number 2: "); ;
//    y = Convert.ToInt32(Console.ReadLine());

//    result = x / y;

//    Console.WriteLine("Result: " + result);
//}
//catch (FormatException e)
//{
//    Console.WriteLine("Enter only numbers!");
//}
//// DivideByZeroException cannot be used on any other data type except integers
//catch (DivideByZeroException e)
//{
//    Console.WriteLine("Cannot divide by zero!");
//}
//// using only Exception is considered bad practice
//catch (Exception e)
//{
//    Console.WriteLine("Something went wrong");
//}
//finally {
//    Console.WriteLine("Thanks for visting");
//}

//// CONDITIONAL OPERATORs are used in conditional assignment based on whether the condition is true/false

//// (condition) ? x:y

//double temperature = 20;
//String message;

// You can assign a value to a variable based on the condition or use a writeline statement because conditional operators returns a value

//message = (temperature >= 15) ? "it's warm outside!" : "It's cold outside!";
//Console.WriteLine(message);
//Console.WriteLine((temperature >= 15) ? "it's warm outside!" : "It's cold outside!");

////STRING INTERPOLATIONS allows us to insert variables into a sting
//// Precede a string literal with a $
//// {} are placeholders

//String firstName = "Bro";
//String lastName = "Code";
//int age = 21;

////Console.WriteLine("Hello "+ firstName+" "+lastName+".");
////Console.WriteLine("You are "+ age+" years old.");

//// inside the placeholder alongside the variable you can allocate a specific number of spaces (including the characters in the variable)
//// a positive integer of spaces allocates spaces to the right of the placeholder or a negative integer of spaces allocates spaces to the left of the placeholder
//Console.WriteLine($"Hello {firstName} {lastName}.");
//Console.WriteLine($"You are {age,10} years old.");

//// MULTI DIMENSIONAL ARRAY
//// an array of arrays

//// the comma allows for multi dimensional arrays
//String[,] parkingLot = { { "Mustang", "F-150", "Explorer" }, { "Corvette", "Camaro", "Silverdao" }, { "Corolla", "Camry", "Rav4" } };

//parkingLot[0, 2] = "Fusion";
//parkingLot[2, 0] = "Tacoma";
////foreach (String car in parkingLot) { Console.WriteLine(car); }
////
//// to create a grid of values use a nested for loop
////for (int i = 0; i < parkingLot.GetLength(0);i++) {
////    for (int j = 0; j < parkingLot.GetLength(1); j++) {
////        Console.Write(parkingLot[i,j]+" ");
////    }
////    Console.WriteLine();
////}

//// CLASS is a bundle of related code
//// this can be used as a blueprint to create objects (OOP)

//// 1. import namespace
//using MyFirstProgram;

//// 2.Access the class and then access any methods

//// if the class uses the static keyword an object cannot be created using it
//// if a method/attribute uses the static keyword an object cannot access it
//// the public keyword allows for anybody to access a specific method/attribute

//Messages.Hello();
//Messages.Waiting();
//Messages.Bye();


//// OBJECT is an instance of a class
//// A class can be used as a blueprint to create objects (OOP)
//// objects can have fields & methods (characteristics & actions)

//Human human1 = new Human();
//Human human2 = new Human();
//human1.name = "Rick";
//human1.age = 65;
//human1.Eat();
//human1.Sleep();
//human2.name = "Morty";
//human2.age = 16;
//human2.Eat();
//human2.Sleep();
//Console.Beep();//make console beep
//Console.ReadKey();//program doesn't end until a key press

//// DO NOT CREATE A NEW CLASS in MAIN CODE
//class Human
//{
//    //fields
//    public String name;
//    public int age;

//    //methods
//    public void Eat()
//    {
//        Console.WriteLine(name + " is eating");
//    }
//    public void Sleep()
//    {
//        Console.WriteLine(name + " is sleeping");
//    }
//}


//// CONSTRUCTOR a special method in a class
//// it has the same name as the class
//// can be used to assign arguements to fields when creating an object
//Car car1 = new Car("Ford","Mustang",2022,"red");
//Car car2 = new Car("Chevy", "Corvette", 2021, "blue");
//car1.Drive();
//car2.Drive();

//Console.Beep();//make console beep
//Console.ReadKey();//program doesn't end until a key press

//// DO NOT CREATE A NEW CLASS in MAIN CODE
//class Car {
//    String make;
//    String model;
//    int year;
//    String color;

//    public Car(String make, String model, int year, String color) {
//        // this. is used to refer to the variable inside of the class and a value is assigned to it from the arguement provided
//        this.make = make;
//        this.model = model;
//        this.year = year;
//        this.color = color;
//    }
//    public void Drive() {
//        Console.WriteLine("You drive the "+make+" "+model+".");
//    }
//}

//// STATIC modifier is used to declare a static member, which belongs to the class itself rather than to any specific object

//Car car1 = new Car("Mustang");
//Car car2 = new Car("Corvette");
//Car car3 = new Car("Lambo");

//// a static variable/method cannot be accessed via a object, but rather use the class name and access the static variable/method
//Console.WriteLine(Car.numberOfCars);
//Car.StartRace();
//Console.Beep();//make console beep
//Console.ReadKey();//program doesn't end until a key press

//// DO NOT CREATE A NEW CLASS in MAIN CODE
//class Car
//{
//    String model;
//    public static int numberOfCars;

//    public Car(String model)
//    {
//        // this. is used to refer to the variable inside of the class and a value is assigned to it from the arguement provided
//        this.model = model;
//        numberOfCars++;
//    }
//    public static void StartRace() {
//        Console.WriteLine("The race has begun!");
//    }
//}

// OVERLOADED CONSTRUCTORS techniques to create multiple constructors
// with a different set of parameters
// name + parameter = signature

//Pizza pizza = new Pizza("stuffed crust");
//Console.Beep();//make console beep
//Console.ReadKey();//program doesn't end until a key press

//class Pizza {
//    String bread;
//    String sauce;
//    String cheese;
//    String topping;

//    public Pizza(String bread, String sauce, String cheese, String topping) { 
//        this.bread = bread;
//        this.sauce = sauce;
//        this.cheese = cheese;
//        this.topping = topping;
//    }
//    public Pizza(String bread, String sauce, String cheese)
//    {
//        this.bread = bread;
//        this.sauce = sauce;
//        this.cheese = cheese;
//    }
//    public Pizza(String bread, String sauce)
//    {
//        this.bread = bread;
//        this.sauce = sauce;
//    }
//    public Pizza(String bread)
//    {
//        this.bread = bread;
//    }
//}

//// INHERITANCE 1 or more child classes recieving fields, methods, etc. from a common parent

//Car car = new Car();
//Bicycle bicycle = new Bicycle();
//Boat boat = new Boat();
//Console.WriteLine(car.speed);
//Console.WriteLine(car.wheels);
//car.go();
//Console.WriteLine(bicycle.speed);
//Console.WriteLine(bicycle.wheels);
//bicycle.go();
//Console.WriteLine(boat.speed);
//Console.WriteLine(boat.wheels);
//boat.go();

//Console.Beep();//make console beep
//Console.ReadKey();//program doesn't end until a key press
//class Vehicle { 
//    public int speed = 0;
//    public void go() {
//        Console.WriteLine("This vehicle is moving!");
//    }
//}
//class Car : Vehicle {
//    public int wheels = 4;
//}

//class Bicycle : Vehicle
//{
//    public int wheels = 2;
//}

//class Boat : Vehicle
//{
//    public int wheels = 0;
//}

//// ABSTRACT CLASSES is a modifier that indicated missing components or incomplete implementation

//Car car = new Car();
//Bicycle bicycle = new Bicycle();
//Boat boat = new Boat();
//Console.WriteLine(car.speed);
//Console.WriteLine(car.wheels);
//car.go();
//Console.WriteLine(bicycle.speed);
//Console.WriteLine(bicycle.wheels);
//bicycle.go();
//Console.WriteLine(boat.speed);
//Console.WriteLine(boat.wheels);
//boat.go();

//Console.Beep();//make console beep
//Console.ReadKey();//program doesn't end until a key press

////this class now cannot be used to instantiate a object
//abstract class Vehicle
//{
//    public int speed = 0;
//    public void go()
//    {
//        Console.WriteLine("This vehicle is moving!");
//    }
//}
//class Car : Vehicle
//{
//    public int wheels = 4;
//}

//class Bicycle : Vehicle
//{
//    public int wheels = 2;
//}

//class Boat : Vehicle
//{
//    public int wheels = 0;
//}

//// ARRAY OF OBJECTS

//// an array needs to have the same data type as the objects within it
////Car[] garage = new Car[3];

////Car car1 = new Car("Mustang");
////Car car2 = new Car("Corvette");
////Car car3 = new Car("Lambo");

////garage[0] = car1;
////garage[1] = car2;
////garage[2] = car3;

//// known as anonymous objects
//Car[] garage = {new Car("Mustang"),new Car("Corvette"),new Car("Lambo")};

//foreach (Car car in garage) {
//    Console.WriteLine(car.model);
//}

//Console.Beep();//make console beep
//Console.ReadKey();//program doesn't end until a key press

//class Car{
//    public String model;

//    public Car(string model)
//        {
//            this.model = model;
//        }
//}

//// PASSING AN OBJECT AS AN ARGUEMENT

//class Program {
//    public static void Main(String[] args) {
//        Car car1 = new Car("Mustang", "red");
//        Car car2 = Copy(car1);
//        Console.WriteLine(car2.color+" "+car2.model);
//        Console.Beep();//make console beep
//        Console.ReadKey();//program doesn't end until a key press

//    }
//    // You can only put the public modifier method after MAIN code
//    public static Car Copy(Car car) {
//        // To return new object use the new keyword
//        return new Car(car.model,car.color);
//    }
//    public static void changeColor(Car car,String color){
//        car.color = color;
//    }
//}
//class Car
//{
//    public String model;
//    public String color;

//    public Car(string model,String color)
//    {
//        this.model = model;
//        this.color = color;
//    }
//}

//// METHOD OVERRIDING provides a new version of a method inherited from a parent class
//// inherited method must be: abstract, virtual, or already overriden
//// Used with ToString(), polymorphism
//Dog dog = new Dog();
//Cat cat = new Cat();
//dog.speak();
//cat.speak();

//Console.Beep();//make console beep
//Console.ReadKey();//program doesn't end until a key press
//class Animal {

//    // A method to be overidden needs to use the virtual or abstract keyword
//    // abstract methods requires an abstract class aswell as an empty method with no body
//    // An abstract class cannot be used to create objects it must be inherited
//    // Non abstract methods within abstract classes can have a body
//    public virtual void speak() {
//        Console.WriteLine("The animal goes *brrr*"); ;
//    }
//}
//class Dog : Animal {
//    public override void speak() {
//        Console.WriteLine("The dog goes *woof*");
//    }
//}
//class Cat:Animal {
//    public override void speak()
//    {
//        Console.WriteLine("The cat goes *meow*");
//    }
//}

//// ToString() converts anj object to its string representation, so that it is suitable to display

//Car car = new Car("Chevy", "Corvette", 2022, "blue");

//// if the class have a overidden ToString() method it will automatically invoke it, if the object is called only by name
//// otherwise it will display the namespace and the object
//Console.WriteLine(car);

//Console.Beep();//make console beep
//Console.ReadKey();//program doesn't end until a key press
//class Car
//{
//    String make;
//    String model;
//    int year;
//    String color;

//    public Car(String make, String model, int year, String color)
//    {
//        // this. is used to refer to the variable inside of the class and a value is assigned to it from the arguement provided
//        this.make = make;
//        this.model = model;
//        this.year = year;
//        this.color = color;
//    }
//    // Overidden ToString() method
//    public override string ToString()
//    {
//        return "This is a " + make + " " + model;
//    }
//}

//// Polymorphism Greek work that means to "have many forms"
//// Objects can be identified by more than one type
//// E.g. A dog is also: Canine, Animal, Organism
//Car car = new Car();
//Bicycle bicycle = new Bicycle();
//Boat boat = new Boat();

//// To create an array of different data types use the parent class of all the data types as the data type
//Vehicle[] vehicles = { car, bicycle, boat };
//foreach (Vehicle vehicle in vehicles) {
//    vehicle.go();
//}

//Console.Beep();//make console beep
//Console.ReadKey();//program doesn't end until a key press

//class Vehicle
//{
//    public virtual void go() { }
//}
//class Car : Vehicle
//{
//    public override void go() {
//        Console.WriteLine("The car is moving!");
//    }
//}

//class Bicycle : Vehicle
//{    
//    public override void go()
//    {
//        Console.WriteLine("The bicycle is moving!");
//    }
//}

//class Boat : Vehicle
//{
//    public override void go()
//    {
//        Console.WriteLine("The boat is moving!");
//    }
//}

//// INFERFACE defines a "contract" that all the clases inheriting from should follow
//// An interface declare "what a class should have"
//// An inheriting classes defines "how it should do it"

//// Benefit = security + multiple inheritance + "plug and play"

//Rabbit rabbit = new Rabbit();
//rabbit.flee();
//Hawk hawk = new Hawk();
//hawk.hunt();
//Fish fish = new Fish();
//fish.hunt();
//fish.flee();

//Console.Beep();//make console beep
//Console.ReadKey();//program doesn't end until a key press
//interface Iprey {
//    void flee();
//}
//interface Ipredator {
//    void hunt();

//}
//class Rabbit:Iprey {
//    public void flee() {
//        Console.WriteLine("The rabbit runs away!");
//    }
//}
//class Hawk:Ipredator {
//    public void hunt() {
//        Console.WriteLine("The hawk is searching for food!");
//    }
//}
//class Fish:Iprey, Ipredator {
//    public void flee() {
//        Console.WriteLine("The fish swims away!");
//    }
//    public void hunt()
//    {
//        Console.WriteLine("The fish is searching for smaller fish");
//    }
//}

//// List is a data strucutre that represents a list of objects thjat can be accessed by index.
//// Similar to array, but can dynamically increase/decrease in size
//// using System.Collections.Generic

////String[] food = new string[3];
////food[0] = "pizza";
////food[1] = "hamburger";
////food[2] = "hotdog";

//List<String> food = new List<String>();
//food.Add("pizza");
//food.Add("hamburger");
//food.Add("hotdog");
//food.Add("fries");

////food.Remove("fries");
////food.Insert(0, "sushi");
////Console.WriteLine(food.Count);
////Console.WriteLine(food.IndexOf("pizza"));
////Console.WriteLine(food.LastIndexOf("fries"));
////Console.WriteLine(food.Contains("pizza"));
////food.Sort();
////food.Reverse();
////food.Clear();
////String[] foodArray = food.ToArray();

//foreach (String item in food) {
//    Console.WriteLine(item);
//}

//// LIST OF OBJECTS

//List<Player> players = new List<Player> ();
////Player player1 = new Player("Chad");
////Player player2 = new Player("Steve");
////Player player3 = new Player("Karen");
////players.Add (player1);
////players.Add(player2);
////players.Add(player3);
//players.Add(new Player("Chad"));
//players.Add(new Player("Steve"));
//players.Add(new Player("Karen"));

//foreach (Player player in players) {
//    Console.WriteLine(player);
//}

//Console.Beep();//make console beep
//Console.ReadKey();//program doesn't end until a key press

//class Player {
//    public String username;
//    public Player(String username)
//    {
//        this.username = username;
//    }
//    public override string ToString()
//    {
//        return username;
//    }
//}

// GETTERS & SETTERS add security to fields by encapsulation
// They're accessors found within properties

// properties = combine aspects of both fields and methdos (share name with a field)
// get accessor = used to return the property value
// get accessor  = used to assign a new value
// value keyword = defines the value being assigned by the set (parameter)

//Car car = new Car(400);
//car.Speed = 100000000;
//Console.WriteLine(car.Speed);

//class Car { public int speed;
//    public Car(int speed) {
//        Speed = speed;
//    }
//    public int Speed {
//        get { return speed; }// read
//        set {
//            // write
//            if (value > 500)
//            {
//                speed = 500;
//            }
//            else { 
//                speed = value;
//            } 
//        }
//    }
//}

// AUTO-IMPLEMENTED PROPERTIES they are sortcuts when no additional logic is required in the property
// you do not have to define a field for a property
// you only have to write get; and/or set; inside the property

//Car car = new Car("Porsche");
//Console.WriteLine(car.Model);

//Console.Beep();//make console beep
//Console.ReadKey();//program doesn't end until a key press

//class Car {
//    //String model;
//    //public String Model { get { return model; }set { model = value; } }
//    public String Model { get; set; }
//    public Car(string model) { this.Model = model; }
//}

//// ENUMS are a special "class" that contains a set of named integer constants.
//// Use enums when you have values that you know will not change,
//// To get the integer value from an item, you must explicitly convert to an int

//// name = integer

//class Program
//{ 
//    static void Main(string[] args) {
//        //Console.WriteLine(Planets.Mercury + " is a planet #"+(int)Planets.Mercury);
//        //Console.WriteLine(Planets.Pluto + " is a planet #" + (int)Planets.Pluto);

//        // To store an enum in a variable you need to use the .ToString() method
//        String name = PlanetRadius.Earth.ToString();
//        int radius = (int)PlanetRadius.Earth;
//        double volume = Volume(PlanetRadius.Earth);

//        Console.WriteLine("planet: " + name);
//        Console.WriteLine("radius: " + radius + "km");
//        Console.WriteLine("volume: "+volume + "km^3");

//        Console.Beep();//make console beep
//        Console.ReadKey();//program doesn't end until a key press
//    }
//    public static double Volume(PlanetRadius radius)
//    {
//        double volume = (4.0 / 3.0) * Math.PI * Math.Pow((int)radius, 3);
//        return volume;
//    }
//    // If no values are assigned then zero is the integer value of the first element

//}
//enum Planets
//{
//    Mercury = 1, Venus = 2, Earth = 3, Mars = 4, Jupiter = 5, Saturn = 6, Uranus = 7, Neptune = 8, Pluto = 9
//}
//enum PlanetRadius
//{
//    Mercury = 2439, Venus = 6051, Earth = 6371, Mars = 3389, Jupiter = 69911, Saturn = 58232, Uranus = 25362, Neptune = 24622, Pluto = 1188
//}

//// GENERIC is not specific  to a particular data type
//// add <T> to classes, methods, fields, etc.
//// allows for code reusability for different data types

//class Program {
//    static void Main(string[] args)
//    {
//        int[] intArray = { 1, 2, 3 };
//        double[] doubleArray = { 1.0, 2.0, 3.0 };
//        String[] stringArray = { "1", "2", "3" };
//        displayElements(intArray);
//        displayElements(doubleArray);
//        displayElements(stringArray);

//        Console.Beep();//make console beep
//        Console.ReadKey();//program doesn't end until a key press
//    }
//    // The character/s in the angled brackets need to be used in the parameters and as the data type used inside the method
//    public static void displayElements<Thing>(Thing[] array)
//    {
//        foreach (Thing item in array)
//        {
//            Console.Write(item + " ");
//        }
//        Console.WriteLine();
//    }
//}

//// THREAD is an execution path of a program
//// We can use mutlipel threads to perform,
//// different tasks of our program at the same time.
//// Current thread running is "main" thread
//// using System.Threading

//Thread mainThread = Thread.CurrentThread;
//mainThread.Name = "Main Thread";
////Console.WriteLine(mainThread.Name);

//// For methods without parameters
////Thread thread1 = new Thread(CountDown);
////Thread thread2 = new Thread(CountUp);

//// For methods with paramters
//Thread thread1 = new Thread(() => CountDown("1"));
//Thread thread2 = new Thread(() => CountUp("2"));

//thread1.Start();
//thread2.Start();

//Console.WriteLine(mainThread.Name +" is complete");

//Console.Beep();//make console beep
//Console.ReadKey();//program doesn't end until a key press

//static void CountDown(String name) {

//    for (int i = 10; i >= 0; i--) {
//        Console.WriteLine("Timer #1 : "+i +" seconds");
//        Thread.Sleep(1000);
//    }
//    Console.WriteLine("Timer #1 is complete");
//}
//static void CountUp(String name)
//{

//    for (int i = 0; i <= 10; i++)
//    {
//        Console.WriteLine("Timer #2 : " + i + " seconds");
//        Thread.Sleep(1000);
//    }
//    Console.WriteLine("Timer #2 is complete");
//}

Console.Beep();//make console beep
Console.ReadKey();//program doesn't end until a key press