
// part A : 
/*
 * -----------------(Part-A)----------------------
 * 1) files & folders explination
 *  - csproj :the project configuration files is the .csproj file, which contains information about the project like (Framework , dependencies , .NET version ..etc)
 *  - program.cs : this file constianing the main entry point of the application , where the program excution starts.
 *  - obj : this folder is used to store the intermediate files generated during the build process , such as compiled assemblies and temporary files.
 *  - bin : this folder is used to store the final excutable files or binaries (assemblies) , such as (.exe) , (dll)) 
 * 
 * 2) content csproj file
 *  - OutputType : Exe
 *  - TargetFramework : net10.0
 *  - ImplicitUsings : enable
 *  - Nullable : enable
 *  
 * 3) file scope namespace , why remove ? 
 *    - for more readability , and decrease not neccessary empty spaces
 *    
 *    namespace CSharpBasicsAssignment; 
 *       internal class program 
 *       {
 *         static void Main(string[] args)
 *         {
 *         }
 *       }
 * 4) .slnx vs .sln newer version
 *  - .slnx is a newer version from .sln 
 *  - advantages of .slnx : clean XML format this make more readable and easier to understand (human-readable) and much easier to resolve merge conflicts in git & github
 */



// ____________________________________________________________________________________________________________________________________________________
namespace CSharpBasicsAssignment;

struct Point
{
    public int x;
    public int y;
}
public class Order
{
    public int OrderId;
    public string CustomerName;
    public int Quantity;
    public decimal UnitPrice;
    public decimal TotalPrice;
    public bool IsPaid;
    public double DiscountPercent;
    public string ShippingCity;
    public char Priority;
    public long ItemCode;

    public void CalculateTotal()
    {
        decimal result = (decimal)(1 - (DiscountPercent / 100));
        TotalPrice = Quantity * UnitPrice * result;
    }
    public void PrintSummary()
    {
        Console.WriteLine($"[ Order : {OrderId} ] + [ Customer : {CustomerName} ] + [ Total-Price : {TotalPrice}] + [ Paid : {IsPaid} ]");

    }
}

internal class program
{
    static void Main(string[] args)
    {
        Console.WriteLine("TEST");
        RunPartB();
        RunPartC();
    }
    public static void RunPartB()
    {
        Console.WriteLine("=== PART B: Variables & Types ===");
        // integer numbers
        int age = 25;
        long people = 7800000000;
        short rate = 10000;
        byte levels = 255;
        // floating point numbers
        float price = 19.5f;
        double pi = 3.14159;
        decimal money = 100.5m;
        // boolean 
        bool isSuccessed = true;
        // character
        char gradeStudent = 'A';
        // string (text)
        string studentName = "Mohamed Assem";


        //precision test
        float operationFloat = 3.0f / 1.0f;
        double operationDouble = 3.0 / 1.0;
        decimal operationDecimal = 3.0m / 1.0m;
        Console.WriteLine("Output Test : " + operationFloat + " , " + operationDouble + " , " + operationDecimal);


        // scope 
        {
            int scopeVariable = 10;
        }

        // scopeVariable = 20; // we get an error here because the variable is out of scope and cannot be accessed outside of its bloack

    }



    //_________________________________________________________________________________________________________________________________________
    // Part C : 

    public static void RunPartC()
    {
        Console.WriteLine("=== PART C: Value vs. Reference Types ===");

        // value types example
        Point p1, p2;
        p1.x = 10;
        p1.y = 20;

        p2 = p1;

        p2.x = 5;
        Console.WriteLine("result of p1.x : " + p1.x);
        Console.WriteLine("result of p2.x : " + p2.x);

        // no change in p1.x because structs are value types , strored data in the stack memory



        // reference types exammple
        Order o1 = new Order();
        o1.OrderId = 101;
        o1.CustomerName = "Ali";
        o1.Quantity = 2;
        o1.UnitPrice = 50.0m;
        o1.IsPaid = false;
        o1.DiscountPercent = 10;
        o1.ShippingCity = "Cairo";
        o1.Priority = 'H';
        o1.ItemCode = 9876543210;

        o1.CalculateTotal();

        Order o2 = o1;
        o2.IsPaid = true;
        o2.ShippingCity = "Alexandria";

        Console.WriteLine($"Paid status for o1 : {o1.IsPaid} \n Paid status for o2 : {o2.IsPaid}");
        // has been changed because classes are reference types , stored data in the heap memory and both o1 & o2 are pointing to the same object in the heap memory

        object boxedOrder = o1;
        Order o3 = (Order)boxedOrder;

        if (object.ReferenceEquals(o1, o3))
        {
            Console.WriteLine("o1 and o3 are pointing the same location in memory");
        }
        else
        {
            Console.WriteLine("o1 and o3 are not pointing to the same location in memory");
        }

        o2.PrintSummary();


        Console.WriteLine(
            "- value types live on the stack , while reference types store data on the heap\n" +
            "- assignment operator (=) for value types copies the actual data , while for reference types it only copies the address\n" +
            "- storing a reference type in an object variable does not duplicate the object; it just stores a pointer to the existing Heap object\n"
            );
    }



    //_________________________________________________________________________________________________________________________________________
    // part D : 
   class PartD
    {
        // D1

       public int id // field variable 

         public static void StudentData()
         {
            string name = "Mohamed Assem";
             
            Console.WriteLine($"Student Data \n name : {name}  & id : {id}"); 
            
         }
          
         // in case we used to variable called (name) in above method , we get an error because the variable is out of scope
         
         public static void StudentGrade()
         {
            string grade = "A";
            Console.WriteLine("id : "+ id + " Grade : " + grade); 
         }
         static public void Loop()
         {
             for(int i = 0; i < 5; i++)
             {
                int outSide = i * 2;
                Console.WriteLine(outSide); 
             }
            //Console.WriteLine(outSide); 
            //>Program.cs(13,23): Error CS0103 : The name 'outSide' does not exist in the current context
        }


        // D2 
        public static void CompositeOperators()
        {
        
            int total = 100;

            total += 50;
            Console.WriteLine($"add +50 : {total}");

            total -= 30;
            Console.WriteLine($"sub -30 : {total}");

            total *= 2;
            Console.WriteLine($"multiply *2 : {total}");

            total /= 4;
            Console.WriteLine($"divide /4 : {total}");

            total %= 7;
            Console.WriteLine($"modulus %7 : {total}");

        }


        // D3 
        public static void BitwiseOperator()
        {
            int a = 12, b = 10;
            Console.WriteLine($"a & b: {a & b}");
            //and bitwise operator :  (a) 1100 & (b) 1010 = 1000 (binary result) -> 8 (decimal)

            Console.WriteLine($"a | b: {a | b}");
            //or bitwise operator :  (a) 1100 | (b) 1010 = 1110 (binary result) -> 14 (decimal)

            Console.WriteLine($"a ^ b: {a ^ b}");
            //xor bitwise operator :  (a) 1100 ^ (b) 1010 = 0110 (binary result) -> 6 (decimal)

            /*
              explanation of & vs &&
              (&) -> Bitwise AND operator : this operator works at the bit level
                -while-
              (&&) -> logical operator (&&) : used for comparison in condition 
             */

        }
        public static void RunPartD()
         {
            StudentData();
            StudentGrade();
            Loop() ;
            CompositeOperators();
         }
    }
}






