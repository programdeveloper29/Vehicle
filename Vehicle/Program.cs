using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace Vehicle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char ch;
            do {
                
            //object
            Car car = new Car();
            Train train = new Train();
            Lorry lorry = new Lorry();
            Console.Write("\n Enter the Vehicle type (car, train , lorry):");
            string input=Console.ReadLine();
            if (input.Equals("car")) Program.VehicleRange(car);
            else if (input.Equals("train")) Program.VehicleRange(train);
            else if (input.Equals("lorry")) Program.VehicleRange(lorry);
            else Console.WriteLine("\n You Enter Invaild value");
            Console.Write("\nDo you want another Type? (y/n): ");
             ch = Console.ReadKey().KeyChar;
            Console.WriteLine();

        } while (ch == 'y');

            // overload
            //Program.VehicleRange(car);
            //Program.VehicleRange(train);
            // Program.VehicleRange(lorry);
        }
        //overload
        //static void VehicleRange(Car car) {

        //    // write 
        //    Console.Write("\n Enter Car Capacity = ");
        //    string input = Console.ReadLine();
        //    if(float.TryParse(input, out float value)) {car.Capacity = value;}
        //    else { Console.WriteLine("\n Invaild Value"); }
        //    Console.Write("\n Enter Car KiloPerLitre = ");
        //    string input2 = Console.ReadLine();
        //    if (float.TryParse(input2, out float value2)) { car.KiloPerLitre = value2; }
        //    else { Console.WriteLine("\n Invaild Value"); }
        //    //Read
        //    Console.WriteLine("\n Car Range = {0}", car.Range());
        //    Console.Write("\n Enter car Speed = ");
        //    string input3 = Console.ReadLine();
        //    if (float.TryParse(input3, out float value3)) { car.Speed = value3; }
        //    else { Console.WriteLine("\n Invaild Value"); }
        //    Console.WriteLine("\n Car Speed = {0}", car.Speed);
        //}
        //static void VehicleRange(Train train) {


        //    // write 
        //    Console.Write("\n Enter Train Capacity = ");
        //    string input = Console.ReadLine();
        //    if (float.TryParse(input, out float value)) { train.Capacity = value; }
        //    else { Console.WriteLine("\n Invaild Value"); }
        //    Console.Write("\n Enter Train KiloPerLitre = ");
        //    string input2 = Console.ReadLine();
        //    if (float.TryParse(input2, out float value2)) { train.KiloPerLitre = value2; }
        //    else { Console.WriteLine("\n Invaild Value"); }
        //    //Read
        //    Console.WriteLine("\n Train Range = {0}", train.Range());
        //    Console.Write("\n Enter Train Speed = ");
        //    string input3 = Console.ReadLine();
        //    if (float.TryParse(input3, out float value3)) { train.Speed = value3; }
        //    else { Console.WriteLine("\n Invaild Value"); }
        //    Console.WriteLine("\n Train Speed = {0}", train.Speed);

        //}
        //static void VehicleRange(Lorry lorry) {



        //    // write 
        //    Console.Write("\n Enter Lorry Capacity = ");
        //    string input = Console.ReadLine();
        //    if (float.TryParse(input, out float value)) { lorry.Capacity = value; }
        //    else { Console.WriteLine("\n Invaild Value"); }
        //    Console.Write("\n Enter Lorry KiloPerLitre = ");
        //    string input2 = Console.ReadLine();
        //    if (float.TryParse(input2, out float value2)) { lorry.KiloPerLitre = value2; }
        //    else { Console.WriteLine("\n Invaild Value"); }
        //    //Read
        //    Console.WriteLine("\n Lorry Range = {0}", lorry.Range());
        //    //Use Custom Member
        //    Console.Write("\n Goods Type: ");
        //    lorry.GoodsType=Console.ReadLine();
        //    Console.Write("\n Enter Lorry Speed = ");
        //    string input3 = Console.ReadLine();
        //    if (float.TryParse(input3, out float value3)) { lorry.Speed = value3; }
        //    else { Console.WriteLine("\n Invaild Value"); }
        //    Console.WriteLine("\n Lorry Speed = {0}", lorry.Speed);


        //}


        // Update OverLoad
        // ------------------------------
        // Overload for Car
        static void VehicleRange(Car car)
        {
            Console.WriteLine("\n--- Car ---");
            EnterCommonValues(car);
            Console.WriteLine($"Car Range = {car.Range()}");
            Console.WriteLine($"Car Speed = {car.Speed}");
        }

        // Overload for Train
        static void VehicleRange(Train train)
        {
            Console.WriteLine("\n--- Train ---");
            EnterCommonValues(train);
            Console.WriteLine($"Train Range = {train.Range()}");
            Console.WriteLine($"Train Speed = {train.Speed}");
        }

        // Overload for Lorry
        static void VehicleRange(Lorry lorry)
        {
            Console.WriteLine("\n--- Lorry ---");
            EnterCommonValues(lorry);

            // خاص باللوري
            Console.Write("Enter Goods Type: ");
            lorry.GoodsType = Console.ReadLine();

            Console.WriteLine($"Lorry Range = {lorry.Range()}");
            Console.WriteLine($"Lorry Speed = {lorry.Speed}");
        }

        // Method مشتركة لادخال القيم العامة
        static void EnterCommonValues(Vehicles vehicle)
        {
            Console.Write("Enter Capacity: ");
            string input = Console.ReadLine();
            if (float.TryParse(input, out float cap)) vehicle.Capacity = cap;
            else Console.WriteLine("Invalid value, setting 0");

            Console.Write("Enter KiloPerLitre: ");
            input = Console.ReadLine();
            if (float.TryParse(input, out float kpl)) vehicle.KiloPerLitre = kpl;
            else Console.WriteLine("Invalid value, setting 0");

            Console.Write("Enter Speed (0-300): ");
            input = Console.ReadLine();
            if (float.TryParse(input, out float spd)) vehicle.Speed = spd;
            else Console.WriteLine("Invalid value, setting 0");
        }
    }
}
// Base/parent
public class Vehicles
{// field
    private float _capacity;
    private float _kiloPerLitre;
    private float _speed;
    // proprties
    internal float Capacity { get { return _capacity; } set { _capacity = (value >= 0) ? value : 0; } }
    internal float KiloPerLitre { get { return _kiloPerLitre; }  set { _kiloPerLitre = (value >= 0) ? value : 0; } }
    internal virtual float Speed { get { return _speed; }set { _speed = (value >= 0 && value <= 300) ? value : 0; }  }

    //methods
    internal float Range() { return _capacity * _kiloPerLitre; }
}
//Inherants
//drived/child
public class Car:Vehicles
{

}
public class Train: Vehicles
{
    //override
    internal override float Speed { get => base.Speed +3; set => base.Speed = (value >= 0 && value <= 300) ? value : 0;}
}
//custom member : used in just one only child class
public class Lorry : Vehicles
{
    // field
    string _goodsType;
    //properties
    internal string GoodsType { get { return _goodsType; } set { _goodsType = value; } }
}