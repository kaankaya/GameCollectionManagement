namespace GameCollectionManagement
{
    partial class EditGame
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
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            btnOpenFileDialog = new Button();
            txtGameCoverImage = new TextBox();
            numericGamePlayTime = new NumericUpDown();
            dtpGameReleaseDate = new DateTimePicker();
            cbGamePlatform = new ComboBox();
            txtGameGenre = new TextBox();
            txtGameName = new TextBox();
            btnEdit = new Button();
            ofdCoverImage = new OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)numericGamePlayTime).BeginInit();
            SuspendLayout();
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(46, 260);
            label6.Name = "label6";
            label6.Size = new Size(80, 15);
            label6.TabIndex = 25;
            label6.Text = "Kapak Resmi :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(46, 211);
            label5.Name = "label5";
            label5.Size = new Size(90, 15);
            label5.TabIndex = 24;
            label5.Text = "Oynanış Süresi :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(46, 173);
            label4.Name = "label4";
            label4.Size = new Size(69, 15);
            label4.TabIndex = 23;
            label4.Text = "Çıkış Tarihi :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(46, 128);
            label3.Name = "label3";
            label3.Size = new Size(98, 15);
            label3.TabIndex = 22;
            label3.Text = "Oyun Platformu :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(46, 75);
            label2.Name = "label2";
            label2.Size = new Size(69, 15);
            label2.TabIndex = 21;
            label2.Text = "Oyun Türü :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(46, 31);
            label1.Name = "label1";
            label1.Size = new Size(63, 15);
            label1.TabIndex = 20;
            label1.Text = "Oyun Adı :";
            // 
            // btnOpenFileDialog
            // 
            btnOpenFileDialog.Location = new Point(514, 260);
            btnOpenFileDialog.Name = "btnOpenFileDialog";
            btnOpenFileDialog.Size = new Size(41, 23);
            btnOpenFileDialog.TabIndex = 19;
            btnOpenFileDialog.Text = "...";
            btnOpenFileDialog.UseVisualStyleBackColor = true;
            btnOpenFileDialog.Click += btnOpenFileDialog_Click;
            // 
            // txtGameCoverImage
            // 
            txtGameCoverImage.Location = new Point(171, 260);
            txtGameCoverImage.Name = "txtGameCoverImage";
            txtGameCoverImage.Size = new Size(337, 23);
            txtGameCoverImage.TabIndex = 18;
            // 
            // numericGamePlayTime
            // 
            numericGamePlayTime.Location = new Point(171, 211);
            numericGamePlayTime.Name = "numericGamePlayTime";
            numericGamePlayTime.Size = new Size(337, 23);
            numericGamePlayTime.TabIndex = 17;
            // 
            // dtpGameReleaseDate
            // 
            dtpGameReleaseDate.Location = new Point(171, 173);
            dtpGameReleaseDate.Name = "dtpGameReleaseDate";
            dtpGameReleaseDate.Size = new Size(337, 23);
            dtpGameReleaseDate.TabIndex = 16;
            // 
            // cbGamePlatform
            // 
            cbGamePlatform.FormattingEnabled = true;
            cbGamePlatform.Items.AddRange(new object[] { "PC", "XBox", "Playstaion", "Nintendo" });
            cbGamePlatform.Location = new Point(171, 128);
            cbGamePlatform.Name = "cbGamePlatform";
            cbGamePlatform.Size = new Size(337, 23);
            cbGamePlatform.TabIndex = 15;
            // 
            // txtGameGenre
            // 
            txtGameGenre.Location = new Point(171, 75);
            txtGameGenre.Name = "txtGameGenre";
            txtGameGenre.Size = new Size(337, 23);
            txtGameGenre.TabIndex = 14;
            // 
            // txtGameName
            // 
            txtGameName.Location = new Point(171, 31);
            txtGameName.Name = "txtGameName";
            txtGameName.Size = new Size(337, 23);
            txtGameName.TabIndex = 13;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(464, 298);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(75, 23);
            btnEdit.TabIndex = 26;
            btnEdit.Text = "Güncelle";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // ofdCoverImage
            // 
            ofdCoverImage.FileName = "openFileDialog1";
            // 
            // EditGame
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(605, 333);
            Controls.Add(btnEdit);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnOpenFileDialog);
            Controls.Add(txtGameCoverImage);
            Controls.Add(numericGamePlayTime);
            Controls.Add(dtpGameReleaseDate);
            Controls.Add(cbGamePlatform);
            Controls.Add(txtGameGenre);
            Controls.Add(txtGameName);
            Name = "EditGame";
            Text = "Oyun Güncelle";
            ((System.ComponentModel.ISupportInitialize)numericGamePlayTime).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button btnOpenFileDialog;
        private TextBox txtGameCoverImage;
        private NumericUpDown numericGamePlayTime;
        private DateTimePicker dtpGameReleaseDate;
        private ComboBox cbGamePlatform;
        private TextBox txtGameGenre;
        private TextBox txtGameName;
        private Button btnEdit;
        private OpenFileDialog ofdCoverImage;
    }
}