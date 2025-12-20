using System;

namespace Task1
{
    public class Motorcycle : Vehicle
    {
        public bool HasSidecar { get; set; }

        public Motorcycle(string plate, double tankCap, double currentFuel, double consumption, bool hasSidecar)
            : base(plate, tankCap, currentFuel, consumption)
        {
            HasSidecar = hasSidecar;
        }

        public override string ToString()
        {
            return base.ToString() + $", Коляска: {(HasSidecar ? "Да" : "Нет")}";
        }
    }
}