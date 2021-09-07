﻿
namespace Scheduler
{
    partial class CaseWorkerVisualSchedule
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label_CaseWorkerName = new System.Windows.Forms.Label();
            this.listBox_Meetings = new System.Windows.Forms.ListBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button_ChangeDate = new System.Windows.Forms.Button();
            this.button_Add = new System.Windows.Forms.Button();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label_CaseWorkerName
            // 
            this.label_CaseWorkerName.AutoSize = true;
            this.label_CaseWorkerName.Dock = System.Windows.Forms.DockStyle.Top;
            this.label_CaseWorkerName.Location = new System.Drawing.Point(0, 0);
            this.label_CaseWorkerName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_CaseWorkerName.Name = "label_CaseWorkerName";
            this.label_CaseWorkerName.Size = new System.Drawing.Size(56, 25);
            this.label_CaseWorkerName.TabIndex = 0;
            this.label_CaseWorkerName.Text = "name";
            // 
            // listBox_Meetings
            // 
            this.listBox_Meetings.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBox_Meetings.FormattingEnabled = true;
            this.listBox_Meetings.ItemHeight = 25;
            this.listBox_Meetings.Location = new System.Drawing.Point(0, 25);
            this.listBox_Meetings.Margin = new System.Windows.Forms.Padding(2);
            this.listBox_Meetings.Name = "listBox_Meetings";
            this.listBox_Meetings.Size = new System.Drawing.Size(443, 303);
            this.listBox_Meetings.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button_ChangeDate);
            this.panel1.Controls.Add(this.button_Add);
            this.panel1.Controls.Add(this.dateTimePicker);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 266);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(443, 62);
            this.panel1.TabIndex = 2;
            // 
            // button_ChangeDate
            // 
            this.button_ChangeDate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_ChangeDate.Location = new System.Drawing.Point(0, 31);
            this.button_ChangeDate.Margin = new System.Windows.Forms.Padding(2);
            this.button_ChangeDate.Name = "button_ChangeDate";
            this.button_ChangeDate.Size = new System.Drawing.Size(218, 31);
            this.button_ChangeDate.TabIndex = 2;
            this.button_ChangeDate.Text = "Change";
            this.button_ChangeDate.UseVisualStyleBackColor = true;
            // 
            // button_Add
            // 
            this.button_Add.Dock = System.Windows.Forms.DockStyle.Right;
            this.button_Add.Location = new System.Drawing.Point(218, 31);
            this.button_Add.Margin = new System.Windows.Forms.Padding(2);
            this.button_Add.Name = "button_Add";
            this.button_Add.Size = new System.Drawing.Size(225, 31);
            this.button_Add.TabIndex = 0;
            this.button_Add.Text = "Add";
            this.button_Add.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.CustomFormat = "yyyy.MM.dd HH:mm";
            this.dateTimePicker.Dock = System.Windows.Forms.DockStyle.Top;
            this.dateTimePicker.Location = new System.Drawing.Point(0, 0);
            this.dateTimePicker.Margin = new System.Windows.Forms.Padding(2);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(443, 31);
            this.dateTimePicker.TabIndex = 1;
            // 
            // CaseWorkerVisualSchedule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.listBox_Meetings);
            this.Controls.Add(this.label_CaseWorkerName);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "CaseWorkerVisualSchedule";
            this.Size = new System.Drawing.Size(443, 328);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_CaseWorkerName;
        private System.Windows.Forms.ListBox listBox_Meetings;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button_Add;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.Button button_ChangeDate;
    }
}
