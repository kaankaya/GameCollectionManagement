using GameCollectionManagement.Models;
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
    public partial class EditUser : Form
    {
        private readonly IUserService _userService;
        private User _user;
        private UserList _userList;
        public EditUser(int id, UserList userList)
        {
            InitializeComponent();
            _userList = userList;
            _userService = new UserService();
            _user = _userService.GetById(id);
            txtEmail.Text = _user.Email;
            txtPassword.Text = _user.Password;
            txtUserName.Text = _user.Username;
            txtRole.Text = _user.Role;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (ValidateInput())
            {
                _user.Username = txtUserName.Text.Trim();
                _user.Email = txtEmail.Text.Trim();
                _user.Password = txtPassword.Text.Trim();
                _user.Role = txtRole.Text.Trim();

                try
                {
                    _userService.Update(_user);
                    MessageBox.Show("Kullanıcı Güncellendi");

                    _userList.LoadUsers();
                    Close();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

    
        private bool ValidateInput()
        {
            if (string.IsNullOrWhiteSpace(txtUserName.Text))
            {
                MessageBox.Show("Kullanıcı Adı Giriniz", "Giriş Hatası", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                MessageBox.Show("EmailGiriniz", "Giriş Hatası", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                MessageBox.Show("Şifre Giriniz", "Giriş Hatası", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtRole.Text))
            {
                MessageBox.Show("Role Giriniz", "Giriş Hatası", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }
    }
}
