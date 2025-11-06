using System.Windows.Forms;

namespace Elevator_Project
{
    /// <summary>
    /// Emergency State - Elevator is in emergency mode, all operations halted
    /// </summary>
    public class EmergencyState : IElevatorState
    {
        private ElevatorStateMachine stateMachine;
        private Main_Form form;
        
        public EmergencyState(ElevatorStateMachine stateMachine, Main_Form form)
        {
            this.stateMachine = stateMachine;
            this.form = form;
        }
        
        public void PressFloorButton(int floorNumber)
        {
            MessageBox.Show("Emergency mode is active. Elevator operations are halted.", "Emergency Active", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        
        public void OpenDoors()
        {
            MessageBox.Show("Emergency mode is active. Elevator operations are halted.", "Emergency Active", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        
        public void CloseDoors()
        {
            MessageBox.Show("Emergency mode is active. Elevator operations are halted.", "Emergency Active", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        
        public void ActivateEmergency()
        {
            // Already in emergency state
            MessageBox.Show("Emergency mode is already active.", "Emergency Active", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        
        public void DeactivateEmergency()
        {
            DialogResult result = MessageBox.Show("Do you want to deactivate emergency mode?", 
                "Deactivate Emergency", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            
            if (result == DialogResult.Yes)
            {
                form.IsEmergencyActive = false;
                form.button_emergency.BackColor = System.Drawing.Color.Red;
                form.button_emergency.Text = "";
                form.button_emergency.Invalidate();
                
                // Transition back to Idle state
                stateMachine.ChangeState(stateMachine.IdleState);
                
                MessageBox.Show("Emergency mode deactivated.\nNormal operations resumed.", 
                    "Emergency Deactivated", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        
        public string GetStateName()
        {
            return "Emergency";
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

