namespace program_lab5
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtFullName = new TextBox();
            nudCount = new NumericUpDown();
            nudTotalWeight = new NumericUpDown();
            btnAdd = new Button();
            btnDelete = new Button();
            btnSave = new Button();
            btnLoad = new Button();
            nudWeightThreshold = new NumericUpDown();
            btnFilter = new Button();
            btnSort = new Button();
            listViewCloakRooms = new ListView();
            colFullName = new ColumnHeader();
            colCount = new ColumnHeader();
            colTotalWeight = new ColumnHeader();
            lblStatus = new Label();
            ((System.ComponentModel.ISupportInitialize)nudCount).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudTotalWeight).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudWeightThreshold).BeginInit();
            SuspendLayout();
            // 
            // txtFullName
            // 
            txtFullName.Location = new Point(10, 10);
            txtFullName.Name = "txtFullName";
            txtFullName.Size = new Size(300, 27);
            txtFullName.TabIndex = 0;
            // 
            // nudCount
            // 
            nudCount.Location = new Point(10, 45);
            nudCount.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            nudCount.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudCount.Name = "nudCount";
            nudCount.Size = new Size(100, 27);
            nudCount.TabIndex = 1;
            nudCount.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // nudTotalWeight
            // 
            nudTotalWeight.DecimalPlaces = 1;
            nudTotalWeight.Location = new Point(120, 45);
            nudTotalWeight.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            nudTotalWeight.Name = "nudTotalWeight";
            nudTotalWeight.Size = new Size(100, 27);
            nudTotalWeight.TabIndex = 2;
            nudTotalWeight.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(10, 85);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(80, 30);
            btnAdd.TabIndex = 3;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += BtnAdd_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(100, 85);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(80, 30);
            btnDelete.TabIndex = 4;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += BtnDelete_Click;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(190, 85);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(80, 30);
            btnSave.TabIndex = 5;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += BtnSave_Click;
            // 
            // btnLoad
            // 
            btnLoad.Location = new Point(280, 85);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new Size(80, 30);
            btnLoad.TabIndex = 6;
            btnLoad.Text = "Load";
            btnLoad.UseVisualStyleBackColor = true;
            btnLoad.Click += BtnLoad_Click;
            // 
            // nudWeightThreshold
            // 
            nudWeightThreshold.DecimalPlaces = 1;
            nudWeightThreshold.Location = new Point(10, 125);
            nudWeightThreshold.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            nudWeightThreshold.Name = "nudWeightThreshold";
            nudWeightThreshold.Size = new Size(100, 27);
            nudWeightThreshold.TabIndex = 9;
            // 
            // btnFilter
            // 
            btnFilter.Location = new Point(120, 125);
            btnFilter.Name = "btnFilter";
            btnFilter.Size = new Size(80, 30);
            btnFilter.TabIndex = 10;
            btnFilter.Text = "Filter";
            btnFilter.UseVisualStyleBackColor = true;
            btnFilter.Click += BtnFilter_Click;
            // 
            // btnSort
            // 
            btnSort.Location = new Point(210, 125);
            btnSort.Name = "btnSort";
            btnSort.Size = new Size(80, 30);
            btnSort.TabIndex = 11;
            btnSort.Text = "Sort";
            btnSort.UseVisualStyleBackColor = true;
            btnSort.Click += BtnSort_Click;
            // 
            // listViewCloakRooms
            // 
            listViewCloakRooms.Columns.AddRange(new ColumnHeader[] { colFullName, colCount, colTotalWeight });
            listViewCloakRooms.FullRowSelect = true;
            listViewCloakRooms.Location = new Point(10, 170);
            listViewCloakRooms.Name = "listViewCloakRooms";
            listViewCloakRooms.Size = new Size(760, 220);
            listViewCloakRooms.TabIndex = 12;
            listViewCloakRooms.UseCompatibleStateImageBehavior = false;
            listViewCloakRooms.View = View.Details;
            listViewCloakRooms.SelectedIndexChanged += LstCloakRooms_SelectedIndexChanged;
            // 
            // colFullName
            // 
            colFullName.Text = "ПІБ";
            colFullName.Width = 400;
            // 
            // colCount
            // 
            colCount.Text = "Кількість";
            colCount.Width = 120;
            // 
            // colTotalWeight
            // 
            colTotalWeight.Text = "Загальна вага";
            colTotalWeight.Width = 120;
            // 
            // lblStatus
            // 
            lblStatus.Location = new Point(10, 400);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(760, 30);
            lblStatus.TabIndex = 13;
            lblStatus.Text = "Ready";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtFullName);
            Controls.Add(nudCount);
            Controls.Add(nudTotalWeight);
            Controls.Add(btnAdd);
            Controls.Add(btnDelete);
            Controls.Add(btnSave);
            Controls.Add(btnLoad);
            Controls.Add(nudWeightThreshold);
            Controls.Add(btnFilter);
            Controls.Add(btnSort);
            Controls.Add(listViewCloakRooms);
            Controls.Add(lblStatus);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)nudCount).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudTotalWeight).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudWeightThreshold).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TextBox txtFullName;
        private System.Windows.Forms.NumericUpDown nudCount;
        private System.Windows.Forms.NumericUpDown nudTotalWeight;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.NumericUpDown nudWeightThreshold;
        private System.Windows.Forms.Button btnFilter;
        private System.Windows.Forms.Button btnSort;
        private System.Windows.Forms.ListView listViewCloakRooms;
        private System.Windows.Forms.ColumnHeader colFullName;
        private System.Windows.Forms.ColumnHeader colCount;
        private System.Windows.Forms.ColumnHeader colTotalWeight;
        private System.Windows.Forms.Label lblStatus;
    }
}
