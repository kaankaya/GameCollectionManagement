namespace GameCollectionManagement
{
    partial class GameList
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
            label2 = new Label();
            label1 = new Label();
            btnSearch = new Button();
            cbGenre = new ComboBox();
            cbPlaform = new ComboBox();
            txtSearch = new TextBox();
            btnAdd = new Button();
            btnGameDelete = new Button();
            btnGameList = new Button();
            btnEditGame = new Button();
            panel2 = new Panel();
            dgvGames = new DataGridView();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvGames).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(btnSearch);
            panel1.Controls.Add(cbGenre);
            panel1.Controls.Add(cbPlaform);
            panel1.Controls.Add(txtSearch);
            panel1.Controls.Add(btnAdd);
            panel1.Controls.Add(btnGameDelete);
            panel1.Controls.Add(btnGameList);
            panel1.Controls.Add(btnEditGame);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(833, 133);
            panel1.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(247, 37);
            label2.Name = "label2";
            label2.Size = new Size(37, 15);
            label2.TabIndex = 9;
            label2.Text = "Türü :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(493, 35);
            label1.Name = "label1";
            label1.Size = new Size(59, 15);
            label1.TabIndex = 8;
            label1.Text = "Platform :";
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(3, 3);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(75, 23);
            btnSearch.TabIndex = 7;
            btnSearch.Text = "Ara";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // cbGenre
            // 
            cbGenre.FormattingEnabled = true;
            cbGenre.Location = new Point(297, 32);
            cbGenre.Name = "cbGenre";
            cbGenre.Size = new Size(169, 23);
            cbGenre.TabIndex = 6;
            // 
            // cbPlaform
            // 
            cbPlaform.FormattingEnabled = true;
            cbPlaform.Items.AddRange(new object[] { "PC", "XBox", "Playstaion", "Nintendo" });
            cbPlaform.Location = new Point(558, 32);
            cbPlaform.Name = "cbPlaform";
            cbPlaform.Size = new Size(162, 23);
            cbPlaform.TabIndex = 5;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(101, 3);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(618, 23);
            txtSearch.TabIndex = 4;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(418, 104);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(75, 23);
            btnAdd.TabIndex = 3;
            btnAdd.Text = "Ekle";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnGameDelete
            // 
            btnGameDelete.BackColor = Color.Red;
            btnGameDelete.ForeColor = SystemColors.Control;
            btnGameDelete.Location = new Point(611, 104);
            btnGameDelete.Name = "btnGameDelete";
            btnGameDelete.Size = new Size(98, 23);
            btnGameDelete.TabIndex = 2;
            btnGameDelete.Text = "Seçili Oyunu Sİl";
            btnGameDelete.UseVisualStyleBackColor = false;
            btnGameDelete.Click += btnGameDelete_Click;
            // 
            // btnGameList
            // 
            btnGameList.Location = new Point(499, 104);
            btnGameList.Name = "btnGameList";
            btnGameList.Size = new Size(106, 23);
            btnGameList.TabIndex = 1;
            btnGameList.Text = "Oyunları Listele";
            btnGameList.UseVisualStyleBackColor = true;
            btnGameList.Click += btnGameList_Click;
            // 
            // btnEditGame
            // 
            btnEditGame.Anchor = AnchorStyles.Right;
            btnEditGame.Location = new Point(715, 104);
            btnEditGame.Name = "btnEditGame";
            btnEditGame.Size = new Size(118, 23);
            btnEditGame.TabIndex = 0;
            btnEditGame.Text = "Oyunu Güncelle";
            btnEditGame.UseVisualStyleBackColor = true;
            btnEditGame.Click += btnEditGame_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(dgvGames);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 133);
            panel2.Name = "panel2";
            panel2.Size = new Size(833, 392);
            panel2.TabIndex = 1;
            // 
            // dgvGames
            // 
            dgvGames.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvGames.Dock = DockStyle.Fill;
            dgvGames.Location = new Point(0, 0);
            dgvGames.Name = "dgvGames";
            dgvGames.Size = new Size(833, 392);
            dgvGames.TabIndex = 0;
            // 
            // GameList
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "GameList";
            Size = new Size(833, 525);
            Load += GameList_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvGames).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btnEditGame;
        private Panel panel2;
        private DataGridView dgvGames;
        private Button btnGameList;
        private Button btnGameDelete;
        private Button btnAdd;
        private TextBox txtSearch;
        private Button btnSearch;
        private ComboBox cbGenre;
        private ComboBox cbPlaform;
        private Label label1;
        private Label label2;
    }
}
