using System.Windows.Forms;

namespace Elevator_Project
{
    /// <summary>
    /// Moving Up State - Elevator is moving from floor 1 to floor 2
    /// </summary>
    public class MovingUpState : IElevatorState
    {
        private ElevatorStateMachine stateMachine;
        private Main_Form form;
        
        public MovingUpState(ElevatorStateMachine stateMachine, Main_Form form)
        {
            this.stateMachine = stateMachine;
            this.form = form;
        }
        
        public void PressFloorButton(int floorNumber)
        {
            MessageBox.Show("Elevator is moving. Please wait until it reaches the destination.", "Elevator Moving", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        
        public void OpenDoors()
        {
            MessageBox.Show("Cannot open doors while elevator is moving.", "Elevator Moving", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        
        public void CloseDoors()
        {
            MessageBox.Show("Cannot close doors while elevator is moving.", "Elevator Moving", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        
        public void ActivateEmergency()
        {
            stateMachine.ChangeState(stateMachine.EmergencyState);
            form.IsEmergencyActive = true;
            form.button_emergency.BackColor = System.Drawing.Color.DarkRed;
            form.button_emergency.Text = "";
            form.button_emergency.Invalidate();
            
            // Stop movement
            form.move_elevatorBox_from_floor1_to_floor2.Stop();
            
            MessageBox.Show("EMERGENCY MODE ACTIVATED!\n\nElevator operations have been halted.", 
                "EMERGENCY", MessageBoxButtons.OK, MessageBoxIcon.Stop);
        }
        
        public void DeactivateEmergency()
        {
            // No emergency to deactivate while moving
        }
        
        /// <summary>
        /// Called when elevator reaches destination floor
        /// </summary>
        public void OnArrival()
        {
            // Doors will open automatically when arriving
            stateMachine.ChangeState(stateMachine.DoorsOpeningState);
        }
        
        public string GetStateName()
        {
            return "Moving Up";
        }
        
        public bool CanOpenDoors()
        {
            return false;
        }
        
        public bool CanCloseDoors()
        {
            return false;
        }
        
        public bool CanMoveToFloor(int floorNumber)
        {
            return false;
        }
    }
}

