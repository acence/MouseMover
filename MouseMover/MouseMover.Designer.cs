namespace MouseMover
{
    partial class MouseMover
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MouseMover));
            this.btnStart = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.timMove = new System.Windows.Forms.Timer(this.components);
            this.timePicker = new System.Windows.Forms.DateTimePicker();
            this.cbShutdown = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.cb_Mouse = new System.Windows.Forms.CheckBox();
            this.cb_Keyboard = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(12, 26);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(186, 29);
            this.btnStart.TabIndex = 1;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(12, 61);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(186, 29);
            this.btnStop.TabIndex = 2;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // timMove
            // 
            this.timMove.Enabled = true;
            this.timMove.Interval = 30000;
            this.timMove.Tick += new System.EventHandler(this.timMove_Tick);
            // 
            // timePicker
            // 
            this.timePicker.CustomFormat = "HH:mm";
            this.timePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.timePicker.Location = new System.Drawing.Point(13, 229);
            this.timePicker.Name = "timePicker";
            this.timePicker.ShowUpDown = true;
            this.timePicker.Size = new System.Drawing.Size(186, 23);
            this.timePicker.TabIndex = 4;
            this.timePicker.Value = new System.DateTime(2020, 11, 26, 16, 46, 47, 0);
            // 
            // cbShutdown
            // 
            this.cbShutdown.AutoSize = true;
            this.cbShutdown.Location = new System.Drawing.Point(13, 204);
            this.cbShutdown.Name = "cbShutdown";
            this.cbShutdown.Size = new System.Drawing.Size(80, 19);
            this.cbShutdown.TabIndex = 3;
            this.cbShutdown.Text = "Shutdown";
            this.cbShutdown.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Status: ";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblStatus.Location = new System.Drawing.Point(64, 106);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(54, 15);
            this.lblStatus.TabIndex = 4;
            this.lblStatus.Text = "Stopped";
            // 
            // cb_Mouse
            // 
            this.cb_Mouse.AutoSize = true;
            this.cb_Mouse.Checked = true;
            this.cb_Mouse.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cb_Mouse.Location = new System.Drawing.Point(11, 151);
            this.cb_Mouse.Name = "cb_Mouse";
            this.cb_Mouse.Size = new System.Drawing.Size(62, 19);
            this.cb_Mouse.TabIndex = 5;
            this.cb_Mouse.Text = "Mouse";
            this.cb_Mouse.UseVisualStyleBackColor = true;
            // 
            // cb_Keyboard
            // 
            this.cb_Keyboard.AutoSize = true;
            this.cb_Keyboard.Checked = true;
            this.cb_Keyboard.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cb_Keyboard.Location = new System.Drawing.Point(123, 151);
            this.cb_Keyboard.Name = "cb_Keyboard";
            this.cb_Keyboard.Size = new System.Drawing.Size(76, 19);
            this.cb_Keyboard.TabIndex = 6;
            this.cb_Keyboard.Text = "Keyboard";
            this.cb_Keyboard.UseVisualStyleBackColor = true;
            // 
            // MouseMover
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(210, 264);
            this.Controls.Add(this.cb_Keyboard);
            this.Controls.Add(this.cb_Mouse);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbShutdown);
            this.Controls.Add(this.timePicker);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnStart);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MouseMover";
            this.Text = "Mouse Mover";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Timer timMove;
        private System.Windows.Forms.DateTimePicker timePicker;
        private System.Windows.Forms.CheckBox cbShutdown;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.CheckBox cb_Mouse;
        private System.Windows.Forms.CheckBox cb_Keyboard;
    }
}

