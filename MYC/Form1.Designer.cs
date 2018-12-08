namespace MYC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button1 = new System.Windows.Forms.Button();
            this.weightBox = new System.Windows.Forms.TextBox();
            this.ageBox = new System.Windows.Forms.TextBox();
            this.heightBox = new System.Windows.Forms.TextBox();
            this.labelAge = new System.Windows.Forms.Label();
            this.labelWeight = new System.Windows.Forms.Label();
            this.labelHeight = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gender = new System.Windows.Forms.GroupBox();
            this.genderFemale = new System.Windows.Forms.RadioButton();
            this.genderMale = new System.Windows.Forms.RadioButton();
            this.gender.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(154, 219);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "расчитать";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // weightBox
            // 
            this.weightBox.Location = new System.Drawing.Point(246, 139);
            this.weightBox.Name = "weightBox";
            this.weightBox.Size = new System.Drawing.Size(100, 20);
            this.weightBox.TabIndex = 1;
            this.weightBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // ageBox
            // 
            this.ageBox.Location = new System.Drawing.Point(246, 103);
            this.ageBox.Name = "ageBox";
            this.ageBox.Size = new System.Drawing.Size(100, 20);
            this.ageBox.TabIndex = 2;
            this.ageBox.TextChanged += new System.EventHandler(this.ageBox_TextChanged);
            // 
            // heightBox
            // 
            this.heightBox.Location = new System.Drawing.Point(246, 174);
            this.heightBox.Name = "heightBox";
            this.heightBox.Size = new System.Drawing.Size(100, 20);
            this.heightBox.TabIndex = 3;
            // 
            // labelAge
            // 
            this.labelAge.AutoSize = true;
            this.labelAge.Location = new System.Drawing.Point(73, 110);
            this.labelAge.Name = "labelAge";
            this.labelAge.Size = new System.Drawing.Size(75, 13);
            this.labelAge.TabIndex = 4;
            this.labelAge.Text = "Возраст (год)";
            this.labelAge.Click += new System.EventHandler(this.label1_Click);
            // 
            // labelWeight
            // 
            this.labelWeight.AutoSize = true;
            this.labelWeight.Location = new System.Drawing.Point(73, 146);
            this.labelWeight.Name = "labelWeight";
            this.labelWeight.Size = new System.Drawing.Size(46, 13);
            this.labelWeight.TabIndex = 5;
            this.labelWeight.Text = "Вес (кг)";
            // 
            // labelHeight
            // 
            this.labelHeight.AutoSize = true;
            this.labelHeight.Location = new System.Drawing.Point(73, 181);
            this.labelHeight.Name = "labelHeight";
            this.labelHeight.Size = new System.Drawing.Size(54, 13);
            this.labelHeight.TabIndex = 6;
            this.labelHeight.Text = "Рост (см)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(114, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Формула Харриса-Бенедикта";
            // 
            // gender
            // 
            this.gender.Controls.Add(this.genderMale);
            this.gender.Controls.Add(this.genderFemale);
            this.gender.Location = new System.Drawing.Point(148, 37);
            this.gender.Name = "gender";
            this.gender.Size = new System.Drawing.Size(100, 60);
            this.gender.TabIndex = 11;
            this.gender.TabStop = false;
            this.gender.Text = "Пол";
            // 
            // genderFemale
            // 
            this.genderFemale.AutoSize = true;
            this.genderFemale.Location = new System.Drawing.Point(6, 37);
            this.genderFemale.Name = "genderFemale";
            this.genderFemale.Size = new System.Drawing.Size(75, 17);
            this.genderFemale.TabIndex = 13;
            this.genderFemale.Text = "Женщина";
            this.genderFemale.UseVisualStyleBackColor = true;
            this.genderFemale.CheckedChanged += new System.EventHandler(this.genderFemale_CheckedChanged);
            // 
            // genderMale
            // 
            this.genderMale.AutoSize = true;
            this.genderMale.Checked = true;
            this.genderMale.Location = new System.Drawing.Point(6, 14);
            this.genderMale.Name = "genderMale";
            this.genderMale.Size = new System.Drawing.Size(70, 17);
            this.genderMale.TabIndex = 14;
            this.genderMale.TabStop = true;
            this.genderMale.Text = "Мужчина";
            this.genderMale.UseVisualStyleBackColor = true;
            this.genderMale.CheckedChanged += new System.EventHandler(this.genderMale_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(414, 287);
            this.Controls.Add(this.gender);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelHeight);
            this.Controls.Add(this.labelWeight);
            this.Controls.Add(this.labelAge);
            this.Controls.Add(this.heightBox);
            this.Controls.Add(this.ageBox);
            this.Controls.Add(this.weightBox);
            this.Controls.Add(this.button1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "MYCalories";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gender.ResumeLayout(false);
            this.gender.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox weightBox;
        private System.Windows.Forms.TextBox ageBox;
        private System.Windows.Forms.TextBox heightBox;
        private System.Windows.Forms.Label labelAge;
        private System.Windows.Forms.Label labelWeight;
        private System.Windows.Forms.Label labelHeight;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gender;
        private System.Windows.Forms.RadioButton genderFemale;
        private System.Windows.Forms.RadioButton genderMale;
    }
}

