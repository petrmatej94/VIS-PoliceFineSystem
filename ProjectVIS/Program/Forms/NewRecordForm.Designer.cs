﻿namespace ProjectVIS.Program.Forms
{
    partial class NewRecordForm
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
            this.buttonRecordConfirm = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
            this.boxRecordAmmount = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.boxRecordExpire = new System.Windows.Forms.TextBox();
            this.comboRecordCategory = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.boxRecordPoints = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonRecordConfirm
            // 
            this.buttonRecordConfirm.Location = new System.Drawing.Point(454, 323);
            this.buttonRecordConfirm.Name = "buttonRecordConfirm";
            this.buttonRecordConfirm.Size = new System.Drawing.Size(159, 30);
            this.buttonRecordConfirm.TabIndex = 85;
            this.buttonRecordConfirm.Text = "Confirm";
            this.buttonRecordConfirm.UseVisualStyleBackColor = true;
            this.buttonRecordConfirm.Click += new System.EventHandler(this.buttonRecordConfirm_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label16.Location = new System.Drawing.Point(178, 135);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(190, 24);
            this.label16.TabIndex = 84;
            this.label16.Text = "Create new Record";
            // 
            // boxRecordAmmount
            // 
            this.boxRecordAmmount.Location = new System.Drawing.Point(350, 246);
            this.boxRecordAmmount.Name = "boxRecordAmmount";
            this.boxRecordAmmount.Size = new System.Drawing.Size(263, 20);
            this.boxRecordAmmount.TabIndex = 82;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label12.Location = new System.Drawing.Point(197, 246);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(76, 18);
            this.label12.TabIndex = 81;
            this.label12.Text = "Ammount:";
            // 
            // boxRecordExpire
            // 
            this.boxRecordExpire.Location = new System.Drawing.Point(350, 211);
            this.boxRecordExpire.Name = "boxRecordExpire";
            this.boxRecordExpire.Size = new System.Drawing.Size(263, 20);
            this.boxRecordExpire.TabIndex = 80;
            // 
            // comboRecordCategory
            // 
            this.comboRecordCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboRecordCategory.FormattingEnabled = true;
            this.comboRecordCategory.Items.AddRange(new object[] {
            "Jedna",
            "Dva",
            "Tři"});
            this.comboRecordCategory.Location = new System.Drawing.Point(350, 177);
            this.comboRecordCategory.Name = "comboRecordCategory";
            this.comboRecordCategory.Size = new System.Drawing.Size(263, 21);
            this.comboRecordCategory.TabIndex = 79;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label13.Location = new System.Drawing.Point(197, 211);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(86, 18);
            this.label13.TabIndex = 77;
            this.label13.Text = "Expire after:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label14.Location = new System.Drawing.Point(197, 176);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(145, 18);
            this.label14.TabIndex = 78;
            this.label14.Text = "Category of Offense:";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.button1.Location = new System.Drawing.Point(182, 162);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(440, 155);
            this.button1.TabIndex = 83;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // boxRecordPoints
            // 
            this.boxRecordPoints.Location = new System.Drawing.Point(350, 282);
            this.boxRecordPoints.Name = "boxRecordPoints";
            this.boxRecordPoints.ReadOnly = true;
            this.boxRecordPoints.Size = new System.Drawing.Size(263, 20);
            this.boxRecordPoints.TabIndex = 87;
            this.boxRecordPoints.TextChanged += new System.EventHandler(this.boxRecordPoints_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(197, 282);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 18);
            this.label1.TabIndex = 86;
            this.label1.Text = "Points:";
            // 
            // NewRecordForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.boxRecordPoints);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonRecordConfirm);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.boxRecordAmmount);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.boxRecordExpire);
            this.Controls.Add(this.comboRecordCategory);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.button1);
            this.Name = "NewRecordForm";
            this.Text = "NewRecordForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonRecordConfirm;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox boxRecordAmmount;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox boxRecordExpire;
        private System.Windows.Forms.ComboBox comboRecordCategory;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox boxRecordPoints;
        private System.Windows.Forms.Label label1;
    }
}