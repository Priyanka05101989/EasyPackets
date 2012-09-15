namespace Packet_demo
{
    partial class Senderform
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
            this.txtMessage = new System.Windows.Forms.TextBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.thisip = new System.Windows.Forms.TextBox();
            this.Lable1 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.thisport = new System.Windows.Forms.TextBox();
            this.Conect = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.Return_txt = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtMessage
            // 
            this.txtMessage.Location = new System.Drawing.Point(12, 316);
            this.txtMessage.Multiline = true;
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.Size = new System.Drawing.Size(449, 31);
            this.txtMessage.TabIndex = 0;
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(12, 353);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(449, 20);
            this.btnSend.TabIndex = 1;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // thisip
            // 
            this.thisip.Location = new System.Drawing.Point(38, 12);
            this.thisip.Name = "thisip";
            this.thisip.Size = new System.Drawing.Size(100, 20);
            this.thisip.TabIndex = 2;
            this.thisip.Text = "127.0.0.1";
            // 
            // Lable1
            // 
            this.Lable1.AutoSize = true;
            this.Lable1.Location = new System.Drawing.Point(12, 15);
            this.Lable1.Name = "Lable1";
            this.Lable1.Size = new System.Drawing.Size(20, 13);
            this.Lable1.TabIndex = 3;
            this.Lable1.Text = "IP:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(144, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Port:";
            // 
            // thisport
            // 
            this.thisport.Location = new System.Drawing.Point(179, 12);
            this.thisport.Name = "thisport";
            this.thisport.Size = new System.Drawing.Size(100, 20);
            this.thisport.TabIndex = 4;
            this.thisport.Text = "7777";
            // 
            // Conect
            // 
            this.Conect.Location = new System.Drawing.Point(285, 10);
            this.Conect.Name = "Conect";
            this.Conect.Size = new System.Drawing.Size(74, 23);
            this.Conect.TabIndex = 6;
            this.Conect.Text = "Connect";
            this.Conect.UseVisualStyleBackColor = true;
            this.Conect.Click += new System.EventHandler(this.Conect_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(365, 10);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(76, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "KILL";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Return_txt
            // 
            this.Return_txt.Location = new System.Drawing.Point(12, 38);
            this.Return_txt.Multiline = true;
            this.Return_txt.Name = "Return_txt";
            this.Return_txt.ReadOnly = true;
            this.Return_txt.Size = new System.Drawing.Size(446, 272);
            this.Return_txt.TabIndex = 9;
            // 
            // Senderform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(470, 378);
            this.Controls.Add(this.Return_txt);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Conect);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.thisport);
            this.Controls.Add(this.Lable1);
            this.Controls.Add(this.thisip);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.txtMessage);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Senderform";
            this.Text = "Sender";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtMessage;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.TextBox thisip;
        private System.Windows.Forms.Label Lable1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox thisport;
        private System.Windows.Forms.Button Conect;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox Return_txt;
    }
}