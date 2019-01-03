namespace WindowsFormsApplication1
{
    partial class LWP02Main
    {
        /// <summary>
        /// Требуется переменная конструктора.
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
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LWP02Main));
            this.ResultBox = new System.Windows.Forms.TextBox();
            this.BO1 = new System.Windows.Forms.Button();
            this.BO2 = new System.Windows.Forms.Button();
            this.BO3 = new System.Windows.Forms.Button();
            this.BO4 = new System.Windows.Forms.Button();
            this.BO5 = new System.Windows.Forms.Button();
            this.BO6 = new System.Windows.Forms.Button();
            this.BO7 = new System.Windows.Forms.Button();
            this.BO8 = new System.Windows.Forms.Button();
            this.BO9 = new System.Windows.Forms.Button();
            this.BO0 = new System.Windows.Forms.Button();
            this.BD = new System.Windows.Forms.Button();
            this.BResult = new System.Windows.Forms.Button();
            this.BSpecial = new System.Windows.Forms.Button();
            this.NumericSpecial = new System.Windows.Forms.NumericUpDown();
            this.BOperation1 = new System.Windows.Forms.Button();
            this.BOperation2 = new System.Windows.Forms.Button();
            this.BOperation3 = new System.Windows.Forms.Button();
            this.BOperation4 = new System.Windows.Forms.Button();
            this.BC = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.NumericSpecial)).BeginInit();
            this.SuspendLayout();
            // 
            // ResultBox
            // 
            this.ResultBox.Location = new System.Drawing.Point(12, 12);
            this.ResultBox.Name = "ResultBox";
            this.ResultBox.ReadOnly = true;
            this.ResultBox.Size = new System.Drawing.Size(260, 20);
            this.ResultBox.TabIndex = 0;
            this.ResultBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // BO1
            // 
            this.BO1.Location = new System.Drawing.Point(12, 72);
            this.BO1.Name = "BO1";
            this.BO1.Size = new System.Drawing.Size(33, 23);
            this.BO1.TabIndex = 1;
            this.BO1.Text = "1";
            this.BO1.UseVisualStyleBackColor = true;
            this.BO1.Click += new System.EventHandler(this.BO1_Click);
            // 
            // BO2
            // 
            this.BO2.Location = new System.Drawing.Point(51, 72);
            this.BO2.Name = "BO2";
            this.BO2.Size = new System.Drawing.Size(33, 23);
            this.BO2.TabIndex = 2;
            this.BO2.Text = "2";
            this.BO2.UseVisualStyleBackColor = true;
            this.BO2.Click += new System.EventHandler(this.BO2_Click);
            // 
            // BO3
            // 
            this.BO3.Location = new System.Drawing.Point(90, 72);
            this.BO3.Name = "BO3";
            this.BO3.Size = new System.Drawing.Size(33, 23);
            this.BO3.TabIndex = 3;
            this.BO3.Text = "3";
            this.BO3.UseVisualStyleBackColor = true;
            this.BO3.Click += new System.EventHandler(this.BO3_Click);
            // 
            // BO4
            // 
            this.BO4.Location = new System.Drawing.Point(12, 101);
            this.BO4.Name = "BO4";
            this.BO4.Size = new System.Drawing.Size(33, 23);
            this.BO4.TabIndex = 6;
            this.BO4.Text = "4";
            this.BO4.UseVisualStyleBackColor = true;
            this.BO4.Click += new System.EventHandler(this.BO4_Click);
            // 
            // BO5
            // 
            this.BO5.Location = new System.Drawing.Point(51, 101);
            this.BO5.Name = "BO5";
            this.BO5.Size = new System.Drawing.Size(33, 23);
            this.BO5.TabIndex = 5;
            this.BO5.Text = "5";
            this.BO5.UseVisualStyleBackColor = true;
            this.BO5.Click += new System.EventHandler(this.BO5_Click);
            // 
            // BO6
            // 
            this.BO6.Location = new System.Drawing.Point(90, 101);
            this.BO6.Name = "BO6";
            this.BO6.Size = new System.Drawing.Size(33, 23);
            this.BO6.TabIndex = 4;
            this.BO6.Text = "6";
            this.BO6.UseVisualStyleBackColor = true;
            this.BO6.Click += new System.EventHandler(this.BO6_Click);
            // 
            // BO7
            // 
            this.BO7.Location = new System.Drawing.Point(12, 130);
            this.BO7.Name = "BO7";
            this.BO7.Size = new System.Drawing.Size(33, 23);
            this.BO7.TabIndex = 9;
            this.BO7.Text = "7";
            this.BO7.UseVisualStyleBackColor = true;
            this.BO7.Click += new System.EventHandler(this.BO7_Click);
            // 
            // BO8
            // 
            this.BO8.Location = new System.Drawing.Point(51, 130);
            this.BO8.Name = "BO8";
            this.BO8.Size = new System.Drawing.Size(33, 23);
            this.BO8.TabIndex = 8;
            this.BO8.Text = "8";
            this.BO8.UseVisualStyleBackColor = true;
            this.BO8.Click += new System.EventHandler(this.BO8_Click);
            // 
            // BO9
            // 
            this.BO9.Location = new System.Drawing.Point(90, 130);
            this.BO9.Name = "BO9";
            this.BO9.Size = new System.Drawing.Size(33, 23);
            this.BO9.TabIndex = 7;
            this.BO9.Text = "9";
            this.BO9.UseVisualStyleBackColor = true;
            this.BO9.Click += new System.EventHandler(this.BO9_Click);
            // 
            // BO0
            // 
            this.BO0.Location = new System.Drawing.Point(51, 159);
            this.BO0.Name = "BO0";
            this.BO0.Size = new System.Drawing.Size(33, 23);
            this.BO0.TabIndex = 11;
            this.BO0.Text = "0";
            this.BO0.UseVisualStyleBackColor = true;
            this.BO0.Click += new System.EventHandler(this.BO0_Click);
            // 
            // BD
            // 
            this.BD.Location = new System.Drawing.Point(51, 188);
            this.BD.Name = "BD";
            this.BD.Size = new System.Drawing.Size(33, 23);
            this.BD.TabIndex = 10;
            this.BD.Text = ",";
            this.BD.UseVisualStyleBackColor = true;
            this.BD.Click += new System.EventHandler(this.BD_Click);
            // 
            // BResult
            // 
            this.BResult.Location = new System.Drawing.Point(12, 227);
            this.BResult.Name = "BResult";
            this.BResult.Size = new System.Drawing.Size(33, 23);
            this.BResult.TabIndex = 12;
            this.BResult.Text = "=";
            this.BResult.UseVisualStyleBackColor = true;
            this.BResult.Click += new System.EventHandler(this.BResult_Click);
            // 
            // BSpecial
            // 
            this.BSpecial.Location = new System.Drawing.Point(51, 227);
            this.BSpecial.Name = "BSpecial";
            this.BSpecial.Size = new System.Drawing.Size(72, 23);
            this.BSpecial.TabIndex = 13;
            this.BSpecial.Text = "Округлить";
            this.BSpecial.UseVisualStyleBackColor = true;
            this.BSpecial.Click += new System.EventHandler(this.BSpecial_Click);
            // 
            // NumericSpecial
            // 
            this.NumericSpecial.Location = new System.Drawing.Point(129, 227);
            this.NumericSpecial.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.NumericSpecial.Name = "NumericSpecial";
            this.NumericSpecial.Size = new System.Drawing.Size(38, 20);
            this.NumericSpecial.TabIndex = 14;
            // 
            // BOperation1
            // 
            this.BOperation1.Location = new System.Drawing.Point(200, 195);
            this.BOperation1.Name = "BOperation1";
            this.BOperation1.Size = new System.Drawing.Size(33, 23);
            this.BOperation1.TabIndex = 18;
            this.BOperation1.Text = "+";
            this.BOperation1.UseVisualStyleBackColor = true;
            this.BOperation1.Click += new System.EventHandler(this.BOperation1_Click);
            // 
            // BOperation2
            // 
            this.BOperation2.Location = new System.Drawing.Point(239, 195);
            this.BOperation2.Name = "BOperation2";
            this.BOperation2.Size = new System.Drawing.Size(33, 23);
            this.BOperation2.TabIndex = 17;
            this.BOperation2.Text = "-";
            this.BOperation2.UseVisualStyleBackColor = true;
            this.BOperation2.Click += new System.EventHandler(this.BOperation2_Click);
            // 
            // BOperation3
            // 
            this.BOperation3.Location = new System.Drawing.Point(200, 224);
            this.BOperation3.Name = "BOperation3";
            this.BOperation3.Size = new System.Drawing.Size(33, 23);
            this.BOperation3.TabIndex = 16;
            this.BOperation3.Text = "*";
            this.BOperation3.UseVisualStyleBackColor = true;
            this.BOperation3.Click += new System.EventHandler(this.BOperation3_Click);
            // 
            // BOperation4
            // 
            this.BOperation4.Location = new System.Drawing.Point(239, 224);
            this.BOperation4.Name = "BOperation4";
            this.BOperation4.Size = new System.Drawing.Size(33, 23);
            this.BOperation4.TabIndex = 15;
            this.BOperation4.Text = "/";
            this.BOperation4.UseVisualStyleBackColor = true;
            this.BOperation4.Click += new System.EventHandler(this.BOperation4_Click);
            // 
            // BC
            // 
            this.BC.Location = new System.Drawing.Point(239, 72);
            this.BC.Name = "BC";
            this.BC.Size = new System.Drawing.Size(33, 23);
            this.BC.TabIndex = 19;
            this.BC.Text = "C";
            this.BC.UseVisualStyleBackColor = true;
            this.BC.Click += new System.EventHandler(this.BC_Click);
            // 
            // LWP02Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 270);
            this.Controls.Add(this.BC);
            this.Controls.Add(this.BOperation1);
            this.Controls.Add(this.BOperation2);
            this.Controls.Add(this.BOperation3);
            this.Controls.Add(this.BOperation4);
            this.Controls.Add(this.NumericSpecial);
            this.Controls.Add(this.BSpecial);
            this.Controls.Add(this.BResult);
            this.Controls.Add(this.BO0);
            this.Controls.Add(this.BD);
            this.Controls.Add(this.BO7);
            this.Controls.Add(this.BO8);
            this.Controls.Add(this.BO9);
            this.Controls.Add(this.BO4);
            this.Controls.Add(this.BO5);
            this.Controls.Add(this.BO6);
            this.Controls.Add(this.BO3);
            this.Controls.Add(this.BO2);
            this.Controls.Add(this.BO1);
            this.Controls.Add(this.ResultBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimizeBox = false;
            this.Name = "LWP02Main";
            this.Text = "Простой калькулятор (C#)";
            ((System.ComponentModel.ISupportInitialize)(this.NumericSpecial)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ResultBox;
        private System.Windows.Forms.Button BO1;
        private System.Windows.Forms.Button BO2;
        private System.Windows.Forms.Button BO3;
        private System.Windows.Forms.Button BO4;
        private System.Windows.Forms.Button BO5;
        private System.Windows.Forms.Button BO6;
        private System.Windows.Forms.Button BO7;
        private System.Windows.Forms.Button BO8;
        private System.Windows.Forms.Button BO9;
        private System.Windows.Forms.Button BO0;
        private System.Windows.Forms.Button BD;
        private System.Windows.Forms.Button BResult;
        private System.Windows.Forms.Button BSpecial;
        private System.Windows.Forms.NumericUpDown NumericSpecial;
        private System.Windows.Forms.Button BOperation1;
        private System.Windows.Forms.Button BOperation2;
        private System.Windows.Forms.Button BOperation3;
        private System.Windows.Forms.Button BOperation4;
        private System.Windows.Forms.Button BC;
    }
}

