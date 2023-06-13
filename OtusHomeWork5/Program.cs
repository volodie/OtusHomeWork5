using System.Threading.Channels;
using OtusHomeWork5;

internal class Program
{
    private static void Main(string[] args)
    {
        IRobot robot = new Robot();
        robot.GetInfo();
        robot.GetComponents();
        robot.GetRobotType();

        Quadcopter quadcopter = new Quadcopter();
        ((IFlyingRobot)quadcopter).GetComponents();
        ((IChargeable)quadcopter).Charge();
        Console.WriteLine(((IChargeable)quadcopter).GetInfo()); 
    }
}