namespace OOPAbstrakt_Interface
{
    abstract class AbstractBaseClass
    {
        public void SimpleMethod()
        {
            Console.WriteLine("AbstractBaseClass.SimpleMethod");
        }

        virtual public void VirtualMethod()
        {
            Console.WriteLine("AbstractBaseClass.VirtualMethod");
        }

        abstract public void AbstractMethod();

    }
}
