namespace _17_02_20_Homework_BlogLesson45_TaskCancelation
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
            this.btnCreateTask = new System.Windows.Forms.Button();
            this.txtNumber = new System.Windows.Forms.TextBox();
            this.lblNumber = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnCreateTaskToFauls = new System.Windows.Forms.Button();
            this.btnInvestigateException = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCreateTask
            // 
            this.btnCreateTask.Location = new System.Drawing.Point(39, 32);
            this.btnCreateTask.Name = "btnCreateTask";
            this.btnCreateTask.Size = new System.Drawing.Size(75, 23);
            this.btnCreateTask.TabIndex = 0;
            this.btnCreateTask.Text = "Create Task";
            this.btnCreateTask.UseVisualStyleBackColor = true;
            this.btnCreateTask.Click += new System.EventHandler(this.btnCreateTask_Click);
            // 
            // txtNumber
            // 
            this.txtNumber.Location = new System.Drawing.Point(221, 34);
            this.txtNumber.Name = "txtNumber";
            this.txtNumber.Size = new System.Drawing.Size(115, 20);
            this.txtNumber.TabIndex = 1;
            // 
            // lblNumber
            // 
            this.lblNumber.AutoSize = true;
            this.lblNumber.Location = new System.Drawing.Point(168, 37);
            this.lblNumber.Name = "lblNumber";
            this.lblNumber.Size = new System.Drawing.Size(47, 13);
            this.lblNumber.TabIndex = 2;
            this.lblNumber.Text = "Number:";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(39, 89);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnCreateTaskToFauls
            // 
            this.btnCreateTaskToFauls.Location = new System.Drawing.Point(474, 31);
            this.btnCreateTaskToFauls.Name = "btnCreateTaskToFauls";
            this.btnCreateTaskToFauls.Size = new System.Drawing.Size(75, 23);
            this.btnCreateTaskToFauls.TabIndex = 4;
            this.btnCreateTaskToFauls.Text = "Task to fault";
            this.btnCreateTaskToFauls.UseVisualStyleBackColor = true;
            this.btnCreateTaskToFauls.Click += new System.EventHandler(this.btnCreateTaskToFauls_Click);
            // 
            // btnInvestigateException
            // 
            this.btnInvestigateException.Location = new System.Drawing.Point(474, 88);
            this.btnInvestigateException.Name = "btnInvestigateException";
            this.btnInvestigateException.Size = new System.Drawing.Size(75, 23);
            this.btnInvestigateException.TabIndex = 5;
            this.btnInvestigateException.Text = "Investigate exception";
            this.btnInvestigateException.UseVisualStyleBackColor = true;
            this.btnInvestigateException.Click += new System.EventHandler(this.btnInvestigateException_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnInvestigateException);
            this.Controls.Add(this.btnCreateTaskToFauls);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.lblNumber);
            this.Controls.Add(this.txtNumber);
            this.Controls.Add(this.btnCreateTask);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCreateTask;
        private System.Windows.Forms.TextBox txtNumber;
        private System.Windows.Forms.Label lblNumber;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnCreateTaskToFauls;
        private System.Windows.Forms.Button btnInvestigateException;
    }
}

