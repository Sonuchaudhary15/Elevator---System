using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Elevator_Project
{
    public partial class Main_Form : Form
    {
        public static Main_Form Self;

        public Main_Form()
        {
            InitializeComponent();
            Self = this;

            // Initialize State Machine (State Design Pattern)
            stateMachine = new ElevatorStateMachine(this);

            // Load images from Images folder
            LoadImagesFromFolder();

            // On Starting of the program Set elevator acording to the database
            SetElevator();
            // set the label with the current floor number
            control_label.Text = "Elevator Current Floor = " + db.GetCurrentFloor();             // Use of Abstraction

            // Enable inside elevator control panel buttons if doors are closed (doors start closed by default)
            // Buttons will be disabled during door operations and elevator movement
            button_floor_1.Enabled = IsElevatorDoorClosed;
            button_floor_2.Enabled = IsElevatorDoorClosed;

            // Make buttons circular
            MakeButtonCircular(button_floor_1);
            MakeButtonCircular(button_floor_2);
            MakeButtonCircular(button_open_door);
            MakeButtonCircular(button_close_door);
            MakeButtonCircular(button_emergency);
        }


        // *****************Class objects*********************
        Floors floor1 = new Floors(1, 337);                                  // Elevator moves using Timer
        Floors floor2 = new Floors(2, 0);
        Elevator elevator = new Elevator();
        Elevator_Database db = new Elevator_Database();
        ElevatorStateMachine stateMachine;  // State Design Pattern - State Machine

        // ****************Form Buttons **********************

        // button floor 1
        private void elevator_floor1_btn_up_Click(object sender, EventArgs e)
        {
            if (IsEmergencyActive)
            {
                MessageBox.Show("Emergency mode is active. Elevator operations are halted.", "Emergency Active", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            floor1.Open_Close_Gates();
            elevator.MoveToFloor(floor2);
        }

        // button floor 2
        private void elevator_floor2_btn_down_Click(object sender, EventArgs e)
        {
            if (IsEmergencyActive)
            {
                MessageBox.Show("Emergency mode is active. Elevator operations are halted.", "Emergency Active", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            floor2.Open_Close_Gates();
            elevator.MoveToFloor(floor1);
        }

        // button for displaying database log in to the dataview grid
        private void Display_db_Log_btn_Click(object sender, EventArgs e)
        {
            db.GetTablesData();    // Abstraction uses
            Display_db_Log_btn.Text = "Reload Elevator Logs";
        }

        // button for deleting selected log from database
        private void Delete_Log_btn_Click(object sender, EventArgs e)
        {
            if (database_grid_view.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a log entry to delete.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Get the selected row
            DataGridViewRow selectedRow = database_grid_view.SelectedRows[0];
            
            // Get the Date_Time and Floor_id from the selected row
            string dateTime = selectedRow.Cells["Column2"].Value?.ToString();
            int floorId = Convert.ToInt32(selectedRow.Cells["Column1"].Value);

            if (string.IsNullOrEmpty(dateTime))
            {
                MessageBox.Show("Unable to identify the selected log entry.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Confirm deletion
            DialogResult result = MessageBox.Show(
                $"Are you sure you want to delete the log entry for Floor {floorId} at {dateTime}?",
                "Confirm Deletion",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                // Delete from database
                bool deleted = db.DeleteLogEntry(floorId, dateTime);
                
                if (deleted)
                {
                    MessageBox.Show("Log entry deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    // Refresh the grid view
                    db.GetTablesData();
                }
                else
                {
                    MessageBox.Show("Failed to delete the log entry.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // button for deleting all logs from database
        private void Delete_All_Logs_btn_Click(object sender, EventArgs e)
        {
            // Confirm deletion with a warning
            DialogResult result = MessageBox.Show(
                "WARNING: This will delete ALL log entries from the database!\n\nAre you absolutely sure you want to continue?",
                "Confirm Delete All Logs",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                // Double confirmation for safety
                DialogResult secondConfirm = MessageBox.Show(
                    "This action cannot be undone!\n\nAre you sure you want to delete ALL logs?",
                    "Final Confirmation",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Stop);

                if (secondConfirm == DialogResult.Yes)
                {
                    // Delete all from database
                    int deletedCount = db.DeleteAllLogs();
                    
                    if (deletedCount >= 0)
                    {
                        // After deleting all logs, initialize the elevator to floor 1 to prevent button issues
                        // This ensures the system can continue operating after log deletion
                        int currentFloor = GetCurrentFloorSafe();
                        if (currentFloor == -1)
                        {
                            // No floor records exist, set default to floor 1
                            db.SetCurrentFloor(1);
                            control_label.Text = "Elevator Current Floor = 1";
                            
                            // Ensure elevator visual position matches floor 1
                            elevator_box_picturebox.Location = new System.Drawing.Point(0, floor1.GetFloorYLocation());
                            
                            // Ensure buttons are enabled if doors are closed
                            if (IsElevatorDoorClosed && !IsEmergencyActive)
                            {
                                button_floor_1.Enabled = true;
                                button_floor_2.Enabled = true;
                            }
                        }
                        
                        MessageBox.Show($"Successfully deleted {deletedCount} log entries.\nElevator initialized to Floor 1.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        // Refresh the grid view
                        db.GetTablesData();
                    }
                    else
                    {
                        MessageBox.Show("Failed to delete logs.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        // button 1 of the elevator control panel - Using State Design Pattern
        private void button_floor_1_Click(object sender, EventArgs e)
        {
            stateMachine.PressFloorButton(1);
        }
        
        // button 2 of the elevator control panel - Using State Design Pattern
        private void button_floor_2_Click(object sender, EventArgs e)
        {
            stateMachine.PressFloorButton(2);
        }

        // ************Variables*****************      // State Design Pattern
        // Made internal for State classes to access
        internal bool IsElevatorDoorClosed = true;
        internal bool IsEmergencyActive = false;


        // ************Timers*****************

        // Timer for Open and Close Gate of the Floor 1 - Using State Design Pattern
        private void floor1_door_open_close_timer_Tick(object sender, EventArgs e)
        {
            Buttons_On_Off("off");
            // Disable inside controller buttons during door operations
            button_floor_1.Enabled = false;
            button_floor_2.Enabled = false;
            int currentFloor = GetCurrentFloorSafe();
            if (picturebox_left_floor1_door.Width >= 0 && IsElevatorDoorClosed == true && currentFloor == 1)
            {
                // Transition to DoorsOpeningState if not already
                if (stateMachine.GetCurrentState() != stateMachine.DoorsOpeningState)
                {
                    stateMachine.ChangeState(stateMachine.DoorsOpeningState);
                }
                // Open Door
                picturebox_left_floor1_door.Width -= 5;
                picturebox_right_floor1_door.Width -= 5;
                picturebox_right_floor1_door.Left += 5;
                if (picturebox_left_floor1_door.Width <= 0) {
                    IsElevatorDoorClosed = false;
                    // Doors are now fully open - can stay in DoorsOpeningState or transition to Idle
                }
            }
            else if (picturebox_left_floor1_door.Width <= 141 && IsElevatorDoorClosed == false)
            {
                // Transition to DoorsClosingState if not already
                if (stateMachine.GetCurrentState() != stateMachine.DoorsClosingState)
                {
                    stateMachine.ChangeState(stateMachine.DoorsClosingState);
                }
                // Close door
                picturebox_left_floor1_door.Width += 5;
                picturebox_right_floor1_door.Width += 5;
                picturebox_right_floor1_door.Left -= 5;
                if (picturebox_left_floor1_door.Width >= 142)
                {
                    // Stop This timer
                    IsElevatorDoorClosed = true;
                    floor1_door_open_close_timer.Stop();
                    Buttons_On_Off("on");
                    // Transition to Idle state when doors are closed
                    stateMachine.ChangeState(stateMachine.IdleState);
                    //  enable elevator inside control panel buttons
                    button_floor_1.Enabled = true;
                    button_floor_2.Enabled = true;
                }
            }
        }

        // Timer for Open and Close Gate of the Floor 2 - Using State Design Pattern
        private void floor2_door_open_close_timer_Tick(object sender, EventArgs e)
        {
            Buttons_On_Off("off");
            // Disable inside controller buttons during door operations
            button_floor_1.Enabled = false;
            button_floor_2.Enabled = false;
            int currentFloor = GetCurrentFloorSafe();
            if (picturebox_left_floor2_door.Width >= 0 && IsElevatorDoorClosed == true && currentFloor == 2)
            {
                // Transition to DoorsOpeningState if not already
                if (stateMachine.GetCurrentState() != stateMachine.DoorsOpeningState)
                {
                    stateMachine.ChangeState(stateMachine.DoorsOpeningState);
                }
                // Open Door
                picturebox_left_floor2_door.Width -= 5;
                picturebox_right_floor2_door.Width -= 5;
                picturebox_right_floor2_door.Left += 5;
                if (picturebox_left_floor2_door.Width <= 0)
                {
                    IsElevatorDoorClosed = false;
                    // Doors are now fully open
                }
            }
            else if (picturebox_left_floor2_door.Width <= 141 && IsElevatorDoorClosed == false)
            {
                // Transition to DoorsClosingState if not already
                if (stateMachine.GetCurrentState() != stateMachine.DoorsClosingState)
                {
                    stateMachine.ChangeState(stateMachine.DoorsClosingState);
                }
                // Close door
                picturebox_left_floor2_door.Width += 5;
                picturebox_right_floor2_door.Width += 5;
                picturebox_right_floor2_door.Left -= 5;
                if (picturebox_left_floor2_door.Width >= 142)
                {
                    // Stop This timer
                    IsElevatorDoorClosed = true;
                    floor2_door_open_close_timer.Stop();
                    Buttons_On_Off("on");
                    // Transition to Idle state when doors are closed
                    stateMachine.ChangeState(stateMachine.IdleState);
                    //  enable elevator inside control panel buttons
                    button_floor_1.Enabled = true;
                    button_floor_2.Enabled = true;
                }
            }
        }

        // Timer for moving the elevator from floor 2 to floor 1 - Using State Design Pattern
        private void move_elevatorBox_from_floor2_to_floor1_Tick(object sender, EventArgs e)
        {
            Buttons_On_Off("off");
            // Disable inside controller buttons during movement
            button_floor_1.Enabled = false;
            button_floor_2.Enabled = false;
            control_label.Text = "Going to Floor 1";
            if (floor2_door_open_close_timer.Enabled == false)
            {
                elevator_box_picturebox.Top += 5;
                if (elevator_box_picturebox.Location.Y >= floor1.GetFloorYLocation()) {
                    move_elevatorBox_from_floor2_to_floor1.Stop();
                    // Transition to DoorsOpeningState when arriving at destination
                    stateMachine.ChangeState(stateMachine.DoorsOpeningState);
                    floor1.Open_Close_Gates();
                    db.SetCurrentFloor(1);
                    db.GetTablesData();
                    Buttons_On_Off("on");
                    Btn_ColorLabel_reset();
                    control_label.Text = "Elevator Current Floor = " + db.GetCurrentFloor();
                }
            }
        }

        // Timer for moving the elevator from floor 1 to floor 2 - Using State Design Pattern
        private void move_elevatorBox_from_floor1_to_floor2_Tick(object sender, EventArgs e)
        {
            Buttons_On_Off("off");
            // Disable inside controller buttons during movement
            button_floor_1.Enabled = false;
            button_floor_2.Enabled = false;
            control_label.Text = "Going to Floor 2";
            if (floor1_door_open_close_timer.Enabled == false)
            {
                elevator_box_picturebox.Top -= 5;
                if (elevator_box_picturebox.Location.Y <= floor2.GetFloorYLocation()){
                    move_elevatorBox_from_floor1_to_floor2.Stop();
                    // Transition to DoorsOpeningState when arriving at destination
                    stateMachine.ChangeState(stateMachine.DoorsOpeningState);
                    floor2.Open_Close_Gates();
                    db.SetCurrentFloor(2);
                    db.GetTablesData();
                    Buttons_On_Off("on");
                    Btn_ColorLabel_reset();
                    control_label.Text = "Elevator Current Floor = "+db.GetCurrentFloor();
                }
            }
        }

        // **************Functions***************

        // Helper function to safely get current floor as integer
        // Returns -1 if parsing fails (e.g., no database records)
        // Made internal for State classes to access
        internal int GetCurrentFloorSafe()
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

        // Helper function to initialize elevator to a specific floor
        // Made internal for State classes to access
        internal void InitializeElevatorToFloor(int floorNumber)
        {
            db.SetCurrentFloor(floorNumber);
            if (floorNumber == 1)
            {
                elevator_box_picturebox.Location = new System.Drawing.Point(0, floor1.GetFloorYLocation());
            }
            else if (floorNumber == 2)
            {
                elevator_box_picturebox.Location = new System.Drawing.Point(0, floor2.GetFloorYLocation());
            }
            control_label.Text = $"Elevator Current Floor = {floorNumber}";
        }

        // Function to load images from Images folder
        private void LoadImagesFromFolder()
        {
            try
            {
                // Get path to Images folder (in the project root)
                // Try relative path from bin\Debug or bin\Release first
                string imagesFolder = Path.Combine(Application.StartupPath, "..", "..", "Images");
                imagesFolder = Path.GetFullPath(imagesFolder);
                
                // If that doesn't exist, try direct path from executable location
                if (!Directory.Exists(imagesFolder))
                {
                    imagesFolder = Path.Combine(Application.StartupPath, "Images");
                    imagesFolder = Path.GetFullPath(imagesFolder);
                }

                // Load door.jpeg for all door pictureboxes
                string doorImagePath = Path.Combine(imagesFolder, "door.jpeg");
                if (File.Exists(doorImagePath))
                {
                    Image doorImage = Image.FromFile(doorImagePath);
                    picturebox_left_floor1_door.Image = doorImage;
                    picturebox_right_floor1_door.Image = doorImage;
                    picturebox_left_floor2_door.Image = doorImage;
                    picturebox_right_floor2_door.Image = doorImage;
                }

                // Load Elevator.jpeg for elevator box
                string elevatorImagePath = Path.Combine(imagesFolder, "Elevator.jpeg");
                if (File.Exists(elevatorImagePath))
                {
                    Image elevatorImage = Image.FromFile(elevatorImagePath);
                    elevator_box_picturebox.BackgroundImage = elevatorImage;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading images: " + ex.Message);
            }
        }

        // fuction to set the elevatorBox on program run.
        private void SetElevator() {
            int currentFloor = GetCurrentFloorSafe();
            if (currentFloor == 1)
            {
                elevator_box_picturebox.Location = new System.Drawing.Point(0, floor1.GetFloorYLocation());
            }
            else if (currentFloor == 2)
            {
                elevator_box_picturebox.Location = new System.Drawing.Point(0, floor2.GetFloorYLocation());
            }
            else
            {
                // by default add the elevator to floor 1 if no valid floor found
                elevator_box_picturebox.Location = new System.Drawing.Point(0, floor1.GetFloorYLocation());
                // and add to the db for other functions to work correctly
                db.SetCurrentFloor(1);
            }
        }

        // function which will desable or enable buttons of the form while elevator is moving or doors are closing or opening
        private void Buttons_On_Off(string btn) {
            if (btn == "on") {
                elevator_floor1_btn_up.Click += elevator_floor1_btn_up_Click;
                elevator_floor2_btn_down.Click += elevator_floor2_btn_down_Click;
            }
            else if (btn == "off")
            {
                elevator_floor1_btn_up.Click -= elevator_floor1_btn_up_Click;
                elevator_floor2_btn_down.Click -= elevator_floor2_btn_down_Click;
            }
        }

        // function to change the elevator weiting bg color to default and reset the labels
        private void Btn_ColorLabel_reset() {
            if (elevator_floor2_btn_down.BackColor == Color.Lime || elevator_floor1_btn_up.BackColor == Color.Lime) {
                elevator_floor2_btn_down.BackColor = Color.Transparent;
                elevator_floor1_btn_up.BackColor = Color.Transparent;
            }
        }

        // Open door button handler - Using State Design Pattern
        private void button_open_door_Click(object sender, EventArgs e)
        {
            stateMachine.OpenDoors();
        }

        // Close door button handler - Using State Design Pattern
        private void button_close_door_Click(object sender, EventArgs e)
        {
            stateMachine.CloseDoors();
        }

        // Emergency button handler - Using State Design Pattern
        private void button_emergency_Click(object sender, EventArgs e)
        {
            if (!IsEmergencyActive)
            {
                stateMachine.ActivateEmergency();
            }
            else
            {
                stateMachine.DeactivateEmergency();
            }
        }

        // Make button circular
        private void MakeButtonCircular(Button button)
        {
            // Create circular region
            System.Drawing.Drawing2D.GraphicsPath path = new System.Drawing.Drawing2D.GraphicsPath();
            path.AddEllipse(0, 0, button.Width, button.Height);
            button.Region = new Region(path);

            // Custom paint event for circular appearance
            button.Paint += (sender, e) =>
            {
                Button btn = sender as Button;
                if (btn != null)
                {
                    // Draw button background as circle if no background image
                    if (btn.BackgroundImage == null && btn.BackColor != Color.Transparent)
                    {
                        using (SolidBrush brush = new SolidBrush(btn.BackColor))
                        {
                            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
                            e.Graphics.FillEllipse(brush, 0, 0, btn.Width, btn.Height);
                            
                            // Draw border
                            using (Pen pen = new Pen(btn.FlatAppearance.BorderColor, 1))
                            {
                                e.Graphics.DrawEllipse(pen, 0, 0, btn.Width - 1, btn.Height - 1);
                            }
                        }
                    }

                    // Special handling for emergency button - add alert icon
                    if (btn == button_emergency)
                    {
                        DrawEmergencyIcon(e.Graphics, btn);
                    }

                    // Draw text if present (but not for emergency button if we're drawing icon)
                    if (!string.IsNullOrEmpty(btn.Text) && btn != button_emergency)
                    {
                        TextRenderer.DrawText(e.Graphics, btn.Text, btn.Font, btn.ClientRectangle, btn.ForeColor, 
                            TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter | TextFormatFlags.NoPadding);
                    }
                }
            };
        }

        // Draw alert icon on emergency button
        private void DrawEmergencyIcon(Graphics g, Button btn)
        {
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            g.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;

            // Draw exclamation mark icon
            using (Font iconFont = new Font("Arial", btn.Height * 0.4f, FontStyle.Bold))
            using (Brush textBrush = new SolidBrush(btn.ForeColor))
            {
                // Draw exclamation mark (⚠ or !)
                string alertIcon = "!";
                SizeF iconSize = g.MeasureString(alertIcon, iconFont);
                float x = (btn.Width - iconSize.Width) / 2;
                float y = (btn.Height - iconSize.Height) / 2;
                
                // Draw with shadow for visibility
                using (Brush shadowBrush = new SolidBrush(Color.FromArgb(100, Color.Black)))
                {
                    g.DrawString(alertIcon, iconFont, shadowBrush, x + 1, y + 1);
                }
                g.DrawString(alertIcon, iconFont, textBrush, x, y);
            }
        }

        private void Main_tableLayoutPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void picturebox_left_floor2_door_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
