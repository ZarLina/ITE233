namespace Calculator_info
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
            this.clear_number = new System.Windows.Forms.Button();
            this.sub_from_memory = new System.Windows.Forms.Button();
            this.add_from_memory = new System.Windows.Forms.Button();
            this.memory_clear = new System.Windows.Forms.Button();
            this.ten_in_power_of_number = new System.Windows.Forms.Button();
            this.in_power_of_number = new System.Windows.Forms.Button();
            this.in_power_of_3 = new System.Windows.Forms.Button();
            this.in_power_of_2 = new System.Windows.Forms.Button();
            this.exp = new System.Windows.Forms.Button();
            this.modulo = new System.Windows.Forms.Button();
            this.factorial = new System.Windows.Forms.Button();
            this.clear_one = new System.Windows.Forms.Button();
            this.clear_all = new System.Windows.Forms.Button();
            this.solution = new System.Windows.Forms.Button();
            this.division = new System.Windows.Forms.Button();
            this.multiplication = new System.Windows.Forms.Button();
            this.subtraction = new System.Windows.Forms.Button();
            this.addition = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // clear_number
            // 
            this.clear_number.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clear_number.Location = new System.Drawing.Point(103, 285);
            this.clear_number.Name = "clear_number";
            this.clear_number.Size = new System.Drawing.Size(86, 47);
            this.clear_number.TabIndex = 51;
            this.clear_number.Text = "CE";
            this.clear_number.UseVisualStyleBackColor = true;
            this.clear_number.Click += new System.EventHandler(this.clear_number_Click);
            // 
            // sub_from_memory
            // 
            this.sub_from_memory.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sub_from_memory.Location = new System.Drawing.Point(103, 234);
            this.sub_from_memory.Name = "sub_from_memory";
            this.sub_from_memory.Size = new System.Drawing.Size(86, 45);
            this.sub_from_memory.TabIndex = 50;
            this.sub_from_memory.Text = "M-";
            this.sub_from_memory.UseVisualStyleBackColor = true;
            this.sub_from_memory.Click += new System.EventHandler(this.sub_from_memory_Click);
            // 
            // add_from_memory
            // 
            this.add_from_memory.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add_from_memory.Location = new System.Drawing.Point(195, 234);
            this.add_from_memory.Name = "add_from_memory";
            this.add_from_memory.Size = new System.Drawing.Size(86, 45);
            this.add_from_memory.TabIndex = 49;
            this.add_from_memory.Text = "M+";
            this.add_from_memory.UseVisualStyleBackColor = true;
            this.add_from_memory.Click += new System.EventHandler(this.add_from_memory_Click);
            // 
            // memory_clear
            // 
            this.memory_clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.memory_clear.Location = new System.Drawing.Point(195, 183);
            this.memory_clear.Name = "memory_clear";
            this.memory_clear.Size = new System.Drawing.Size(86, 45);
            this.memory_clear.TabIndex = 48;
            this.memory_clear.Text = "MC";
            this.memory_clear.UseVisualStyleBackColor = true;
            this.memory_clear.Click += new System.EventHandler(this.memory_clear_Click);
            // 
            // ten_in_power_of_number
            // 
            this.ten_in_power_of_number.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ten_in_power_of_number.Location = new System.Drawing.Point(195, 132);
            this.ten_in_power_of_number.Name = "ten_in_power_of_number";
            this.ten_in_power_of_number.Size = new System.Drawing.Size(86, 45);
            this.ten_in_power_of_number.TabIndex = 47;
            this.ten_in_power_of_number.Text = "10^x";
            this.ten_in_power_of_number.UseVisualStyleBackColor = true;
            this.ten_in_power_of_number.Click += new System.EventHandler(this.ten_in_power_of_number_Click);
            // 
            // in_power_of_number
            // 
            this.in_power_of_number.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.in_power_of_number.Location = new System.Drawing.Point(195, 80);
            this.in_power_of_number.Name = "in_power_of_number";
            this.in_power_of_number.Size = new System.Drawing.Size(86, 45);
            this.in_power_of_number.TabIndex = 46;
            this.in_power_of_number.Text = "x^y";
            this.in_power_of_number.UseVisualStyleBackColor = true;
            this.in_power_of_number.Click += new System.EventHandler(this.in_power_of_number_Click);
            // 
            // in_power_of_3
            // 
            this.in_power_of_3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.in_power_of_3.Location = new System.Drawing.Point(195, 30);
            this.in_power_of_3.Name = "in_power_of_3";
            this.in_power_of_3.Size = new System.Drawing.Size(86, 45);
            this.in_power_of_3.TabIndex = 45;
            this.in_power_of_3.Text = "x^3";
            this.in_power_of_3.UseVisualStyleBackColor = true;
            this.in_power_of_3.Click += new System.EventHandler(this.in_power_of_3_Click);
            // 
            // in_power_of_2
            // 
            this.in_power_of_2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.in_power_of_2.Location = new System.Drawing.Point(103, 30);
            this.in_power_of_2.Name = "in_power_of_2";
            this.in_power_of_2.Size = new System.Drawing.Size(86, 45);
            this.in_power_of_2.TabIndex = 44;
            this.in_power_of_2.Text = "x^2";
            this.in_power_of_2.UseVisualStyleBackColor = true;
            this.in_power_of_2.Click += new System.EventHandler(this.in_power_of_2_Click);
            // 
            // exp
            // 
            this.exp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exp.Location = new System.Drawing.Point(103, 183);
            this.exp.Name = "exp";
            this.exp.Size = new System.Drawing.Size(86, 45);
            this.exp.TabIndex = 43;
            this.exp.Text = "Exp";
            this.exp.UseVisualStyleBackColor = true;
            this.exp.Click += new System.EventHandler(this.exp_Click);
            // 
            // modulo
            // 
            this.modulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modulo.Location = new System.Drawing.Point(103, 132);
            this.modulo.Name = "modulo";
            this.modulo.Size = new System.Drawing.Size(86, 45);
            this.modulo.TabIndex = 42;
            this.modulo.Text = "Mod";
            this.modulo.UseVisualStyleBackColor = true;
            this.modulo.Click += new System.EventHandler(this.modulo_Click);
            // 
            // factorial
            // 
            this.factorial.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.factorial.Location = new System.Drawing.Point(103, 81);
            this.factorial.Name = "factorial";
            this.factorial.Size = new System.Drawing.Size(86, 45);
            this.factorial.TabIndex = 41;
            this.factorial.Text = "n!";
            this.factorial.UseVisualStyleBackColor = true;
            this.factorial.Click += new System.EventHandler(this.factorial_Click);
            // 
            // clear_one
            // 
            this.clear_one.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clear_one.Location = new System.Drawing.Point(11, 285);
            this.clear_one.Name = "clear_one";
            this.clear_one.Size = new System.Drawing.Size(86, 45);
            this.clear_one.TabIndex = 40;
            this.clear_one.Text = "←";
            this.clear_one.UseVisualStyleBackColor = true;
            this.clear_one.Click += new System.EventHandler(this.clear_one_Click);
            // 
            // clear_all
            // 
            this.clear_all.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clear_all.Location = new System.Drawing.Point(195, 285);
            this.clear_all.Name = "clear_all";
            this.clear_all.Size = new System.Drawing.Size(86, 45);
            this.clear_all.TabIndex = 39;
            this.clear_all.Text = "C";
            this.clear_all.UseVisualStyleBackColor = true;
            this.clear_all.Click += new System.EventHandler(this.clear_all_Click);
            // 
            // solution
            // 
            this.solution.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.solution.Location = new System.Drawing.Point(11, 234);
            this.solution.Name = "solution";
            this.solution.Size = new System.Drawing.Size(86, 45);
            this.solution.TabIndex = 37;
            this.solution.Text = "=";
            this.solution.UseVisualStyleBackColor = true;
            this.solution.Click += new System.EventHandler(this.solution_Click);
            // 
            // division
            // 
            this.division.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.division.Location = new System.Drawing.Point(11, 132);
            this.division.Name = "division";
            this.division.Size = new System.Drawing.Size(86, 45);
            this.division.TabIndex = 36;
            this.division.Text = "/";
            this.division.UseVisualStyleBackColor = true;
            this.division.Click += new System.EventHandler(this.division_Click);
            // 
            // multiplication
            // 
            this.multiplication.Location = new System.Drawing.Point(11, 81);
            this.multiplication.Name = "multiplication";
            this.multiplication.Size = new System.Drawing.Size(86, 45);
            this.multiplication.TabIndex = 35;
            this.multiplication.Text = "X";
            this.multiplication.UseVisualStyleBackColor = true;
            this.multiplication.Click += new System.EventHandler(this.multiplication_Click);
            // 
            // subtraction
            // 
            this.subtraction.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subtraction.Location = new System.Drawing.Point(11, 30);
            this.subtraction.Name = "subtraction";
            this.subtraction.Size = new System.Drawing.Size(86, 45);
            this.subtraction.TabIndex = 34;
            this.subtraction.Text = "-";
            this.subtraction.UseVisualStyleBackColor = true;
            this.subtraction.Click += new System.EventHandler(this.subtraction_Click);
            // 
            // addition
            // 
            this.addition.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addition.Location = new System.Drawing.Point(11, 183);
            this.addition.Name = "addition";
            this.addition.Size = new System.Drawing.Size(86, 45);
            this.addition.TabIndex = 33;
            this.addition.Text = "+";
            this.addition.UseVisualStyleBackColor = true;
            this.addition.Click += new System.EventHandler(this.addition_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.Location = new System.Drawing.Point(378, 30);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(293, 300);
            this.richTextBox1.TabIndex = 52;
            this.richTextBox1.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(772, 417);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.clear_number);
            this.Controls.Add(this.sub_from_memory);
            this.Controls.Add(this.add_from_memory);
            this.Controls.Add(this.memory_clear);
            this.Controls.Add(this.ten_in_power_of_number);
            this.Controls.Add(this.in_power_of_number);
            this.Controls.Add(this.in_power_of_3);
            this.Controls.Add(this.in_power_of_2);
            this.Controls.Add(this.exp);
            this.Controls.Add(this.modulo);
            this.Controls.Add(this.factorial);
            this.Controls.Add(this.clear_one);
            this.Controls.Add(this.clear_all);
            this.Controls.Add(this.solution);
            this.Controls.Add(this.division);
            this.Controls.Add(this.multiplication);
            this.Controls.Add(this.subtraction);
            this.Controls.Add(this.addition);
            this.Name = "Form1";
            this.Text = "Info";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button clear_number;
        private System.Windows.Forms.Button sub_from_memory;
        private System.Windows.Forms.Button add_from_memory;
        private System.Windows.Forms.Button memory_clear;
        private System.Windows.Forms.Button ten_in_power_of_number;
        private System.Windows.Forms.Button in_power_of_number;
        private System.Windows.Forms.Button in_power_of_3;
        private System.Windows.Forms.Button in_power_of_2;
        private System.Windows.Forms.Button exp;
        private System.Windows.Forms.Button modulo;
        private System.Windows.Forms.Button factorial;
        private System.Windows.Forms.Button clear_one;
        private System.Windows.Forms.Button clear_all;
        private System.Windows.Forms.Button solution;
        private System.Windows.Forms.Button division;
        private System.Windows.Forms.Button multiplication;
        private System.Windows.Forms.Button subtraction;
        private System.Windows.Forms.Button addition;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}

