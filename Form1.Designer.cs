namespace IP_Calculator
{
    partial class frmIPCalculator
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
            this.gbxSelectIPType = new System.Windows.Forms.GroupBox();
            this.rbnClassless = new System.Windows.Forms.RadioButton();
            this.rbnClassful = new System.Windows.Forms.RadioButton();
            this.gbxNumDevices = new System.Windows.Forms.GroupBox();
            this.txtNumAddresses = new System.Windows.Forms.TextBox();
            this.gbxIPAddress = new System.Windows.Forms.GroupBox();
            this.lblCriteria = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.lbxOutput = new System.Windows.Forms.ListBox();
            this.gbxSelectIPType.SuspendLayout();
            this.gbxNumDevices.SuspendLayout();
            this.gbxIPAddress.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbxSelectIPType
            // 
            this.gbxSelectIPType.Controls.Add(this.rbnClassless);
            this.gbxSelectIPType.Controls.Add(this.rbnClassful);
            this.gbxSelectIPType.Location = new System.Drawing.Point(81, 63);
            this.gbxSelectIPType.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbxSelectIPType.Name = "gbxSelectIPType";
            this.gbxSelectIPType.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbxSelectIPType.Size = new System.Drawing.Size(200, 138);
            this.gbxSelectIPType.TabIndex = 0;
            this.gbxSelectIPType.TabStop = false;
            // 
            // rbnClassless
            // 
            this.rbnClassless.AutoSize = true;
            this.rbnClassless.Location = new System.Drawing.Point(31, 72);
            this.rbnClassless.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rbnClassless.Name = "rbnClassless";
            this.rbnClassless.Size = new System.Drawing.Size(111, 26);
            this.rbnClassless.TabIndex = 1;
            this.rbnClassless.TabStop = true;
            this.rbnClassless.Text = "radioButton2";
            this.rbnClassless.UseVisualStyleBackColor = true;
            // 
            // rbnClassful
            // 
            this.rbnClassful.AutoSize = true;
            this.rbnClassful.Location = new System.Drawing.Point(31, 36);
            this.rbnClassful.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rbnClassful.Name = "rbnClassful";
            this.rbnClassful.Size = new System.Drawing.Size(111, 26);
            this.rbnClassful.TabIndex = 0;
            this.rbnClassful.TabStop = true;
            this.rbnClassful.Text = "radioButton1";
            this.rbnClassful.UseVisualStyleBackColor = true;
            // 
            // gbxNumDevices
            // 
            this.gbxNumDevices.Controls.Add(this.txtNumAddresses);
            this.gbxNumDevices.Location = new System.Drawing.Point(485, 191);
            this.gbxNumDevices.Name = "gbxNumDevices";
            this.gbxNumDevices.Size = new System.Drawing.Size(200, 100);
            this.gbxNumDevices.TabIndex = 1;
            this.gbxNumDevices.TabStop = false;
            // 
            // txtNumAddresses
            // 
            this.txtNumAddresses.Location = new System.Drawing.Point(74, 54);
            this.txtNumAddresses.Name = "txtNumAddresses";
            this.txtNumAddresses.Size = new System.Drawing.Size(100, 28);
            this.txtNumAddresses.TabIndex = 0;
            // 
            // gbxIPAddress
            // 
            this.gbxIPAddress.Controls.Add(this.lblCriteria);
            this.gbxIPAddress.Controls.Add(this.txtAddress);
            this.gbxIPAddress.Location = new System.Drawing.Point(640, 374);
            this.gbxIPAddress.Name = "gbxIPAddress";
            this.gbxIPAddress.Size = new System.Drawing.Size(200, 193);
            this.gbxIPAddress.TabIndex = 2;
            this.gbxIPAddress.TabStop = false;
            // 
            // lblCriteria
            // 
            this.lblCriteria.AutoSize = true;
            this.lblCriteria.Location = new System.Drawing.Point(48, 98);
            this.lblCriteria.Name = "lblCriteria";
            this.lblCriteria.Size = new System.Drawing.Size(0, 22);
            this.lblCriteria.TabIndex = 2;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(50, 36);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(100, 28);
            this.txtAddress.TabIndex = 1;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(148, 437);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(186, 54);
            this.btnCalculate.TabIndex = 4;
            this.btnCalculate.Text = "button1";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // lbxOutput
            // 
            this.lbxOutput.FormattingEnabled = true;
            this.lbxOutput.ItemHeight = 22;
            this.lbxOutput.Location = new System.Drawing.Point(353, 456);
            this.lbxOutput.Name = "lbxOutput";
            this.lbxOutput.Size = new System.Drawing.Size(378, 92);
            this.lbxOutput.TabIndex = 6;
            // 
            // frmIPCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1031, 898);
            this.Controls.Add(this.lbxOutput);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.gbxIPAddress);
            this.Controls.Add(this.gbxNumDevices);
            this.Controls.Add(this.gbxSelectIPType);
            this.Font = new System.Drawing.Font("Arial Narrow", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmIPCalculator";
            this.Text = "IP Calculator";
            this.Load += new System.EventHandler(this.frmIPCalculator_Load);
            this.gbxSelectIPType.ResumeLayout(false);
            this.gbxSelectIPType.PerformLayout();
            this.gbxNumDevices.ResumeLayout(false);
            this.gbxNumDevices.PerformLayout();
            this.gbxIPAddress.ResumeLayout(false);
            this.gbxIPAddress.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxSelectIPType;
        private System.Windows.Forms.RadioButton rbnClassless;
        private System.Windows.Forms.RadioButton rbnClassful;
        private System.Windows.Forms.GroupBox gbxNumDevices;
        private System.Windows.Forms.TextBox txtNumAddresses;
        private System.Windows.Forms.GroupBox gbxIPAddress;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Label lblCriteria;
        private System.Windows.Forms.ListBox lbxOutput;
    }
}

