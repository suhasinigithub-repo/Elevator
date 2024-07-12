using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elevator
{
    public class Elevator
    {
        public int _currentFloor = 1;
        public int _firstFloor = 1;
        public int _numberOfFloors = 5;
        public Queue<int> floorrequests = new Queue<int>();
        public string elevatorMovement = "Up";
        
        public Elevator(int numberOfFloors)
        {
            _numberOfFloors = numberOfFloors;
        }
        public void callElevator(int fromFloor)
        {
            if (fromFloor >= _firstFloor && fromFloor <= _numberOfFloors)
            {
                Console.WriteLine($"User called Elevator from floor: {fromFloor}");
                floorrequests.Enqueue(fromFloor);
            }
            else
            {
                Console.WriteLine($"Invalid request for floor: {fromFloor}");
            }
        }

        
        public void goToFloor(int toFloor)
        {            
            if (toFloor >= _firstFloor && toFloor <= _numberOfFloors)
            {
                Console.WriteLine($"User requested Elevator to go to floor: {toFloor}");
                floorrequests.Enqueue(toFloor);
            }
            else
            {
                Console.WriteLine($"Invalid request for floor: {toFloor}");
            }
        }

        public void startElevator()
        {
            while(floorrequests.Count > 0)
            {
                int toFloor = floorrequests.Dequeue();

                if(toFloor > _currentFloor) 
                {
                    Console.WriteLine($"Elevator is moving up to floor: {toFloor}");
                    elevatorMovement = "Up";
                }
                else if (toFloor < _currentFloor)
                {
                    Console.WriteLine($"Elevator is moving down to floor: {toFloor}");
                    elevatorMovement = "Down";
                }


                while (toFloor != _currentFloor)
                {
                    if (elevatorMovement == "Up")
                    {
                        _currentFloor++;

                    }
                    else if (elevatorMovement == "Down")
                    {
                        _currentFloor--;
                    }
                    
                    
                }

                Console.WriteLine($"Landed at floor: {_currentFloor}");

            }

        }

        public void elevatorStatus()
        {
            Console.WriteLine($"Elevator is at floor: {_currentFloor}");
        }

    }
}
