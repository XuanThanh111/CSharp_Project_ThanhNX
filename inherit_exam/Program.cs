using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inherit_exam
{
    class Program
    {
        static void Main(string[] args)
        {
            Plane myplane = new Plane();
            myplane.StartEngine("Contact");
            myplane.TakeOff();
            myplane.Land();
            myplane.StopEngine("Stoppppp");

            Console.WriteLine("----------------------------------------------");
            Car mycar = new Car();
            mycar.StartEngine("thasnh");
            mycar.Accelerate();
            mycar.Brake();
            mycar.StopEngine("Stopping car");
            mycar.Drive(); ; // ==> "Drive" Override need " Virtual"


            Vehicle vehi = new Vehicle();
            vehi.Drive();
            Console.ReadKey();
        }
    }
    class Vehicle
    {
        public void StartEngine(string noiseToMakeWhenStarting)
        {
            Console.WriteLine("Starting Engine: {0}", noiseToMakeWhenStarting);
        }
        public void StopEngine(string noiseToMakeStopping)
        {
            Console.WriteLine("Stopping Engine: {0}", noiseToMakeStopping);
        }
        public virtual void Drive()
        {     
            Console.WriteLine("Default implementation of the Drive method");
        }
    } 

    class Plane: Vehicle
    {
        public void TakeOff()
        {
            Console.WriteLine("Taking Off");
        }
        public void Land()
        {
            Console.WriteLine("Landing");
        }
    }
    class Car : Vehicle
    {
        public void Accelerate()
        {
            Console.WriteLine("Accelerating");
        }
        public void Brake()
        {
            Console.WriteLine("Braking");
        }
        public override void Drive()     //Override
        {
            Console.WriteLine("Motoring");
        }
        public interface Thanh
        {
        }

    }
}