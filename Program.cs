// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
using Elevator;

class Program
{
    static void Main(string[] args)
    {
        
        Elevator.Elevator ele = new Elevator.Elevator(5);
        ele.callElevator(3);
        ele.goToFloor(4);
        ele.callElevator(2);
        ele.goToFloor(5);

        ele.startElevator();

        ele.elevatorStatus();

    }
}
