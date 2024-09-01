namespace GameCollectionManagement
{
    partial class EditReviewcs
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
            btnUpdate = new Button();
            label3 = new Label();
            label2 = new Label();
            txtReview = new TextBox();
            nudRating = new NumericUpDown();
            label1 = new Label();
            cbGames = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)nudRating).BeginInit();
            SuspendLayout();
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(265, 284);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(75, 23);
            btnUpdate.TabIndex = 13;
            btnUpdate.Text = "Güncelle";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(37, 112);
            label3.Name = "label3";
            label3.Size = new Size(48, 15);
            label3.TabIndex = 12;
            label3.Text = "Yorum :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(37, 71);
            label2.Name = "label2";
            label2.Size = new Size(50, 15);
            label2.TabIndex = 11;
            label2.Text = "Rating  :";
            // 
            // txtReview
            // 
            txtReview.Location = new Point(135, 112);
            txtReview.Multiline = true;
            txtReview.Name = "txtReview";
            txtReview.Size = new Size(205, 149);
            txtReview.TabIndex = 10;
            // 
            // nudRating
            // 
            nudRating.Location = new Point(135, 69);
            nudRating.Maximum = new decimal(new int[] { 5, 0, 0, 0 });
            nudRating.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudRating.Name = "nudRating";
            nudRating.Size = new Size(205, 23);
            nudRating.TabIndex = 9;
            nudRating.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(36, 26);
            label1.Name = "label1";
            label1.Size = new Size(45, 15);
            label1.TabIndex = 8;
            label1.Text = "Oyun  :";
            // 
            // cbGames
            // 
            cbGames.FormattingEnabled = true;
            cbGames.Location = new Point(135, 23);
            cbGames.Name = "cbGames";
            cbGames.Size = new Size(205, 23);
            cbGames.TabIndex = 7;
            // 
            // EditReviewcs
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(374, 329);
            Controls.Add(btnUpdate);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtReview);
            Controls.Add(nudRating);
            Controls.Add(label1);
            Controls.Add(cbGames);
            MaximizeBox = false;
            Name = "EditReviewcs";
            Text = "EditReviewcs";
            ((System.ComponentModel.ISupportInitialize)nudRating).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnUpdate;
        private Label label3;
        private Label label2;
        private TextBox txtReview;
        private NumericUpDown nudRating;
        private Label label1;
        private ComboBox cbGames;
    }
}