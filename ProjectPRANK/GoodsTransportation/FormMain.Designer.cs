namespace GoodsTransportation
{
    partial class FormMain
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
            this.label7 = new System.Windows.Forms.Label();
            this.tbSrc = new System.Windows.Forms.TextBox();
            this.btnSetRoads = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btn_bfs = new System.Windows.Forms.Button();
            this.groupBoxGoods = new System.Windows.Forms.GroupBox();
            this.btnRes = new System.Windows.Forms.Button();
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
            this.dataGridViewCities.AllowUserToAddRows = false;
            this.dataGridViewCities.AllowUserToDeleteRows = false;
            this.dataGridViewCities.AllowUserToOrderColumns = true;
            this.dataGridViewCities.AllowUserToResizeColumns = false;
            this.dataGridViewCities.AllowUserToResizeRows = false;
            this.dataGridViewCities.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridViewCities.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCities.ColumnHeadersVisible = false;
            this.dataGridViewCities.Location = new System.Drawing.Point(6, 48);
            this.dataGridViewCities.Name = "dataGridViewCities";
            this.dataGridViewCities.RowHeadersVisible = false;
            this.dataGridViewCities.Size = new System.Drawing.Size(300, 300);
            this.dataGridViewCities.TabIndex = 0;
            this.dataGridViewCities.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.dataGridViewCities_CellBeginEdit);
            this.dataGridViewCities.CurrentCellChanged += new System.EventHandler(this.dataGridViewCities_CurrentCellChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Number of cities:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(477, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Number of places in a city:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(401, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "City:";
            // 
            // dataGridViewPlaces
            // 
            this.dataGridViewPlaces.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPlaces.Location = new System.Drawing.Point(404, 48);
            this.dataGridViewPlaces.Name = "dataGridViewPlaces";
            this.dataGridViewPlaces.RowHeadersWidth = 50;
            this.dataGridViewPlaces.Size = new System.Drawing.Size(299, 214);
            this.dataGridViewPlaces.TabIndex = 9;
            // 
            // numericUpDownCity
            // 
            this.numericUpDownCity.Location = new System.Drawing.Point(434, 22);
            this.numericUpDownCity.Name = "numericUpDownCity";
            this.numericUpDownCity.Size = new System.Drawing.Size(37, 20);
            this.numericUpDownCity.TabIndex = 10;
            // 
            // buttonAcceptPlace
            // 
            this.buttonAcceptPlace.Location = new System.Drawing.Point(640, 19);
            this.buttonAcceptPlace.Name = "buttonAcceptPlace";
            this.buttonAcceptPlace.Size = new System.Drawing.Size(64, 23);
            this.buttonAcceptPlace.TabIndex = 4;
            this.buttonAcceptPlace.Text = "Accept";
            this.buttonAcceptPlace.UseVisualStyleBackColor = true;
            this.buttonAcceptPlace.Click += new System.EventHandler(this.ButtonAcceptPlace_Click);
            // 
            // buttonAcceptCity
            // 
            this.buttonAcceptCity.Location = new System.Drawing.Point(231, 19);
            this.buttonAcceptCity.Name = "buttonAcceptCity";
            this.buttonAcceptCity.Size = new System.Drawing.Size(64, 23);
            this.buttonAcceptCity.TabIndex = 1;
            this.buttonAcceptCity.Text = "Accept";
            this.buttonAcceptCity.UseVisualStyleBackColor = true;
            this.buttonAcceptCity.Click += new System.EventHandler(this.ButtonAcceptCity_Click);
            // 
            // textBoxNumberOfPlaces
            // 
            this.textBoxNumberOfPlaces.Location = new System.Drawing.Point(615, 22);
            this.textBoxNumberOfPlaces.Name = "textBoxNumberOfPlaces";
            this.textBoxNumberOfPlaces.Size = new System.Drawing.Size(19, 20);
            this.textBoxNumberOfPlaces.TabIndex = 6;
            // 
            // textBoxNumberOfCities
            // 
            this.textBoxNumberOfCities.Location = new System.Drawing.Point(98, 21);
            this.textBoxNumberOfCities.Name = "textBoxNumberOfCities";
            this.textBoxNumberOfCities.Size = new System.Drawing.Size(25, 20);
            this.textBoxNumberOfCities.TabIndex = 11;
            // 
            // groupBoxCitiesPlaces
            // 
            this.groupBoxCitiesPlaces.Controls.Add(this.label7);
            this.groupBoxCitiesPlaces.Controls.Add(this.tbSrc);
            this.groupBoxCitiesPlaces.Controls.Add(this.btnSetRoads);
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
            this.groupBoxCitiesPlaces.Location = new System.Drawing.Point(12, 12);
            this.groupBoxCitiesPlaces.Name = "groupBoxCitiesPlaces";
            this.groupBoxCitiesPlaces.Size = new System.Drawing.Size(710, 353);
            this.groupBoxCitiesPlaces.TabIndex = 12;
            this.groupBoxCitiesPlaces.TabStop = false;
            this.groupBoxCitiesPlaces.Text = "Cities and places ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(129, 24);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Start city #:";
            // 
            // tbSrc
            // 
            this.tbSrc.Location = new System.Drawing.Point(200, 21);
            this.tbSrc.Name = "tbSrc";
            this.tbSrc.Size = new System.Drawing.Size(25, 20);
            this.tbSrc.TabIndex = 15;
            // 
            // btnSetRoads
            // 
            this.btnSetRoads.Location = new System.Drawing.Point(312, 48);
            this.btnSetRoads.Name = "btnSetRoads";
            this.btnSetRoads.Size = new System.Drawing.Size(75, 300);
            this.btnSetRoads.TabIndex = 14;
            this.btnSetRoads.Text = "Set road map";
            this.btnSetRoads.UseVisualStyleBackColor = true;
            this.btnSetRoads.Click += new System.EventHandler(this.btnSetRoads_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(404, 311);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(301, 20);
            this.textBox1.TabIndex = 13;
            // 
            // btn_bfs
            // 
            this.btn_bfs.AutoSize = true;
            this.btn_bfs.Location = new System.Drawing.Point(526, 266);
            this.btn_bfs.Margin = new System.Windows.Forms.Padding(2);
            this.btn_bfs.Name = "btn_bfs";
            this.btn_bfs.Size = new System.Drawing.Size(82, 36);
            this.btn_bfs.TabIndex = 12;
            this.btn_bfs.Text = "Show rezult";
            this.btn_bfs.UseVisualStyleBackColor = true;
            this.btn_bfs.Click += new System.EventHandler(this.btn_bfs_Click);
            // 
            // groupBoxGoods
            // 
            this.groupBoxGoods.Controls.Add(this.btnRes);
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
            this.groupBoxGoods.Location = new System.Drawing.Point(12, 371);
            this.groupBoxGoods.Name = "groupBoxGoods";
            this.groupBoxGoods.Size = new System.Drawing.Size(710, 178);
            this.groupBoxGoods.TabIndex = 13;
            this.groupBoxGoods.TabStop = false;
            this.groupBoxGoods.Text = "Goods";
            // 
            // btnRes
            // 
            this.btnRes.BackColor = System.Drawing.Color.Red;
            this.btnRes.Enabled = false;
            this.btnRes.ForeColor = System.Drawing.Color.Black;
            this.btnRes.Location = new System.Drawing.Point(9, 119);
            this.btnRes.Name = "btnRes";
            this.btnRes.Size = new System.Drawing.Size(155, 59);
            this.btnRes.TabIndex = 16;
            this.btnRes.Text = "SHOW ANSWER";
            this.btnRes.UseVisualStyleBackColor = false;
            this.btnRes.Click += new System.EventHandler(this.btnRes_Click);
            // 
            // btnShowGoods
            // 
            this.btnShowGoods.Location = new System.Drawing.Point(170, 119);
            this.btnShowGoods.Name = "btnShowGoods";
            this.btnShowGoods.Size = new System.Drawing.Size(62, 23);
            this.btnShowGoods.TabIndex = 14;
            this.btnShowGoods.Text = "Show ";
            this.btnShowGoods.UseVisualStyleBackColor = true;
            this.btnShowGoods.Click += new System.EventHandler(this.btnShowGoods_Click);
            // 
            // buttonSortPrice
            // 
            this.buttonSortPrice.Location = new System.Drawing.Point(298, 119);
            this.buttonSortPrice.Name = "buttonSortPrice";
            this.buttonSortPrice.Size = new System.Drawing.Size(100, 44);
            this.buttonSortPrice.TabIndex = 15;
            this.buttonSortPrice.Text = "Sort by price";
            this.buttonSortPrice.UseVisualStyleBackColor = true;
            this.buttonSortPrice.Click += new System.EventHandler(this.ButtonSortPrice_Click);
            // 
            // buttonSortWeight
            // 
            this.buttonSortWeight.Location = new System.Drawing.Point(298, 69);
            this.buttonSortWeight.Name = "buttonSortWeight";
            this.buttonSortWeight.Size = new System.Drawing.Size(100, 44);
            this.buttonSortWeight.TabIndex = 14;
            this.buttonSortWeight.Text = "Sort by weight";
            this.buttonSortWeight.UseVisualStyleBackColor = true;
            this.buttonSortWeight.Click += new System.EventHandler(this.ButtonSortWeight_Click);
            // 
            // buttonSortName
            // 
            this.buttonSortName.Location = new System.Drawing.Point(298, 19);
            this.buttonSortName.Name = "buttonSortName";
            this.buttonSortName.Size = new System.Drawing.Size(100, 44);
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
            this.dataGridViewGoods.Location = new System.Drawing.Point(404, 19);
            this.dataGridViewGoods.Name = "dataGridViewGoods";
            this.dataGridViewGoods.ReadOnly = true;
            this.dataGridViewGoods.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridViewGoods.RowHeadersVisible = false;
            this.dataGridViewGoods.RowTemplate.ReadOnly = true;
            this.dataGridViewGoods.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridViewGoods.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataGridViewGoods.Size = new System.Drawing.Size(300, 144);
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
            this.buttonAdd.Location = new System.Drawing.Point(170, 29);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(62, 72);
            this.buttonAdd.TabIndex = 6;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.ButtonAdd_Click);
            // 
            // textBoxWeight
            // 
            this.textBoxWeight.Location = new System.Drawing.Point(64, 56);
            this.textBoxWeight.Name = "textBoxWeight";
            this.textBoxWeight.Size = new System.Drawing.Size(100, 20);
            this.textBoxWeight.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 59);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Weight:";
            // 
            // textBoxPrice
            // 
            this.textBoxPrice.Location = new System.Drawing.Point(64, 82);
            this.textBoxPrice.Name = "textBoxPrice";
            this.textBoxPrice.Size = new System.Drawing.Size(100, 20);
            this.textBoxPrice.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 85);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Price:";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(64, 30);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(100, 20);
            this.textBoxName.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Name:";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 561);
            this.Controls.Add(this.groupBoxGoods);
            this.Controls.Add(this.groupBoxCitiesPlaces);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
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
        private System.Windows.Forms.Button btnRes;
        private System.Windows.Forms.Button btnSetRoads;
        private System.Windows.Forms.TextBox tbSrc;
        private System.Windows.Forms.Label label7;
    }
}

