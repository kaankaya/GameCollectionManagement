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
    public partial class AddUserForm : Form
    {
        private UserList _users = null;
        public AddUserForm(UserList users)
        {
            InitializeComponent();
            _users = users;
        }
        public AddUserForm()
        {
            InitializeComponent();
        }
        private void AddUserForm_Load(object sender, EventArgs e)
        {
            AddUser addUser = null;
            if(_users is not null)
                addUser = new AddUser(_users);
            else
                addUser = new AddUser(fromLoginPage:true);

            panelContainer.Controls.Add(addUser);   
            
        }
    }
}
