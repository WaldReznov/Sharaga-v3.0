namespace WindowsFormsApplication3
{
    partial class LWP04Main
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
            this.components = new System.ComponentModel.Container();
            this.Hint = new System.Windows.Forms.ToolTip(this.components);
            this.ButtonShowChildren = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ButtonShowChildren
            // 
            this.ButtonShowChildren.Location = new System.Drawing.Point(322, 277);
            this.ButtonShowChildren.Name = "ButtonShowChildren";
            this.ButtonShowChildren.Size = new System.Drawing.Size(150, 23);
            this.ButtonShowChildren.TabIndex = 0;
            this.ButtonShowChildren.Text = "Подчинённая форма";
            this.Hint.SetToolTip(this.ButtonShowChildren, "Передача параметра через прямой доступ к элементам управления");
            this.ButtonShowChildren.UseVisualStyleBackColor = true;
            this.ButtonShowChildren.Click += new System.EventHandler(this.ButtonShowChildren_Click);
            // 
            // LWP04Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 312);
            this.Controls.Add(this.ButtonShowChildren);
            this.Name = "LWP04Main";
            this.Text = "Windows Forms (C#)";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolTip Hint;
        private System.Windows.Forms.Button ButtonShowChildren;
    }
}

