using System;
namespace GlueLab.Classes{
    public abstract class Vehicle{
        public abstract int NumOfDoors {get; set;}
        public abstract string Speed {get; set;}
        public abstract void Drive();
    }
}