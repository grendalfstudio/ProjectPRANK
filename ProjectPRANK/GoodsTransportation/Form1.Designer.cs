namespace GoodsTransportation
{
    partial class Form1
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridViewCities = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridViewPlaces = new System.Windows.Forms.DataGridView();
            this.numericUpDownCity = new System.Windows.Forms.NumericUpDown();
            this.buttonAcceptPlace = new System.Windows.Forms.Button();
            this.buttonAcceptCity = new System.Windows.Forms.Button();
            this.textBoxNumberOfPlaces = new System.Windows.Forms.TextBox();
            this.textBoxNumberOfCities = new System.Windows.Forms.TextBox();
            this.groupBoxCitiesPlaces = new System.Windows.Forms.GroupBox();
            this.groupBoxGoods = new System.Windows.Forms.GroupBox();
            this.btnShowGoods = new System.Windows.Forms.Button();
            this.buttonSortPrice = new System.Windows.Forms.Button();
            this.buttonSortWeight = new System.Windows.Forms.Button();
            this.buttonSortName = new System.Windows.Forms.Button();
            this.dataGridViewGoods = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.textBoxWeight = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxPrice = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_bfs = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCities)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPlaces)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCity)).BeginInit();
            this.groupBoxCitiesPlaces.SuspendLayout();
            this.groupBoxGoods.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewGoods)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewCities
            // 
            this.dataGridViewCities.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCities.Location = new System.Drawing.Point(8, 59);
            this.dataGridViewCities.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridViewCities.Name = "dataGridViewCities";
            this.dataGridViewCities.Size = new System.Drawing.Size(400, 369);
            this.dataGridViewCities.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 30);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Number of cities:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(636, 30);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(175, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Number of places in a city:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(535, 30);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "City:";
            // 
            // dataGridViewPlaces
            // 
            this.dataGridViewPlaces.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPlaces.Location = new System.Drawing.Point(539, 59);
            this.dataGridViewPlaces.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridViewPlaces.Name = "dataGridViewPlaces";
            this.dataGridViewPlaces.RowHeadersWidth = 50;
            this.dataGridViewPlaces.Size = new System.Drawing.Size(399, 263);
            this.dataGridViewPlaces.TabIndex = 9;
            // 
            // numericUpDownCity
            // 
            this.numericUpDownCity.Location = new System.Drawing.Point(579, 27);
            this.numericUpDownCity.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.numericUpDownCity.Name = "numericUpDownCity";
            this.numericUpDownCity.Size = new System.Drawing.Size(49, 22);
            this.numericUpDownCity.TabIndex = 10;
            // 
            // buttonAcceptPlace
            // 
            this.buttonAcceptPlace.Location = new System.Drawing.Point(853, 23);
            this.buttonAcceptPlace.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonAcceptPlace.Name = "buttonAcceptPlace";
            this.buttonAcceptPlace.Size = new System.Drawing.Size(85, 28);
            this.buttonAcceptPlace.TabIndex = 4;
            this.buttonAcceptPlace.Text = "Accept";
            this.buttonAcceptPlace.UseVisualStyleBackColor = true;
            this.buttonAcceptPlace.Click += new System.EventHandler(this.ButtonAcceptPlace_Click);
            // 
            // buttonAcceptCity
            // 
            this.buttonAcceptCity.Location = new System.Drawing.Point(172, 25);
            this.buttonAcceptCity.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonAcceptCity.Name = "buttonAcceptCity";
            this.buttonAcceptCity.Size = new System.Drawing.Size(85, 28);
            this.buttonAcceptCity.TabIndex = 1;
            this.buttonAcceptCity.Text = "Accept";
            this.buttonAcceptCity.UseVisualStyleBackColor = true;
            this.buttonAcceptCity.Click += new System.EventHandler(this.ButtonAcceptCity_Click);
            // 
            // textBoxNumberOfPlaces
            // 
            this.textBoxNumberOfPlaces.Location = new System.Drawing.Point(820, 27);
            this.textBoxNumberOfPlaces.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxNumberOfPlaces.Name = "textBoxNumberOfPlaces";
            this.textBoxNumberOfPlaces.Size = new System.Drawing.Size(24, 22);
            this.textBoxNumberOfPlaces.TabIndex = 6;
            // 
            // textBoxNumberOfCities
            // 
            this.textBoxNumberOfCities.Location = new System.Drawing.Point(131, 26);
            this.textBoxNumberOfCities.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxNumberOfCities.Name = "textBoxNumberOfCities";
            this.textBoxNumberOfCities.Size = new System.Drawing.Size(32, 22);
            this.textBoxNumberOfCities.TabIndex = 11;
            // 
            // groupBoxCitiesPlaces
            // 
            this.groupBoxCitiesPlaces.Controls.Add(this.textBox1);
            this.groupBoxCitiesPlaces.Controls.Add(this.btn_bfs);
            this.groupBoxCitiesPlaces.Controls.Add(this.textBoxNumberOfCities);
            this.groupBoxCitiesPlaces.Controls.Add(this.numericUpDownCity);
            this.groupBoxCitiesPlaces.Controls.Add(this.dataGridViewPlaces);
            this.groupBoxCitiesPlaces.Controls.Add(this.label3);
            this.groupBoxCitiesPlaces.Controls.Add(this.textBoxNumberOfPlaces);
            this.groupBoxCitiesPlaces.Controls.Add(this.label2);
            this.groupBoxCitiesPlaces.Controls.Add(this.buttonAcceptPlace);
            this.groupBoxCitiesPlaces.Controls.Add(this.label1);
            this.groupBoxCitiesPlaces.Controls.Add(this.buttonAcceptCity);
            this.groupBoxCitiesPlaces.Controls.Add(this.dataGridViewCities);
            this.groupBoxCitiesPlaces.Location = new System.Drawing.Point(16, 15);
            this.groupBoxCitiesPlaces.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBoxCitiesPlaces.Name = "groupBoxCitiesPlaces";
            this.groupBoxCitiesPlaces.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBoxCitiesPlaces.Size = new System.Drawing.Size(947, 434);
            this.groupBoxCitiesPlaces.TabIndex = 12;
            this.groupBoxCitiesPlaces.TabStop = false;
            this.groupBoxCitiesPlaces.Text = "Cities and places ";
            // 
            // groupBoxGoods
            // 
            this.groupBoxGoods.Controls.Add(this.btnShowGoods);
            this.groupBoxGoods.Controls.Add(this.buttonSortPrice);
            this.groupBoxGoods.Controls.Add(this.buttonSortWeight);
            this.groupBoxGoods.Controls.Add(this.buttonSortName);
            this.groupBoxGoods.Controls.Add(this.dataGridViewGoods);
            this.groupBoxGoods.Controls.Add(this.buttonAdd);
            this.groupBoxGoods.Controls.Add(this.textBoxWeight);
            this.groupBoxGoods.Controls.Add(this.label6);
            this.groupBoxGoods.Controls.Add(this.textBoxPrice);
            this.groupBoxGoods.Controls.Add(this.label5);
            this.groupBoxGoods.Controls.Add(this.textBoxName);
            this.groupBoxGoods.Controls.Add(this.label4);
            this.groupBoxGoods.Location = new System.Drawing.Point(16, 457);
            this.groupBoxGoods.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBoxGoods.Name = "groupBoxGoods";
            this.groupBoxGoods.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBoxGoods.Size = new System.Drawing.Size(947, 219);
            this.groupBoxGoods.TabIndex = 13;
            this.groupBoxGoods.TabStop = false;
            this.groupBoxGoods.Text = "Goods";
            // 
            // btnShowGoods
            // 
            this.btnShowGoods.Location = new System.Drawing.Point(227, 146);
            this.btnShowGoods.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnShowGoods.Name = "btnShowGoods";
            this.btnShowGoods.Size = new System.Drawing.Size(83, 28);
            this.btnShowGoods.TabIndex = 14;
            this.btnShowGoods.Text = "Show ";
            this.btnShowGoods.UseVisualStyleBackColor = true;
            this.btnShowGoods.Click += new System.EventHandler(this.btnShowGoods_Click);
            // 
            // buttonSortPrice
            // 
            this.buttonSortPrice.Location = new System.Drawing.Point(397, 146);
            this.buttonSortPrice.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonSortPrice.Name = "buttonSortPrice";
            this.buttonSortPrice.Size = new System.Drawing.Size(133, 54);
            this.buttonSortPrice.TabIndex = 15;
            this.buttonSortPrice.Text = "Sort by price";
            this.buttonSortPrice.UseVisualStyleBackColor = true;
            this.buttonSortPrice.Click += new System.EventHandler(this.ButtonSortPrice_Click);
            // 
            // buttonSortWeight
            // 
            this.buttonSortWeight.Location = new System.Drawing.Point(397, 85);
            this.buttonSortWeight.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonSortWeight.Name = "buttonSortWeight";
            this.buttonSortWeight.Size = new System.Drawing.Size(133, 54);
            this.buttonSortWeight.TabIndex = 14;
            this.buttonSortWeight.Text = "Sort by weight";
            this.buttonSortWeight.UseVisualStyleBackColor = true;
            this.buttonSortWeight.Click += new System.EventHandler(this.ButtonSortWeight_Click);
            // 
            // buttonSortName
            // 
            this.buttonSortName.Location = new System.Drawing.Point(397, 23);
            this.buttonSortName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonSortName.Name = "buttonSortName";
            this.buttonSortName.Size = new System.Drawing.Size(133, 54);
            this.buttonSortName.TabIndex = 13;
            this.buttonSortName.Text = "Sort by name";
            this.buttonSortName.UseVisualStyleBackColor = true;
            this.buttonSortName.Click += new System.EventHandler(this.ButtonSortName_Click);
            // 
            // dataGridViewGoods
            // 
            this.dataGridViewGoods.AllowUserToAddRows = false;
            this.dataGridViewGoods.AllowUserToDeleteRows = false;
            this.dataGridViewGoods.AllowUserToResizeRows = false;
            this.dataGridViewGoods.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridViewGoods.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.dataGridViewGoods.Location = new System.Drawing.Point(539, 23);
            this.dataGridViewGoods.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridViewGoods.Name = "dataGridViewGoods";
            this.dataGridViewGoods.ReadOnly = true;
            this.dataGridViewGoods.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridViewGoods.RowHeadersVisible = false;
            this.dataGridViewGoods.RowTemplate.ReadOnly = true;
            this.dataGridViewGoods.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridViewGoods.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataGridViewGoods.Size = new System.Drawing.Size(400, 177);
            this.dataGridViewGoods.TabIndex = 12;
            // 
            // Column1
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            this.Column1.DefaultCellStyle = dataGridViewCellStyle3;
            this.Column1.Frozen = true;
            this.Column1.HeaderText = "Name";
            this.Column1.MaxInputLength = 32;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 200;
            // 
            // Column2
            // 
            this.Column2.Frozen = true;
            this.Column2.HeaderText = "Weight";
            this.Column2.MaxInputLength = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column2.Width = 50;
            // 
            // Column3
            // 
            this.Column3.Frozen = true;
            this.Column3.HeaderText = "Price";
            this.Column3.MaxInputLength = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 50;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(227, 36);
            this.buttonAdd.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(83, 89);
            this.buttonAdd.TabIndex = 6;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.ButtonAdd_Click);
            // 
            // textBoxWeight
            // 
            this.textBoxWeight.Location = new System.Drawing.Point(85, 69);
            this.textBoxWeight.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxWeight.Name = "textBoxWeight";
            this.textBoxWeight.Size = new System.Drawing.Size(132, 22);
            this.textBoxWeight.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(23, 73);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 17);
            this.label6.TabIndex = 4;
            this.label6.Text = "Weight:";
            // 
            // textBoxPrice
            // 
            this.textBoxPrice.Location = new System.Drawing.Point(85, 101);
            this.textBoxPrice.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxPrice.Name = "textBoxPrice";
            this.textBoxPrice.Size = new System.Drawing.Size(132, 22);
            this.textBoxPrice.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 105);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 17);
            this.label5.TabIndex = 2;
            this.label5.Text = "Price:";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(85, 37);
            this.textBoxName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(132, 22);
            this.textBoxName.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 41);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "Name:";
            // 
            // btn_bfs
            // 
            this.btn_bfs.Location = new System.Drawing.Point(701, 344);
            this.btn_bfs.Name = "btn_bfs";
            this.btn_bfs.Size = new System.Drawing.Size(75, 23);
            this.btn_bfs.TabIndex = 12;
            this.btn_bfs.Text = "button1";
            this.btn_bfs.UseVisualStyleBackColor = true;
            this.btn_bfs.Click += new System.EventHandler(this.btn_bfs_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(538, 383);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(400, 22);
            this.textBox1.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(979, 690);
            this.Controls.Add(this.groupBoxGoods);
            this.Controls.Add(this.groupBoxCitiesPlaces);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Goods Transportation";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCities)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPlaces)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCity)).EndInit();
            this.groupBoxCitiesPlaces.ResumeLayout(false);
            this.groupBoxCitiesPlaces.PerformLayout();
            this.groupBoxGoods.ResumeLayout(false);
            this.groupBoxGoods.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewGoods)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewCities;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridViewPlaces;
        private System.Windows.Forms.NumericUpDown numericUpDownCity;
        private System.Windows.Forms.Button buttonAcceptPlace;
        private System.Windows.Forms.Button buttonAcceptCity;
        private System.Windows.Forms.TextBox textBoxNumberOfPlaces;
        private System.Windows.Forms.TextBox textBoxNumberOfCities;
        private System.Windows.Forms.GroupBox groupBoxCitiesPlaces;
        private System.Windows.Forms.GroupBox groupBoxGoods;
        private System.Windows.Forms.Button buttonSortPrice;
        private System.Windows.Forms.Button buttonSortWeight;
        private System.Windows.Forms.Button buttonSortName;
        private System.Windows.Forms.DataGridView dataGridViewGoods;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.TextBox textBoxWeight;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxPrice;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.Button btnShowGoods;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btn_bfs;
    }
}

