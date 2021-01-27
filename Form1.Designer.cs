namespace KRTP
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.delete_data = new System.Windows.Forms.Button();
            this.add_monument = new System.Windows.Forms.Button();
            this.ConditionAssessment = new System.Windows.Forms.TextBox();
            this.YearOfCreate = new System.Windows.Forms.TextBox();
            this.Region = new System.Windows.Forms.TextBox();
            this.Creater = new System.Windows.Forms.TextBox();
            this.type_monument = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.mame_monument = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // delete_data
            // 
            this.delete_data.Cursor = System.Windows.Forms.Cursors.Hand;
            this.delete_data.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.delete_data.Location = new System.Drawing.Point(263, 470);
            this.delete_data.Name = "delete_data";
            this.delete_data.Size = new System.Drawing.Size(217, 56);
            this.delete_data.TabIndex = 29;
            this.delete_data.Text = "Удалить";
            this.delete_data.UseVisualStyleBackColor = true;
            // 
            // add_monument
            // 
            this.add_monument.Cursor = System.Windows.Forms.Cursors.Hand;
            this.add_monument.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.add_monument.Location = new System.Drawing.Point(12, 470);
            this.add_monument.Name = "add_monument";
            this.add_monument.Size = new System.Drawing.Size(244, 57);
            this.add_monument.TabIndex = 28;
            this.add_monument.Text = "Добавить";
            this.add_monument.UseVisualStyleBackColor = true;
            // 
            // ConditionAssessment
            // 
            this.ConditionAssessment.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ConditionAssessment.Location = new System.Drawing.Point(12, 430);
            this.ConditionAssessment.Name = "ConditionAssessment";
            this.ConditionAssessment.Size = new System.Drawing.Size(468, 34);
            this.ConditionAssessment.TabIndex = 27;
            // 
            // YearOfCreate
            // 
            this.YearOfCreate.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.YearOfCreate.Location = new System.Drawing.Point(12, 365);
            this.YearOfCreate.Name = "YearOfCreate";
            this.YearOfCreate.Size = new System.Drawing.Size(468, 34);
            this.YearOfCreate.TabIndex = 26;
            // 
            // Region
            // 
            this.Region.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Region.Location = new System.Drawing.Point(12, 297);
            this.Region.Name = "Region";
            this.Region.Size = new System.Drawing.Size(468, 34);
            this.Region.TabIndex = 25;
            // 
            // Creater
            // 
            this.Creater.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Creater.Location = new System.Drawing.Point(12, 232);
            this.Creater.Name = "Creater";
            this.Creater.Size = new System.Drawing.Size(468, 34);
            this.Creater.TabIndex = 24;
            // 
            // type_monument
            // 
            this.type_monument.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.type_monument.Location = new System.Drawing.Point(12, 166);
            this.type_monument.Name = "type_monument";
            this.type_monument.Size = new System.Drawing.Size(468, 34);
            this.type_monument.TabIndex = 23;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(10, 333);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(190, 29);
            this.label7.TabIndex = 22;
            this.label7.Text = "Год создания:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(12, 401);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(252, 29);
            this.label6.TabIndex = 21;
            this.label6.Text = "Оценка состояния:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(12, 268);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 29);
            this.label5.TabIndex = 20;
            this.label5.Text = "Регион:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(12, 202);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(154, 29);
            this.label4.TabIndex = 19;
            this.label4.Text = "Создатель:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(12, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 29);
            this.label3.TabIndex = 18;
            this.label3.Text = "Вид:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(9, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(284, 29);
            this.label2.TabIndex = 17;
            this.label2.Text = "Название памятника:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(9, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(476, 36);
            this.label1.TabIndex = 16;
            this.label1.Text = "Заполните анкету памятника:";
            // 
            // mame_monument
            // 
            this.mame_monument.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.mame_monument.Location = new System.Drawing.Point(12, 99);
            this.mame_monument.Name = "mame_monument";
            this.mame_monument.Size = new System.Drawing.Size(468, 34);
            this.mame_monument.TabIndex = 15;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1072, 573);
            this.Controls.Add(this.delete_data);
            this.Controls.Add(this.add_monument);
            this.Controls.Add(this.ConditionAssessment);
            this.Controls.Add(this.YearOfCreate);
            this.Controls.Add(this.Region);
            this.Controls.Add(this.Creater);
            this.Controls.Add(this.type_monument);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.mame_monument);
            this.Name = "Form1";
            this.Text = "Памятники истории и архитектуры";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button delete_data;
        private System.Windows.Forms.Button add_monument;
        private System.Windows.Forms.TextBox ConditionAssessment;
        private System.Windows.Forms.TextBox YearOfCreate;
        private System.Windows.Forms.TextBox Region;
        private System.Windows.Forms.TextBox Creater;
        private System.Windows.Forms.TextBox type_monument;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox mame_monument;
    }
}

