namespace OOPAbstrakt_Interfeys
{
    /*    abstract class AbstractClassA
        {
            public abstract void OperationA();
        }
        abstract class AbstractClassB : AbstractClassA
        {
            public abstract void OperationB();
        }

        class ConcreteClass : AbstractClassB
        {
            public override void OperationA()
            {
                Console.WriteLine("ConkreteClass.OperationA");
            }

            public override void OperationB()
            {
                Console.WriteLine("ConkreteClass.OperationB");
            }
        }*/

    interface IGoEater
    {
        void Go();
        void Eat();
    }

    interface ISecurity : IGoEater
    {
        void Guard();
    }

    class Dog : IGoEater, ISecurity
    {
        public void Go()
        {
            Console.WriteLine("Dog step!");
        }
        public void Eat()
        {
            Console.WriteLine("Dog style eat");
        }
        public void Guard()
        {
            Console.WriteLine("Dog guard");
            Console.WriteLine();
            Console.WriteLine();

        }
    }
    class Cat : IGoEater
    {
        public void Go()
        {
            Console.WriteLine("Cat step!");
        }
        public void Eat()
        {
            Console.WriteLine("Cat style eat");
        }
    }



    class Program
    {
        static void Main()
        {

            ISecurity dog = new Dog();
            IGoEater cat = new Cat();

            /*        Dog dog = new Dog();
                    Cat cat = new Cat();*/

            dog.Go();
            dog.Eat();
            dog.Guard();

            cat.Go();
            cat.Eat();





            /*     ConcreteDerivedClass instance = new ConcreteDerivedClass();

                 instance.SimpleMethod();
                 instance.VirtualMethod();
                 instance.AbstractMethod();*/


            /*      AbstractClassB instance = new ConcreteClass();

                  // instance.Method();
                  instance.OperationA();
                  instance.OperationB();*/

            Console.ReadKey();
        }
    }
}

