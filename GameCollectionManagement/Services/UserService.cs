﻿using GameCollectionManagement.Models;
using GameCollectionManagement.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameCollectionManagement.Services
{
    public class UserService : IUserService
    {
        private readonly UserRepository _userRepository;

        public UserService()
        {
            _userRepository = new UserRepository();
        }

        public void Add(User user)
        {
            if (string.IsNullOrWhiteSpace(user.Username))
                throw new ArgumentException("Kullanıcı Adı Boş Geçilemez");

            if (string.IsNullOrWhiteSpace(user.Email))
                throw new ArgumentException("Email adresi boş olamaz");
            if (string.IsNullOrWhiteSpace(user.Password))
                throw new ArgumentException("Şifre Boş Olamaz");
            _userRepository.Add(user);
        }

        public void Delete(int id)
        {
            if (id <= 0)
                throw new ArgumentException("Geçersiz Oyun Id");

            var user = GetById(id);
            if (user is not null)
            {
                _userRepository.Delete(user.Id);
            }
        }

        public List<User> GetAll()
        {
            return _userRepository.GetAll();
        }

        public User GetById(int id)
        {
            return _userRepository.GetById(id);
        }

        public (bool isAuthenticated, int? userId) Login(string username, string password)
        {
            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
                throw new ArgumentException("Kullanıcı adı ve şifre boş olamaz");

            return _userRepository.Login(username, password);
        }

        public void Update(User user)
        {
            if (user.Id <= 0)
                throw new ArgumentException("Geçersiz User Id");

            var currentUser = GetById(user.Id);
            if (currentUser is not null)
            {
                 
                _userRepository.Update(user);
            }
        }//End Update

        public List<User> Search(string searchTerm)
        {

            return GetAll().Where(u => u.Username.Contains(searchTerm,StringComparison.OrdinalIgnoreCase) || u.Email.Contains(searchTerm,StringComparison.OrdinalIgnoreCase)).ToList();
        }
    }
}
