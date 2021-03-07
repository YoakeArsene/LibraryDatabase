
namespace DatabaseAssignment
{
    partial class Library
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
            this.LibraryGridView = new System.Windows.Forms.DataGridView();
            this.ViewButton = new System.Windows.Forms.Button();
            this.AddButton = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.LibraryGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // LibraryGridView
            // 
            this.LibraryGridView.AllowUserToOrderColumns = true;
            this.LibraryGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.LibraryGridView.Location = new System.Drawing.Point(27, 199);
            this.LibraryGridView.Name = "LibraryGridView";
            this.LibraryGridView.RowHeadersWidth = 51;
            this.LibraryGridView.RowTemplate.Height = 24;
            this.LibraryGridView.Size = new System.Drawing.Size(1005, 354);
            this.LibraryGridView.TabIndex = 0;
            this.LibraryGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.LibraryGridView_CellContentClick);
            // 
            // ViewButton
            // 
            this.ViewButton.Location = new System.Drawing.Point(1063, 199);
            this.ViewButton.Name = "ViewButton";
            this.ViewButton.Size = new System.Drawing.Size(156, 62);
            this.ViewButton.TabIndex = 1;
            this.ViewButton.Text = "View Library";
            this.ViewButton.UseVisualStyleBackColor = true;
            this.ViewButton.Click += new System.EventHandler(this.ViewButton_Click);
            // 
            // AddButton
            // 
            this.AddButton.AccessibleName = "button2";
            this.AddButton.Location = new System.Drawing.Point(1063, 291);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(156, 62);
            this.AddButton.TabIndex = 1;
            this.AddButton.Text = "Add Book";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(1063, 386);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(156, 62);
            this.button3.TabIndex = 1;
            this.button3.Text = "Edit Book";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(1063, 491);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(156, 62);
            this.button4.TabIndex = 1;
            this.button4.Text = "Delete Book";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(417, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(407, 55);
            this.label1.TabIndex = 2;
            this.label1.Text = "Library Database";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(102, 138);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(204, 30);
            this.textBox1.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(21, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 32);
            this.label2.TabIndex = 4;
            this.label2.Text = "Title";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(340, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 32);
            this.label3.TabIndex = 4;
            this.label3.Text = "Author";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(686, 135);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 32);
            this.label4.TabIndex = 4;
            this.label4.Text = "Genre";
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(451, 135);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(204, 30);
            this.textBox2.TabIndex = 3;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.Location = new System.Drawing.Point(791, 135);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(204, 30);
            this.textBox3.TabIndex = 3;
            this.textBox3.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1063, 105);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(156, 62);
            this.button1.TabIndex = 1;
            this.button1.Text = "Search";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Search_Click);
            // 
            // Library
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1254, 578);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ViewButton);
            this.Controls.Add(this.LibraryGridView);
            this.Name = "Library";
            this.Text = "Library";
            ((System.ComponentModel.ISupportInitialize)(this.LibraryGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView LibraryGridView;
        private System.Windows.Forms.Button ViewButton;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button button1;
    }
}