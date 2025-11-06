using System;

namespace Elevator_Project
{
    /// <summary>
    /// State Machine for managing elevator states using State Design Pattern
    /// This class maintains the current state and delegates operations to it
    /// </summary>
    public class ElevatorStateMachine
    {
        private IElevatorState currentState;
        private Main_Form form;
        
        // Singleton instances of states
        public readonly IElevatorState IdleState;
        public readonly IElevatorState MovingUpState;
        public readonly IElevatorState MovingDownState;
        public readonly IElevatorState DoorsOpeningState;
        public readonly IElevatorState DoorsClosingState;
        public readonly IElevatorState EmergencyState;
        
        public ElevatorStateMachine(Main_Form form)
        {
            this.form = form;
            
            // Initialize all states
            IdleState = new IdleState(this, form);
            MovingUpState = new MovingUpState(this, form);
            MovingDownState = new MovingDownState(this, form);
            DoorsOpeningState = new DoorsOpeningState(this, form);
            DoorsClosingState = new DoorsClosingState(this, form);
            EmergencyState = new EmergencyState(this, form);
            
            // Set initial state to Idle
            currentState = IdleState;
        }
        
        /// <summary>
        /// Change the current state of the elevator
        /// </summary>
        public void ChangeState(IElevatorState newState)
        {
            currentState = newState;
        }
        
        /// <summary>
        /// Get current state
        /// </summary>
        public IElevatorState GetCurrentState()
        {
            return currentState;
        }
        
        /// <summary>
        /// Delegate button press to current state
        /// </summary>
        public void PressFloorButton(int floorNumber)
        {
            currentState.PressFloorButton(floorNumber);
        }
        
        /// <summary>
        /// Delegate open doors to current state
        /// </summary>
        public void OpenDoors()
        {
            currentState.OpenDoors();
        }
        
        /// <summary>
        /// Delegate close doors to current state
        /// </summary>
        public void CloseDoors()
        {
            currentState.CloseDoors();
        }
        
        /// <summary>
        /// Delegate emergency activation to current state
        /// </summary>
        public void ActivateEmergency()
        {
            currentState.ActivateEmergency();
        }
        
        /// <summary>
        /// Delegate emergency deactivation to current state
        /// </summary>
        public void DeactivateEmergency()
        {
            currentState.DeactivateEmergency();
        }
        
        /// <summary>
        /// Get current state name
        /// </summary>
        public string GetCurrentStateName()
        {
            return currentState.GetStateName();
        }
    }
}

