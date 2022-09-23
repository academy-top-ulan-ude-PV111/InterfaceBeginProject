namespace InterfaceBeginProject
{
    interface IA
    {
        void Method1();
    }

    interface IB
    {
        void Method2();
    }

    interface IC : IA, IB
    {

    }

    class D : IA, IB
    {
        public void Method1()
        {
            throw new NotImplementedException();
        }

        public void Method2()
        {
            throw new NotImplementedException();
        }
    }




    interface ISpeed
    {
        const int GoodSpeed = 60;
        static int MaxSpeed = 100;
        void Move(int s);

        void Stop()
        {
            Console.WriteLine("Стоп!");
        }
    }

    abstract class Car : ISpeed
    {
        abstract public void Move(int s);
        //public virtual void Move(int s)
        //{
        //    Console.WriteLine($"Едем {s} км");
        //}
    }

    class AmbulanceCar : Car
    {
        public override void Move(int s)
        {
            Console.WriteLine($"Едем {s} км с сиреной");
        }
    }

    //class Bycicle : ISpeed
    //{
    //    public void Move(int s)
    //    {
    //        Console.WriteLine($"Крутим педали {s} метров");
    //    }
    //}

    interface IPerson<T>
    {
        T Id { set; get; }
    }

    class User<T> : IPerson<T>
    {
        public T Id { set; get; }
    }


    internal class Program
    {
        static void Main(string[] args)
        {
            IPerson<int> user = new User<int>();

            //Bycicle bycicle = new();
            ////bycicle.Move(1000);
            //DateTime date = new DateTime();

            //Console.WriteLine(bycicle is ISpeed);

            ////Console.WriteLine(ISpeed.GoodSpeed);
            ////Console.WriteLine(ISpeed.MaxSpeed);

            //ISpeed speed = new Bycicle();
            //speed.Move(1000);
            //speed.Stop();

            AmbulanceCar ambulanceCar = new AmbulanceCar();
            //ambulanceCar.Move(5);

            ISpeed speed = new AmbulanceCar();
            speed.Move(5);
        }
    }
}