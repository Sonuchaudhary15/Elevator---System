using System;

namespace Elevator_Project
{
    /// <summary>
    /// Interface for elevator states using State Design Pattern
    /// Each state defines how the elevator responds to different actions
    /// </summary>
    public interface IElevatorState
    {
        /// <summary>
        /// Handle button press for floor selection
        /// </summary>
        void PressFloorButton(int floorNumber);
        
        /// <summary>
        /// Handle opening doors request
        /// </summary>
        void OpenDoors();
        
        /// <summary>
        /// Handle closing doors request
        /// </summary>
        void CloseDoors();
        
        /// <summary>
        /// Handle emergency button press
        /// </summary>
        void ActivateEmergency();
        
        /// <summary>
        /// Handle deactivation of emergency
        /// </summary>
        void DeactivateEmergency();
        
        /// <summary>
        /// Get the current state name
        /// </summary>
        string GetStateName();
        
        /// <summary>
        /// Check if doors can be opened in this state
        /// </summary>
        bool CanOpenDoors();
        
        /// <summary>
        /// Check if doors can be closed in this state
        /// </summary>
        bool CanCloseDoors();
        
        /// <summary>
        /// Check if elevator can move to a floor in this state
        /// </summary>
        bool CanMoveToFloor(int floorNumber);
    }
}

