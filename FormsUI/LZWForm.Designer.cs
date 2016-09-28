namespace FormsUI
{
    partial class LZWForm
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
            this.inputForm = new System.Windows.Forms.RichTextBox();
            this.outputForm = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.typeOfAction = new System.Windows.Forms.ComboBox();
            this.strategyOfOutput = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // inputForm
            // 
            this.inputForm.Location = new System.Drawing.Point(64, 86);
            this.inputForm.Name = "inputForm";
            this.inputForm.Size = new System.Drawing.Size(131, 106);
            this.inputForm.TabIndex = 0;
            this.inputForm.Text = "";
            // 
            // outputForm
            // 
            this.outputForm.Location = new System.Drawing.Point(304, 86);
            this.outputForm.Name = "outputForm";
            this.outputForm.Size = new System.Drawing.Size(131, 106);
            this.outputForm.TabIndex = 1;
            this.outputForm.Text = "";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(333, 223);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(102, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Преобразовать";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // typeOfAction
            // 
            this.typeOfAction.FormattingEnabled = true;
            this.typeOfAction.Items.AddRange(new object[] {
            "Архивировать",
            "Разархивировать"});
            this.typeOfAction.Location = new System.Drawing.Point(64, 35);
            this.typeOfAction.Name = "typeOfAction";
            this.typeOfAction.Size = new System.Drawing.Size(131, 21);
            this.typeOfAction.TabIndex = 75;
            // 
            // strategyOfOutput
            // 
            this.strategyOfOutput.FormattingEnabled = true;
            this.strategyOfOutput.Items.AddRange(new object[] {
            "В окно",
            "В файл",
            "В бинарный"});
            this.strategyOfOutput.Location = new System.Drawing.Point(304, 35);
            this.strategyOfOutput.Name = "strategyOfOutput";
            this.strategyOfOutput.Size = new System.Drawing.Size(131, 21);
            this.strategyOfOutput.TabIndex = 76;
            // 
            // LZWForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(532, 347);
            this.Controls.Add(this.strategyOfOutput);
            this.Controls.Add(this.typeOfAction);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.outputForm);
            this.Controls.Add(this.inputForm);
            this.Name = "LZWForm";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox inputForm;
        private System.Windows.Forms.RichTextBox outputForm;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox typeOfAction;
        private System.Windows.Forms.ComboBox strategyOfOutput;
    }
}

