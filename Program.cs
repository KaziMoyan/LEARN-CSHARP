using System;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Principal;

class Person{
    public string name;
    public int age;

    // public Person(){

    //     name="test";
    //     age=15;
    //     Console.WriteLine("i am a default Constructor");
    // }
//    public Person(string n , int a){

//         name=n;
//         age=a;
//         Console.WriteLine("i am a default Constructor");
//     }

    public void SetValue(string n, int a){ 

        name =n;
        age = a;


    }

    public void Displayinfo(){
        Console.WriteLine($"Name:{name}, Age:{age}\n");
    }

}

class Test{

/*
    public static void Greeting(string text){
        Console.WriteLine(text);
    }
    public static void Add(int num1,int num2){
        Console.WriteLine("adding");
        int result = num1+num2;
        Console.WriteLine($"The sum of {num1}+ {num2} ={result}");
    }
    public static void Sub(int num1,int num2){
       Console.WriteLine("adding"); 
        int result = num1-num2;
        Console.WriteLine($"The sum of {num1}- {num2} ={result}");
       
    }
    public static int Square(int number){
      return number*number;
    }
    */
   public static void Main(string[] args){


    
    /*
    Console.Write("\"my name is Moyeen.\"\n");
    
   //Console.WriteLine("i am 25\t years old");

   // Declare the variables only once
   string? studentName;
   int studentAge;
   double cgpa;
   bool isRegistered;
   
   Console.WriteLine("Enter Your Name:");
   studentName = Console.ReadLine();
   Console.WriteLine("My Name is: " + studentName);

   Console.WriteLine("Enter Your Age:");
   studentAge = Convert.ToInt32(Console.ReadLine());

   Console.WriteLine("Enter Your CGPA:");
   cgpa = Convert.ToDouble(Console.ReadLine());

   Console.WriteLine("Have you already registered? (true/false):");
   isRegistered = Convert.ToBoolean(Console.ReadLine());

   Console.WriteLine("\n--- Student Information ---");
   Console.WriteLine("Name: " + studentName);
   Console.WriteLine("Age: " + studentAge);
   Console.WriteLine("CGPA: " + cgpa);
   Console.WriteLine("Is Registered: " + isRegistered);


int num1;
        int num2;
        int result;

        Console.WriteLine("Enter Num1:");
        num1 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter Num2:");
        num2 = Convert.ToInt32(Console.ReadLine());

        result = num1 + num2;
        Console.WriteLine("Addition: " + result);

        result = num1 - num2;
        Console.WriteLine($"Subtraction: {num1} - {num2} = {result}");

        result = num1 * num2;
        Console.WriteLine("Multiplication: " + result);

        double div = (double)num1 / num2;
        Console.WriteLine("Division: " + div.ToString());

        result = num1 % num2;
        Console.WriteLine("Remainder: " + result);

       
 int num1, num2, num3, sum;
        double avg;

        Console.Write("num1=");
        num1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("num2=");
        num2 = Convert.ToInt32(Console.ReadLine());

        Console.Write("num3=");
        num3 = Convert.ToInt32(Console.ReadLine());

        sum = num1 + num2 + num3;
        Console.WriteLine($"sum = {sum}");

        avg = (double)sum / 3;
        Console.WriteLine($"avg = {avg}");
    


    double baseL,height,triangleArea;


    Console.WriteLine("Triangle Are Calcultor");
    Console.WriteLine("Base=");
    baseL=Convert.ToDouble(Console.ReadLine());
      Console.WriteLine("Height=");
     height=Convert.ToDouble(Console.ReadLine());

     triangleArea= 0.5* baseL*height;

     Console.WriteLine($"Tiangle area ={triangleArea.ToString("F2")}");


 double radius,circleArea;


    Console.WriteLine("Circle Area Calcultor");
    Console.Write("Radius =");
    radius=Convert.ToDouble(Console.ReadLine());
      

    circleArea= 3.1416*radius*radius;

     Console.WriteLine($"Circle area ={circleArea.ToString("F2")}");


double fharenhite,celcius;



    Console.WriteLine("Fharenhite=");
    
    fharenhite=Convert.ToDouble(Console.ReadLine());
      

    celcius= (fharenhite-32)/1.8;

     Console.WriteLine($"celcius ={celcius.ToString("F2")}");


double fharenhite,celcius;



    Console.WriteLine("Celcius=");
    
    celcius=Convert.ToDouble(Console.ReadLine());
      

    fharenhite= (1.8*celcius)+32;

     Console.WriteLine($"fahrenhite={fharenhite.ToString("F2")}");





// assignment

int num1 = 30;
int num2 =40;


num1 +=5;
Console.WriteLine($"{num1}");

num1 -=5;
Console.WriteLine($"{num1}");

num1 *=5;
Console.WriteLine($"{num1}");
num1 /=5;
Console.WriteLine($"{num1}");

num1 %=5;
Console.WriteLine($"{num1}");




//RElational

int num1 = 0;
int num2 = 6;
int num3 = 8;

Console.WriteLine(num1>num2);
Console.WriteLine(num3>=num2);
Console.WriteLine(num2<=num3);
Console.WriteLine(num3!=num2);
Console.WriteLine(num3= =num2);



//Logical Operator


int num1 = 0;
int num2 = 6;
int num3 = 8;
 
Console.WriteLine(num1>num2 && num1<num3);
Console.WriteLine(9>6&& 6>3);
 Console.WriteLine(9>11|| 6>3);
Console.WriteLine(!(9>6&& 6>3));



//Bitwiase
int num1 = 3;
int num2 = 6;
int result;

result = num1&num2;
Console.WriteLine($"{num1}&{num2}={result}");

result = num1|num2;
Console.WriteLine($"{num1}|{num2}={result}");

result = num1^num2;
Console.WriteLine($"{num1}^{num2}={result}");

result = num1>> 1;
Console.WriteLine($"{num1}>> 2 ={result}");
result = num1<<2;
Console.WriteLine($"{num1}>> 2 ={result}");


//unary 


int num1 = 10;
Console.WriteLine(-num1);

Console.WriteLine(--num1);
Console.WriteLine(num1);
Console.WriteLine(num1++);



//Ternary
int numa= 11;
int numb=5;
int num1 = 10>8 ? 9 : 8;
Console.WriteLine(num1);

int large = numa > numb ? numa : numb;

Console.WriteLine(large);


int number = 1;
if(number>0){
    Console.WriteLine("Postitive Number ");
}else if(number==0){
Console.WriteLine("negative Number ");
}
else{
Console.WriteLine("Negative  Number ");

}


Console.WriteLine("Enter any number between 0 to 9:");

int digit =Convert.ToInt32( Console.ReadLine());

if(digit==0){
    Console.WriteLine("Zero");
}
else if(digit==1){
    Console.WriteLine("one");
}
else if(digit==2){
    Console.WriteLine("two");
}
else{
    Console.WriteLine("Not in from 0 to 9");
}


int number ;
Console.WriteLine("Enetr a number :");
number = Convert.ToInt32(Console.ReadLine());

if(number%2==0){
     Console.WriteLine("its an even number");
}
else if (number%2!=0){
     Console.WriteLine("its an odd number");
}


int number1,number2 ;
Console.WriteLine("Enetr a number :");
number1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enetr a number :");
number2 = Convert.ToInt32(Console.ReadLine());

if(number1>number2){
     Console.WriteLine($"{number1} is large number");

}
else if (number1<number2){
     Console.WriteLine($"{number2} is large number");

}else{
    Console.WriteLine(" Both Are Equal");
}



int num1,num2,num3;

Console.WriteLine("Number1 =");
num1 = Convert.ToInt32(Console.ReadLine());


Console.WriteLine("Number2=");
num2 = Convert.ToInt32(Console.ReadLine());


Console.WriteLine("Number3 =");
num3 = Convert.ToInt32(Console.ReadLine());

if(num2> num1&& num2 > num3){
    Console.WriteLine($"Largest Number :{num1}");
}else if(num2>num1 && num2> num1){
    Console.WriteLine($"Largest Number :{num2}");
}else if(num3>num1 && num3> num2){
    Console.WriteLine($"Largest Number :{num3}");
}else{
    Console.WriteLine($"All numbers are Equal");
}


// grade sheat 


double marks;
Console.Write("Enetr Your Marks:");
marks= Convert.ToDouble(Console.ReadLine());

if(marks>=0 && marks <=100){
    if(marks>=80){
 Console.WriteLine($"A+");
    }
     else if(marks>=70){
 Console.WriteLine($"A");
    }
     else if(marks>=60){
 Console.WriteLine($"B");
    }
     else if(marks>=33){
 Console.WriteLine($"C");
    }else{
      Console.WriteLine($"Fail");
    }



}else{
 Console.WriteLine($"{marks}Invalid marks");
}



//Leap year
int year ;
Console.Write("Enter Year :");
year = Convert.ToInt32(Console.ReadLine());

if(year%400 ==0 || year % 4 == 0 && year % 100 != 0){
    Console.Write($"{year} is a Leap Year");

}
else{
     Console.Write($"{year} is not a Leap Year");
}



char letter;
Console.Write("Enetr Your letter : ");
letter = Convert.ToChar(Console.ReadLine());

if(letter>= 'A' && letter <= 'Z'){

    Console.WriteLine($"{letter} is a capital letter");


}else{
    Console.WriteLine($"{letter} is a small letter");
}




char letter;
Console.Write("Enetr Your letter : ");
letter = Convert.ToChar(Console.ReadLine());

letter = char.ToLower(letter);

if(letter== 'a' || letter == 'e' || letter == 'i'|| letter == 'o'|| letter <= 'u'  ){

    Console.WriteLine($"{letter} is a Vowel");


}else{
    Console.WriteLine($"{letter} is  Consonant");
}


int digit;
Console.Write("Enter a digit:");

digit = Convert.ToInt32(Console.ReadLine());
switch(digit){
    case 0:
    Console.WriteLine("Zero");
    break;
    case 1:
    Console.WriteLine("one");
     break;
    case 2:
    Console.WriteLine("Two");
     break;
    case 3:
    Console.WriteLine("Three");
     break;
    default:
    Console.WriteLine("Not a digit ");
     break;
}


char input;
Console.Write("Enter a single character :");

input = Convert.ToChar(Console.ReadLine());
switch(Char.ToLower(input)){
    case 'a':
    case 'e':
    case 'i':
    case 'o':
    case 'u':
    Console.WriteLine($"{input} Is a Vowel");
    break;
    default:
    if(Char.IsLetter(input)){
        Console.WriteLine($"{input}is a Consonant");
    }else{
          Console.WriteLine($"{input}Not a valid Corecter");
    }
     break;
     
}



char input;
Console.Write("Enter a Day  :");

string day = (Console.ReadLine());
 switch(day.ToLower()){
    case"sunday":
    case"monday":
    case"tuesday":
    case"wednesday":
    case"Thursday":
    Console.WriteLine("weekday");
    break;
    case"friday":
    case"saturday":
    Console.WriteLine("weekend");
    break;
    default:
    Console.WriteLine("not a valid day ");
    break;
 }
   
  

   
int digit =1;

string message = digit switch
{
    1=>"one",
    2=>"Two",
    3=>"Three",

};
Console.WriteLine($"{message}");
Console.ReadKey();

// Console.Write("Enter a digit:");

// digit = Convert.ToInt32(Console.ReadLine());
// switch(digit){
//     case 0:
//     Console.WriteLine("Zero");
//     break;
//     case 1:
//     Console.WriteLine("one");
//      break;
//     case 2:
//     Console.WriteLine("Two");
//      break;
//     case 3:
//     Console.WriteLine("Three");
//      break;
  //  default:
  //  Console.WriteLine("Not a digit ");
   //  break;

  

Console.Write("Enter a your number : :");

 object number= (Console.ReadLine());
object result = number switch
{
    int => "Integer",
    double=>"Double",
    string=> "String",

};
Console.WriteLine($"{result}");
Console.ReadKey();


Console.WriteLine("Enetr a number 1 to 10");
int number= Convert.ToInt32(Console.ReadLine());
string result = number switch{
int num when num<1 || num>10 => "Number is out of range",
int num when num%2==0 =>"Even Number",
int num when num % 2 != 0=>"odd Number", 
 _=>"dd case "

};

Console.WriteLine($"{result}");
Console.ReadKey();




 Console.WriteLine("Temperature Converter Started");
        Console.WriteLine("Choose 1. Fahrenheit to Celsius");
        Console.WriteLine("Choose 2. Celsius to Fahrenheit");

        int choice = Convert.ToInt32(Console.ReadLine());

        switch(choice){
            case 1:
                Console.Write("Enter Fahrenheit temperature: ");
                double fahrenheit = Convert.ToDouble(Console.ReadLine());
                double celsius = (fahrenheit - 32) / 1.8;
                Console.WriteLine($"Temperature in Celsius: {celsius:F2}");
                break;
                
            case 2:
                Console.Write("Enter Celsius temperature: ");
                double cels = Convert.ToDouble(Console.ReadLine());
                double fahr = cels * 1.8 + 32;
                Console.WriteLine($"Temperature in Fahrenheit: {fahr:F2}");
                break;
                
            default:
                Console.WriteLine("Invalid Choice");
                break;
        }


        

         int number1,number2;
         char operation;
        Console.WriteLine("Enetr an Operation + - * / : ");
        operation= Convert.ToChar(Console.ReadLine());
        Console.WriteLine("Enetr Number1 : ");
        number1= Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enetr Number2 : ");
        number2= Convert.ToInt32(Console.ReadLine());

        switch(operation){
            case '+':
            Console.WriteLine($"{number1}+{number2}={number1 + number2}");
            break;
            case '-':
            Console.WriteLine($"{number1}-{number2}={number1 - number2}");
            break;
            case '*':
            Console.WriteLine($"{number1}*{number2}={number1 * number2}");
            break;
            case '/':
            if(number2!=0){
                Console.WriteLine($"{number1}/{number2}={number1/number2}");
            }else{
               Console.WriteLine("Can not divided by zero");
            }
            Console.WriteLine($"{number1}/{number2}={number1 / number2}");
            break;
            default:
            Console.WriteLine("Invalid Operastor");
            break;
        }

         

         for(int count =100;count>= 1;count--){
           Console.Write($"{count}: ");
         }

         Console.WriteLine(1);


int sum=0;
for (int i =1;i<=100;i++)

{if(i%2==0){
sum = sum+i;
}
}
Console.WriteLine($"Sum={sum}");


Console.Write("Enter a Number: ");
        int number = Convert.ToInt32(Console.ReadLine());
        int fact = 1;

        for (int i = number; i >= 1; i--) {
            fact = fact * i; // Multiply fact by i, not 1
        }

        Console.WriteLine($"Factorial({number}) = {fact}");



int i =2;
while (i<=10)
{
    Console.Write(i);
    i++;
}


int i =2;
do
{
    Console.Write(i);
    i++;
    
}while (i<=10);


for(int i=1;i<=100;i++){
    if(i==50){
        //break;
        continue;
    }
    Console.WriteLine(i);
}



for(int i= 1;i<=3; i++)
{
    for(int j=1;j<=5;j++){
        Console.WriteLine($"i={i},j={j}:Bd");
    }
}


int startnumber;
int endnumber;
Console.WriteLine("Eneter startnumber:");
startnumber = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Eneter emdnumber:");
endnumber = Convert.ToInt32(Console.ReadLine());

for(int i = startnumber;i<=endnumber;i++)
{
 for(int j =1; j<=10;j++)
 {
    Console.WriteLine($"{i} X {j}= { i * i}");
 }
}
Console.WriteLine("____________");
*/
/*
Greeting("welcome ");

int num1,num2,result;

Add(10,20);

num1=10;
num2=20;
Add(num1,num2);



num1=30;
num2=20;
Add(num1,num2);

num1=30;
num2=20;
Add(num1,num2);

Sub(40,30);

int resultp = Square(5);
Console.WriteLine($"Square of {resultp}");

Greeting("bye bye ");


while (true) {
    Console.WriteLine("Enter a number from 1 to 10 or write 'quit' to exit the app:");
    string input = Console.ReadLine()?.ToLower().Trim() ?? "";

    if (input == "quit") {
        Console.WriteLine("Thanks for using this app. Bye!");
        break;
    }

    if (!int.TryParse(input, out int number)) {
        Console.WriteLine("Invalid input. Please enter a valid number.");
        continue;
    }

    if (number < 1 || number > 10) {
        Console.WriteLine("Please enter a number between 1 and 10.");
        continue;
    }

    int square = number * number;
    Console.WriteLine($"Square of {number} = {square}");
}


Person p1 = new Person();
p1.name="Moyeen";
p1.age= 25;
Console.WriteLine("Person1");
Console.WriteLine($"Name:{p1.name}, Age:{p1.age}\n");

Person p2 = new Person();
p1.name="Sumu";
p1.age= 22;
Console.WriteLine("Person2");
Console.WriteLine($"Name:{p2.name}, Age:{p2.age}\n");


Person p1 = new Person("MOyeen",22);

p1.Displayinfo();

Person p2 = new Person();
p2.Displayinfo();


   int x= 30;
   int y = x;
   y =20;
   Console.WriteLine($"x={x},y={y}");
   Console.WriteLine(x);
   Console.WriteLine(y);
   */
 Person p1 = new Person();
        p1.name = "Mk";
        p1.age = 33;

        Console.WriteLine($"p1.name = {p1.name}, p1.age = {p1.age}");

        Person p2 = p1;
      }
   
}

   
   


      

   
