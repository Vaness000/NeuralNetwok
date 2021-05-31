
namespace WindowsFormsUI
{
    partial class InputAmountUserControl
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

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.numberOfLayerLabel = new System.Windows.Forms.Label();
            this.neuronsAmount = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.neuronsAmount)).BeginInit();
            this.SuspendLayout();
            // 
            // numberOfLayerLabel
            // 
            this.numberOfLayerLabel.AutoSize = true;
            this.numberOfLayerLabel.Location = new System.Drawing.Point(4, 4);
            this.numberOfLayerLabel.Name = "numberOfLayerLabel";
            this.numberOfLayerLabel.Size = new System.Drawing.Size(162, 13);
            this.numberOfLayerLabel.TabIndex = 0;
            this.numberOfLayerLabel.Text = "Количество нейронов в слое 5";
            // 
            // neuronsAmount
            // 
            this.neuronsAmount.Location = new System.Drawing.Point(217, 2);
            this.neuronsAmount.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.neuronsAmount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.neuronsAmount.Name = "neuronsAmount";
            this.neuronsAmount.Size = new System.Drawing.Size(120, 20);
            this.neuronsAmount.TabIndex = 1;
            this.neuronsAmount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // InputAmountUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.neuronsAmount);
            this.Controls.Add(this.numberOfLayerLabel);
            this.Name = "InputAmountUserControl";
            this.Size = new System.Drawing.Size(341, 24);
            ((System.ComponentModel.ISupportInitialize)(this.neuronsAmount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label numberOfLayerLabel;
        private System.Windows.Forms.NumericUpDown neuronsAmount;
    }
}
