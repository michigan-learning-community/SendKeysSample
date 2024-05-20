
namespace SendKeys
{
    partial class Form1
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
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblCurrentlyActiveWindow = new System.Windows.Forms.ToolStripStatusLabel();
            this.btnLock = new System.Windows.Forms.Button();
            this.lblActiveWindow = new System.Windows.Forms.Label();
            this.txtActiveWindow = new System.Windows.Forms.TextBox();
            this.txtWindowHandle = new System.Windows.Forms.TextBox();
            this.lblActiveWindowHandle = new System.Windows.Forms.Label();
            this.grpKeys = new System.Windows.Forms.GroupBox();
            this.txtText = new System.Windows.Forms.TextBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.rbtALT = new System.Windows.Forms.RadioButton();
            this.rbtCTRL = new System.Windows.Forms.RadioButton();
            this.cboLetter = new System.Windows.Forms.ComboBox();
            this.txtQueue = new System.Windows.Forms.TextBox();
            this.btnSendQueue = new System.Windows.Forms.Button();
            this.btnAutomate = new System.Windows.Forms.Button();
            this.statusStrip1.SuspendLayout();
            this.grpKeys.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(40, 40);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblCurrentlyActiveWindow});
            this.statusStrip1.Location = new System.Drawing.Point(0, 292);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(425, 22);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lblCurrentlyActiveWindow
            // 
            this.lblCurrentlyActiveWindow.Name = "lblCurrentlyActiveWindow";
            this.lblCurrentlyActiveWindow.Size = new System.Drawing.Size(90, 17);
            this.lblCurrentlyActiveWindow.Text = "Active Window:";
            // 
            // btnLock
            // 
            this.btnLock.Location = new System.Drawing.Point(305, 12);
            this.btnLock.Name = "btnLock";
            this.btnLock.Size = new System.Drawing.Size(110, 23);
            this.btnLock.TabIndex = 1;
            this.btnLock.Text = "Lock Window";
            this.btnLock.UseVisualStyleBackColor = true;
            this.btnLock.Click += new System.EventHandler(this.btnLock_Click);
            // 
            // lblActiveWindow
            // 
            this.lblActiveWindow.AutoSize = true;
            this.lblActiveWindow.Location = new System.Drawing.Point(13, 17);
            this.lblActiveWindow.Name = "lblActiveWindow";
            this.lblActiveWindow.Size = new System.Drawing.Size(82, 13);
            this.lblActiveWindow.TabIndex = 2;
            this.lblActiveWindow.Text = "Active Window:";
            // 
            // txtActiveWindow
            // 
            this.txtActiveWindow.Location = new System.Drawing.Point(101, 14);
            this.txtActiveWindow.Name = "txtActiveWindow";
            this.txtActiveWindow.Size = new System.Drawing.Size(198, 20);
            this.txtActiveWindow.TabIndex = 3;
            // 
            // txtWindowHandle
            // 
            this.txtWindowHandle.Location = new System.Drawing.Point(101, 40);
            this.txtWindowHandle.Name = "txtWindowHandle";
            this.txtWindowHandle.Size = new System.Drawing.Size(72, 20);
            this.txtWindowHandle.TabIndex = 4;
            // 
            // lblActiveWindowHandle
            // 
            this.lblActiveWindowHandle.AutoSize = true;
            this.lblActiveWindowHandle.Location = new System.Drawing.Point(9, 43);
            this.lblActiveWindowHandle.Name = "lblActiveWindowHandle";
            this.lblActiveWindowHandle.Size = new System.Drawing.Size(86, 13);
            this.lblActiveWindowHandle.TabIndex = 5;
            this.lblActiveWindowHandle.Text = "Window Handle:";
            // 
            // grpKeys
            // 
            this.grpKeys.Controls.Add(this.btnAutomate);
            this.grpKeys.Controls.Add(this.btnSendQueue);
            this.grpKeys.Controls.Add(this.txtQueue);
            this.grpKeys.Controls.Add(this.txtText);
            this.grpKeys.Controls.Add(this.btnSend);
            this.grpKeys.Controls.Add(this.rbtALT);
            this.grpKeys.Controls.Add(this.rbtCTRL);
            this.grpKeys.Controls.Add(this.cboLetter);
            this.grpKeys.Location = new System.Drawing.Point(12, 66);
            this.grpKeys.Name = "grpKeys";
            this.grpKeys.Size = new System.Drawing.Size(403, 223);
            this.grpKeys.TabIndex = 6;
            this.grpKeys.TabStop = false;
            this.grpKeys.Text = "Send Keys";
            // 
            // txtText
            // 
            this.txtText.Location = new System.Drawing.Point(24, 59);
            this.txtText.Multiline = true;
            this.txtText.Name = "txtText";
            this.txtText.Size = new System.Drawing.Size(373, 22);
            this.txtText.TabIndex = 6;
            this.txtText.Text = "Type here to send keystrokes directly to application.";
            this.txtText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtText_KeyPress);
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(212, 30);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(75, 23);
            this.btnSend.TabIndex = 5;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // rbtALT
            // 
            this.rbtALT.AutoSize = true;
            this.rbtALT.Location = new System.Drawing.Point(83, 33);
            this.rbtALT.Name = "rbtALT";
            this.rbtALT.Size = new System.Drawing.Size(45, 17);
            this.rbtALT.TabIndex = 4;
            this.rbtALT.TabStop = true;
            this.rbtALT.Text = "ALT";
            this.rbtALT.UseVisualStyleBackColor = true;
            // 
            // rbtCTRL
            // 
            this.rbtCTRL.AutoSize = true;
            this.rbtCTRL.Location = new System.Drawing.Point(24, 33);
            this.rbtCTRL.Name = "rbtCTRL";
            this.rbtCTRL.Size = new System.Drawing.Size(53, 17);
            this.rbtCTRL.TabIndex = 3;
            this.rbtCTRL.TabStop = true;
            this.rbtCTRL.Text = "CTRL";
            this.rbtCTRL.UseVisualStyleBackColor = true;
            // 
            // cboLetter
            // 
            this.cboLetter.FormattingEnabled = true;
            this.cboLetter.Items.AddRange(new object[] {
            "A",
            "O",
            "P",
            "F4"});
            this.cboLetter.Location = new System.Drawing.Point(134, 32);
            this.cboLetter.Name = "cboLetter";
            this.cboLetter.Size = new System.Drawing.Size(72, 21);
            this.cboLetter.TabIndex = 1;
            // 
            // txtQueue
            // 
            this.txtQueue.AcceptsReturn = true;
            this.txtQueue.Location = new System.Drawing.Point(24, 88);
            this.txtQueue.Multiline = true;
            this.txtQueue.Name = "txtQueue";
            this.txtQueue.Size = new System.Drawing.Size(263, 93);
            this.txtQueue.TabIndex = 7;
            // 
            // btnSendQueue
            // 
            this.btnSendQueue.Location = new System.Drawing.Point(293, 88);
            this.btnSendQueue.Name = "btnSendQueue";
            this.btnSendQueue.Size = new System.Drawing.Size(104, 40);
            this.btnSendQueue.TabIndex = 8;
            this.btnSendQueue.Text = "Send Queued Text";
            this.btnSendQueue.UseVisualStyleBackColor = true;
            this.btnSendQueue.Click += new System.EventHandler(this.btnSendQueue_Click);
            // 
            // btnAutomate
            // 
            this.btnAutomate.Location = new System.Drawing.Point(293, 189);
            this.btnAutomate.Name = "btnAutomate";
            this.btnAutomate.Size = new System.Drawing.Size(104, 28);
            this.btnAutomate.TabIndex = 9;
            this.btnAutomate.Text = "Automate!";
            this.btnAutomate.UseVisualStyleBackColor = true;
            this.btnAutomate.Click += new System.EventHandler(this.btnAutomate_ClickAsync);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(425, 314);
            this.Controls.Add(this.grpKeys);
            this.Controls.Add(this.lblActiveWindowHandle);
            this.Controls.Add(this.txtWindowHandle);
            this.Controls.Add(this.txtActiveWindow);
            this.Controls.Add(this.lblActiveWindow);
            this.Controls.Add(this.btnLock);
            this.Controls.Add(this.statusStrip1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.grpKeys.ResumeLayout(false);
            this.grpKeys.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblCurrentlyActiveWindow;
        private System.Windows.Forms.Button btnLock;
        private System.Windows.Forms.Label lblActiveWindow;
        private System.Windows.Forms.TextBox txtActiveWindow;
        private System.Windows.Forms.TextBox txtWindowHandle;
        private System.Windows.Forms.Label lblActiveWindowHandle;
        private System.Windows.Forms.GroupBox grpKeys;
        private System.Windows.Forms.ComboBox cboLetter;
        private System.Windows.Forms.RadioButton rbtCTRL;
        private System.Windows.Forms.RadioButton rbtALT;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.TextBox txtText;
        private System.Windows.Forms.Button btnAutomate;
        private System.Windows.Forms.Button btnSendQueue;
        private System.Windows.Forms.TextBox txtQueue;
    }
}

