namespace KRTP
{
    partial class Form2
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
            this.itog_Condition = new System.Windows.Forms.TextBox();
            this.itog_Year = new System.Windows.Forms.TextBox();
            this.itog_Region = new System.Windows.Forms.TextBox();
            this.itpg_Creater = new System.Windows.Forms.TextBox();
            this.itog_type = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.itog_name_monument = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.ListOfMonuments = new System.Windows.Forms.ListBox();
            this.Redactor_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // itog_Condition
            // 
            this.itog_Condition.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.itog_Condition.Location = new System.Drawing.Point(341, 436);
            this.itog_Condition.Name = "itog_Condition";
            this.itog_Condition.Size = new System.Drawing.Size(468, 34);
            this.itog_Condition.TabIndex = 38;
            // 
            // itog_Year
            // 
            this.itog_Year.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.itog_Year.Location = new System.Drawing.Point(341, 367);
            this.itog_Year.Name = "itog_Year";
            this.itog_Year.Size = new System.Drawing.Size(468, 34);
            this.itog_Year.TabIndex = 37;
            // 
            // itog_Region
            // 
            this.itog_Region.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.itog_Region.Location = new System.Drawing.Point(341, 298);
            this.itog_Region.Name = "itog_Region";
            this.itog_Region.Size = new System.Drawing.Size(468, 34);
            this.itog_Region.TabIndex = 36;
            // 
            // itpg_Creater
            // 
            this.itpg_Creater.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.itpg_Creater.Location = new System.Drawing.Point(341, 229);
            this.itpg_Creater.Name = "itpg_Creater";
            this.itpg_Creater.Size = new System.Drawing.Size(468, 34);
            this.itpg_Creater.TabIndex = 35;
            // 
            // itog_type
            // 
            this.itog_type.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.itog_type.Location = new System.Drawing.Point(341, 160);
            this.itog_type.Name = "itog_type";
            this.itog_type.Size = new System.Drawing.Size(468, 34);
            this.itog_type.TabIndex = 34;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(336, 335);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(190, 29);
            this.label9.TabIndex = 33;
            this.label9.Text = "Год создания:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(336, 404);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(252, 29);
            this.label10.TabIndex = 32;
            this.label10.Text = "Оценка состояния:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.Location = new System.Drawing.Point(336, 266);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(111, 29);
            this.label11.TabIndex = 31;
            this.label11.Text = "Регион:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label12.Location = new System.Drawing.Point(336, 197);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(154, 29);
            this.label12.TabIndex = 30;
            this.label12.Text = "Создатель:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label13.Location = new System.Drawing.Point(336, 128);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(68, 29);
            this.label13.TabIndex = 29;
            this.label13.Text = "Вид:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label14.Location = new System.Drawing.Point(336, 59);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(284, 29);
            this.label14.TabIndex = 28;
            this.label14.Text = "Название памятника:";
            // 
            // itog_name_monument
            // 
            this.itog_name_monument.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.itog_name_monument.Location = new System.Drawing.Point(341, 91);
            this.itog_name_monument.Name = "itog_name_monument";
            this.itog_name_monument.Size = new System.Drawing.Size(468, 34);
            this.itog_name_monument.TabIndex = 27;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(6, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(170, 32);
            this.label8.TabIndex = 26;
            this.label8.Text = "Памятники";
            // 
            // ListOfMonuments
            // 
            this.ListOfMonuments.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ListOfMonuments.FormattingEnabled = true;
            this.ListOfMonuments.ItemHeight = 22;
            this.ListOfMonuments.Location = new System.Drawing.Point(12, 56);
            this.ListOfMonuments.Name = "ListOfMonuments";
            this.ListOfMonuments.Size = new System.Drawing.Size(318, 444);
            this.ListOfMonuments.TabIndex = 25;
            // 
            // Redactor_button
            // 
            this.Redactor_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Redactor_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Redactor_button.Location = new System.Drawing.Point(12, 506);
            this.Redactor_button.Name = "Redactor_button";
            this.Redactor_button.Size = new System.Drawing.Size(214, 56);
            this.Redactor_button.TabIndex = 39;
            this.Redactor_button.Text = "Редактор";
            this.Redactor_button.UseVisualStyleBackColor = true;
            this.Redactor_button.Click += new System.EventHandler(this.Redactor_button_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1072, 573);
            this.Controls.Add(this.Redactor_button);
            this.Controls.Add(this.itog_Condition);
            this.Controls.Add(this.itog_Year);
            this.Controls.Add(this.itog_Region);
            this.Controls.Add(this.itpg_Creater);
            this.Controls.Add(this.itog_type);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.itog_name_monument);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.ListOfMonuments);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Памятники истории и архитектуры";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form2_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox itog_Condition;
        private System.Windows.Forms.TextBox itog_Year;
        private System.Windows.Forms.TextBox itog_Region;
        private System.Windows.Forms.TextBox itpg_Creater;
        private System.Windows.Forms.TextBox itog_type;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox itog_name_monument;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ListBox ListOfMonuments;
        private System.Windows.Forms.Button Redactor_button;
    }
}