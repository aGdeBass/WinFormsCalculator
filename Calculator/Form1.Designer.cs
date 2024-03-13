namespace Calculator
{
    partial class Calculator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Calculator));
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.PnlUp = new System.Windows.Forms.Panel();
            this.hide = new System.Windows.Forms.Button();
            this.BtnExit = new System.Windows.Forms.Button();
            this.TxtDisplay = new System.Windows.Forms.TextBox();
            this.one = new System.Windows.Forms.Button();
            this.two = new System.Windows.Forms.Button();
            this.three = new System.Windows.Forms.Button();
            this.four = new System.Windows.Forms.Button();
            this.five = new System.Windows.Forms.Button();
            this.six = new System.Windows.Forms.Button();
            this.seven = new System.Windows.Forms.Button();
            this.eight = new System.Windows.Forms.Button();
            this.nine = new System.Windows.Forms.Button();
            this.zero = new System.Windows.Forms.Button();
            this.equalsBtn = new System.Windows.Forms.Button();
            this.plusBtn = new System.Windows.Forms.Button();
            this.minBtn = new System.Windows.Forms.Button();
            this.mulBtn = new System.Windows.Forms.Button();
            this.divBtn = new System.Windows.Forms.Button();
            this.ceBtn = new System.Windows.Forms.Button();
            this.dotBtn = new System.Windows.Forms.Button();
            this.backspace = new System.Windows.Forms.Button();
            this.PnlUp.SuspendLayout();
            this.SuspendLayout();
            // 
            // PnlUp
            // 
            this.PnlUp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.PnlUp.Controls.Add(this.hide);
            this.PnlUp.Controls.Add(this.BtnExit);
            this.PnlUp.Dock = System.Windows.Forms.DockStyle.Top;
            this.PnlUp.Location = new System.Drawing.Point(0, 0);
            this.PnlUp.Name = "PnlUp";
            this.PnlUp.Size = new System.Drawing.Size(430, 34);
            this.PnlUp.TabIndex = 0;
            this.PnlUp.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PnlUp_MouseDown);
            this.PnlUp.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PnlUp_MouseMove);
            this.PnlUp.MouseUp += new System.Windows.Forms.MouseEventHandler(this.PnlUp_MouseUp);
            // 
            // hide
            // 
            this.hide.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.hide.Cursor = System.Windows.Forms.Cursors.Hand;
            this.hide.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.hide.Dock = System.Windows.Forms.DockStyle.Right;
            this.hide.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.hide.FlatAppearance.BorderSize = 0;
            this.hide.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.hide.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue;
            this.hide.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hide.Image = global::Calculator.Properties.Resources.svermi;
            this.hide.Location = new System.Drawing.Point(258, 0);
            this.hide.Margin = new System.Windows.Forms.Padding(0);
            this.hide.Name = "hide";
            this.hide.Size = new System.Drawing.Size(81, 34);
            this.hide.TabIndex = 1;
            this.hide.UseVisualStyleBackColor = false;
            this.hide.Click += new System.EventHandler(this.hide_Click);
            // 
            // BtnExit
            // 
            this.BtnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.BtnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnExit.Dock = System.Windows.Forms.DockStyle.Right;
            this.BtnExit.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.BtnExit.FlatAppearance.BorderSize = 0;
            this.BtnExit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.BtnExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.BtnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnExit.Image = global::Calculator.Properties.Resources.BtnExit1;
            this.BtnExit.Location = new System.Drawing.Point(339, 0);
            this.BtnExit.Margin = new System.Windows.Forms.Padding(0);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(91, 34);
            this.BtnExit.TabIndex = 0;
            this.BtnExit.UseVisualStyleBackColor = false;
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // TxtDisplay
            // 
            this.TxtDisplay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.TxtDisplay.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtDisplay.Dock = System.Windows.Forms.DockStyle.Top;
            this.TxtDisplay.Font = new System.Drawing.Font("Gadugi", 42F);
            this.TxtDisplay.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.TxtDisplay.Location = new System.Drawing.Point(0, 34);
            this.TxtDisplay.Margin = new System.Windows.Forms.Padding(0);
            this.TxtDisplay.MaxLength = 9;
            this.TxtDisplay.Multiline = true;
            this.TxtDisplay.Name = "TxtDisplay";
            this.TxtDisplay.ReadOnly = true;
            this.TxtDisplay.Size = new System.Drawing.Size(430, 66);
            this.TxtDisplay.TabIndex = 1;
            this.TxtDisplay.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // one
            // 
            this.one.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.one.Cursor = System.Windows.Forms.Cursors.Hand;
            this.one.FlatAppearance.BorderSize = 0;
            this.one.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.one.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.one.Location = new System.Drawing.Point(15, 117);
            this.one.Name = "one";
            this.one.Size = new System.Drawing.Size(75, 75);
            this.one.TabIndex = 2;
            this.one.Text = "1";
            this.one.UseVisualStyleBackColor = false;
            this.one.Click += new System.EventHandler(this.BtnNum_Click);
            // 
            // two
            // 
            this.two.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.two.Cursor = System.Windows.Forms.Cursors.Hand;
            this.two.FlatAppearance.BorderSize = 0;
            this.two.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.two.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.two.Location = new System.Drawing.Point(96, 117);
            this.two.Name = "two";
            this.two.Size = new System.Drawing.Size(75, 75);
            this.two.TabIndex = 3;
            this.two.Text = "2";
            this.two.UseVisualStyleBackColor = false;
            this.two.Click += new System.EventHandler(this.BtnNum_Click);
            // 
            // three
            // 
            this.three.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.three.Cursor = System.Windows.Forms.Cursors.Hand;
            this.three.FlatAppearance.BorderSize = 0;
            this.three.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.three.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.three.Location = new System.Drawing.Point(177, 117);
            this.three.Name = "three";
            this.three.Size = new System.Drawing.Size(75, 75);
            this.three.TabIndex = 4;
            this.three.Text = "3";
            this.three.UseVisualStyleBackColor = false;
            this.three.Click += new System.EventHandler(this.BtnNum_Click);
            // 
            // four
            // 
            this.four.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.four.Cursor = System.Windows.Forms.Cursors.Hand;
            this.four.FlatAppearance.BorderSize = 0;
            this.four.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.four.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.four.Location = new System.Drawing.Point(15, 198);
            this.four.Name = "four";
            this.four.Size = new System.Drawing.Size(75, 75);
            this.four.TabIndex = 5;
            this.four.Text = "4";
            this.four.UseVisualStyleBackColor = false;
            this.four.Click += new System.EventHandler(this.BtnNum_Click);
            // 
            // five
            // 
            this.five.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.five.Cursor = System.Windows.Forms.Cursors.Hand;
            this.five.FlatAppearance.BorderSize = 0;
            this.five.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.five.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.five.Location = new System.Drawing.Point(96, 198);
            this.five.Name = "five";
            this.five.Size = new System.Drawing.Size(75, 75);
            this.five.TabIndex = 6;
            this.five.Text = "5";
            this.five.UseVisualStyleBackColor = false;
            this.five.Click += new System.EventHandler(this.BtnNum_Click);
            // 
            // six
            // 
            this.six.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.six.Cursor = System.Windows.Forms.Cursors.Hand;
            this.six.FlatAppearance.BorderSize = 0;
            this.six.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.six.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.six.Location = new System.Drawing.Point(177, 198);
            this.six.Name = "six";
            this.six.Size = new System.Drawing.Size(75, 75);
            this.six.TabIndex = 7;
            this.six.Text = "6";
            this.six.UseVisualStyleBackColor = false;
            this.six.Click += new System.EventHandler(this.BtnNum_Click);
            // 
            // seven
            // 
            this.seven.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.seven.Cursor = System.Windows.Forms.Cursors.Hand;
            this.seven.FlatAppearance.BorderSize = 0;
            this.seven.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.seven.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.seven.Location = new System.Drawing.Point(15, 279);
            this.seven.Name = "seven";
            this.seven.Size = new System.Drawing.Size(75, 75);
            this.seven.TabIndex = 8;
            this.seven.Text = "7";
            this.seven.UseVisualStyleBackColor = false;
            this.seven.Click += new System.EventHandler(this.BtnNum_Click);
            // 
            // eight
            // 
            this.eight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.eight.Cursor = System.Windows.Forms.Cursors.Hand;
            this.eight.FlatAppearance.BorderSize = 0;
            this.eight.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.eight.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.eight.Location = new System.Drawing.Point(96, 279);
            this.eight.Name = "eight";
            this.eight.Size = new System.Drawing.Size(75, 75);
            this.eight.TabIndex = 9;
            this.eight.Text = "8";
            this.eight.UseVisualStyleBackColor = false;
            this.eight.Click += new System.EventHandler(this.BtnNum_Click);
            // 
            // nine
            // 
            this.nine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.nine.Cursor = System.Windows.Forms.Cursors.Hand;
            this.nine.FlatAppearance.BorderSize = 0;
            this.nine.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.nine.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.nine.Location = new System.Drawing.Point(177, 279);
            this.nine.Name = "nine";
            this.nine.Size = new System.Drawing.Size(75, 75);
            this.nine.TabIndex = 10;
            this.nine.Text = "9";
            this.nine.UseVisualStyleBackColor = false;
            this.nine.Click += new System.EventHandler(this.BtnNum_Click);
            // 
            // zero
            // 
            this.zero.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.zero.Cursor = System.Windows.Forms.Cursors.Hand;
            this.zero.FlatAppearance.BorderSize = 0;
            this.zero.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.zero.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.zero.Location = new System.Drawing.Point(15, 360);
            this.zero.Name = "zero";
            this.zero.Size = new System.Drawing.Size(156, 75);
            this.zero.TabIndex = 11;
            this.zero.Text = "0";
            this.zero.UseVisualStyleBackColor = false;
            this.zero.Click += new System.EventHandler(this.BtnNum_Click);
            // 
            // equalsBtn
            // 
            this.equalsBtn.BackColor = System.Drawing.Color.SteelBlue;
            this.equalsBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.equalsBtn.FlatAppearance.BorderSize = 0;
            this.equalsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.equalsBtn.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.equalsBtn.Location = new System.Drawing.Point(258, 279);
            this.equalsBtn.Name = "equalsBtn";
            this.equalsBtn.Size = new System.Drawing.Size(156, 75);
            this.equalsBtn.TabIndex = 12;
            this.equalsBtn.Text = "=";
            this.equalsBtn.UseVisualStyleBackColor = false;
            this.equalsBtn.Click += new System.EventHandler(this.equalsBtn_Click);
            // 
            // plusBtn
            // 
            this.plusBtn.BackColor = System.Drawing.Color.DimGray;
            this.plusBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.plusBtn.FlatAppearance.BorderSize = 0;
            this.plusBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.plusBtn.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.plusBtn.Location = new System.Drawing.Point(258, 117);
            this.plusBtn.Name = "plusBtn";
            this.plusBtn.Size = new System.Drawing.Size(75, 75);
            this.plusBtn.TabIndex = 13;
            this.plusBtn.Text = "+";
            this.plusBtn.UseVisualStyleBackColor = false;
            this.plusBtn.Click += new System.EventHandler(this.BtnOperation_Click);
            // 
            // minBtn
            // 
            this.minBtn.BackColor = System.Drawing.Color.DimGray;
            this.minBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.minBtn.FlatAppearance.BorderSize = 0;
            this.minBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minBtn.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.minBtn.Location = new System.Drawing.Point(339, 117);
            this.minBtn.Name = "minBtn";
            this.minBtn.Size = new System.Drawing.Size(75, 75);
            this.minBtn.TabIndex = 14;
            this.minBtn.Text = "-";
            this.minBtn.UseVisualStyleBackColor = false;
            this.minBtn.Click += new System.EventHandler(this.BtnOperation_Click);
            // 
            // mulBtn
            // 
            this.mulBtn.BackColor = System.Drawing.Color.DimGray;
            this.mulBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.mulBtn.FlatAppearance.BorderSize = 0;
            this.mulBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mulBtn.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.mulBtn.Location = new System.Drawing.Point(258, 198);
            this.mulBtn.Name = "mulBtn";
            this.mulBtn.Size = new System.Drawing.Size(75, 75);
            this.mulBtn.TabIndex = 15;
            this.mulBtn.Text = "x";
            this.mulBtn.UseVisualStyleBackColor = false;
            this.mulBtn.Click += new System.EventHandler(this.BtnOperation_Click);
            // 
            // divBtn
            // 
            this.divBtn.BackColor = System.Drawing.Color.DimGray;
            this.divBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.divBtn.FlatAppearance.BorderSize = 0;
            this.divBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.divBtn.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.divBtn.Location = new System.Drawing.Point(339, 198);
            this.divBtn.Name = "divBtn";
            this.divBtn.Size = new System.Drawing.Size(75, 75);
            this.divBtn.TabIndex = 16;
            this.divBtn.Text = "/";
            this.divBtn.UseVisualStyleBackColor = false;
            this.divBtn.Click += new System.EventHandler(this.BtnOperation_Click);
            // 
            // ceBtn
            // 
            this.ceBtn.BackColor = System.Drawing.Color.SteelBlue;
            this.ceBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ceBtn.FlatAppearance.BorderSize = 0;
            this.ceBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ceBtn.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.ceBtn.Location = new System.Drawing.Point(258, 360);
            this.ceBtn.Name = "ceBtn";
            this.ceBtn.Size = new System.Drawing.Size(75, 75);
            this.ceBtn.TabIndex = 12;
            this.ceBtn.Text = "CE";
            this.ceBtn.UseVisualStyleBackColor = false;
            this.ceBtn.Click += new System.EventHandler(this.ceBtn_Click);
            // 
            // dotBtn
            // 
            this.dotBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.dotBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dotBtn.FlatAppearance.BorderSize = 0;
            this.dotBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dotBtn.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.dotBtn.Location = new System.Drawing.Point(177, 360);
            this.dotBtn.Name = "dotBtn";
            this.dotBtn.Size = new System.Drawing.Size(75, 75);
            this.dotBtn.TabIndex = 17;
            this.dotBtn.Text = ",";
            this.dotBtn.UseVisualStyleBackColor = false;
            this.dotBtn.Click += new System.EventHandler(this.BtnNum_Click);
            // 
            // backspace
            // 
            this.backspace.BackColor = System.Drawing.Color.SteelBlue;
            this.backspace.Cursor = System.Windows.Forms.Cursors.Hand;
            this.backspace.FlatAppearance.BorderSize = 0;
            this.backspace.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backspace.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.backspace.Location = new System.Drawing.Point(339, 360);
            this.backspace.Name = "backspace";
            this.backspace.Size = new System.Drawing.Size(75, 75);
            this.backspace.TabIndex = 18;
            this.backspace.Text = "Delete";
            this.backspace.UseVisualStyleBackColor = false;
            this.backspace.Click += new System.EventHandler(this.backspace_Click);
            // 
            // Calculator
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.CausesValidation = false;
            this.ClientSize = new System.Drawing.Size(430, 450);
            this.Controls.Add(this.backspace);
            this.Controls.Add(this.dotBtn);
            this.Controls.Add(this.divBtn);
            this.Controls.Add(this.mulBtn);
            this.Controls.Add(this.minBtn);
            this.Controls.Add(this.plusBtn);
            this.Controls.Add(this.ceBtn);
            this.Controls.Add(this.equalsBtn);
            this.Controls.Add(this.zero);
            this.Controls.Add(this.nine);
            this.Controls.Add(this.eight);
            this.Controls.Add(this.seven);
            this.Controls.Add(this.six);
            this.Controls.Add(this.five);
            this.Controls.Add(this.four);
            this.Controls.Add(this.three);
            this.Controls.Add(this.two);
            this.Controls.Add(this.one);
            this.Controls.Add(this.TxtDisplay);
            this.Controls.Add(this.PnlUp);
            this.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Calculator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculator";
            this.PnlUp.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Panel PnlUp;
        private System.Windows.Forms.TextBox TxtDisplay;
        private System.Windows.Forms.Button BtnExit;
        private System.Windows.Forms.Button one;
        private System.Windows.Forms.Button two;
        private System.Windows.Forms.Button three;
        private System.Windows.Forms.Button four;
        private System.Windows.Forms.Button five;
        private System.Windows.Forms.Button six;
        private System.Windows.Forms.Button seven;
        private System.Windows.Forms.Button eight;
        private System.Windows.Forms.Button nine;
        private System.Windows.Forms.Button zero;
        private System.Windows.Forms.Button equalsBtn;
        private System.Windows.Forms.Button plusBtn;
        private System.Windows.Forms.Button minBtn;
        private System.Windows.Forms.Button mulBtn;
        private System.Windows.Forms.Button divBtn;
        private System.Windows.Forms.Button ceBtn;
        private System.Windows.Forms.Button dotBtn;
        private System.Windows.Forms.Button backspace;
        private System.Windows.Forms.Button hide;
    }
}

