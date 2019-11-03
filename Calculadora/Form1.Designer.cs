namespace Calculadora
{
    partial class calculadoraWd
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(calculadoraWd));
            this.square = new System.Windows.Forms.Button();
            this.onepart = new System.Windows.Forms.Button();
            this.percent = new System.Windows.Forms.Button();
            this.root = new System.Windows.Forms.Button();
            this.Clear = new System.Windows.Forms.Button();
            this.clearAll = new System.Windows.Forms.Button();
            this.divide = new System.Windows.Forms.Button();
            this.delete = new System.Windows.Forms.Button();
            this.eight = new System.Windows.Forms.Button();
            this.seven = new System.Windows.Forms.Button();
            this.multiply = new System.Windows.Forms.Button();
            this.nine = new System.Windows.Forms.Button();
            this.five = new System.Windows.Forms.Button();
            this.four = new System.Windows.Forms.Button();
            this.plus = new System.Windows.Forms.Button();
            this.six = new System.Windows.Forms.Button();
            this.two = new System.Windows.Forms.Button();
            this.one = new System.Windows.Forms.Button();
            this.minus = new System.Windows.Forms.Button();
            this.three = new System.Windows.Forms.Button();
            this.zero = new System.Windows.Forms.Button();
            this.equals = new System.Windows.Forms.Button();
            this.numBox1 = new System.Windows.Forms.RichTextBox();
            this.resultadoBox = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // square
            // 
            this.square.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.square.Location = new System.Drawing.Point(159, 144);
            this.square.Name = "square";
            this.square.Size = new System.Drawing.Size(68, 68);
            this.square.TabIndex = 3;
            this.square.Text = "x²";
            this.square.UseVisualStyleBackColor = true;
            this.square.Click += new System.EventHandler(this.Square_Click);
            // 
            // onepart
            // 
            this.onepart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.onepart.Location = new System.Drawing.Point(232, 144);
            this.onepart.Name = "onepart";
            this.onepart.Size = new System.Drawing.Size(68, 68);
            this.onepart.TabIndex = 4;
            this.onepart.Text = "1/x";
            this.onepart.UseVisualStyleBackColor = true;
            this.onepart.Click += new System.EventHandler(this.Onepart_Click);
            // 
            // percent
            // 
            this.percent.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.percent.Location = new System.Drawing.Point(11, 144);
            this.percent.Name = "percent";
            this.percent.Size = new System.Drawing.Size(68, 68);
            this.percent.TabIndex = 1;
            this.percent.Text = "%";
            this.percent.UseVisualStyleBackColor = true;
            this.percent.Click += new System.EventHandler(this.Percent_Click);
            // 
            // root
            // 
            this.root.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.root.Location = new System.Drawing.Point(85, 144);
            this.root.Name = "root";
            this.root.Size = new System.Drawing.Size(68, 68);
            this.root.TabIndex = 2;
            this.root.Text = "√";
            this.root.UseVisualStyleBackColor = true;
            this.root.Click += new System.EventHandler(this.Root_Click);
            // 
            // Clear
            // 
            this.Clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Clear.Location = new System.Drawing.Point(85, 218);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(68, 68);
            this.Clear.TabIndex = 6;
            this.Clear.Text = "C";
            this.Clear.UseVisualStyleBackColor = true;
            this.Clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // clearAll
            // 
            this.clearAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearAll.Location = new System.Drawing.Point(11, 218);
            this.clearAll.Name = "clearAll";
            this.clearAll.Size = new System.Drawing.Size(68, 68);
            this.clearAll.TabIndex = 5;
            this.clearAll.Text = "CA";
            this.clearAll.UseVisualStyleBackColor = true;
            this.clearAll.Click += new System.EventHandler(this.ClearAll_Click);
            // 
            // divide
            // 
            this.divide.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.divide.Location = new System.Drawing.Point(232, 218);
            this.divide.Name = "divide";
            this.divide.Size = new System.Drawing.Size(68, 68);
            this.divide.TabIndex = 8;
            this.divide.Text = "÷";
            this.divide.UseVisualStyleBackColor = true;
            this.divide.Click += new System.EventHandler(this.Divide_Click);
            // 
            // delete
            // 
            this.delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delete.Location = new System.Drawing.Point(159, 218);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(68, 68);
            this.delete.TabIndex = 7;
            this.delete.Text = "←";
            this.delete.UseVisualStyleBackColor = true;
            this.delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // eight
            // 
            this.eight.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.eight.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eight.Location = new System.Drawing.Point(85, 292);
            this.eight.Name = "eight";
            this.eight.Size = new System.Drawing.Size(68, 68);
            this.eight.TabIndex = 10;
            this.eight.Text = "8";
            this.eight.UseVisualStyleBackColor = false;
            this.eight.Click += new System.EventHandler(this.Eight_Click);
            // 
            // seven
            // 
            this.seven.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.seven.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.seven.Location = new System.Drawing.Point(11, 292);
            this.seven.Name = "seven";
            this.seven.Size = new System.Drawing.Size(68, 68);
            this.seven.TabIndex = 9;
            this.seven.Text = "7";
            this.seven.UseVisualStyleBackColor = false;
            this.seven.Click += new System.EventHandler(this.Seven_Click);
            // 
            // multiply
            // 
            this.multiply.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.multiply.Location = new System.Drawing.Point(232, 292);
            this.multiply.Name = "multiply";
            this.multiply.Size = new System.Drawing.Size(68, 68);
            this.multiply.TabIndex = 12;
            this.multiply.Text = "x";
            this.multiply.UseVisualStyleBackColor = true;
            this.multiply.Click += new System.EventHandler(this.Multiply_Click);
            // 
            // nine
            // 
            this.nine.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.nine.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nine.Location = new System.Drawing.Point(159, 292);
            this.nine.Name = "nine";
            this.nine.Size = new System.Drawing.Size(68, 68);
            this.nine.TabIndex = 11;
            this.nine.Text = "9";
            this.nine.UseVisualStyleBackColor = false;
            this.nine.Click += new System.EventHandler(this.Nine_Click);
            // 
            // five
            // 
            this.five.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.five.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.five.Location = new System.Drawing.Point(85, 366);
            this.five.Name = "five";
            this.five.Size = new System.Drawing.Size(68, 68);
            this.five.TabIndex = 14;
            this.five.Text = "5";
            this.five.UseVisualStyleBackColor = false;
            this.five.Click += new System.EventHandler(this.Five_Click);
            // 
            // four
            // 
            this.four.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.four.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.four.Location = new System.Drawing.Point(11, 366);
            this.four.Name = "four";
            this.four.Size = new System.Drawing.Size(68, 68);
            this.four.TabIndex = 13;
            this.four.Text = "4";
            this.four.UseVisualStyleBackColor = false;
            this.four.Click += new System.EventHandler(this.Four_Click);
            // 
            // plus
            // 
            this.plus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.plus.Location = new System.Drawing.Point(232, 366);
            this.plus.Name = "plus";
            this.plus.Size = new System.Drawing.Size(68, 68);
            this.plus.TabIndex = 16;
            this.plus.Text = "+";
            this.plus.UseVisualStyleBackColor = true;
            this.plus.Click += new System.EventHandler(this.Plus_Click);
            // 
            // six
            // 
            this.six.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.six.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.six.Location = new System.Drawing.Point(159, 366);
            this.six.Name = "six";
            this.six.Size = new System.Drawing.Size(68, 68);
            this.six.TabIndex = 15;
            this.six.Text = "6";
            this.six.UseVisualStyleBackColor = false;
            this.six.Click += new System.EventHandler(this.Six_Click);
            // 
            // two
            // 
            this.two.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.two.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.two.Location = new System.Drawing.Point(85, 441);
            this.two.Name = "two";
            this.two.Size = new System.Drawing.Size(68, 68);
            this.two.TabIndex = 18;
            this.two.Text = "2";
            this.two.UseVisualStyleBackColor = false;
            this.two.Click += new System.EventHandler(this.Two_Click);
            // 
            // one
            // 
            this.one.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.one.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.one.Location = new System.Drawing.Point(11, 441);
            this.one.Name = "one";
            this.one.Size = new System.Drawing.Size(68, 68);
            this.one.TabIndex = 17;
            this.one.Text = "1";
            this.one.UseVisualStyleBackColor = false;
            this.one.Click += new System.EventHandler(this.One_Click);
            // 
            // minus
            // 
            this.minus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minus.Location = new System.Drawing.Point(232, 441);
            this.minus.Name = "minus";
            this.minus.Size = new System.Drawing.Size(68, 68);
            this.minus.TabIndex = 20;
            this.minus.Text = "-";
            this.minus.UseVisualStyleBackColor = true;
            this.minus.Click += new System.EventHandler(this.Minus_Click);
            // 
            // three
            // 
            this.three.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.three.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.three.Location = new System.Drawing.Point(159, 441);
            this.three.Name = "three";
            this.three.Size = new System.Drawing.Size(68, 68);
            this.three.TabIndex = 19;
            this.three.Text = "3";
            this.three.UseVisualStyleBackColor = false;
            this.three.Click += new System.EventHandler(this.Three_Click);
            // 
            // zero
            // 
            this.zero.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.zero.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.zero.Location = new System.Drawing.Point(12, 515);
            this.zero.Name = "zero";
            this.zero.Size = new System.Drawing.Size(141, 68);
            this.zero.TabIndex = 22;
            this.zero.Text = "0";
            this.zero.UseVisualStyleBackColor = false;
            this.zero.Click += new System.EventHandler(this.Zero_Click);
            // 
            // equals
            // 
            this.equals.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.equals.Location = new System.Drawing.Point(159, 515);
            this.equals.Name = "equals";
            this.equals.Size = new System.Drawing.Size(141, 68);
            this.equals.TabIndex = 24;
            this.equals.Text = "=";
            this.equals.UseVisualStyleBackColor = true;
            this.equals.Click += new System.EventHandler(this.Equals_Click);
            // 
            // numBox1
            // 
            this.numBox1.BackColor = System.Drawing.SystemColors.Window;
            this.numBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.numBox1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.numBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numBox1.Location = new System.Drawing.Point(11, 12);
            this.numBox1.Name = "numBox1";
            this.numBox1.ReadOnly = true;
            this.numBox1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.numBox1.Size = new System.Drawing.Size(289, 67);
            this.numBox1.TabIndex = 0;
            this.numBox1.Text = "";
            // 
            // resultadoBox
            // 
            this.resultadoBox.BackColor = System.Drawing.SystemColors.Window;
            this.resultadoBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.resultadoBox.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.resultadoBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultadoBox.Location = new System.Drawing.Point(11, 77);
            this.resultadoBox.Name = "resultadoBox";
            this.resultadoBox.ReadOnly = true;
            this.resultadoBox.Size = new System.Drawing.Size(289, 61);
            this.resultadoBox.TabIndex = 26;
            this.resultadoBox.Text = "";
            // 
            // calculadoraWd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(311, 597);
            this.Controls.Add(this.resultadoBox);
            this.Controls.Add(this.numBox1);
            this.Controls.Add(this.zero);
            this.Controls.Add(this.equals);
            this.Controls.Add(this.two);
            this.Controls.Add(this.one);
            this.Controls.Add(this.minus);
            this.Controls.Add(this.three);
            this.Controls.Add(this.five);
            this.Controls.Add(this.four);
            this.Controls.Add(this.plus);
            this.Controls.Add(this.six);
            this.Controls.Add(this.eight);
            this.Controls.Add(this.seven);
            this.Controls.Add(this.multiply);
            this.Controls.Add(this.nine);
            this.Controls.Add(this.Clear);
            this.Controls.Add(this.clearAll);
            this.Controls.Add(this.divide);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.root);
            this.Controls.Add(this.percent);
            this.Controls.Add(this.onepart);
            this.Controls.Add(this.square);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "calculadoraWd";
            this.Text = "Calculadora";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button square;
        private System.Windows.Forms.Button onepart;
        private System.Windows.Forms.Button percent;
        private System.Windows.Forms.Button root;
        private System.Windows.Forms.Button Clear;
        private System.Windows.Forms.Button clearAll;
        private System.Windows.Forms.Button divide;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.Button eight;
        private System.Windows.Forms.Button seven;
        private System.Windows.Forms.Button multiply;
        private System.Windows.Forms.Button nine;
        private System.Windows.Forms.Button five;
        private System.Windows.Forms.Button four;
        private System.Windows.Forms.Button plus;
        private System.Windows.Forms.Button six;
        private System.Windows.Forms.Button two;
        private System.Windows.Forms.Button one;
        private System.Windows.Forms.Button minus;
        private System.Windows.Forms.Button three;
        private System.Windows.Forms.Button zero;
        private System.Windows.Forms.Button equals;
        private System.Windows.Forms.RichTextBox numBox1;
        private System.Windows.Forms.RichTextBox resultadoBox;
    }
}

