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
using System.Xml.Linq;

namespace GameCollectionManagement
{
    public partial class ReviewList : UserControl
    {
        private readonly User _user;
        private readonly IReviewService _reviewService;
        public ReviewList(User user)
        {
            InitializeComponent();
            _user = user;
            _reviewService = new ReviewService();
        }

        private void btnReviews_Click(object sender, EventArgs e)
        {
            dgvReviews.DataSource = _reviewService.GetAllByRole(_user.Role, _user.Id);
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvReviews.SelectedRows.Count > 0)
            {
                int id = (int)dgvReviews.SelectedRows[0].Cells["Id"].Value;
                EditReviewcs form = new EditReviewcs(id);
                form.ShowDialog();
            }

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvReviews.SelectedRows.Count > 0)
            {
                int id = (int)dgvReviews.SelectedRows[0].Cells["Id"].Value;
                _reviewService.Delete(id);

                if (MessageBox.Show($"{id} nolu yorumu silmek istediğinizden emin misiniz ?", "Silme Onayı", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        _reviewService.Delete(id);

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
            else
            {
                MessageBox.Show("Sİlme işlemi için oyun seçmelisiniz");
            }
        }
    }
}

