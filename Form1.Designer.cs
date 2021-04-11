
namespace formCalculator
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.calculateTextBox = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.button20 = new System.Windows.Forms.Button();
            this.button19 = new System.Windows.Forms.Button();
            this.button18 = new System.Windows.Forms.Button();
            this.button17 = new System.Windows.Forms.Button();
            this.numberTwo = new System.Windows.Forms.Button();
            this.numberOne = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.numberThree = new System.Windows.Forms.Button();
            this.numberSix = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.numberFive = new System.Windows.Forms.Button();
            this.numberFour = new System.Windows.Forms.Button();
            this.numberEight = new System.Windows.Forms.Button();
            this.numberSeven = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(3, 105);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(86, 96);
            this.button1.TabIndex = 1;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // calculateTextBox
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.calculateTextBox, 4);
            this.calculateTextBox.Font = new System.Drawing.Font("Segoe UI", 42F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.calculateTextBox.Location = new System.Drawing.Point(3, 3);
            this.calculateTextBox.MinimumSize = new System.Drawing.Size(365, 75);
            this.calculateTextBox.Name = "calculateTextBox";
            this.calculateTextBox.Size = new System.Drawing.Size(365, 82);
            this.calculateTextBox.TabIndex = 0;
            this.calculateTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.calculateTextBox.TextChanged += new System.EventHandler(this.calculateInput_changed_textbox);
            // 
            // button2
            // 
            this.button2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button2.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button2.Location = new System.Drawing.Point(95, 105);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(86, 96);
            this.button2.TabIndex = 2;
            this.button2.Text = "/";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.btnDivide_Click);
            // 
            // button3
            // 
            this.button3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button3.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button3.Location = new System.Drawing.Point(187, 105);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(86, 96);
            this.button3.TabIndex = 3;
            this.button3.Text = "C";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.btnClearResult_Click);
            // 
            // button4
            // 
            this.button4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button4.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button4.Location = new System.Drawing.Point(279, 105);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(88, 96);
            this.button4.TabIndex = 4;
            this.button4.Text = "<-";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.btnRemoveLastChar_Click);
            // 
            // button5
            // 
            this.button5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button5.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button5.Location = new System.Drawing.Point(187, 207);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(86, 96);
            this.button5.TabIndex = 5;
            this.button5.Text = "9";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.btnNine_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.button20, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.button19, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.button18, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.button17, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.numberTwo, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.numberOne, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.button14, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.numberThree, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.numberSix, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.button11, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.numberFive, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.numberFour, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.numberEight, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.numberSeven, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.button6, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.button5, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.button4, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.button3, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.button2, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.calculateTextBox, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.button1, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.MinimumSize = new System.Drawing.Size(0, 50);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(370, 612);
            this.tableLayoutPanel1.TabIndex = 0;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // button20
            // 
            this.button20.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button20.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button20.Location = new System.Drawing.Point(95, 513);
            this.button20.Name = "button20";
            this.button20.Size = new System.Drawing.Size(86, 96);
            this.button20.TabIndex = 20;
            this.button20.Text = "0";
            this.button20.UseVisualStyleBackColor = true;
            this.button20.Click += new System.EventHandler(this.btnClearResult_Click);
            // 
            // button19
            // 
            this.button19.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button19.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button19.Location = new System.Drawing.Point(3, 513);
            this.button19.Name = "button19";
            this.button19.Size = new System.Drawing.Size(86, 96);
            this.button19.TabIndex = 19;
            this.button19.UseVisualStyleBackColor = true;
            // 
            // button18
            // 
            this.button18.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button18.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button18.Location = new System.Drawing.Point(279, 513);
            this.button18.Name = "button18";
            this.button18.Size = new System.Drawing.Size(88, 96);
            this.button18.TabIndex = 18;
            this.button18.Text = "=";
            this.button18.UseVisualStyleBackColor = true;
            this.button18.Click += new System.EventHandler(this.btnEqual_Click);
            // 
            // button17
            // 
            this.button17.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button17.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button17.Location = new System.Drawing.Point(187, 513);
            this.button17.Name = "button17";
            this.button17.Size = new System.Drawing.Size(86, 96);
            this.button17.TabIndex = 17;
            this.button17.Text = ",";
            this.button17.UseVisualStyleBackColor = true;
            this.button17.Click += new System.EventHandler(this.btnDot_Click);
            // 
            // numberTwo
            // 
            this.numberTwo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.numberTwo.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.numberTwo.Location = new System.Drawing.Point(95, 411);
            this.numberTwo.Name = "numberTwo";
            this.numberTwo.Size = new System.Drawing.Size(86, 96);
            this.numberTwo.TabIndex = 16;
            this.numberTwo.Text = "2";
            this.numberTwo.UseVisualStyleBackColor = true;
            this.numberTwo.Click += new System.EventHandler(this.btnTwo_Click);
            // 
            // numberOne
            // 
            this.numberOne.Dock = System.Windows.Forms.DockStyle.Fill;
            this.numberOne.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.numberOne.Location = new System.Drawing.Point(3, 411);
            this.numberOne.Name = "numberOne";
            this.numberOne.Size = new System.Drawing.Size(86, 96);
            this.numberOne.TabIndex = 15;
            this.numberOne.Text = "1";
            this.numberOne.UseVisualStyleBackColor = true;
            this.numberOne.Click += new System.EventHandler(this.btnOne_Click);
            // 
            // button14
            // 
            this.button14.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button14.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button14.Location = new System.Drawing.Point(279, 411);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(88, 96);
            this.button14.TabIndex = 14;
            this.button14.Text = "+";
            this.button14.UseVisualStyleBackColor = true;
            this.button14.Click += new System.EventHandler(this.btnAddition_Click);
            // 
            // numberThree
            // 
            this.numberThree.Dock = System.Windows.Forms.DockStyle.Fill;
            this.numberThree.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.numberThree.Location = new System.Drawing.Point(187, 411);
            this.numberThree.Name = "numberThree";
            this.numberThree.Size = new System.Drawing.Size(86, 96);
            this.numberThree.TabIndex = 13;
            this.numberThree.Text = "3";
            this.numberThree.UseVisualStyleBackColor = true;
            this.numberThree.Click += new System.EventHandler(this.btnThree_Click);
            // 
            // numberSix
            // 
            this.numberSix.Dock = System.Windows.Forms.DockStyle.Fill;
            this.numberSix.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.numberSix.Location = new System.Drawing.Point(187, 309);
            this.numberSix.Name = "numberSix";
            this.numberSix.Size = new System.Drawing.Size(86, 96);
            this.numberSix.TabIndex = 12;
            this.numberSix.Text = "6";
            this.numberSix.UseVisualStyleBackColor = true;
            this.numberSix.Click += new System.EventHandler(this.btnSix_Click);
            // 
            // button11
            // 
            this.button11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button11.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button11.Location = new System.Drawing.Point(279, 309);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(88, 96);
            this.button11.TabIndex = 11;
            this.button11.Text = "-";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.btnSubtract_Click);
            // 
            // numberFive
            // 
            this.numberFive.Dock = System.Windows.Forms.DockStyle.Fill;
            this.numberFive.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.numberFive.Location = new System.Drawing.Point(95, 309);
            this.numberFive.Name = "numberFive";
            this.numberFive.Size = new System.Drawing.Size(86, 96);
            this.numberFive.TabIndex = 10;
            this.numberFive.Text = "5";
            this.numberFive.UseVisualStyleBackColor = true;
            this.numberFive.Click += new System.EventHandler(this.btnFive_Click);
            // 
            // numberFour
            // 
            this.numberFour.Dock = System.Windows.Forms.DockStyle.Fill;
            this.numberFour.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.numberFour.Location = new System.Drawing.Point(3, 309);
            this.numberFour.Name = "numberFour";
            this.numberFour.Size = new System.Drawing.Size(86, 96);
            this.numberFour.TabIndex = 9;
            this.numberFour.Text = "4";
            this.numberFour.UseVisualStyleBackColor = true;
            this.numberFour.Click += new System.EventHandler(this.btnFour_Click);
            // 
            // numberEight
            // 
            this.numberEight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.numberEight.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.numberEight.Location = new System.Drawing.Point(95, 207);
            this.numberEight.Name = "numberEight";
            this.numberEight.Size = new System.Drawing.Size(86, 96);
            this.numberEight.TabIndex = 8;
            this.numberEight.Text = "8";
            this.numberEight.UseVisualStyleBackColor = true;
            this.numberEight.Click += new System.EventHandler(this.btnEight_Click);
            // 
            // numberSeven
            // 
            this.numberSeven.Dock = System.Windows.Forms.DockStyle.Fill;
            this.numberSeven.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.numberSeven.Location = new System.Drawing.Point(3, 207);
            this.numberSeven.Name = "numberSeven";
            this.numberSeven.Size = new System.Drawing.Size(86, 96);
            this.numberSeven.TabIndex = 7;
            this.numberSeven.Text = "7";
            this.numberSeven.UseVisualStyleBackColor = true;
            this.numberSeven.Click += new System.EventHandler(this.btnSeven_Click);
            // 
            // button6
            // 
            this.button6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button6.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button6.Location = new System.Drawing.Point(279, 207);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(88, 96);
            this.button6.TabIndex = 6;
            this.button6.Text = "X";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.btnMultiply_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(370, 612);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox calculateTextBox;
        protected System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button numberSix;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button numberFive;
        private System.Windows.Forms.Button numberFour;
        private System.Windows.Forms.Button numberEight;
        private System.Windows.Forms.Button numberSeven;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button numberTwo;
        private System.Windows.Forms.Button numberOne;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Button numberThree;
        private System.Windows.Forms.Button button20;
        private System.Windows.Forms.Button button19;
        private System.Windows.Forms.Button button18;
        private System.Windows.Forms.Button button17;
        private System.Windows.Forms.Button one;
        private System.Windows.Forms.Button o;
    }
}

