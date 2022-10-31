﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarLotSimulator
{
    public class Car
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public string EngineNoise { get; set; }
        public string HonkNoise { get; set; }
        public bool IsDrivable { get; set; }

        public  void MakeEngineSound()
        {
            Console.WriteLine($"{EngineNoise} {EngineNoise}");
        }
        public  void MakeHonkSound()
        {
            Console.WriteLine($"{HonkNoise} {HonkNoise}");
        }
    }
}
