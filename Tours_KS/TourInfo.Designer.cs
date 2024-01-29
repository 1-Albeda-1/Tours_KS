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
            this.buttonImage = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImageTour)).BeginInit();
            this.SuspendLayout();
            // 
            // labelName
            // 
            this.labelName.Font = new System.Drawing.Font("Comic Sans MS", 15.85714F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelName.Location = new System.Drawing.Point(59, 33);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(372, 125);
            this.labelName.TabIndex = 0;
            this.labelName.Text = "Наименование тура";
            this.labelName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBoxImageTour
            // 
            this.pictureBoxImageTour.Image = global::Tours_KS.Properties.Resources.picture;
            this.pictureBoxImageTour.InitialImage = null;
            this.pictureBoxImageTour.Location = new System.Drawing.Point(68, 176);
            this.pictureBoxImageTour.Name = "pictureBoxImageTour";
            this.pictureBoxImageTour.Size = new System.Drawing.Size(380, 226);
            this.pictureBoxImageTour.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxImageTour.TabIndex = 1;
            this.pictureBoxImageTour.TabStop = false;
            // 
            // labelPrice
            // 
            this.labelPrice.AutoSize = true;
            this.labelPrice.Font = new System.Drawing.Font("Comic Sans MS", 15.85714F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPrice.Location = new System.Drawing.Point(139, 425);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(235, 51);
            this.labelPrice.TabIndex = 2;
            this.labelPrice.Text = "10,000 РУБ";
            // 
            // labelActual
            // 
            this.labelActual.AutoSize = true;
            this.labelActual.Font = new System.Drawing.Font("Comic Sans MS", 9.857143F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelActual.Location = new System.Drawing.Point(30, 498);
            this.labelActual.Name = "labelActual";
            this.labelActual.Size = new System.Drawing.Size(122, 33);
            this.labelActual.TabIndex = 3;
            this.labelActual.Text = "Актуален";
            // 
            // labelCount
            // 
            this.labelCount.AutoSize = true;
            this.labelCount.Font = new System.Drawing.Font("Comic Sans MS", 9.857143F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCount.Location = new System.Drawing.Point(329, 498);
            this.labelCount.Name = "labelCount";
            this.labelCount.Size = new System.Drawing.Size(155, 33);
            this.labelCount.TabIndex = 4;
            this.labelCount.Text = "Билетов: 47";
            // 
            // buttonImage
            // 
            this.buttonImage.Font = new System.Drawing.Font("Comic Sans MS", 8.142858F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonImage.Location = new System.Drawing.Point(162, 541);
            this.buttonImage.Name = "buttonImage";
            this.buttonImage.Size = new System.Drawing.Size(153, 90);
            this.buttonImage.TabIndex = 5;
            this.buttonImage.Text = "Добавить ФОТО";
            this.buttonImage.UseVisualStyleBackColor = true;
            this.buttonImage.Click += new System.EventHandler(this.buttonImage_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // TourInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.buttonImage);
            this.Controls.Add(this.labelCount);
            this.Controls.Add(this.labelActual);
            this.Controls.Add(this.labelPrice);
            this.Controls.Add(this.pictureBoxImageTour);
            this.Controls.Add(this.labelName);
            this.Name = "TourInfo";
            this.Size = new System.Drawing.Size(510, 655);
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
        private System.Windows.Forms.Button buttonImage;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}
