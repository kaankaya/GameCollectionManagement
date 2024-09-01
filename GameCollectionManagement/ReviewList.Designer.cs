namespace GameCollectionManagement
{
    partial class ReviewList
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            btnEdit = new Button();
            btnReviews = new Button();
            panel2 = new Panel();
            dgvReviews = new DataGridView();
            btnDelete = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvReviews).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(btnDelete);
            panel1.Controls.Add(btnEdit);
            panel1.Controls.Add(btnReviews);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(586, 65);
            panel1.TabIndex = 0;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(421, 36);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(75, 23);
            btnEdit.TabIndex = 1;
            btnEdit.Text = "Güncelle";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnReviews
            // 
            btnReviews.Location = new Point(312, 36);
            btnReviews.Name = "btnReviews";
            btnReviews.Size = new Size(103, 23);
            btnReviews.TabIndex = 0;
            btnReviews.Text = "Yorumları Listele";
            btnReviews.UseVisualStyleBackColor = true;
            btnReviews.Click += btnReviews_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(dgvReviews);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 65);
            panel2.Name = "panel2";
            panel2.Size = new Size(586, 336);
            panel2.TabIndex = 1;
            // 
            // dgvReviews
            // 
            dgvReviews.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvReviews.Dock = DockStyle.Fill;
            dgvReviews.Location = new Point(0, 0);
            dgvReviews.Name = "dgvReviews";
            dgvReviews.Size = new Size(586, 336);
            dgvReviews.TabIndex = 0;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.Red;
            btnDelete.ForeColor = Color.White;
            btnDelete.Location = new Point(502, 36);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(75, 23);
            btnDelete.TabIndex = 2;
            btnDelete.Text = "Sil";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // ReviewList
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "ReviewList";
            Size = new Size(586, 401);
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvReviews).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btnReviews;
        private Panel panel2;
        private DataGridView dgvReviews;
        private Button btnEdit;
        private Button btnDelete;
    }
}
