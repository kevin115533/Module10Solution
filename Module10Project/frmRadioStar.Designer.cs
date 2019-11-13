namespace Module10Project
{
    partial class frmRadioStar
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
            this.btnExit = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.lblLeftOp = new System.Windows.Forms.Label();
            this.lblRightOp = new System.Windows.Forms.Label();
            this.txtLeftOp = new System.Windows.Forms.TextBox();
            this.txtRightOp = new System.Windows.Forms.TextBox();
            this.lblMessage = new System.Windows.Forms.Label();
            this.grpRadioButtons = new System.Windows.Forms.GroupBox();
            this.rBtnAdd = new System.Windows.Forms.RadioButton();
            this.rBtnMutliply = new System.Windows.Forms.RadioButton();
            this.rBtnSubtract = new System.Windows.Forms.RadioButton();
            this.rBtnDivide = new System.Windows.Forms.RadioButton();
            this.rBtnModulus = new System.Windows.Forms.RadioButton();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.chkBxVerbose = new System.Windows.Forms.CheckBox();
            this.grpRadioButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(211, 218);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(114, 45);
            this.btnExit.TabIndex = 0;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnReset
            // 
            this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.Location = new System.Drawing.Point(211, 158);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(114, 45);
            this.btnReset.TabIndex = 1;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // lblLeftOp
            // 
            this.lblLeftOp.AutoSize = true;
            this.lblLeftOp.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLeftOp.Location = new System.Drawing.Point(12, 9);
            this.lblLeftOp.Name = "lblLeftOp";
            this.lblLeftOp.Size = new System.Drawing.Size(119, 24);
            this.lblLeftOp.TabIndex = 2;
            this.lblLeftOp.Text = "Left Operand";
            // 
            // lblRightOp
            // 
            this.lblRightOp.AutoSize = true;
            this.lblRightOp.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRightOp.Location = new System.Drawing.Point(12, 46);
            this.lblRightOp.Name = "lblRightOp";
            this.lblRightOp.Size = new System.Drawing.Size(133, 24);
            this.lblRightOp.TabIndex = 3;
            this.lblRightOp.Text = "Right Operand";
            // 
            // txtLeftOp
            // 
            this.txtLeftOp.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLeftOp.Location = new System.Drawing.Point(147, 6);
            this.txtLeftOp.Name = "txtLeftOp";
            this.txtLeftOp.Size = new System.Drawing.Size(178, 29);
            this.txtLeftOp.TabIndex = 4;
            // 
            // txtRightOp
            // 
            this.txtRightOp.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRightOp.Location = new System.Drawing.Point(147, 46);
            this.txtRightOp.Name = "txtRightOp";
            this.txtRightOp.Size = new System.Drawing.Size(178, 29);
            this.txtRightOp.TabIndex = 5;
            // 
            // lblMessage
            // 
            this.lblMessage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lblMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMessage.Location = new System.Drawing.Point(12, 292);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(313, 146);
            this.lblMessage.TabIndex = 6;
            this.lblMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // grpRadioButtons
            // 
            this.grpRadioButtons.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.grpRadioButtons.Controls.Add(this.rBtnModulus);
            this.grpRadioButtons.Controls.Add(this.rBtnDivide);
            this.grpRadioButtons.Controls.Add(this.rBtnSubtract);
            this.grpRadioButtons.Controls.Add(this.rBtnMutliply);
            this.grpRadioButtons.Controls.Add(this.rBtnAdd);
            this.grpRadioButtons.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.grpRadioButtons.Location = new System.Drawing.Point(16, 95);
            this.grpRadioButtons.Name = "grpRadioButtons";
            this.grpRadioButtons.Size = new System.Drawing.Size(136, 167);
            this.grpRadioButtons.TabIndex = 7;
            this.grpRadioButtons.TabStop = false;
            // 
            // rBtnAdd
            // 
            this.rBtnAdd.AutoSize = true;
            this.rBtnAdd.Checked = true;
            this.rBtnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rBtnAdd.Location = new System.Drawing.Point(6, 13);
            this.rBtnAdd.Name = "rBtnAdd";
            this.rBtnAdd.Size = new System.Drawing.Size(87, 24);
            this.rBtnAdd.TabIndex = 0;
            this.rBtnAdd.TabStop = true;
            this.rBtnAdd.Text = "Add ( + )";
            this.rBtnAdd.UseVisualStyleBackColor = true;
            this.rBtnAdd.CheckedChanged += new System.EventHandler(this.rBtnAdd_CheckedChanged);
            // 
            // rBtnMutliply
            // 
            this.rBtnMutliply.AutoSize = true;
            this.rBtnMutliply.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rBtnMutliply.Location = new System.Drawing.Point(6, 73);
            this.rBtnMutliply.Name = "rBtnMutliply";
            this.rBtnMutliply.Size = new System.Drawing.Size(107, 24);
            this.rBtnMutliply.TabIndex = 1;
            this.rBtnMutliply.TabStop = true;
            this.rBtnMutliply.Text = "Multiply ( * )";
            this.rBtnMutliply.UseVisualStyleBackColor = true;
            // 
            // rBtnSubtract
            // 
            this.rBtnSubtract.AutoSize = true;
            this.rBtnSubtract.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rBtnSubtract.Location = new System.Drawing.Point(6, 43);
            this.rBtnSubtract.Name = "rBtnSubtract";
            this.rBtnSubtract.Size = new System.Drawing.Size(111, 24);
            this.rBtnSubtract.TabIndex = 2;
            this.rBtnSubtract.TabStop = true;
            this.rBtnSubtract.Text = "Subtract( - )";
            this.rBtnSubtract.UseVisualStyleBackColor = true;
            // 
            // rBtnDivide
            // 
            this.rBtnDivide.AutoSize = true;
            this.rBtnDivide.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rBtnDivide.Location = new System.Drawing.Point(6, 103);
            this.rBtnDivide.Name = "rBtnDivide";
            this.rBtnDivide.Size = new System.Drawing.Size(96, 24);
            this.rBtnDivide.TabIndex = 3;
            this.rBtnDivide.TabStop = true;
            this.rBtnDivide.Text = "Divide ( / )";
            this.rBtnDivide.UseVisualStyleBackColor = true;
            // 
            // rBtnModulus
            // 
            this.rBtnModulus.AutoSize = true;
            this.rBtnModulus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rBtnModulus.Location = new System.Drawing.Point(6, 133);
            this.rBtnModulus.Name = "rBtnModulus";
            this.rBtnModulus.Size = new System.Drawing.Size(123, 24);
            this.rBtnModulus.TabIndex = 4;
            this.rBtnModulus.TabStop = true;
            this.rBtnModulus.Text = "Modulus ( % )";
            this.rBtnModulus.UseVisualStyleBackColor = true;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculate.Location = new System.Drawing.Point(211, 95);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(114, 45);
            this.btnCalculate.TabIndex = 8;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // chkBxVerbose
            // 
            this.chkBxVerbose.AutoSize = true;
            this.chkBxVerbose.Checked = true;
            this.chkBxVerbose.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkBxVerbose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkBxVerbose.Location = new System.Drawing.Point(16, 450);
            this.chkBxVerbose.Name = "chkBxVerbose";
            this.chkBxVerbose.Size = new System.Drawing.Size(132, 24);
            this.chkBxVerbose.TabIndex = 9;
            this.chkBxVerbose.Text = "Verbose Mode";
            this.chkBxVerbose.UseVisualStyleBackColor = true;
            // 
            // frmRadioStar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(343, 477);
            this.Controls.Add(this.chkBxVerbose);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.grpRadioButtons);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.txtRightOp);
            this.Controls.Add(this.txtLeftOp);
            this.Controls.Add(this.lblRightOp);
            this.Controls.Add(this.lblLeftOp);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnExit);
            this.KeyPreview = true;
            this.Name = "frmRadioStar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculations by Radio Light";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmRadioStar_KeyDown);
            this.grpRadioButtons.ResumeLayout(false);
            this.grpRadioButtons.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Label lblLeftOp;
        private System.Windows.Forms.Label lblRightOp;
        private System.Windows.Forms.TextBox txtLeftOp;
        private System.Windows.Forms.TextBox txtRightOp;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.GroupBox grpRadioButtons;
        private System.Windows.Forms.RadioButton rBtnModulus;
        private System.Windows.Forms.RadioButton rBtnDivide;
        private System.Windows.Forms.RadioButton rBtnSubtract;
        private System.Windows.Forms.RadioButton rBtnMutliply;
        private System.Windows.Forms.RadioButton rBtnAdd;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.CheckBox chkBxVerbose;
    }
}

