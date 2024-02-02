namespace Tours_KS
{
    partial class TourForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelAllPrice = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.checkBoxActual = new System.Windows.Forms.CheckBox();
            this.comboBoxType = new System.Windows.Forms.ComboBox();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.labelSearch = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.отелиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.panel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.labelAllPrice);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.checkBoxActual);
            this.panel1.Controls.Add(this.comboBoxType);
            this.panel1.Controls.Add(this.textBoxSearch);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.labelSearch);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 41);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1303, 189);
            this.panel1.TabIndex = 0;
            // 
            // labelAllPrice
            // 
            this.labelAllPrice.AutoSize = true;
            this.labelAllPrice.Font = new System.Drawing.Font("Comic Sans MS", 9.857143F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelAllPrice.Location = new System.Drawing.Point(320, 133);
            this.labelAllPrice.Name = "labelAllPrice";
            this.labelAllPrice.Size = new System.Drawing.Size(30, 33);
            this.labelAllPrice.TabIndex = 6;
            this.labelAllPrice.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 9.857143F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(21, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(293, 33);
            this.label2.TabIndex = 5;
            this.label2.Text = "Общая стоимость туров:";
            // 
            // checkBoxActual
            // 
            this.checkBoxActual.AutoSize = true;
            this.checkBoxActual.Font = new System.Drawing.Font("Comic Sans MS", 9.857143F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBoxActual.Location = new System.Drawing.Point(619, 129);
            this.checkBoxActual.Name = "checkBoxActual";
            this.checkBoxActual.Size = new System.Drawing.Size(323, 37);
            this.checkBoxActual.TabIndex = 4;
            this.checkBoxActual.Text = "только актуальные туры";
            this.checkBoxActual.UseVisualStyleBackColor = true;
            this.checkBoxActual.CheckedChanged += new System.EventHandler(this.checkBoxActual_CheckedChanged);
            // 
            // comboBoxType
            // 
            this.comboBoxType.FormattingEnabled = true;
            this.comboBoxType.Location = new System.Drawing.Point(619, 81);
            this.comboBoxType.Name = "comboBoxType";
            this.comboBoxType.Size = new System.Drawing.Size(260, 32);
            this.comboBoxType.TabIndex = 3;
            this.comboBoxType.SelectedIndexChanged += new System.EventHandler(this.comboBoxType_SelectedIndexChanged);
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Location = new System.Drawing.Point(619, 31);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(260, 29);
            this.textBoxSearch.TabIndex = 2;
            this.textBoxSearch.TextChanged += new System.EventHandler(this.textBoxSearch_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 9.857143F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(411, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(183, 33);
            this.label1.TabIndex = 1;
            this.label1.Text = "Выберите тип:";
            // 
            // labelSearch
            // 
            this.labelSearch.AutoSize = true;
            this.labelSearch.Font = new System.Drawing.Font("Comic Sans MS", 9.857143F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSearch.Location = new System.Drawing.Point(276, 28);
            this.labelSearch.Name = "labelSearch";
            this.labelSearch.Size = new System.Drawing.Size(318, 33);
            this.labelSearch.TabIndex = 0;
            this.labelSearch.Text = "Введите текст для поиска:";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 230);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1303, 538);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(92)))), ((int)(((byte)(147)))));
            this.menuStrip1.Font = new System.Drawing.Font("Comic Sans MS", 9.857143F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(28, 28);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.отелиToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1303, 41);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // отелиToolStripMenuItem
            // 
            this.отелиToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Control;
            this.отелиToolStripMenuItem.Name = "отелиToolStripMenuItem";
            this.отелиToolStripMenuItem.Size = new System.Drawing.Size(107, 41);
            this.отелиToolStripMenuItem.Text = "Отели";
            this.отелиToolStripMenuItem.Click += new System.EventHandler(this.отелиToolStripMenuItem_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // TourForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1303, 768);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "TourForm";
            this.Text = "Туры";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelSearch;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.CheckBox checkBoxActual;
        private System.Windows.Forms.ComboBox comboBoxType;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelAllPrice;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem отелиToolStripMenuItem;
    }
}

