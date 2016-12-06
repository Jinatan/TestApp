namespace TestTask
{
    partial class XMLViewer
    {
        /// <summary>
        /// Требуется переменная конструктора.
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
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.Browse = new System.Windows.Forms.Button();
            this.Add = new System.Windows.Forms.Button();
            this.Remove = new System.Windows.Forms.Button();
            this.SaveAll = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Component = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Edit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.removeCount = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // Browse
            // 
            this.Browse.Location = new System.Drawing.Point(405, 29);
            this.Browse.Name = "Browse";
            this.Browse.Size = new System.Drawing.Size(97, 28);
            this.Browse.TabIndex = 1;
            this.Browse.Text = "Browse";
            this.Browse.UseVisualStyleBackColor = true;
            this.Browse.Click += new System.EventHandler(this.Browse_Click);
            // 
            // Add
            // 
            this.Add.Location = new System.Drawing.Point(405, 74);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(97, 23);
            this.Add.TabIndex = 2;
            this.Add.Text = "Add ";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // Remove
            // 
            this.Remove.Location = new System.Drawing.Point(393, 262);
            this.Remove.Name = "Remove";
            this.Remove.Size = new System.Drawing.Size(97, 23);
            this.Remove.TabIndex = 3;
            this.Remove.Text = "Remove";
            this.Remove.UseVisualStyleBackColor = true;
            this.Remove.Click += new System.EventHandler(this.Remove_Click);
            // 
            // SaveAll
            // 
            this.SaveAll.Location = new System.Drawing.Point(405, 155);
            this.SaveAll.Name = "SaveAll";
            this.SaveAll.Size = new System.Drawing.Size(97, 30);
            this.SaveAll.TabIndex = 4;
            this.SaveAll.Text = "Save All";
            this.SaveAll.UseVisualStyleBackColor = true;
            this.SaveAll.Click += new System.EventHandler(this.SaveAll_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Component,
            this.Column2,
            this.Column3});
            this.dataGridView1.Location = new System.Drawing.Point(0, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(367, 299);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Component
            // 
            this.Component.HeaderText = "Component";
            this.Component.Name = "Component";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Allow";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "";
            this.Column3.Name = "Column3";
            // 
            // Edit
            // 
            this.Edit.Location = new System.Drawing.Point(405, 116);
            this.Edit.Name = "Edit";
            this.Edit.Size = new System.Drawing.Size(97, 23);
            this.Edit.TabIndex = 5;
            this.Edit.Text = "Edit";
            this.Edit.UseVisualStyleBackColor = true;
            this.Edit.Click += new System.EventHandler(this.Edit_Click);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(393, 205);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 38);
            this.label1.TabIndex = 6;
            this.label1.Text = "Please enter amount of tags to delete ";
            // 
            // removeCount
            // 
            this.removeCount.Location = new System.Drawing.Point(393, 236);
            this.removeCount.Name = "removeCount";
            this.removeCount.Size = new System.Drawing.Size(100, 20);
            this.removeCount.TabIndex = 7;
            // 
            // XMLViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(514, 323);
            this.Controls.Add(this.removeCount);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Edit);
            this.Controls.Add(this.SaveAll);
            this.Controls.Add(this.Remove);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.Browse);
            this.Controls.Add(this.dataGridView1);
            this.Name = "XMLViewer";
            this.Text = "XMLManager";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Browse;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.Button Remove;
        private System.Windows.Forms.Button SaveAll;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Component;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Column2;
        private System.Windows.Forms.DataGridViewButtonColumn Column3;
        private System.Windows.Forms.Button Edit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox removeCount;
    }
}

