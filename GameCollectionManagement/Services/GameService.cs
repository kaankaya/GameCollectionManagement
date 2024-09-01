using GameCollectionManagement.Models;
using GameCollectionManagement.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameCollectionManagement.Services
{
    public class GameService : IGameService
    {
        private readonly GameRepository _gameRepository;

        public GameService()
        {
            _gameRepository = new GameRepository();
        }
        public void Add(Game game)
        {
            if (string.IsNullOrWhiteSpace(game.Name))
                throw new ArgumentException("Oyun adı Olmadan Ekleme Yapamazsınız");

            _gameRepository.Add(game);
        }//End Add

        public void Delete(int id)
        {
            if (id <= 0)
                throw new ArgumentException("Geçersiz Oyun Id");

            var game = GetById(id);
            if (game is not null)
            {
                _gameRepository.Delete(game);
            }
        }//End Delete

        public List<Game> GetAll()
        {
            return _gameRepository.GetAll();
        }//End GetAll


        public List<Game> GetByGenre(string genre)
        {
            return GetAll().Where(g=>g.Genre.Equals(genre,StringComparison.OrdinalIgnoreCase)).ToList();
        }//End GetByGenre

        public Game GetById(int id)
        {
            return _gameRepository.GetById(id);
        }//End GetById

        public List<string> GetGenres()
        {
            return _gameRepository.GetGenres();
        }

        public int GetTotalCount()
        {
            return GetAll().Count();
        }//End GetTotalCount

        public List<Game> Search(string searchTerm)
        {
            return GetAll().Where(g=>g.Name.Contains(searchTerm,StringComparison.OrdinalIgnoreCase) || g.Genre.Contains(searchTerm,StringComparison.OrdinalIgnoreCase) || g.Platform.Contains(searchTerm,StringComparison.OrdinalIgnoreCase)).ToList();
        }//End Search

        public void Update(Game game)
        {
            if (game.Id <= 0)
                throw new ArgumentException("Geçersiz Oyun Id");

            var gcurrentGame = GetById(game.Id);
            if (gcurrentGame is not null)
            {
                _gameRepository.Update(game);
            }
        }//End Update
    }
}
