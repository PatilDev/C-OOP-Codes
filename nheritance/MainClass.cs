using Inheritance;

public class MainClass
{
    public static void Main(string[] args)
    {
        Console.WriteLine("hello devendra ");

        /*Child child = new Child();
      Console.WriteLine("Single Inheritance");
        child.disA();              //indirect calling to P mehtod
        child.disB();*/

        //MultiLevelChild ml = new MultiLevelChild();
        //ml.disP();
        //ml.disA();
        //ml.disB();
        //Console.WriteLine("Multilevel Inheritance");

        Console.WriteLine("herarchical inheritance");
        Child1 child =new Child1();
        child.dis1();
        child.dis2();
        Console.WriteLine();
        Child2 child2 =new Child2();
        child2.dis1();
        child2.dis3();
        Console.WriteLine();
        Child3 child3 =new Child3();
        child3.dis1();
        child3.dis4();
        Console.WriteLine();
        

    

        
    }
}
