using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elevator_Project
{
    class Elevator
    {
        // get object of the db class to get the current floor number
        Elevator_Database db = new Elevator_Database();
        
        // Helper function to safely get current floor as integer
        // Returns -1 if parsing fails (e.g., no database records)
        private int GetCurrentFloorSafe()
        {
            string floorStr = db.GetCurrentFloor();
            int floor;
            if (Int32.TryParse(floorStr, out floor))
            {
                return floor;
            }
            // If parsing fails, return -1 (invalid floor)
            return -1;
        }
        
        // method to run the timer of the elevator acording to the floor number of the floor object
        internal void MoveToFloor(Floors floor) {
            int currentFloor = GetCurrentFloorSafe();
            
            if (currentFloor == -1)
            {
                // Invalid floor - cannot move elevator
                return;
            }
            
            if (floor.GetFloorNumber() == 1 && currentFloor == 2)
            {
                Main_Form.Self.move_elevatorBox_from_floor2_to_floor1.Start();
            }
            else if (floor.GetFloorNumber() == 2 && currentFloor == 1) {
                Main_Form.Self.move_elevatorBox_from_floor1_to_floor2.Start();
            }
            else if (floor.GetFloorNumber() == 1 && currentFloor == 1)
            {
                Main_Form.Self.elevator_floor2_btn_down.BackColor = System.Drawing.Color.Lime;
                Main_Form.Self.move_elevatorBox_from_floor1_to_floor2.Start();
            }
            else if (floor.GetFloorNumber() == 2 && currentFloor == 2)
            {
                Main_Form.Self.elevator_floor1_btn_up.BackColor = System.Drawing.Color.Lime;
                Main_Form.Self.move_elevatorBox_from_floor2_to_floor1.Start();
            }
        }


    }
}
