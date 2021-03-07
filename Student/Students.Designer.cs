
namespace DatabaseAssignment
{
    partial class Students
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
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.AddButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.ViewButton = new System.Windows.Forms.Button();
            this.StudentGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.StudentGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(469, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 32);
            this.label3.TabIndex = 16;
            this.label3.Text = "Class";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 141);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(208, 32);
            this.label2.TabIndex = 17;
            this.label2.Text = "Student Name";
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(566, 144);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(204, 30);
            this.textBox2.TabIndex = 12;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(237, 144);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(204, 30);
            this.textBox1.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(330, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(289, 55);
            this.label1.TabIndex = 11;
            this.label1.Text = "Student List";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(807, 491);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(156, 62);
            this.button4.TabIndex = 6;
            this.button4.Text = "Delete";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(807, 399);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(156, 62);
            this.button3.TabIndex = 7;
            this.button3.Text = "Edit Student";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // AddButton
            // 
            this.AddButton.AccessibleName = "button2";
            this.AddButton.Location = new System.Drawing.Point(807, 306);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(156, 62);
            this.AddButton.TabIndex = 8;
            this.AddButton.Text = "Add Student";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(807, 131);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(156, 62);
            this.button1.TabIndex = 9;
            this.button1.Text = "Search";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ViewButton
            // 
            this.ViewButton.Location = new System.Drawing.Point(807, 222);
            this.ViewButton.Name = "ViewButton";
            this.ViewButton.Size = new System.Drawing.Size(156, 62);
            this.ViewButton.TabIndex = 10;
            this.ViewButton.Text = "View List";
            this.ViewButton.UseVisualStyleBackColor = true;
            this.ViewButton.Click += new System.EventHandler(this.ViewButton_Click);
            // 
            // StudentGridView
            // 
            this.StudentGridView.AllowUserToOrderColumns = true;
            this.StudentGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.StudentGridView.Location = new System.Drawing.Point(31, 209);
            this.StudentGridView.Name = "StudentGridView";
            this.StudentGridView.RowHeadersWidth = 51;
            this.StudentGridView.RowTemplate.Height = 24;
            this.StudentGridView.Size = new System.Drawing.Size(739, 354);
            this.StudentGridView.TabIndex = 5;
            // 
            // Students
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 593);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ViewButton);
            this.Controls.Add(this.StudentGridView);
            this.Name = "Students";
            this.Text = "Students";
            ((System.ComponentModel.ISupportInitialize)(this.StudentGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button ViewButton;
        private System.Windows.Forms.DataGridView StudentGridView;
    }
}