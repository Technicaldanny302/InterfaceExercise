using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercise
{
    public class SUV : IVehicle, ICompany
    {
        public SUV()
        {
        }
        public double EngineSize { get; set; } = 2.5;
        public string Model { get; set; } = "Enclave";
        public string Make { get; set; } = "Buick";
        public int SeatCount { get; set; } = 5;
        public string CompanyName { get; set; } = "Buick";
        public string Motto { get; set; } = "Exceptional by design";
        public bool HasChangedGears { get; set; }

        public void Drive()
        {
            Console.WriteLine($"The {GetType().Name} now going forward . . .");
        }
        public void Reverse()
        {
            if (HasChangedGears == true)
            {
                Console.WriteLine($"The {GetType().Name} now reversing . . .");
                HasChangedGears = false;
            }
            else
            {
                Console.WriteLine("Cant reverse until we change gears");
            }

        }
        public void Park()
        {
            if (HasChangedGears == true)
            {
                Console.WriteLine($"The {GetType().Name} now in park . . .");
                HasChangedGears = false;
            }
            else
            {
                Console.WriteLine("Cant park until we change gears");
            }
        }
        public void ChangeGears(bool isChanged)
        {
            HasChangedGears = isChanged;
        }
    }
}
