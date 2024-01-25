namespace Tours_KS
{
    partial class TourInfo
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
            this.labelName = new System.Windows.Forms.Label();
            this.pictureBoxImageTour = new System.Windows.Forms.PictureBox();
            this.labelPrice = new System.Windows.Forms.Label();
            this.labelActual = new System.Windows.Forms.Label();
            this.labelCount = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImageTour)).BeginInit();
            this.SuspendLayout();
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Comic Sans MS", 15.85714F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelName.Location = new System.Drawing.Point(76, 16);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(372, 52);
            this.labelName.TabIndex = 0;
            this.labelName.Text = "Наименование тура";
            // 
            // pictureBoxImageTour
            // 
            this.pictureBoxImageTour.Location = new System.Drawing.Point(68, 85);
            this.pictureBoxImageTour.Name = "pictureBoxImageTour";
            this.pictureBoxImageTour.Size = new System.Drawing.Size(380, 226);
            this.pictureBoxImageTour.TabIndex = 1;
            this.pictureBoxImageTour.TabStop = false;
            // 
            // labelPrice
            // 
            this.labelPrice.AutoSize = true;
            this.labelPrice.Font = new System.Drawing.Font("Comic Sans MS", 15.85714F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPrice.Location = new System.Drawing.Point(139, 334);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(235, 51);
            this.labelPrice.TabIndex = 2;
            this.labelPrice.Text = "10,000 РУБ";
            // 
            // labelActual
            // 
            this.labelActual.AutoSize = true;
            this.labelActual.Font = new System.Drawing.Font("Comic Sans MS", 9.857143F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelActual.Location = new System.Drawing.Point(30, 407);
            this.labelActual.Name = "labelActual";
            this.labelActual.Size = new System.Drawing.Size(122, 33);
            this.labelActual.TabIndex = 3;
            this.labelActual.Text = "Актуален";
            // 
            // labelCount
            // 
            this.labelCount.AutoSize = true;
            this.labelCount.Font = new System.Drawing.Font("Comic Sans MS", 9.857143F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCount.Location = new System.Drawing.Point(329, 407);
            this.labelCount.Name = "labelCount";
            this.labelCount.Size = new System.Drawing.Size(155, 33);
            this.labelCount.TabIndex = 4;
            this.labelCount.Text = "Билетов: 47";
            // 
            // TourInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.labelCount);
            this.Controls.Add(this.labelActual);
            this.Controls.Add(this.labelPrice);
            this.Controls.Add(this.pictureBoxImageTour);
            this.Controls.Add(this.labelName);
            this.Name = "TourInfo";
            this.Size = new System.Drawing.Size(510, 466);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImageTour)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.PictureBox pictureBoxImageTour;
        private System.Windows.Forms.Label labelPrice;
        private System.Windows.Forms.Label labelActual;
        private System.Windows.Forms.Label labelCount;
    }
}
