using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Xml.Linq;
namespace CSharpQuestionProject
{
    public interface IVehicle
    {
        string Location { get; }
        int NumberOfSeats { get; }
        void MoveTo(string city);
    }
    public class Car : IVehicle
    {
        public int NumberOfSeats { get; set; } = 5;
        public string Location { get; set; }
        public void MoveTo(string city = "Boston") => Location = city;
    }
    //----------DO NOT MODIFY CODE ABOVE THIS ROW, IT WILL ANYWAY BE RESET BEFORE EXECUTION----------

    //----------DO NOT MODIFY CODE BELOW THIS ROW, IT WILL ANYWAY BE RESET BEFORE EXECUTION----------
}

