namespace GameCollectionManagement
{
    partial class AddReview
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
            cbGames = new ComboBox();
            label1 = new Label();
            nudRating = new NumericUpDown();
            txtReview = new TextBox();
            label2 = new Label();
            label3 = new Label();
            btnAdd = new Button();
            ((System.ComponentModel.ISupportInitialize)nudRating).BeginInit();
            SuspendLayout();
            // 
            // cbGames
            // 
            cbGames.FormattingEnabled = true;
            cbGames.Location = new Point(123, 52);
            cbGames.Name = "cbGames";
            cbGames.Size = new Size(205, 23);
            cbGames.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(24, 55);
            label1.Name = "label1";
            label1.Size = new Size(81, 15);
            label1.TabIndex = 1;
            label1.Text = "Oyun Seçiniz :";
            // 
            // nudRating
            // 
            nudRating.Location = new Point(123, 98);
            nudRating.Maximum = new decimal(new int[] { 5, 0, 0, 0 });
            nudRating.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudRating.Name = "nudRating";
            nudRating.Size = new Size(205, 23);
            nudRating.TabIndex = 2;
            nudRating.Value = new decimal(new int[] { 1, 0, 0, 0 });
            nudRating.ValueChanged += nudRating_ValueChanged;
            // 
            // txtReview
            // 
            txtReview.Location = new Point(123, 141);
            txtReview.Multiline = true;
            txtReview.Name = "txtReview";
            txtReview.Size = new Size(205, 149);
            txtReview.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(25, 100);
            label2.Name = "label2";
            label2.Size = new Size(80, 15);
            label2.TabIndex = 4;
            label2.Text = "Rating Puanı :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(25, 141);
            label3.Name = "label3";
            label3.Size = new Size(48, 15);
            label3.TabIndex = 5;
            label3.Text = "Yorum :";
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(253, 317);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(75, 23);
            btnAdd.TabIndex = 6;
            btnAdd.Text = "Ekle";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // AddReview
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btnAdd);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtReview);
            Controls.Add(nudRating);
            Controls.Add(label1);
            Controls.Add(cbGames);
            Name = "AddReview";
            Size = new Size(353, 374);
            ((System.ComponentModel.ISupportInitialize)nudRating).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cbGames;
        private Label label1;
        private NumericUpDown nudRating;
        private TextBox txtReview;
        private Label label2;
        private Label label3;
        private Button btnAdd;
    }
}
