﻿
namespace Tyuiu.IlyinME.Sprint6.Task0.V14
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.buttonDone_IME = new System.Windows.Forms.Button();
            this.groupBoxCondition_IME = new System.Windows.Forms.GroupBox();
            this.textBoxTask_IME = new System.Windows.Forms.TextBox();
            this.groupBoxInputData_IME = new System.Windows.Forms.GroupBox();
            this.groupBoxOutputData_IME = new System.Windows.Forms.GroupBox();
            this.buttonHelp_IME = new System.Windows.Forms.Button();
            this.textBoxVarX_IME = new System.Windows.Forms.TextBox();
            this.labelVarX_IME = new System.Windows.Forms.Label();
            this.textBoxResult_IME = new System.Windows.Forms.TextBox();
            this.pictureBoxFormula_IME = new System.Windows.Forms.PictureBox();
            this.labelResult_IME = new System.Windows.Forms.Label();
            this.groupBoxCondition_IME.SuspendLayout();
            this.groupBoxInputData_IME.SuspendLayout();
            this.groupBoxOutputData_IME.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFormula_IME)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonDone_IME
            // 
            this.buttonDone_IME.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonDone_IME.Location = new System.Drawing.Point(653, 402);
            this.buttonDone_IME.Name = "buttonDone_IME";
            this.buttonDone_IME.Size = new System.Drawing.Size(135, 36);
            this.buttonDone_IME.TabIndex = 0;
            this.buttonDone_IME.Text = "Выполнить";
            this.buttonDone_IME.UseVisualStyleBackColor = true;
            this.buttonDone_IME.Click += new System.EventHandler(this.buttonDone_IME_Click);
            // 
            // groupBoxCondition_IME
            // 
            this.groupBoxCondition_IME.Controls.Add(this.pictureBoxFormula_IME);
            this.groupBoxCondition_IME.Controls.Add(this.textBoxTask_IME);
            this.groupBoxCondition_IME.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBoxCondition_IME.Location = new System.Drawing.Point(25, 38);
            this.groupBoxCondition_IME.Name = "groupBoxCondition_IME";
            this.groupBoxCondition_IME.Size = new System.Drawing.Size(752, 207);
            this.groupBoxCondition_IME.TabIndex = 1;
            this.groupBoxCondition_IME.TabStop = false;
            this.groupBoxCondition_IME.Text = "Условие";
            // 
            // textBoxTask_IME
            // 
            this.textBoxTask_IME.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxTask_IME.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxTask_IME.Location = new System.Drawing.Point(6, 19);
            this.textBoxTask_IME.Multiline = true;
            this.textBoxTask_IME.Name = "textBoxTask_IME";
            this.textBoxTask_IME.ReadOnly = true;
            this.textBoxTask_IME.Size = new System.Drawing.Size(530, 182);
            this.textBoxTask_IME.TabIndex = 0;
            this.textBoxTask_IME.Text = "Вычислить выражение по формуле";
            // 
            // groupBoxInputData_IME
            // 
            this.groupBoxInputData_IME.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBoxInputData_IME.Controls.Add(this.labelVarX_IME);
            this.groupBoxInputData_IME.Controls.Add(this.textBoxVarX_IME);
            this.groupBoxInputData_IME.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBoxInputData_IME.Location = new System.Drawing.Point(25, 261);
            this.groupBoxInputData_IME.Name = "groupBoxInputData_IME";
            this.groupBoxInputData_IME.Size = new System.Drawing.Size(352, 105);
            this.groupBoxInputData_IME.TabIndex = 2;
            this.groupBoxInputData_IME.TabStop = false;
            this.groupBoxInputData_IME.Text = "Ввод данных";
            // 
            // groupBoxOutputData_IME
            // 
            this.groupBoxOutputData_IME.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxOutputData_IME.Controls.Add(this.labelResult_IME);
            this.groupBoxOutputData_IME.Controls.Add(this.textBoxResult_IME);
            this.groupBoxOutputData_IME.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBoxOutputData_IME.Location = new System.Drawing.Point(422, 266);
            this.groupBoxOutputData_IME.Name = "groupBoxOutputData_IME";
            this.groupBoxOutputData_IME.Size = new System.Drawing.Size(355, 100);
            this.groupBoxOutputData_IME.TabIndex = 3;
            this.groupBoxOutputData_IME.TabStop = false;
            this.groupBoxOutputData_IME.Text = "Вывод данных";
            // 
            // buttonHelp_IME
            // 
            this.buttonHelp_IME.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonHelp_IME.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonHelp_IME.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonHelp_IME.Location = new System.Drawing.Point(586, 402);
            this.buttonHelp_IME.Name = "buttonHelp_IME";
            this.buttonHelp_IME.Size = new System.Drawing.Size(44, 36);
            this.buttonHelp_IME.TabIndex = 4;
            this.buttonHelp_IME.Text = "?";
            this.buttonHelp_IME.UseVisualStyleBackColor = true;
            this.buttonHelp_IME.Click += new System.EventHandler(this.buttonHelp_IME_Click);
            // 
            // textBoxVarX_IME
            // 
            this.textBoxVarX_IME.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.textBoxVarX_IME.Location = new System.Drawing.Point(6, 49);
            this.textBoxVarX_IME.Name = "textBoxVarX_IME";
            this.textBoxVarX_IME.Size = new System.Drawing.Size(113, 24);
            this.textBoxVarX_IME.TabIndex = 0;
            this.textBoxVarX_IME.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxVarX_IME_KeyPress);
            // 
            // labelVarX_IME
            // 
            this.labelVarX_IME.AutoSize = true;
            this.labelVarX_IME.Location = new System.Drawing.Point(7, 30);
            this.labelVarX_IME.Name = "labelVarX_IME";
            this.labelVarX_IME.Size = new System.Drawing.Size(112, 18);
            this.labelVarX_IME.TabIndex = 1;
            this.labelVarX_IME.Text = "Переменная X:";
            // 
            // textBoxResult_IME
            // 
            this.textBoxResult_IME.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxResult_IME.BackColor = System.Drawing.SystemColors.ControlLight;
            this.textBoxResult_IME.Location = new System.Drawing.Point(6, 44);
            this.textBoxResult_IME.Name = "textBoxResult_IME";
            this.textBoxResult_IME.ReadOnly = true;
            this.textBoxResult_IME.Size = new System.Drawing.Size(343, 24);
            this.textBoxResult_IME.TabIndex = 0;
            // 
            // pictureBoxFormula_IME
            // 
            this.pictureBoxFormula_IME.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxFormula_IME.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxFormula_IME.BackgroundImage")));
            this.pictureBoxFormula_IME.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxFormula_IME.Image")));
            this.pictureBoxFormula_IME.Location = new System.Drawing.Point(622, 19);
            this.pictureBoxFormula_IME.Name = "pictureBoxFormula_IME";
            this.pictureBoxFormula_IME.Size = new System.Drawing.Size(124, 63);
            this.pictureBoxFormula_IME.TabIndex = 1;
            this.pictureBoxFormula_IME.TabStop = false;
            // 
            // labelResult_IME
            // 
            this.labelResult_IME.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.labelResult_IME.AutoSize = true;
            this.labelResult_IME.Location = new System.Drawing.Point(6, 25);
            this.labelResult_IME.Name = "labelResult_IME";
            this.labelResult_IME.Size = new System.Drawing.Size(84, 18);
            this.labelResult_IME.TabIndex = 1;
            this.labelResult_IME.Text = "Результат:";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonHelp_IME);
            this.Controls.Add(this.groupBoxOutputData_IME);
            this.Controls.Add(this.groupBoxInputData_IME);
            this.Controls.Add(this.groupBoxCondition_IME);
            this.Controls.Add(this.buttonDone_IME);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 0 | Вариант 14 | Ильин М.Е. ";
            this.groupBoxCondition_IME.ResumeLayout(false);
            this.groupBoxCondition_IME.PerformLayout();
            this.groupBoxInputData_IME.ResumeLayout(false);
            this.groupBoxInputData_IME.PerformLayout();
            this.groupBoxOutputData_IME.ResumeLayout(false);
            this.groupBoxOutputData_IME.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFormula_IME)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonDone_IME;
        private System.Windows.Forms.GroupBox groupBoxCondition_IME;
        private System.Windows.Forms.TextBox textBoxTask_IME;
        private System.Windows.Forms.GroupBox groupBoxInputData_IME;
        private System.Windows.Forms.GroupBox groupBoxOutputData_IME;
        private System.Windows.Forms.Button buttonHelp_IME;
        private System.Windows.Forms.TextBox textBoxVarX_IME;
        private System.Windows.Forms.Label labelVarX_IME;
        private System.Windows.Forms.TextBox textBoxResult_IME;
        private System.Windows.Forms.PictureBox pictureBoxFormula_IME;
        private System.Windows.Forms.Label labelResult_IME;
    }
}

