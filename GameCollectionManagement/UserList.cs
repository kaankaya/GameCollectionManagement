using GameCollectionManagement.Services;
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
    public partial class UserList : UserControl
    {
        private IUserService _userService;
        public UserList()
        {
            InitializeComponent();
            _userService = new UserService();
        }
        public void LoadUsers()
        {
            var users = _userService.GetAll();
            dgvUsers.DataSource = users;
            dgvUsers.Columns["Id"].Visible = false;
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            LoadUsers();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvUsers.SelectedRows.Count > 0)
            {
                int id = (int)dgvUsers.SelectedRows[0].Cells["Id"].Value;
                string name = dgvUsers.SelectedRows[0].Cells["Username"].Value.ToString();
                if (MessageBox.Show($"{name} adlı kullanıcıyı silmek istediğinizden emin misiniz ?", "Silme Onayı", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        _userService.Delete(id);
                        LoadUsers();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
            else
            {
                MessageBox.Show("Sİlme işlemi için Kullanıcı seçmelisiniz");
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddUserForm addUserForm = new AddUserForm(this);
            addUserForm.ShowDialog();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvUsers.SelectedRows.Count > 0)
            {
                int id = (int)dgvUsers.SelectedRows[0].Cells["Id"].Value;
                EditUser editUser = new EditUser(id, this);
                editUser.ShowDialog();
            }

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string searchTerm = string.Empty;
            if (!string.IsNullOrWhiteSpace(txtSearch.Text))
            {
                searchTerm = txtSearch.Text;
            }
            
            var users = _userService.Search(searchTerm);

            dgvUsers.DataSource = users;
        }
    }
}
