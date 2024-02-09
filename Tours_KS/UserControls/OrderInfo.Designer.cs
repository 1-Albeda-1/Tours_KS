namespace Tours_KS
{
    partial class OrderInfo
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
            this.pictureBoxTourImage = new System.Windows.Forms.PictureBox();
            this.labelName = new System.Windows.Forms.Label();
            this.labelDescription = new System.Windows.Forms.Label();
            this.listBoxTypeTour = new System.Windows.Forms.ListBox();
            this.labelActual = new System.Windows.Forms.Label();
            this.labelCountTicket = new System.Windows.Forms.Label();
            this.labelCountry = new System.Windows.Forms.Label();
            this.numericUpDownCount = new System.Windows.Forms.NumericUpDown();
            this.labelPrice = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTourImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCount)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxTourImage
            // 
            this.pictureBoxTourImage.Location = new System.Drawing.Point(18, 23);
            this.pictureBoxTourImage.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBoxTourImage.Name = "pictureBoxTourImage";
            this.pictureBoxTourImage.Size = new System.Drawing.Size(162, 165);
            this.pictureBoxTourImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxTourImage.TabIndex = 0;
            this.pictureBoxTourImage.TabStop = false;
            // 
            // labelName
            // 
            this.labelName.Font = new System.Drawing.Font("Comic Sans MS", 11.14286F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelName.Location = new System.Drawing.Point(202, 23);
            this.labelName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(121, 60);
            this.labelName.TabIndex = 1;
            this.labelName.Text = "Название";
            // 
            // labelDescription
            // 
            this.labelDescription.Font = new System.Drawing.Font("Comic Sans MS", 9.857143F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelDescription.Location = new System.Drawing.Point(202, 117);
            this.labelDescription.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelDescription.Name = "labelDescription";
            this.labelDescription.Size = new System.Drawing.Size(121, 71);
            this.labelDescription.TabIndex = 2;
            this.labelDescription.Text = "Описание";
            // 
            // listBoxTypeTour
            // 
            this.listBoxTypeTour.Font = new System.Drawing.Font("Comic Sans MS", 9.857143F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listBoxTypeTour.FormattingEnabled = true;
            this.listBoxTypeTour.ItemHeight = 18;
            this.listBoxTypeTour.Location = new System.Drawing.Point(340, 28);
            this.listBoxTypeTour.Margin = new System.Windows.Forms.Padding(4);
            this.listBoxTypeTour.Name = "listBoxTypeTour";
            this.listBoxTypeTour.Size = new System.Drawing.Size(205, 148);
            this.listBoxTypeTour.TabIndex = 3;
            // 
            // labelActual
            // 
            this.labelActual.AutoSize = true;
            this.labelActual.Font = new System.Drawing.Font("Comic Sans MS", 9.857143F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelActual.ForeColor = System.Drawing.Color.ForestGreen;
            this.labelActual.Location = new System.Drawing.Point(589, 36);
            this.labelActual.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelActual.Name = "labelActual";
            this.labelActual.Size = new System.Drawing.Size(74, 19);
            this.labelActual.TabIndex = 4;
            this.labelActual.Text = "Актуален";
            // 
            // labelCountTicket
            // 
            this.labelCountTicket.AutoSize = true;
            this.labelCountTicket.Font = new System.Drawing.Font("Comic Sans MS", 9.857143F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCountTicket.Location = new System.Drawing.Point(589, 75);
            this.labelCountTicket.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelCountTicket.Name = "labelCountTicket";
            this.labelCountTicket.Size = new System.Drawing.Size(114, 19);
            this.labelCountTicket.TabIndex = 5;
            this.labelCountTicket.Text = "Кол-во билетов";
            // 
            // labelCountry
            // 
            this.labelCountry.AutoSize = true;
            this.labelCountry.Font = new System.Drawing.Font("Comic Sans MS", 9.857143F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCountry.Location = new System.Drawing.Point(589, 117);
            this.labelCountry.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelCountry.Name = "labelCountry";
            this.labelCountry.Size = new System.Drawing.Size(53, 19);
            this.labelCountry.TabIndex = 6;
            this.labelCountry.Text = "Страна";
            // 
            // numericUpDownCount
            // 
            this.numericUpDownCount.Font = new System.Drawing.Font("Comic Sans MS", 9.857143F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numericUpDownCount.Location = new System.Drawing.Point(726, 35);
            this.numericUpDownCount.Margin = new System.Windows.Forms.Padding(4);
            this.numericUpDownCount.Name = "numericUpDownCount";
            this.numericUpDownCount.Size = new System.Drawing.Size(72, 26);
            this.numericUpDownCount.TabIndex = 7;
            this.numericUpDownCount.ValueChanged += new System.EventHandler(this.numericUpDownCount_ValueChanged);
            // 
            // labelPrice
            // 
            this.labelPrice.AutoSize = true;
            this.labelPrice.Font = new System.Drawing.Font("Comic Sans MS", 9.857143F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPrice.Location = new System.Drawing.Point(589, 157);
            this.labelPrice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(43, 19);
            this.labelPrice.TabIndex = 8;
            this.labelPrice.Text = "Цена";
            // 
            // OrderInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.labelPrice);
            this.Controls.Add(this.numericUpDownCount);
            this.Controls.Add(this.labelCountry);
            this.Controls.Add(this.labelCountTicket);
            this.Controls.Add(this.labelActual);
            this.Controls.Add(this.listBoxTypeTour);
            this.Controls.Add(this.labelDescription);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.pictureBoxTourImage);
            this.Font = new System.Drawing.Font("Comic Sans MS", 9.857143F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "OrderInfo";
            this.Size = new System.Drawing.Size(812, 216);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTourImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxTourImage;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelDescription;
        private System.Windows.Forms.ListBox listBoxTypeTour;
        private System.Windows.Forms.Label labelActual;
        private System.Windows.Forms.Label labelCountTicket;
        private System.Windows.Forms.Label labelCountry;
        private System.Windows.Forms.NumericUpDown numericUpDownCount;
        private System.Windows.Forms.Label labelPrice;
    }
}
