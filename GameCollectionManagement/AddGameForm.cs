using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameCollectionManagement
{
    public partial class AddGameForm : Form
    {
        private GameList _gameList;
        public AddGameForm()
        {
            InitializeComponent();

        }

        private void InitializeComponent()
        {
            panelContainer = new Panel();
            SuspendLayout();
            // 
            // panelContainer
            // 
            panelContainer.Dock = DockStyle.Fill;
            panelContainer.Location = new Point(0, 0);
            panelContainer.Name = "panelContainer";
            panelContainer.Size = new Size(576, 352);
            panelContainer.TabIndex = 0;
            // 
            // AddGameForm
            // 
            ClientSize = new Size(576, 352);
            Controls.Add(panelContainer);
            Name = "AddGameForm";
            Load += AddGameForm_Load;
            ResumeLayout(false);
        }

        private void AddGameForm_Load(object sender, EventArgs e)
        {
            AddGame addGame = new AddGame(_gameList);
            panelContainer.Controls.Add(addGame);
        }

        private Panel panelContainer;
    }
}
