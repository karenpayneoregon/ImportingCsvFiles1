namespace Example1
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.PerfectWorldExampleDataTableButton = new System.Windows.Forms.Button();
            this.SpacesInLinesButton = new System.Windows.Forms.Button();
            this.RealWorldGoodButton = new System.Windows.Forms.Button();
            this.RealWorldBad1Button = new System.Windows.Forms.Button();
            this.PerfectWorldExampleListButton = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ValidateDateColumnButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.ValidateDateColumnButton);
            this.panel1.Controls.Add(this.PerfectWorldExampleDataTableButton);
            this.panel1.Controls.Add(this.SpacesInLinesButton);
            this.panel1.Controls.Add(this.RealWorldGoodButton);
            this.panel1.Controls.Add(this.RealWorldBad1Button);
            this.panel1.Controls.Add(this.PerfectWorldExampleListButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 382);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(897, 68);
            this.panel1.TabIndex = 0;
            // 
            // PerfectWorldExampleDataTableButton
            // 
            this.PerfectWorldExampleDataTableButton.Location = new System.Drawing.Point(12, 38);
            this.PerfectWorldExampleDataTableButton.Name = "PerfectWorldExampleDataTableButton";
            this.PerfectWorldExampleDataTableButton.Size = new System.Drawing.Size(199, 23);
            this.PerfectWorldExampleDataTableButton.TabIndex = 6;
            this.PerfectWorldExampleDataTableButton.Text = "Perfect World example (DataTable)";
            this.PerfectWorldExampleDataTableButton.UseVisualStyleBackColor = true;
            this.PerfectWorldExampleDataTableButton.Click += new System.EventHandler(this.PerfectWorldExampleDataTableButton_Click);
            // 
            // SpacesInLinesButton
            // 
            this.SpacesInLinesButton.Location = new System.Drawing.Point(627, 9);
            this.SpacesInLinesButton.Name = "SpacesInLinesButton";
            this.SpacesInLinesButton.Size = new System.Drawing.Size(199, 23);
            this.SpacesInLinesButton.TabIndex = 5;
            this.SpacesInLinesButton.Text = "Spaces in fields";
            this.SpacesInLinesButton.UseVisualStyleBackColor = true;
            this.SpacesInLinesButton.Click += new System.EventHandler(this.SpacesInLinesButton_Click);
            // 
            // RealWorldGoodButton
            // 
            this.RealWorldGoodButton.Location = new System.Drawing.Point(422, 9);
            this.RealWorldGoodButton.Name = "RealWorldGoodButton";
            this.RealWorldGoodButton.Size = new System.Drawing.Size(199, 23);
            this.RealWorldGoodButton.TabIndex = 4;
            this.RealWorldGoodButton.Text = "Real World example 2 (good)";
            this.RealWorldGoodButton.UseVisualStyleBackColor = true;
            this.RealWorldGoodButton.Click += new System.EventHandler(this.RealWorldGoodButton_Click);
            // 
            // RealWorldBad1Button
            // 
            this.RealWorldBad1Button.Location = new System.Drawing.Point(217, 9);
            this.RealWorldBad1Button.Name = "RealWorldBad1Button";
            this.RealWorldBad1Button.Size = new System.Drawing.Size(199, 23);
            this.RealWorldBad1Button.TabIndex = 3;
            this.RealWorldBad1Button.Text = "Real World example 1 (bad)";
            this.RealWorldBad1Button.UseVisualStyleBackColor = true;
            this.RealWorldBad1Button.Click += new System.EventHandler(this.RealWorldBad1Button_Click);
            // 
            // PerfectWorldExampleListButton
            // 
            this.PerfectWorldExampleListButton.Location = new System.Drawing.Point(12, 9);
            this.PerfectWorldExampleListButton.Name = "PerfectWorldExampleListButton";
            this.PerfectWorldExampleListButton.Size = new System.Drawing.Size(199, 23);
            this.PerfectWorldExampleListButton.TabIndex = 2;
            this.PerfectWorldExampleListButton.Text = "Perfect World example (list)";
            this.PerfectWorldExampleListButton.UseVisualStyleBackColor = true;
            this.PerfectWorldExampleListButton.Click += new System.EventHandler(this.PerfectWorldExampleListButton_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(897, 382);
            this.dataGridView1.TabIndex = 1;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "FirstName";
            this.Column1.HeaderText = "First name";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "LastName";
            this.Column2.HeaderText = "Last name";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "Street";
            this.Column3.HeaderText = "Street";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "City";
            this.Column4.HeaderText = "City";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "State";
            this.Column5.HeaderText = "State";
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "Country";
            this.Column6.HeaderText = "Country";
            this.Column6.Name = "Column6";
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "Balance";
            this.Column7.HeaderText = "Balance";
            this.Column7.Name = "Column7";
            // 
            // Column8
            // 
            this.Column8.DataPropertyName = "LastPaid";
            dataGridViewCellStyle1.Format = "d";
            dataGridViewCellStyle1.NullValue = null;
            this.Column8.DefaultCellStyle = dataGridViewCellStyle1;
            this.Column8.HeaderText = "Last paid";
            this.Column8.Name = "Column8";
            // 
            // ValidateDateColumnButton
            // 
            this.ValidateDateColumnButton.Location = new System.Drawing.Point(627, 38);
            this.ValidateDateColumnButton.Name = "ValidateDateColumnButton";
            this.ValidateDateColumnButton.Size = new System.Drawing.Size(199, 23);
            this.ValidateDateColumnButton.TabIndex = 7;
            this.ValidateDateColumnButton.Text = "Validate date column";
            this.ValidateDateColumnButton.UseVisualStyleBackColor = true;
            this.ValidateDateColumnButton.Click += new System.EventHandler(this.ValidateDateColumnButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(897, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reading delimited file";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button PerfectWorldExampleListButton;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.Button RealWorldBad1Button;
        private System.Windows.Forms.Button RealWorldGoodButton;
        private System.Windows.Forms.Button SpacesInLinesButton;
        private System.Windows.Forms.Button PerfectWorldExampleDataTableButton;
        private System.Windows.Forms.Button ValidateDateColumnButton;
    }
}

