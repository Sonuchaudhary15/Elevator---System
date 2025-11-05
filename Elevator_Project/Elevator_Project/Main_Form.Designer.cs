namespace Elevator_Project
{
    partial class Main_Form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main_Form));
            this.floor1_door_open_close_timer = new System.Windows.Forms.Timer(this.components);
            this.floor2_door_open_close_timer = new System.Windows.Forms.Timer(this.components);
            this.move_elevatorBox_from_floor2_to_floor1 = new System.Windows.Forms.Timer(this.components);
            this.move_elevatorBox_from_floor1_to_floor2 = new System.Windows.Forms.Timer(this.components);
            this.floor_labels1 = new System.Windows.Forms.Label();
            this.floor_labels2 = new System.Windows.Forms.Label();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.floor_shadow_pictureBox_floor2 = new System.Windows.Forms.PictureBox();
            this.elevator_floor2_btn_down = new System.Windows.Forms.Button();
            this.Control_panel = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.elevator_Control_panel = new System.Windows.Forms.TableLayoutPanel();
            this.button_floor_2 = new System.Windows.Forms.Button();
            this.control_label = new System.Windows.Forms.Label();
            this.button_floor_1 = new System.Windows.Forms.Button();
            this.button_open_door = new System.Windows.Forms.Button();
            this.button_close_door = new System.Windows.Forms.Button();
            this.button_emergency = new System.Windows.Forms.Button();
            this.Display_db_Log_btn = new System.Windows.Forms.Button();
            this.Delete_Log_btn = new System.Windows.Forms.Button();
            this.Delete_All_Logs_btn = new System.Windows.Forms.Button();
            this.database_grid_view = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Main_tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.Elevator_Moving_panel = new System.Windows.Forms.Panel();
            this.picturebox_right_floor1_door = new System.Windows.Forms.PictureBox();
            this.picturebox_left_floor1_door = new System.Windows.Forms.PictureBox();
            this.picturebox_left_floor2_door = new System.Windows.Forms.PictureBox();
            this.picturebox_right_floor2_door = new System.Windows.Forms.PictureBox();
            this.elevator_box_picturebox = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.elevator_floor1_btn_up = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.floor_shadow_pictureBox_floor2)).BeginInit();
            this.Control_panel.SuspendLayout();
            this.elevator_Control_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.database_grid_view)).BeginInit();
            this.Main_tableLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            this.Elevator_Moving_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picturebox_right_floor1_door)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picturebox_left_floor1_door)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picturebox_left_floor2_door)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picturebox_right_floor2_door)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.elevator_box_picturebox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            this.SuspendLayout();
            // 
            // floor1_door_open_close_timer
            // 
            this.floor1_door_open_close_timer.Tick += new System.EventHandler(this.floor1_door_open_close_timer_Tick);
            // 
            // floor2_door_open_close_timer
            // 
            this.floor2_door_open_close_timer.Tick += new System.EventHandler(this.floor2_door_open_close_timer_Tick);
            // 
            // move_elevatorBox_from_floor2_to_floor1
            // 
            this.move_elevatorBox_from_floor2_to_floor1.Tick += new System.EventHandler(this.move_elevatorBox_from_floor2_to_floor1_Tick);
            // 
            // move_elevatorBox_from_floor1_to_floor2
            // 
            this.move_elevatorBox_from_floor1_to_floor2.Tick += new System.EventHandler(this.move_elevatorBox_from_floor1_to_floor2_Tick);
            // 
            // floor_labels1
            // 
            this.floor_labels1.AutoSize = true;
            this.floor_labels1.BackColor = System.Drawing.Color.Transparent;
            this.floor_labels1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.floor_labels1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.floor_labels1.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.floor_labels1.Location = new System.Drawing.Point(340, 417);
            this.floor_labels1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.floor_labels1.Name = "floor_labels1";
            this.floor_labels1.Size = new System.Drawing.Size(332, 82);
            this.floor_labels1.TabIndex = 21;
            this.floor_labels1.Text = "Floor No : 1";
            this.floor_labels1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // floor_labels2
            // 
            this.floor_labels2.AutoSize = true;
            this.floor_labels2.BackColor = System.Drawing.Color.Transparent;
            this.floor_labels2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.floor_labels2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.floor_labels2.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.floor_labels2.Location = new System.Drawing.Point(340, 0);
            this.floor_labels2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.floor_labels2.Name = "floor_labels2";
            this.floor_labels2.Size = new System.Drawing.Size(332, 82);
            this.floor_labels2.TabIndex = 20;
            this.floor_labels2.Text = "Floor No : 2";
            this.floor_labels2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox7
            // 
            this.pictureBox7.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.Main_tableLayoutPanel.SetColumnSpan(this.pictureBox7, 3);
            this.pictureBox7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox7.Location = new System.Drawing.Point(336, 401);
            this.pictureBox7.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(456, 16);
            this.pictureBox7.TabIndex = 18;
            this.pictureBox7.TabStop = false;
            // 
            // floor_shadow_pictureBox_floor2
            // 
            this.floor_shadow_pictureBox_floor2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("floor_shadow_pictureBox_floor2.BackgroundImage")));
            this.floor_shadow_pictureBox_floor2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Main_tableLayoutPanel.SetColumnSpan(this.floor_shadow_pictureBox_floor2, 3);
            this.floor_shadow_pictureBox_floor2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.floor_shadow_pictureBox_floor2.Location = new System.Drawing.Point(336, 311);
            this.floor_shadow_pictureBox_floor2.Margin = new System.Windows.Forms.Padding(0);
            this.floor_shadow_pictureBox_floor2.Name = "floor_shadow_pictureBox_floor2";
            this.Main_tableLayoutPanel.SetRowSpan(this.floor_shadow_pictureBox_floor2, 2);
            this.floor_shadow_pictureBox_floor2.Size = new System.Drawing.Size(456, 90);
            this.floor_shadow_pictureBox_floor2.TabIndex = 13;
            this.floor_shadow_pictureBox_floor2.TabStop = false;
            // 
            // elevator_floor2_btn_down
            // 
            this.elevator_floor2_btn_down.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.elevator_floor2_btn_down.BackColor = System.Drawing.Color.Transparent;
            this.elevator_floor2_btn_down.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("elevator_floor2_btn_down.BackgroundImage")));
            this.elevator_floor2_btn_down.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.elevator_floor2_btn_down.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.elevator_floor2_btn_down.Location = new System.Drawing.Point(705, 204);
            this.elevator_floor2_btn_down.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.elevator_floor2_btn_down.MaximumSize = new System.Drawing.Size(67, 49);
            this.elevator_floor2_btn_down.MinimumSize = new System.Drawing.Size(67, 49);
            this.elevator_floor2_btn_down.Name = "elevator_floor2_btn_down";
            this.elevator_floor2_btn_down.Size = new System.Drawing.Size(67, 49);
            this.elevator_floor2_btn_down.TabIndex = 7;
            this.elevator_floor2_btn_down.UseVisualStyleBackColor = false;
            this.elevator_floor2_btn_down.Click += new System.EventHandler(this.elevator_floor2_btn_down_Click);
            // 
            // Control_panel
            // 
            this.Control_panel.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.Control_panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Control_panel.Controls.Add(this.label2);
            this.Control_panel.Controls.Add(this.label1);
            this.Control_panel.Controls.Add(this.elevator_Control_panel);
            this.Control_panel.Controls.Add(this.Display_db_Log_btn);
            this.Control_panel.Controls.Add(this.Delete_Log_btn);
            this.Control_panel.Controls.Add(this.Delete_All_Logs_btn);
            this.Control_panel.Controls.Add(this.database_grid_view);
            this.Control_panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Control_panel.Location = new System.Drawing.Point(0, 0);
            this.Control_panel.Margin = new System.Windows.Forms.Padding(0);
            this.Control_panel.Name = "Control_panel";
            this.Main_tableLayoutPanel.SetRowSpan(this.Control_panel, 11);
            this.Control_panel.Size = new System.Drawing.Size(336, 820);
            this.Control_panel.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.label2.Location = new System.Drawing.Point(31, 12);
            this.label2.Margin = new System.Windows.Forms.Padding(0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(251, 26);
            this.label2.TabIndex = 6;
            this.label2.Text = "Elevator Inside Controler";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.label1.Location = new System.Drawing.Point(36, 393);
            this.label1.Margin = new System.Windows.Forms.Padding(0, 12, 0, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(238, 26);
            this.label1.TabIndex = 5;
            this.label1.Text = "Automatic Elevator Log";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // elevator_Control_panel
            // 
            this.elevator_Control_panel.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.elevator_Control_panel.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Inset;
            this.elevator_Control_panel.ColumnCount = 1;
            this.elevator_Control_panel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.elevator_Control_panel.Controls.Add(this.button_floor_2, 0, 2);
            this.elevator_Control_panel.Controls.Add(this.control_label, 0, 0);
            this.elevator_Control_panel.Controls.Add(this.button_floor_1, 0, 1);
            this.elevator_Control_panel.Controls.Add(this.button_open_door, 0, 3);
            this.elevator_Control_panel.Controls.Add(this.button_close_door, 0, 4);
            this.elevator_Control_panel.Controls.Add(this.button_emergency, 0, 5);
            this.elevator_Control_panel.Location = new System.Drawing.Point(11, 48);
            this.elevator_Control_panel.Margin = new System.Windows.Forms.Padding(27, 25, 27, 25);
            this.elevator_Control_panel.Name = "elevator_Control_panel";
            this.elevator_Control_panel.RowCount = 6;
            this.elevator_Control_panel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.elevator_Control_panel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.elevator_Control_panel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.elevator_Control_panel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66F));
            this.elevator_Control_panel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66F));
            this.elevator_Control_panel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66F));
            this.elevator_Control_panel.Size = new System.Drawing.Size(308, 337);
            this.elevator_Control_panel.TabIndex = 4;
            // 
            // button_floor_2
            // 
            this.button_floor_2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button_floor_2.BackColor = System.Drawing.Color.Transparent;
            this.button_floor_2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_floor_2.BackgroundImage")));
            this.button_floor_2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_floor_2.FlatAppearance.BorderSize = 0;
            this.button_floor_2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_floor_2.Location = new System.Drawing.Point(119, 137);
            this.button_floor_2.Margin = new System.Windows.Forms.Padding(4, 12, 4, 12);
            this.button_floor_2.Name = "button_floor_2";
            this.button_floor_2.Size = new System.Drawing.Size(70, 40);
            this.button_floor_2.TabIndex = 2;
            this.button_floor_2.UseVisualStyleBackColor = false;
            this.button_floor_2.Click += new System.EventHandler(this.button_floor_2_Click);
            // 
            // control_label
            // 
            this.control_label.AutoSize = true;
            this.control_label.BackColor = System.Drawing.Color.Transparent;
            this.control_label.Dock = System.Windows.Forms.DockStyle.Fill;
            this.control_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.control_label.ForeColor = System.Drawing.SystemColors.Highlight;
            this.control_label.Location = new System.Drawing.Point(2, 14);
            this.control_label.Margin = new System.Windows.Forms.Padding(0, 12, 0, 12);
            this.control_label.Name = "control_label";
            this.control_label.Size = new System.Drawing.Size(304, 25);
            this.control_label.TabIndex = 0;
            this.control_label.Text = "Current Floor = ";
            this.control_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button_floor_1
            // 
            this.button_floor_1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button_floor_1.BackColor = System.Drawing.Color.Transparent;
            this.button_floor_1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_floor_1.BackgroundImage")));
            this.button_floor_1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_floor_1.FlatAppearance.BorderSize = 0;
            this.button_floor_1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_floor_1.Location = new System.Drawing.Point(119, 67);
            this.button_floor_1.Margin = new System.Windows.Forms.Padding(4, 12, 4, 12);
            this.button_floor_1.Name = "button_floor_1";
            this.button_floor_1.Size = new System.Drawing.Size(70, 40);
            this.button_floor_1.TabIndex = 1;
            this.button_floor_1.UseVisualStyleBackColor = false;
            this.button_floor_1.Click += new System.EventHandler(this.button_floor_1_Click);
            // 
            // button_open_door
            // 
            this.button_open_door.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button_open_door.BackColor = System.Drawing.Color.LightGreen;
            this.button_open_door.FlatAppearance.BorderSize = 0;
            this.button_open_door.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_open_door.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.button_open_door.Location = new System.Drawing.Point(119, 201);
            this.button_open_door.Margin = new System.Windows.Forms.Padding(4, 8, 4, 8);
            this.button_open_door.Name = "button_open_door";
            this.button_open_door.Size = new System.Drawing.Size(70, 29);
            this.button_open_door.TabIndex = 3;
            this.button_open_door.Text = "OPEN";
            this.button_open_door.UseVisualStyleBackColor = false;
            this.button_open_door.Click += new System.EventHandler(this.button_open_door_Click);
            // 
            // button_close_door
            // 
            this.button_close_door.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button_close_door.BackColor = System.Drawing.Color.LightCoral;
            this.button_close_door.FlatAppearance.BorderSize = 0;
            this.button_close_door.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_close_door.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.button_close_door.Location = new System.Drawing.Point(119, 248);
            this.button_close_door.Margin = new System.Windows.Forms.Padding(4, 8, 4, 8);
            this.button_close_door.Name = "button_close_door";
            this.button_close_door.Size = new System.Drawing.Size(70, 29);
            this.button_close_door.TabIndex = 4;
            this.button_close_door.Text = "CLOSE";
            this.button_close_door.UseVisualStyleBackColor = false;
            this.button_close_door.Click += new System.EventHandler(this.button_close_door_Click);
            // 
            // button_emergency
            // 
            this.button_emergency.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button_emergency.BackColor = System.Drawing.Color.Red;
            this.button_emergency.FlatAppearance.BorderSize = 0;
            this.button_emergency.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_emergency.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            this.button_emergency.ForeColor = System.Drawing.Color.White;
            this.button_emergency.Location = new System.Drawing.Point(119, 295);
            this.button_emergency.Margin = new System.Windows.Forms.Padding(4, 8, 4, 8);
            this.button_emergency.Name = "button_emergency";
            this.button_emergency.Size = new System.Drawing.Size(70, 32);
            this.button_emergency.TabIndex = 5;
            this.button_emergency.UseVisualStyleBackColor = false;
            this.button_emergency.Click += new System.EventHandler(this.button_emergency_Click);
            // 
            // Display_db_Log_btn
            // 
            this.Display_db_Log_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.Display_db_Log_btn.Location = new System.Drawing.Point(11, 743);
            this.Display_db_Log_btn.Margin = new System.Windows.Forms.Padding(0);
            this.Display_db_Log_btn.Name = "Display_db_Log_btn";
            this.Display_db_Log_btn.Size = new System.Drawing.Size(150, 34);
            this.Display_db_Log_btn.TabIndex = 1;
            this.Display_db_Log_btn.Text = "Show Elevator Logs";
            this.Display_db_Log_btn.UseVisualStyleBackColor = true;
            this.Display_db_Log_btn.Click += new System.EventHandler(this.Display_db_Log_btn_Click);
            // 
            // Delete_Log_btn
            // 
            this.Delete_Log_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.Delete_Log_btn.Location = new System.Drawing.Point(169, 743);
            this.Delete_Log_btn.Margin = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.Delete_Log_btn.Name = "Delete_Log_btn";
            this.Delete_Log_btn.Size = new System.Drawing.Size(150, 34);
            this.Delete_Log_btn.TabIndex = 7;
            this.Delete_Log_btn.Text = "Delete Selected Log";
            this.Delete_Log_btn.UseVisualStyleBackColor = true;
            this.Delete_Log_btn.Click += new System.EventHandler(this.Delete_Log_btn_Click);
            // 
            // Delete_All_Logs_btn
            // 
            this.Delete_All_Logs_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.Delete_All_Logs_btn.Location = new System.Drawing.Point(11, 785);
            this.Delete_All_Logs_btn.Margin = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.Delete_All_Logs_btn.Name = "Delete_All_Logs_btn";
            this.Delete_All_Logs_btn.Size = new System.Drawing.Size(308, 34);
            this.Delete_All_Logs_btn.TabIndex = 8;
            this.Delete_All_Logs_btn.Text = "Delete All Logs";
            this.Delete_All_Logs_btn.UseVisualStyleBackColor = true;
            this.Delete_All_Logs_btn.Click += new System.EventHandler(this.Delete_All_Logs_btn_Click);
            // 
            // database_grid_view
            // 
            this.database_grid_view.AllowUserToAddRows = false;
            this.database_grid_view.AllowUserToDeleteRows = false;
            this.database_grid_view.AllowUserToResizeColumns = false;
            this.database_grid_view.AllowUserToResizeRows = false;
            this.database_grid_view.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.database_grid_view.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.database_grid_view.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.database_grid_view.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.database_grid_view.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.database_grid_view.Location = new System.Drawing.Point(11, 428);
            this.database_grid_view.Margin = new System.Windows.Forms.Padding(0);
            this.database_grid_view.Name = "database_grid_view";
            this.database_grid_view.ReadOnly = true;
            this.database_grid_view.RowHeadersVisible = false;
            this.database_grid_view.RowHeadersWidth = 51;
            this.database_grid_view.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.database_grid_view.Size = new System.Drawing.Size(308, 316);
            this.database_grid_view.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "Floor_id";
            this.Column1.FillWeight = 70F;
            this.Column1.HeaderText = "Floor Number";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "Date_Time";
            this.Column2.HeaderText = "Arrived On";
            this.Column2.MinimumWidth = 100;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Main_tableLayoutPanel
            // 
            this.Main_tableLayoutPanel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Main_tableLayoutPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Main_tableLayoutPanel.ColumnCount = 7;
            this.Main_tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.Main_tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.29762F));
            this.Main_tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 0.6696429F));
            this.Main_tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8F));
            this.Main_tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 28F));
            this.Main_tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8F));
            this.Main_tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.Main_tableLayoutPanel.Controls.Add(this.pictureBox6, 0, 9);
            this.Main_tableLayoutPanel.Controls.Add(this.Control_panel, 0, 0);
            this.Main_tableLayoutPanel.Controls.Add(this.Elevator_Moving_panel, 4, 2);
            this.Main_tableLayoutPanel.Controls.Add(this.floor_shadow_pictureBox_floor2, 1, 3);
            this.Main_tableLayoutPanel.Controls.Add(this.pictureBox2, 5, 3);
            this.Main_tableLayoutPanel.Controls.Add(this.pictureBox7, 1, 5);
            this.Main_tableLayoutPanel.Controls.Add(this.pictureBox8, 5, 5);
            this.Main_tableLayoutPanel.Controls.Add(this.floor_labels2, 1, 0);
            this.Main_tableLayoutPanel.Controls.Add(this.floor_labels1, 1, 6);
            this.Main_tableLayoutPanel.Controls.Add(this.elevator_floor2_btn_down, 3, 2);
            this.Main_tableLayoutPanel.Controls.Add(this.elevator_floor1_btn_up, 3, 8);
            this.Main_tableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Main_tableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.Main_tableLayoutPanel.Margin = new System.Windows.Forms.Padding(0);
            this.Main_tableLayoutPanel.Name = "Main_tableLayoutPanel";
            this.Main_tableLayoutPanel.RowCount = 11;
            this.Main_tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.Main_tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8F));
            this.Main_tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.Main_tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 1F));
            this.Main_tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.Main_tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 2F));
            this.Main_tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.Main_tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 3.170732F));
            this.Main_tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 24.7561F));
            this.Main_tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 1F));
            this.Main_tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.Main_tableLayoutPanel.Size = new System.Drawing.Size(1344, 820);
            this.Main_tableLayoutPanel.TabIndex = 8;
            this.Main_tableLayoutPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.Main_tableLayoutPanel_Paint);
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox6.BackgroundImage")));
            this.pictureBox6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Main_tableLayoutPanel.SetColumnSpan(this.pictureBox6, 6);
            this.pictureBox6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox6.Location = new System.Drawing.Point(336, 728);
            this.pictureBox6.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox6.Name = "pictureBox6";
            this.Main_tableLayoutPanel.SetRowSpan(this.pictureBox6, 2);
            this.pictureBox6.Size = new System.Drawing.Size(1008, 92);
            this.pictureBox6.TabIndex = 17;
            this.pictureBox6.TabStop = false;
            // 
            // Elevator_Moving_panel
            // 
            this.Elevator_Moving_panel.BackColor = System.Drawing.Color.Transparent;
            this.Elevator_Moving_panel.Controls.Add(this.picturebox_right_floor1_door);
            this.Elevator_Moving_panel.Controls.Add(this.picturebox_left_floor1_door);
            this.Elevator_Moving_panel.Controls.Add(this.picturebox_left_floor2_door);
            this.Elevator_Moving_panel.Controls.Add(this.picturebox_right_floor2_door);
            this.Elevator_Moving_panel.Controls.Add(this.elevator_box_picturebox);
            this.Elevator_Moving_panel.Controls.Add(this.pictureBox5);
            this.Elevator_Moving_panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Elevator_Moving_panel.Location = new System.Drawing.Point(792, 147);
            this.Elevator_Moving_panel.Margin = new System.Windows.Forms.Padding(0);
            this.Elevator_Moving_panel.Name = "Elevator_Moving_panel";
            this.Main_tableLayoutPanel.SetRowSpan(this.Elevator_Moving_panel, 7);
            this.Elevator_Moving_panel.Size = new System.Drawing.Size(376, 581);
            this.Elevator_Moving_panel.TabIndex = 8;
            // 
            // picturebox_right_floor1_door
            // 
            this.picturebox_right_floor1_door.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.picturebox_right_floor1_door.BackColor = System.Drawing.Color.DimGray;
            this.picturebox_right_floor1_door.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picturebox_right_floor1_door.Image = ((System.Drawing.Image)(resources.GetObject("picturebox_right_floor1_door.Image")));
            this.picturebox_right_floor1_door.Location = new System.Drawing.Point(189, 415);
            this.picturebox_right_floor1_door.Margin = new System.Windows.Forms.Padding(0);
            this.picturebox_right_floor1_door.Name = "picturebox_right_floor1_door";
            this.picturebox_right_floor1_door.Size = new System.Drawing.Size(187, 167);
            this.picturebox_right_floor1_door.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picturebox_right_floor1_door.TabIndex = 3;
            this.picturebox_right_floor1_door.TabStop = false;
            // 
            // picturebox_left_floor1_door
            // 
            this.picturebox_left_floor1_door.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.picturebox_left_floor1_door.BackColor = System.Drawing.Color.Gray;
            this.picturebox_left_floor1_door.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picturebox_left_floor1_door.Image = ((System.Drawing.Image)(resources.GetObject("picturebox_left_floor1_door.Image")));
            this.picturebox_left_floor1_door.Location = new System.Drawing.Point(0, 415);
            this.picturebox_left_floor1_door.Margin = new System.Windows.Forms.Padding(0);
            this.picturebox_left_floor1_door.Name = "picturebox_left_floor1_door";
            this.picturebox_left_floor1_door.Size = new System.Drawing.Size(189, 167);
            this.picturebox_left_floor1_door.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picturebox_left_floor1_door.TabIndex = 4;
            this.picturebox_left_floor1_door.TabStop = false;
            // 
            // picturebox_left_floor2_door
            // 
            this.picturebox_left_floor2_door.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.picturebox_left_floor2_door.BackColor = System.Drawing.Color.Gray;
            this.picturebox_left_floor2_door.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picturebox_left_floor2_door.Image = ((System.Drawing.Image)(resources.GetObject("picturebox_left_floor2_door.Image")));
            this.picturebox_left_floor2_door.Location = new System.Drawing.Point(0, 0);
            this.picturebox_left_floor2_door.Margin = new System.Windows.Forms.Padding(0);
            this.picturebox_left_floor2_door.Name = "picturebox_left_floor2_door";
            this.picturebox_left_floor2_door.Size = new System.Drawing.Size(189, 164);
            this.picturebox_left_floor2_door.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picturebox_left_floor2_door.TabIndex = 7;
            this.picturebox_left_floor2_door.TabStop = false;
            this.picturebox_left_floor2_door.Click += new System.EventHandler(this.picturebox_left_floor2_door_Click);
            // 
            // picturebox_right_floor2_door
            // 
            this.picturebox_right_floor2_door.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.picturebox_right_floor2_door.BackColor = System.Drawing.Color.DimGray;
            this.picturebox_right_floor2_door.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picturebox_right_floor2_door.Image = ((System.Drawing.Image)(resources.GetObject("picturebox_right_floor2_door.Image")));
            this.picturebox_right_floor2_door.Location = new System.Drawing.Point(189, 0);
            this.picturebox_right_floor2_door.Margin = new System.Windows.Forms.Padding(0);
            this.picturebox_right_floor2_door.Name = "picturebox_right_floor2_door";
            this.picturebox_right_floor2_door.Size = new System.Drawing.Size(187, 164);
            this.picturebox_right_floor2_door.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picturebox_right_floor2_door.TabIndex = 6;
            this.picturebox_right_floor2_door.TabStop = false;
            // 
            // elevator_box_picturebox
            // 
            this.elevator_box_picturebox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.elevator_box_picturebox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.elevator_box_picturebox.Location = new System.Drawing.Point(0, 1);
            this.elevator_box_picturebox.Margin = new System.Windows.Forms.Padding(0);
            this.elevator_box_picturebox.Name = "elevator_box_picturebox";
            this.elevator_box_picturebox.Size = new System.Drawing.Size(376, 164);
            this.elevator_box_picturebox.TabIndex = 5;
            this.elevator_box_picturebox.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox5.BackgroundImage")));
            this.pictureBox5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox5.Location = new System.Drawing.Point(0, 165);
            this.pictureBox5.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(376, 89);
            this.pictureBox5.TabIndex = 1;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Main_tableLayoutPanel.SetColumnSpan(this.pictureBox2, 2);
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox2.Location = new System.Drawing.Point(1168, 311);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox2.Name = "pictureBox2";
            this.Main_tableLayoutPanel.SetRowSpan(this.pictureBox2, 2);
            this.pictureBox2.Size = new System.Drawing.Size(176, 90);
            this.pictureBox2.TabIndex = 14;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox8
            // 
            this.pictureBox8.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.Main_tableLayoutPanel.SetColumnSpan(this.pictureBox8, 2);
            this.pictureBox8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox8.Location = new System.Drawing.Point(1168, 401);
            this.pictureBox8.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(176, 16);
            this.pictureBox8.TabIndex = 19;
            this.pictureBox8.TabStop = false;
            // 
            // elevator_floor1_btn_up
            // 
            this.elevator_floor1_btn_up.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.elevator_floor1_btn_up.BackColor = System.Drawing.Color.Transparent;
            this.elevator_floor1_btn_up.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("elevator_floor1_btn_up.BackgroundImage")));
            this.elevator_floor1_btn_up.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.elevator_floor1_btn_up.Location = new System.Drawing.Point(705, 602);
            this.elevator_floor1_btn_up.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.elevator_floor1_btn_up.MaximumSize = new System.Drawing.Size(67, 49);
            this.elevator_floor1_btn_up.MinimumSize = new System.Drawing.Size(67, 49);
            this.elevator_floor1_btn_up.Name = "elevator_floor1_btn_up";
            this.elevator_floor1_btn_up.Size = new System.Drawing.Size(67, 49);
            this.elevator_floor1_btn_up.TabIndex = 9;
            this.elevator_floor1_btn_up.UseVisualStyleBackColor = false;
            this.elevator_floor1_btn_up.Click += new System.EventHandler(this.elevator_floor1_btn_up_Click);
            // 
            // Main_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1344, 820);
            this.Controls.Add(this.Main_tableLayoutPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Main_Form";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.floor_shadow_pictureBox_floor2)).EndInit();
            this.Control_panel.ResumeLayout(false);
            this.Control_panel.PerformLayout();
            this.elevator_Control_panel.ResumeLayout(false);
            this.elevator_Control_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.database_grid_view)).EndInit();
            this.Main_tableLayoutPanel.ResumeLayout(false);
            this.Main_tableLayoutPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            this.Elevator_Moving_panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picturebox_right_floor1_door)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picturebox_left_floor1_door)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picturebox_left_floor2_door)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picturebox_right_floor2_door)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.elevator_box_picturebox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        internal System.Windows.Forms.Timer floor1_door_open_close_timer;
        internal System.Windows.Forms.Timer floor2_door_open_close_timer;
        internal System.Windows.Forms.Timer move_elevatorBox_from_floor2_to_floor1;
        internal System.Windows.Forms.Timer move_elevatorBox_from_floor1_to_floor2;
        private System.Windows.Forms.Label floor_labels1;
        private System.Windows.Forms.Label floor_labels2;
        private System.Windows.Forms.TableLayoutPanel Main_tableLayoutPanel;
        private System.Windows.Forms.Panel Control_panel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel elevator_Control_panel;
        internal System.Windows.Forms.Button button_floor_2;
        internal System.Windows.Forms.Label control_label;
        internal System.Windows.Forms.Button button_floor_1;
        internal System.Windows.Forms.Button button_open_door;
        internal System.Windows.Forms.Button button_close_door;
        internal System.Windows.Forms.Button button_emergency;
        private System.Windows.Forms.Button Display_db_Log_btn;
        private System.Windows.Forms.Button Delete_Log_btn;
        private System.Windows.Forms.Button Delete_All_Logs_btn;
        internal System.Windows.Forms.DataGridView database_grid_view;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        internal System.Windows.Forms.Button elevator_floor2_btn_down;
        private System.Windows.Forms.PictureBox floor_shadow_pictureBox_floor2;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.PictureBox pictureBox6;
        internal System.Windows.Forms.Button elevator_floor1_btn_up;
        private System.Windows.Forms.Panel Elevator_Moving_panel;
        private System.Windows.Forms.PictureBox picturebox_right_floor1_door;
        private System.Windows.Forms.PictureBox picturebox_left_floor1_door;
        private System.Windows.Forms.PictureBox picturebox_left_floor2_door;
        private System.Windows.Forms.PictureBox picturebox_right_floor2_door;
        private System.Windows.Forms.PictureBox elevator_box_picturebox;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox8;
    }
}

