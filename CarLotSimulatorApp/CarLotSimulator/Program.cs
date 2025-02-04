﻿using System;
using System.Security.Cryptography.X509Certificates;

namespace CarLotSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO

            //Create a seperate class file called Car
            //Car shall have the following properties: Year, Make, Model, EngineNoise, HonkNoise, IsDriveable
            //Car shall have the following methods: MakeEngineNoise(), MakeHonkNoise()
            //The methods should take one string parameter: the respective noise property


            //Now that the Car class is created we can instanciate 3 new cars
            //Set the properties for each of the cars
            //Call each of the methods for each car

            //*************BONUS*************//

            // Set the properties utilizing the 3 different ways we learned about, one way for each car

            //*************BONUS X 2*************//

            //Create a CarLot class
            //It should have at least one property: a List of cars
            //Instanciate the a Carlot at the beginning of the program and as you create a car add the car to the list.
            //At the end iterate through the list printing each of car's Year, Make, and Model to the console
             
            Carlot lot = new Carlot();
            var bmw = new Car();
            lot.CarList.Add(bmw);
            bmw.Make = "BMW";
            bmw.Model = "M5";
            bmw.Year = 2020;
            bmw.IsDrivable = true;
            bmw.EngineNoise = "vroooom";
            bmw.HonkNoise = "beep beep";

            bmw.MakeEngineSound();
            bmw.MakeHonkSound();

            var clown = new Car() { Make = "Clown", Year = 1998, Model = "Tiny", IsDrivable = true, EngineNoise = "doodoo", HonkNoise = "laughing" };
            lot.CarList.Add(clown);
            clown.MakeEngineSound();
            clown.MakeHonkSound();

            var tesla = new Car() { Make = "Tesla", Year = 2020, Model = "3", IsDrivable = true, EngineNoise = "silent", HonkNoise = "quack" };
            lot.CarList.Add(tesla);
            tesla.MakeEngineSound();
            tesla.MakeHonkSound();
            Console.WriteLine($"Number of cars created : {Carlot.numberOfCars}");

            var Car1 = new Car() { Make = "Honda", Year = 2000, Model = "civic" };
            Console.WriteLine($"Number of cars created : {Carlot.numberOfCars}");

            var car2 = new Car() { Make = "Toyota", Year = 2020, Model = "Camry" };
            Console.WriteLine($"Number of cars created : {Carlot.numberOfCars}");

            var car3 = new Car() { Make = "Tesla", Year = 2022, Model = "S" };
            Console.WriteLine($"Number of cars created : {Carlot.numberOfCars}");

            

            foreach (var car in lot.CarList)
            {
                Console.WriteLine($"Year:{car.Year} Make: {car.Make} Model:{car.Model}");

            }






        }
    }
}
