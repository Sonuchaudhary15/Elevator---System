using System.Windows.Forms;

namespace Elevator_Project
{
    /// <summary>
    /// Doors Opening State - Elevator doors are currently opening
    /// </summary>
    public class DoorsOpeningState : IElevatorState
    {
        private ElevatorStateMachine stateMachine;
        private Main_Form form;
        
        public DoorsOpeningState(ElevatorStateMachine stateMachine, Main_Form form)
        {
            this.stateMachine = stateMachine;
            this.form = form;
        }
        
        public void PressFloorButton(int floorNumber)
        {
            MessageBox.Show("Doors are opening. Please wait.", "Doors Opening", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        
        public void OpenDoors()
        {
            // Doors are already opening
            MessageBox.Show("Doors are already opening.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        
        public void CloseDoors()
        {
            // Can transition to closing while opening
            stateMachine.ChangeState(stateMachine.DoorsClosingState);
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
            // No emergency to deactivate while opening
        }
        
        /// <summary>
        /// Called when doors finish opening
        /// </summary>
        public void OnDoorsOpened()
        {
            // Doors are now open - can transition to Idle (doors open) or wait for closing
            // For simplicity, we'll stay in opening state until doors start closing
        }
        
        public string GetStateName()
        {
            return "Doors Opening";
        }
        
        public bool CanOpenDoors()
        {
            return false; // Already opening
        }
        
        public bool CanCloseDoors()
        {
            return true; // Can interrupt opening to start closing
        }
        
        public bool CanMoveToFloor(int floorNumber)
        {
            return false;
        }
    }
}

