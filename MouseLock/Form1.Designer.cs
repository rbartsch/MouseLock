namespace MouseLock {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.activationBtn = new System.Windows.Forms.Button();
            this.custConstraintBtn = new System.Windows.Forms.Button();
            this.horizontalCheckBox = new System.Windows.Forms.CheckBox();
            this.verticalCheckBox = new System.Windows.Forms.CheckBox();
            this.constraintTypeSetLbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // activationBtn
            // 
            this.activationBtn.Location = new System.Drawing.Point(12, 12);
            this.activationBtn.Name = "activationBtn";
            this.activationBtn.Size = new System.Drawing.Size(101, 23);
            this.activationBtn.TabIndex = 0;
            this.activationBtn.Text = "Activate";
            this.activationBtn.UseVisualStyleBackColor = true;
            this.activationBtn.Click += new System.EventHandler(this.ActivationBtn_Click);
            // 
            // custConstraintBtn
            // 
            this.custConstraintBtn.Location = new System.Drawing.Point(12, 41);
            this.custConstraintBtn.Name = "custConstraintBtn";
            this.custConstraintBtn.Size = new System.Drawing.Size(101, 23);
            this.custConstraintBtn.TabIndex = 1;
            this.custConstraintBtn.Text = "Custom constraint";
            this.custConstraintBtn.UseVisualStyleBackColor = true;
            this.custConstraintBtn.Click += new System.EventHandler(this.CustConstraintBtn_Click);
            // 
            // horizontalCheckBox
            // 
            this.horizontalCheckBox.AutoSize = true;
            this.horizontalCheckBox.Checked = true;
            this.horizontalCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.horizontalCheckBox.Location = new System.Drawing.Point(119, 16);
            this.horizontalCheckBox.Name = "horizontalCheckBox";
            this.horizontalCheckBox.Size = new System.Drawing.Size(73, 17);
            this.horizontalCheckBox.TabIndex = 2;
            this.horizontalCheckBox.Text = "Horizontal";
            this.horizontalCheckBox.UseVisualStyleBackColor = true;
            // 
            // verticalCheckBox
            // 
            this.verticalCheckBox.AutoSize = true;
            this.verticalCheckBox.Checked = true;
            this.verticalCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.verticalCheckBox.Location = new System.Drawing.Point(198, 16);
            this.verticalCheckBox.Name = "verticalCheckBox";
            this.verticalCheckBox.Size = new System.Drawing.Size(61, 17);
            this.verticalCheckBox.TabIndex = 3;
            this.verticalCheckBox.Text = "Vertical";
            this.verticalCheckBox.UseVisualStyleBackColor = true;
            // 
            // constraintTypeSetLbl
            // 
            this.constraintTypeSetLbl.AutoSize = true;
            this.constraintTypeSetLbl.Location = new System.Drawing.Point(119, 46);
            this.constraintTypeSetLbl.Name = "constraintTypeSetLbl";
            this.constraintTypeSetLbl.Size = new System.Drawing.Size(93, 13);
            this.constraintTypeSetLbl.TabIndex = 4;
            this.constraintTypeSetLbl.Text = "constraint type set";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(4, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(342, 130);
            this.label1.TabIndex = 5;
            this.label1.Text = resources.GetString("label1.Text");
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(4, 404);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(40, 13);
            this.linkLabel1.TabIndex = 6;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "ver. 01";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 226);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(341, 169);
            this.label2.TabIndex = 7;
            this.label2.Text = resources.GetString("label2.Text");
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(351, 427);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.constraintTypeSetLbl);
            this.Controls.Add(this.verticalCheckBox);
            this.Controls.Add(this.horizontalCheckBox);
            this.Controls.Add(this.custConstraintBtn);
            this.Controls.Add(this.activationBtn);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Name = "Form1";
            this.Text = "Mouse Lock";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button activationBtn;
        private System.Windows.Forms.Button custConstraintBtn;
        private System.Windows.Forms.CheckBox horizontalCheckBox;
        private System.Windows.Forms.CheckBox verticalCheckBox;
        private System.Windows.Forms.Label constraintTypeSetLbl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label label2;
    }
}

