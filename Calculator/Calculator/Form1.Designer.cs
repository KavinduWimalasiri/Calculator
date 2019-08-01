namespace Calculator
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
            this.btnClearEntry = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnDivide = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnMultiply = new System.Windows.Forms.Button();
            this.btnNine = new System.Windows.Forms.Button();
            this.btnEight = new System.Windows.Forms.Button();
            this.btnSeven = new System.Windows.Forms.Button();
            this.btnSubstraction = new System.Windows.Forms.Button();
            this.btnSix = new System.Windows.Forms.Button();
            this.btnFive = new System.Windows.Forms.Button();
            this.btnFour = new System.Windows.Forms.Button();
            this.btnAddition = new System.Windows.Forms.Button();
            this.btnThree = new System.Windows.Forms.Button();
            this.btnTwo = new System.Windows.Forms.Button();
            this.btnOne = new System.Windows.Forms.Button();
            this.btnEqual = new System.Windows.Forms.Button();
            this.btnDecimal = new System.Windows.Forms.Button();
            this.btnZero = new System.Windows.Forms.Button();
            this.btnPlusMinus = new System.Windows.Forms.Button();
            this.textDisplay1 = new System.Windows.Forms.TextBox();
            this.textDisplay2 = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnClearEntry
            // 
            this.btnClearEntry.FlatAppearance.BorderSize = 0;
            this.btnClearEntry.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClearEntry.ForeColor = System.Drawing.Color.White;
            this.btnClearEntry.Location = new System.Drawing.Point(4, 1);
            this.btnClearEntry.Name = "btnClearEntry";
            this.btnClearEntry.Size = new System.Drawing.Size(84, 73);
            this.btnClearEntry.TabIndex = 0;
            this.btnClearEntry.Text = "CE";
            this.btnClearEntry.UseVisualStyleBackColor = true;
            this.btnClearEntry.Click += new System.EventHandler(this.ALLBtn_Click);
            // 
            // btnClear
            // 
            this.btnClear.FlatAppearance.BorderSize = 0;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.Location = new System.Drawing.Point(94, 1);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(84, 73);
            this.btnClear.TabIndex = 1;
            this.btnClear.Text = "C";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.ALLBtn_Click);
            // 
            // btnDivide
            // 
            this.btnDivide.FlatAppearance.BorderSize = 0;
            this.btnDivide.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDivide.ForeColor = System.Drawing.Color.White;
            this.btnDivide.Location = new System.Drawing.Point(274, 1);
            this.btnDivide.Name = "btnDivide";
            this.btnDivide.Size = new System.Drawing.Size(84, 73);
            this.btnDivide.TabIndex = 3;
            this.btnDivide.Text = "/";
            this.btnDivide.UseVisualStyleBackColor = true;
            this.btnDivide.Click += new System.EventHandler(this.Operation_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(184, 1);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(84, 73);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "DEL";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.ALLBtn_Click);
            // 
            // btnMultiply
            // 
            this.btnMultiply.FlatAppearance.BorderSize = 0;
            this.btnMultiply.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMultiply.ForeColor = System.Drawing.Color.White;
            this.btnMultiply.Location = new System.Drawing.Point(274, 80);
            this.btnMultiply.Name = "btnMultiply";
            this.btnMultiply.Size = new System.Drawing.Size(84, 73);
            this.btnMultiply.TabIndex = 7;
            this.btnMultiply.Text = "x";
            this.btnMultiply.UseVisualStyleBackColor = true;
            this.btnMultiply.Click += new System.EventHandler(this.Operation_Click);
            // 
            // btnNine
            // 
            this.btnNine.FlatAppearance.BorderSize = 0;
            this.btnNine.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNine.ForeColor = System.Drawing.Color.White;
            this.btnNine.Location = new System.Drawing.Point(184, 80);
            this.btnNine.Name = "btnNine";
            this.btnNine.Size = new System.Drawing.Size(84, 73);
            this.btnNine.TabIndex = 6;
            this.btnNine.Text = "9";
            this.btnNine.UseVisualStyleBackColor = true;
            this.btnNine.Click += new System.EventHandler(this.ALLBtn_Click);
            // 
            // btnEight
            // 
            this.btnEight.FlatAppearance.BorderSize = 0;
            this.btnEight.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEight.ForeColor = System.Drawing.Color.White;
            this.btnEight.Location = new System.Drawing.Point(94, 80);
            this.btnEight.Name = "btnEight";
            this.btnEight.Size = new System.Drawing.Size(84, 73);
            this.btnEight.TabIndex = 5;
            this.btnEight.Text = "8";
            this.btnEight.UseVisualStyleBackColor = true;
            this.btnEight.Click += new System.EventHandler(this.ALLBtn_Click);
            // 
            // btnSeven
            // 
            this.btnSeven.FlatAppearance.BorderSize = 0;
            this.btnSeven.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSeven.ForeColor = System.Drawing.Color.White;
            this.btnSeven.Location = new System.Drawing.Point(4, 80);
            this.btnSeven.Name = "btnSeven";
            this.btnSeven.Size = new System.Drawing.Size(84, 73);
            this.btnSeven.TabIndex = 4;
            this.btnSeven.Text = "7";
            this.btnSeven.UseVisualStyleBackColor = true;
            this.btnSeven.Click += new System.EventHandler(this.ALLBtn_Click);
            // 
            // btnSubstraction
            // 
            this.btnSubstraction.FlatAppearance.BorderSize = 0;
            this.btnSubstraction.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubstraction.ForeColor = System.Drawing.Color.White;
            this.btnSubstraction.Location = new System.Drawing.Point(274, 159);
            this.btnSubstraction.Name = "btnSubstraction";
            this.btnSubstraction.Size = new System.Drawing.Size(84, 73);
            this.btnSubstraction.TabIndex = 11;
            this.btnSubstraction.Text = "-";
            this.btnSubstraction.UseVisualStyleBackColor = true;
            this.btnSubstraction.Click += new System.EventHandler(this.Operation_Click);
            // 
            // btnSix
            // 
            this.btnSix.FlatAppearance.BorderSize = 0;
            this.btnSix.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSix.ForeColor = System.Drawing.Color.White;
            this.btnSix.Location = new System.Drawing.Point(184, 159);
            this.btnSix.Name = "btnSix";
            this.btnSix.Size = new System.Drawing.Size(84, 73);
            this.btnSix.TabIndex = 10;
            this.btnSix.Text = "6";
            this.btnSix.UseVisualStyleBackColor = true;
            this.btnSix.Click += new System.EventHandler(this.ALLBtn_Click);
            // 
            // btnFive
            // 
            this.btnFive.FlatAppearance.BorderSize = 0;
            this.btnFive.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFive.ForeColor = System.Drawing.Color.White;
            this.btnFive.Location = new System.Drawing.Point(94, 159);
            this.btnFive.Name = "btnFive";
            this.btnFive.Size = new System.Drawing.Size(84, 73);
            this.btnFive.TabIndex = 9;
            this.btnFive.Text = "5";
            this.btnFive.UseVisualStyleBackColor = true;
            this.btnFive.Click += new System.EventHandler(this.ALLBtn_Click);
            // 
            // btnFour
            // 
            this.btnFour.FlatAppearance.BorderSize = 0;
            this.btnFour.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFour.ForeColor = System.Drawing.Color.White;
            this.btnFour.Location = new System.Drawing.Point(4, 159);
            this.btnFour.Name = "btnFour";
            this.btnFour.Size = new System.Drawing.Size(84, 73);
            this.btnFour.TabIndex = 8;
            this.btnFour.Text = "4";
            this.btnFour.UseVisualStyleBackColor = true;
            this.btnFour.Click += new System.EventHandler(this.ALLBtn_Click);
            // 
            // btnAddition
            // 
            this.btnAddition.FlatAppearance.BorderSize = 0;
            this.btnAddition.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddition.ForeColor = System.Drawing.Color.White;
            this.btnAddition.Location = new System.Drawing.Point(274, 238);
            this.btnAddition.Name = "btnAddition";
            this.btnAddition.Size = new System.Drawing.Size(84, 73);
            this.btnAddition.TabIndex = 15;
            this.btnAddition.Text = "+";
            this.btnAddition.UseVisualStyleBackColor = true;
            this.btnAddition.Click += new System.EventHandler(this.Operation_Click);
            // 
            // btnThree
            // 
            this.btnThree.FlatAppearance.BorderSize = 0;
            this.btnThree.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThree.ForeColor = System.Drawing.Color.White;
            this.btnThree.Location = new System.Drawing.Point(184, 238);
            this.btnThree.Name = "btnThree";
            this.btnThree.Size = new System.Drawing.Size(84, 73);
            this.btnThree.TabIndex = 14;
            this.btnThree.Text = "3";
            this.btnThree.UseVisualStyleBackColor = true;
            this.btnThree.Click += new System.EventHandler(this.ALLBtn_Click);
            // 
            // btnTwo
            // 
            this.btnTwo.FlatAppearance.BorderSize = 0;
            this.btnTwo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTwo.ForeColor = System.Drawing.Color.White;
            this.btnTwo.Location = new System.Drawing.Point(94, 238);
            this.btnTwo.Name = "btnTwo";
            this.btnTwo.Size = new System.Drawing.Size(84, 73);
            this.btnTwo.TabIndex = 13;
            this.btnTwo.Text = "2";
            this.btnTwo.UseVisualStyleBackColor = true;
            this.btnTwo.Click += new System.EventHandler(this.ALLBtn_Click);
            // 
            // btnOne
            // 
            this.btnOne.FlatAppearance.BorderSize = 0;
            this.btnOne.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOne.ForeColor = System.Drawing.Color.White;
            this.btnOne.Location = new System.Drawing.Point(4, 238);
            this.btnOne.Name = "btnOne";
            this.btnOne.Size = new System.Drawing.Size(84, 73);
            this.btnOne.TabIndex = 12;
            this.btnOne.Text = "1";
            this.btnOne.UseVisualStyleBackColor = true;
            this.btnOne.Click += new System.EventHandler(this.ALLBtn_Click);
            // 
            // btnEqual
            // 
            this.btnEqual.FlatAppearance.BorderSize = 0;
            this.btnEqual.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEqual.ForeColor = System.Drawing.Color.White;
            this.btnEqual.Location = new System.Drawing.Point(274, 317);
            this.btnEqual.Name = "btnEqual";
            this.btnEqual.Size = new System.Drawing.Size(84, 73);
            this.btnEqual.TabIndex = 19;
            this.btnEqual.Text = "=";
            this.btnEqual.UseVisualStyleBackColor = true;
            this.btnEqual.Click += new System.EventHandler(this.Operation_Click);
            // 
            // btnDecimal
            // 
            this.btnDecimal.FlatAppearance.BorderSize = 0;
            this.btnDecimal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDecimal.ForeColor = System.Drawing.Color.White;
            this.btnDecimal.Location = new System.Drawing.Point(184, 317);
            this.btnDecimal.Name = "btnDecimal";
            this.btnDecimal.Size = new System.Drawing.Size(84, 73);
            this.btnDecimal.TabIndex = 18;
            this.btnDecimal.Text = ".";
            this.btnDecimal.UseVisualStyleBackColor = true;
            this.btnDecimal.Click += new System.EventHandler(this.ALLBtn_Click);
            // 
            // btnZero
            // 
            this.btnZero.FlatAppearance.BorderSize = 0;
            this.btnZero.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnZero.ForeColor = System.Drawing.Color.White;
            this.btnZero.Location = new System.Drawing.Point(94, 317);
            this.btnZero.Name = "btnZero";
            this.btnZero.Size = new System.Drawing.Size(84, 73);
            this.btnZero.TabIndex = 17;
            this.btnZero.Text = "0";
            this.btnZero.UseVisualStyleBackColor = true;
            this.btnZero.Click += new System.EventHandler(this.ALLBtn_Click);
            // 
            // btnPlusMinus
            // 
            this.btnPlusMinus.FlatAppearance.BorderSize = 0;
            this.btnPlusMinus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlusMinus.ForeColor = System.Drawing.Color.White;
            this.btnPlusMinus.Location = new System.Drawing.Point(4, 317);
            this.btnPlusMinus.Name = "btnPlusMinus";
            this.btnPlusMinus.Size = new System.Drawing.Size(84, 73);
            this.btnPlusMinus.TabIndex = 16;
            this.btnPlusMinus.Text = "+/-";
            this.btnPlusMinus.UseVisualStyleBackColor = true;
            this.btnPlusMinus.Click += new System.EventHandler(this.ALLBtn_Click);
            // 
            // textDisplay1
            // 
            this.textDisplay1.BackColor = System.Drawing.Color.Teal;
            this.textDisplay1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textDisplay1.CausesValidation = false;
            this.textDisplay1.Font = new System.Drawing.Font("Calibri", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textDisplay1.ForeColor = System.Drawing.Color.White;
            this.textDisplay1.Location = new System.Drawing.Point(3, 3);
            this.textDisplay1.Multiline = true;
            this.textDisplay1.Name = "textDisplay1";
            this.textDisplay1.Size = new System.Drawing.Size(354, 48);
            this.textDisplay1.TabIndex = 20;
            this.textDisplay1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textDisplay1.TextChanged += new System.EventHandler(this.TextBox1_TextChanged);
            // 
            // textDisplay2
            // 
            this.textDisplay2.BackColor = System.Drawing.Color.Teal;
            this.textDisplay2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textDisplay2.CausesValidation = false;
            this.textDisplay2.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textDisplay2.ForeColor = System.Drawing.Color.White;
            this.textDisplay2.Location = new System.Drawing.Point(3, 57);
            this.textDisplay2.Multiline = true;
            this.textDisplay2.Name = "textDisplay2";
            this.textDisplay2.Size = new System.Drawing.Size(354, 49);
            this.textDisplay2.TabIndex = 21;
            this.textDisplay2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textDisplay2.TextChanged += new System.EventHandler(this.TextBox2_TextChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Teal;
            this.panel1.Controls.Add(this.textDisplay1);
            this.panel1.Controls.Add(this.textDisplay2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(362, 109);
            this.panel1.TabIndex = 22;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel1_Paint);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel2.Controls.Add(this.btnClearEntry);
            this.panel2.Controls.Add(this.btnEqual);
            this.panel2.Controls.Add(this.btnClear);
            this.panel2.Controls.Add(this.btnDecimal);
            this.panel2.Controls.Add(this.btnDelete);
            this.panel2.Controls.Add(this.btnZero);
            this.panel2.Controls.Add(this.btnDivide);
            this.panel2.Controls.Add(this.btnPlusMinus);
            this.panel2.Controls.Add(this.btnSeven);
            this.panel2.Controls.Add(this.btnAddition);
            this.panel2.Controls.Add(this.btnEight);
            this.panel2.Controls.Add(this.btnThree);
            this.panel2.Controls.Add(this.btnNine);
            this.panel2.Controls.Add(this.btnTwo);
            this.panel2.Controls.Add(this.btnMultiply);
            this.panel2.Controls.Add(this.btnOne);
            this.panel2.Controls.Add(this.btnFour);
            this.panel2.Controls.Add(this.btnSubstraction);
            this.panel2.Controls.Add(this.btnFive);
            this.panel2.Controls.Add(this.btnSix);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 109);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(362, 401);
            this.panel2.TabIndex = 22;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel2_Paint);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.CausesValidation = false;
            this.ClientSize = new System.Drawing.Size(362, 510);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "C# Calculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnClearEntry;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnDivide;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnMultiply;
        private System.Windows.Forms.Button btnNine;
        private System.Windows.Forms.Button btnEight;
        private System.Windows.Forms.Button btnSeven;
        private System.Windows.Forms.Button btnSubstraction;
        private System.Windows.Forms.Button btnSix;
        private System.Windows.Forms.Button btnFive;
        private System.Windows.Forms.Button btnFour;
        private System.Windows.Forms.Button btnAddition;
        private System.Windows.Forms.Button btnThree;
        private System.Windows.Forms.Button btnTwo;
        private System.Windows.Forms.Button btnOne;
        private System.Windows.Forms.Button btnEqual;
        private System.Windows.Forms.Button btnDecimal;
        private System.Windows.Forms.Button btnZero;
        private System.Windows.Forms.Button btnPlusMinus;
        private System.Windows.Forms.TextBox textDisplay1;
        private System.Windows.Forms.TextBox textDisplay2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
    }
}

