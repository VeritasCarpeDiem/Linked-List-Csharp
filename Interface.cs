using System;
using System.Collections.Generic;
using System.Text;

namespace Linked_List_C_Sharp
{
    class Interface
    {
        

        //interface ISpeakable
        //{
        //    void Speak();
        //}


        //class Animal : ISpeakable
        //{
        //    public void Speak()
        //    {
        //        Console.WriteLine("animal noise");
        //    }
        //}

        //class Human : ISpeakable
        //{
        //    public void Speak()
        //    {
        //        Console.WriteLine("human noise");
        //    }
        //}

        //class Car : ISpeakable
        //{
        //    public void Speak()
        //    {
        //        Console.WriteLine("car noise");
        //    }
        //}

        //class B
        //{

        //}





        //class Test : B, ISpeakable, IEnumerable, IDisposable
        //{
        //    ISpeakable speakable;
        //    public Test(ISpeakable temp)
        //    {
        //        speakable = temp;
        //    }

        //    public void Dispose()
        //    {
        //        throw new NotImplementedException();
        //    }

        //    public IEnumerator GetEnumerator()
        //    {
        //        throw new NotImplementedException();
        //    }

        //    public void MakeNoise()
        //    {
        //        speakable.Speak();
        //    }

        //    public void Speak()
        //    {
        //        throw new NotImplementedException();
        //    }
        //}


        class Car : IComparable<Car>
        {

            public int year;

            public Car(int year)
            {

                this.year = year;
            }

            public int CompareTo(Car other)
            {
                if (other == null || this.year > other.year)
                {
                    return 1;
                }

                if (other.year == this.year)
                {
                    return 0;
                }

                return -1;

            }
        }

        static void Main(string[] args)
        {
            Car a = new Car(2017);
            Car b = new Car(2019);
            Car c = new Car(1991);
            Car d = new Car(1886);


            Car[] cars = new Car[] { a, b, c, d };


            foreach (var car in cars)
            {
                Console.WriteLine(car.year);
            }


            Console.WriteLine(new string('-', 100));
            Array.Sort(cars);

            foreach (var car in cars)
            {
                Console.WriteLine(car.year);
            }
        }
    }

    //Console.WriteLine(a.CompareTo(b));

    //new Test(new Car()).MakeNoise();

    ////new Animal().Speak();

    ////new Human().Speak();

    //ISpeakable[] speakables = new ISpeakable[] { new Animal(), new Human(), new Car() };

    //foreach (var speakable in speakables)
    //{
    //    speakable.Speak();
    //}

    //var test = new A();

    //foreach (var item in test)
    //{
    //    Console.WriteLine(item);
    //}


    //foreach (var item in "abc")
    //{
    //    Console.WriteLine(item);
    //}


    //string input = Console.ReadLine();

    //Console.WriteLine(input == new string(input.ToCharArray().Reverse().ToArray()));

    //var list = new LinkedList();

    ////  Console.WriteLine(list.Count);

    //list.AddLast("test");

    ////  Console.WriteLine(list.RemoveLast());

    //list.AddLast("apple");
    //list.AddLast("orange");
    //list.AddLast("banana");


    //foreach (var item in list.OrderByDescending( x => x.Length))
    //{
    //    Console.WriteLine(item);
    //}
}

