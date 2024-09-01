using GameCollectionManagement.Models;
using GameCollectionManagement.Services;
using Microsoft.VisualBasic.ApplicationServices;
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
    public partial class EditReviewcs : Form
    {
        private readonly IReviewService _reviewService;
        private readonly IGameService _gameService;
        private Review _review;
        public EditReviewcs(int id)
        {
            InitializeComponent();
            _reviewService = new ReviewService();
            _gameService = new GameService();

            cbGames.DataSource = _gameService.GetAll();
            cbGames.DisplayMember = nameof(Game.Name);
            cbGames.ValueMember = nameof(Game.Id);
            //40:43
            _review = _reviewService.GetById(id);
            if (_review == null)
            {
                MessageBox.Show("Yorum bulunamadı. Lütfen geçerli bir yorum ID'si girin.");
                Close();  // Formu kapatabilir veya başka bir işlem yapabilirsiniz.
                return;
            }

            txtReview.Text = _review.ReviewText;
            nudRating.Value = _review.Rating;
            cbGames.SelectedValue = _review.GameId;

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (ValidateInput())
            {
                try
                {
                    Game selectedGame = cbGames.SelectedItem as Game;
                    if (selectedGame == null)
                    {
                        MessageBox.Show("Sistemsel Bir hata oluştu");
                        return;
                    }

                    _review.ReviewText = txtReview.Text.Trim();
                    _review.Rating = (int)nudRating.Value;
                    _review.GameId = selectedGame.Id;

                    _reviewService.Update(_review);
                    MessageBox.Show("Yorumunuz Güncellendi");
                   
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        private bool ValidateInput()
        {
            if (cbGames.SelectedItem == null)
            {
                MessageBox.Show("Oyun Seçmelisiniz");
                return false;
            }
            if (nudRating.Value < 1 || nudRating.Value > 5)
            {
                MessageBox.Show("Rating aralığı 1-5 arasında olabilir");
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtReview.Text))
            {
                MessageBox.Show("Yorum Giriniz");
                return false;
            }
            return true;
        }
    }
}
