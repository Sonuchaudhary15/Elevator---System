using System;
using System.Windows.Forms;

namespace Elevator_Project
{
    /// <summary>
    /// Idle State - Elevator is stationary with doors closed, ready for operations
    /// </summary>
    public class IdleState : IElevatorState
    {
        private ElevatorStateMachine stateMachine;
        private Main_Form form;
        
        public IdleState(ElevatorStateMachine stateMachine, Main_Form form)
        {
            this.stateMachine = stateMachine;
            this.form = form;
        }
        
        public void PressFloorButton(int floorNumber)
        {
            int currentFloor = form.GetCurrentFloorSafe();
            
            if (currentFloor == -1)
            {
                // No floor records exist - initialize to floor 1 as default
                form.InitializeElevatorToFloor(1);
                currentFloor = 1;
                
                MessageBox.Show("Elevator floor was not initialized. Set to Floor 1 by default.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
            if (floorNumber == currentFloor)
            {
                form.control_label.Text = $"Lift is already on Floor {floorNumber}";
                return;
            }
            
            // Disable buttons during movement
            form.button_floor_1.Enabled = false;
            form.button_floor_2.Enabled = false;
            
            if (floorNumber == 1 && currentFloor == 2)
            {
                // Move down to floor 1
                stateMachine.ChangeState(stateMachine.MovingDownState);
                form.move_elevatorBox_from_floor2_to_floor1.Start();
            }
            else if (floorNumber == 2 && currentFloor == 1)
            {
                // Move up to floor 2
                stateMachine.ChangeState(stateMachine.MovingUpState);
                form.move_elevatorBox_from_floor1_to_floor2.Start();
            }
        }
        
        public void OpenDoors()
        {
            int currentFloor = form.GetCurrentFloorSafe();
            
            if (currentFloor == -1)
            {
                // No floor records exist - initialize to floor 1 as default
                form.InitializeElevatorToFloor(1);
                currentFloor = 1;
            }
            
            if (currentFloor == 1)
            {
                stateMachine.ChangeState(stateMachine.DoorsOpeningState);
                form.floor1_door_open_close_timer.Start();
            }
            else if (currentFloor == 2)
            {
                stateMachine.ChangeState(stateMachine.DoorsOpeningState);
                form.floor2_door_open_close_timer.Start();
            }
            else
            {
                MessageBox.Show("Unable to determine current floor.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        
        public void CloseDoors()
        {
            // Doors are already closed in Idle state
            MessageBox.Show("Doors are already closed.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        
        public void ActivateEmergency()
        {
            stateMachine.ChangeState(stateMachine.EmergencyState);
            form.IsEmergencyActive = true;
            form.button_emergency.BackColor = System.Drawing.Color.DarkRed;
            form.button_emergency.Text = "";
            form.button_emergency.Invalidate();
            
            // Stop all movements
            form.move_elevatorBox_from_floor1_to_floor2.Stop();
            form.move_elevatorBox_from_floor2_to_floor1.Stop();
            
            MessageBox.Show("EMERGENCY MODE ACTIVATED!\n\nElevator operations have been halted.\nPlease contact building management for assistance.", 
                "EMERGENCY", MessageBoxButtons.OK, MessageBoxIcon.Stop);
        }
        
        public void DeactivateEmergency()
        {
            // No emergency to deactivate in Idle state
        }
        
        public string GetStateName()
        {
            return "Idle";
        }
        
        public bool CanOpenDoors()
        {
            return true;
        }
        
        public bool CanCloseDoors()
        {
            return false; // Doors are already closed
        }
        
        public bool CanMoveToFloor(int floorNumber)
        {
            return true;
        }
    }
}

