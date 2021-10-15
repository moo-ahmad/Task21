namespace Task21
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
            this.titleLabel = new System.Windows.Forms.Label();
            this.minimumTextBox = new System.Windows.Forms.TextBox();
            this.maximumTextBox = new System.Windows.Forms.TextBox();
            this.minLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.dataGridViewTable = new System.Windows.Forms.DataGridView();
            this.dataGridViewPlayerAvg = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPlayerAvg)).BeginInit();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.Location = new System.Drawing.Point(171, 20);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(479, 33);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "Baseball Database App Modification";
            // 
            // minimumTextBox
            // 
            this.minimumTextBox.Location = new System.Drawing.Point(286, 85);
            this.minimumTextBox.Name = "minimumTextBox";
            this.minimumTextBox.Size = new System.Drawing.Size(142, 20);
            this.minimumTextBox.TabIndex = 1;
            // 
            // maximumTextBox
            // 
            this.maximumTextBox.Location = new System.Drawing.Point(286, 120);
            this.maximumTextBox.Name = "maximumTextBox";
            this.maximumTextBox.Size = new System.Drawing.Size(142, 20);
            this.maximumTextBox.TabIndex = 2;
            // 
            // minLabel
            // 
            this.minLabel.AutoSize = true;
            this.minLabel.Location = new System.Drawing.Point(182, 88);
            this.minLabel.Name = "minLabel";
            this.minLabel.Size = new System.Drawing.Size(98, 13);
            this.minLabel.TabIndex = 3;
            this.minLabel.Text = "Enter Minimum Avg";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(179, 123);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Enter Maximum Avg";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(286, 156);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 5;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // dataGridViewTable
            // 
            this.dataGridViewTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTable.Location = new System.Drawing.Point(71, 238);
            this.dataGridViewTable.Name = "dataGridViewTable";
            this.dataGridViewTable.Size = new System.Drawing.Size(240, 150);
            this.dataGridViewTable.TabIndex = 6;
            // 
            // dataGridViewPlayerAvg
            // 
            this.dataGridViewPlayerAvg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPlayerAvg.Location = new System.Drawing.Point(444, 238);
            this.dataGridViewPlayerAvg.Name = "dataGridViewPlayerAvg";
            this.dataGridViewPlayerAvg.Size = new System.Drawing.Size(240, 150);
            this.dataGridViewPlayerAvg.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridViewPlayerAvg);
            this.Controls.Add(this.dataGridViewTable);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.minLabel);
            this.Controls.Add(this.maximumTextBox);
            this.Controls.Add(this.minimumTextBox);
            this.Controls.Add(this.titleLabel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPlayerAvg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.TextBox minimumTextBox;
        private System.Windows.Forms.TextBox maximumTextBox;
        private System.Windows.Forms.Label minLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DataGridView dataGridViewTable;
        private System.Windows.Forms.DataGridView dataGridViewPlayerAvg;
    }
}

