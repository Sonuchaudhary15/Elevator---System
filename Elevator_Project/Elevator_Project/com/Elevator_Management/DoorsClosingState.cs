using System.Windows.Forms;

namespace Elevator_Project
{
    /// <summary>
    /// Doors Closing State - Elevator doors are currently closing
    /// </summary>
    public class DoorsClosingState : IElevatorState
    {
        private ElevatorStateMachine stateMachine;
        private Main_Form form;
        
        public DoorsClosingState(ElevatorStateMachine stateMachine, Main_Form form)
        {
            this.stateMachine = stateMachine;
            this.form = form;
        }
        
        public void PressFloorButton(int floorNumber)
        {
            MessageBox.Show("Doors are closing. Please wait.", "Doors Closing", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        
        public void OpenDoors()
        {
            // Can transition to opening while closing
            stateMachine.ChangeState(stateMachine.DoorsOpeningState);
        }
        
        public void CloseDoors()
        {
            // Doors are already closing
            MessageBox.Show("Doors are already closing.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        
        public void ActivateEmergency()
        {
            stateMachine.ChangeState(stateMachine.EmergencyState);
            form.IsEmergencyActive = true;
            form.button_emergency.BackColor = System.Drawing.Color.DarkRed;
            form.button_emergency.Text = "";
            form.button_emergency.Invalidate();
            
            // Stop door timers
            form.floor1_door_open_close_timer.Stop();
            form.floor2_door_open_close_timer.Stop();
            
            MessageBox.Show("EMERGENCY MODE ACTIVATED!\n\nElevator operations have been halted.", 
                "EMERGENCY", MessageBoxButtons.OK, MessageBoxIcon.Stop);
        }
        
        public void DeactivateEmergency()
        {
            // No emergency to deactivate while closing
        }
        
        /// <summary>
        /// Called when doors finish closing
        /// </summary>
        public void OnDoorsClosed()
        {
            // Transition back to Idle state when doors are fully closed
            stateMachine.ChangeState(stateMachine.IdleState);
            form.button_floor_1.Enabled = true;
            form.button_floor_2.Enabled = true;
        }
        
        public string GetStateName()
        {
            return "Doors Closing";
        }
        
        public bool CanOpenDoors()
        {
            return true; // Can interrupt closing to start opening
        }
        
        public bool CanCloseDoors()
        {
            return false; // Already closing
        }
        
        public bool CanMoveToFloor(int floorNumber)
        {
            return false;
        }
    }
}

