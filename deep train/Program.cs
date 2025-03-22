using Hr.Entities;
using static deep_train.Program;

namespace deep_train
{

     class testclass
    {
        
       public static  void testmethod()
        {

            Console.WriteLine("sealed!");

        }
    }
    class testclass2 
    {

        public static void testmethod()
        {

            Console.WriteLine("sealed!");

        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            testclass.testmethod();
            testclass obj = new testclass();


            Notifier nn = new Notifier("test mail", 19, "con par 3", "con par 4");
            nn.Notify("f par 1", "f par 2", "f par 3");
            Console.WriteLine("Hello, World!");
        }
    }
}
