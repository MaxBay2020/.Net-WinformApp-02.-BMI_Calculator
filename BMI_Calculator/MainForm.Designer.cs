namespace BMI_Calculator
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.BMI_tab = new System.Windows.Forms.TabControl();
            this.bmi = new System.Windows.Forms.TabPage();
            this.weight_comb = new System.Windows.Forms.ComboBox();
            this.height_comb = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.confirm_btn = new System.Windows.Forms.Button();
            this.weight_txt = new System.Windows.Forms.TextBox();
            this.height_txt = new System.Windows.Forms.TextBox();
            this.name_txt = new System.Windows.Forms.TextBox();
            this.weight_lbl = new System.Windows.Forms.Label();
            this.height_lbl = new System.Windows.Forms.Label();
            this.name_lbl = new System.Windows.Forms.Label();
            this.history = new System.Windows.Forms.TabPage();
            this.importBtn = new System.Windows.Forms.Button();
            this.insert_btn = new System.Windows.Forms.Button();
            this.import_btn = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.BMI_tab.SuspendLayout();
            this.bmi.SuspendLayout();
            this.history.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // BMI_tab
            // 
            this.BMI_tab.Controls.Add(this.bmi);
            this.BMI_tab.Controls.Add(this.history);
            this.BMI_tab.Location = new System.Drawing.Point(-3, -5);
            this.BMI_tab.Name = "BMI_tab";
            this.BMI_tab.SelectedIndex = 0;
            this.BMI_tab.Size = new System.Drawing.Size(735, 352);
            this.BMI_tab.TabIndex = 9;
            // 
            // bmi
            // 
            this.bmi.BackColor = System.Drawing.Color.LightSteelBlue;
            this.bmi.Controls.Add(this.weight_comb);
            this.bmi.Controls.Add(this.height_comb);
            this.bmi.Controls.Add(this.button1);
            this.bmi.Controls.Add(this.confirm_btn);
            this.bmi.Controls.Add(this.weight_txt);
            this.bmi.Controls.Add(this.height_txt);
            this.bmi.Controls.Add(this.name_txt);
            this.bmi.Controls.Add(this.weight_lbl);
            this.bmi.Controls.Add(this.height_lbl);
            this.bmi.Controls.Add(this.name_lbl);
            this.bmi.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.bmi.Location = new System.Drawing.Point(4, 22);
            this.bmi.Name = "bmi";
            this.bmi.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.bmi.Size = new System.Drawing.Size(727, 326);
            this.bmi.TabIndex = 0;
            this.bmi.Text = "BMI";
            // 
            // weight_comb
            // 
            this.weight_comb.FormattingEnabled = true;
            this.weight_comb.Items.AddRange(new object[] {
            "kg",
            "pound"});
            this.weight_comb.Location = new System.Drawing.Point(478, 162);
            this.weight_comb.Name = "weight_comb";
            this.weight_comb.Size = new System.Drawing.Size(70, 28);
            this.weight_comb.TabIndex = 19;
            // 
            // height_comb
            // 
            this.height_comb.FormattingEnabled = true;
            this.height_comb.Items.AddRange(new object[] {
            "cm",
            "inch"});
            this.height_comb.Location = new System.Drawing.Point(477, 99);
            this.height_comb.Name = "height_comb";
            this.height_comb.Size = new System.Drawing.Size(71, 28);
            this.height_comb.TabIndex = 18;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.button1.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.button1.Location = new System.Drawing.Point(357, 224);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(84, 38);
            this.button1.TabIndex = 15;
            this.button1.Text = "Manu";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // confirm_btn
            // 
            this.confirm_btn.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.confirm_btn.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirm_btn.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.confirm_btn.Location = new System.Drawing.Point(213, 224);
            this.confirm_btn.Name = "confirm_btn";
            this.confirm_btn.Size = new System.Drawing.Size(84, 38);
            this.confirm_btn.TabIndex = 14;
            this.confirm_btn.Text = "Confirm";
            this.confirm_btn.UseVisualStyleBackColor = false;
            this.confirm_btn.Click += new System.EventHandler(this.confirm_btn_Click);
            // 
            // weight_txt
            // 
            this.weight_txt.BackColor = System.Drawing.SystemColors.Window;
            this.weight_txt.Location = new System.Drawing.Point(213, 162);
            this.weight_txt.Name = "weight_txt";
            this.weight_txt.Size = new System.Drawing.Size(228, 26);
            this.weight_txt.TabIndex = 13;
            // 
            // height_txt
            // 
            this.height_txt.BackColor = System.Drawing.SystemColors.Window;
            this.height_txt.Location = new System.Drawing.Point(213, 99);
            this.height_txt.Name = "height_txt";
            this.height_txt.Size = new System.Drawing.Size(228, 26);
            this.height_txt.TabIndex = 12;
            // 
            // name_txt
            // 
            this.name_txt.BackColor = System.Drawing.SystemColors.Window;
            this.name_txt.Location = new System.Drawing.Point(213, 40);
            this.name_txt.Name = "name_txt";
            this.name_txt.Size = new System.Drawing.Size(228, 26);
            this.name_txt.TabIndex = 11;
            // 
            // weight_lbl
            // 
            this.weight_lbl.AutoSize = true;
            this.weight_lbl.ForeColor = System.Drawing.SystemColors.Desktop;
            this.weight_lbl.Location = new System.Drawing.Point(138, 165);
            this.weight_lbl.Name = "weight_lbl";
            this.weight_lbl.Size = new System.Drawing.Size(61, 20);
            this.weight_lbl.TabIndex = 10;
            this.weight_lbl.Text = "Weight:";
            // 
            // height_lbl
            // 
            this.height_lbl.AutoSize = true;
            this.height_lbl.ForeColor = System.Drawing.SystemColors.Desktop;
            this.height_lbl.Location = new System.Drawing.Point(142, 102);
            this.height_lbl.Name = "height_lbl";
            this.height_lbl.Size = new System.Drawing.Size(58, 20);
            this.height_lbl.TabIndex = 9;
            this.height_lbl.Text = "Height:";
            // 
            // name_lbl
            // 
            this.name_lbl.AutoSize = true;
            this.name_lbl.ForeColor = System.Drawing.SystemColors.Desktop;
            this.name_lbl.Location = new System.Drawing.Point(147, 43);
            this.name_lbl.Name = "name_lbl";
            this.name_lbl.Size = new System.Drawing.Size(52, 20);
            this.name_lbl.TabIndex = 8;
            this.name_lbl.Text = "Name:";
            // 
            // history
            // 
            this.history.BackColor = System.Drawing.Color.White;
            this.history.Controls.Add(this.importBtn);
            this.history.Controls.Add(this.insert_btn);
            this.history.Controls.Add(this.import_btn);
            this.history.Controls.Add(this.dataGridView1);
            this.history.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.history.Location = new System.Drawing.Point(4, 22);
            this.history.Name = "history";
            this.history.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.history.Size = new System.Drawing.Size(727, 326);
            this.history.TabIndex = 1;
            this.history.Text = "History";
            // 
            // importBtn
            // 
            this.importBtn.Location = new System.Drawing.Point(6, 6);
            this.importBtn.Name = "importBtn";
            this.importBtn.Size = new System.Drawing.Size(75, 36);
            this.importBtn.TabIndex = 3;
            this.importBtn.Text = "Import";
            this.importBtn.UseVisualStyleBackColor = true;
            this.importBtn.Click += new System.EventHandler(this.importBtn_Click);
            // 
            // insert_btn
            // 
            this.insert_btn.Location = new System.Drawing.Point(97, 6);
            this.insert_btn.Name = "insert_btn";
            this.insert_btn.Size = new System.Drawing.Size(75, 36);
            this.insert_btn.TabIndex = 2;
            this.insert_btn.Text = "Insert";
            this.insert_btn.UseVisualStyleBackColor = true;
            this.insert_btn.Click += new System.EventHandler(this.insert_btn_Click);
            // 
            // import_btn
            // 
            this.import_btn.Location = new System.Drawing.Point(188, 6);
            this.import_btn.Name = "import_btn";
            this.import_btn.Size = new System.Drawing.Size(75, 36);
            this.import_btn.TabIndex = 1;
            this.import_btn.Text = "Delete";
            this.import_btn.UseVisualStyleBackColor = true;
            this.import_btn.Click += new System.EventHandler(this.import_btn_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 48);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 82;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(711, 272);
            this.dataGridView1.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(722, 344);
            this.Controls.Add(this.BMI_tab);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.BMI_tab.ResumeLayout(false);
            this.bmi.ResumeLayout(false);
            this.bmi.PerformLayout();
            this.history.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl BMI_tab;
        private System.Windows.Forms.TabPage bmi;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button confirm_btn;
        private System.Windows.Forms.TextBox weight_txt;
        private System.Windows.Forms.TextBox height_txt;
        private System.Windows.Forms.TextBox name_txt;
        private System.Windows.Forms.Label weight_lbl;
        private System.Windows.Forms.Label height_lbl;
        private System.Windows.Forms.Label name_lbl;
        private System.Windows.Forms.TabPage history;
        private System.Windows.Forms.ComboBox weight_comb;
        private System.Windows.Forms.ComboBox height_comb;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button import_btn;
        private System.Windows.Forms.Button insert_btn;
        private System.Windows.Forms.Button importBtn;
    }
}