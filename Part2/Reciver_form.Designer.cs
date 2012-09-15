namespace Part2
{
    partial class Reciver_form
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
            this.txtMessageRecieved = new System.Windows.Forms.TextBox();
            this.lblApplicationMessage = new System.Windows.Forms.Label();
            this.Listen = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.My_lanip = new System.Windows.Forms.Label();
            this.My_Wanip = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.theport = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // txtMessageRecieved
            // 
            this.txtMessageRecieved.Location = new System.Drawing.Point(12, 35);
            this.txtMessageRecieved.Multiline = true;
            this.txtMessageRecieved.Name = "txtMessageRecieved";
            this.txtMessageRecieved.ReadOnly = true;
            this.txtMessageRecieved.Size = new System.Drawing.Size(547, 230);
            this.txtMessageRecieved.TabIndex = 4;
            // 
            // lblApplicationMessage
            // 
            this.lblApplicationMessage.AutoSize = true;
            this.lblApplicationMessage.Location = new System.Drawing.Point(12, 10);
            this.lblApplicationMessage.Name = "lblApplicationMessage";
            this.lblApplicationMessage.Size = new System.Drawing.Size(115, 13);
            this.lblApplicationMessage.TabIndex = 3;
            this.lblApplicationMessage.Text = "NO PORT SELECTED";
            // 
            // Listen
            // 
            this.Listen.Location = new System.Drawing.Point(453, 5);
            this.Listen.Name = "Listen";
            this.Listen.Size = new System.Drawing.Size(106, 25);
            this.Listen.TabIndex = 5;
            this.Listen.Text = "Begin listening";
            this.Listen.UseVisualStyleBackColor = true;
            this.Listen.Click += new System.EventHandler(this.Listen_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(310, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Wan ip:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(310, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Lan ip:";
            // 
            // My_lanip
            // 
            this.My_lanip.AutoSize = true;
            this.My_lanip.Location = new System.Drawing.Point(355, 4);
            this.My_lanip.Name = "My_lanip";
            this.My_lanip.Size = new System.Drawing.Size(40, 13);
            this.My_lanip.TabIndex = 10;
            this.My_lanip.Text = "0.0.0.0";
            // 
            // My_Wanip
            // 
            this.My_Wanip.AutoSize = true;
            this.My_Wanip.Location = new System.Drawing.Point(355, 17);
            this.My_Wanip.Name = "My_Wanip";
            this.My_Wanip.Size = new System.Drawing.Size(40, 13);
            this.My_Wanip.TabIndex = 9;
            this.My_Wanip.Text = "0.0.0.0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(173, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Port";
            // 
            // theport
            // 
            this.theport.Location = new System.Drawing.Point(205, 4);
            this.theport.Name = "theport";
            this.theport.Size = new System.Drawing.Size(100, 20);
            this.theport.TabIndex = 7;
            this.theport.Text = "7777";
            // 
            // timer1
            // 
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Reciver_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(565, 272);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.My_lanip);
            this.Controls.Add(this.My_Wanip);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.theport);
            this.Controls.Add(this.Listen);
            this.Controls.Add(this.txtMessageRecieved);
            this.Controls.Add(this.lblApplicationMessage);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Reciver_form";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtMessageRecieved;
        private System.Windows.Forms.Label lblApplicationMessage;
        private System.Windows.Forms.Button Listen;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label My_lanip;
        private System.Windows.Forms.Label My_Wanip;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox theport;
        private System.Windows.Forms.Timer timer1;
    }
}