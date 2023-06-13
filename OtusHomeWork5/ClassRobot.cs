using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtusHomeWork5
{
    interface IRobot
    {
        public void GetInfo()
        {   
            Console.WriteLine("I am a simple robot");
        }
        public void GetComponents()
        {
            Console.WriteLine("I am a simple robot");
        }
        public void GetRobotType()
        {
            Console.WriteLine("I am a simple robot");
        }
    }
    interface IChargeable
    {
        public void Charge();
        public string GetInfo();
    }
    interface IFlyingRobot : IRobot
    {
        public void GetRobotType()
        {
            Console.WriteLine("I am a flying robot");
        }
    }
    class Quadcopter : IFlyingRobot, IChargeable
    {
        List<string> _components = new List<string> { "rotor1", "rotor2", "rotor3", "rotor4" };

        void IRobot.GetComponents()
        {
            foreach (var item in _components)
            {
                Console.WriteLine(item);
            }
        }
        void IChargeable.Charge()
        {
            Console.WriteLine("Charging....");
            Thread.Sleep(3000);
            Console.WriteLine("Charged!");
        }
        string IChargeable.GetInfo()
        {
            string s = "Robot charging complete";
            return s;
        }
    }
    class Robot : IRobot
    { }
}
