﻿using Database.Context;
using Database.Models;


namespace Database.SongRepository
{
    public class SongRepository : IGenericRepository<Song>
    {
        private readonly SongContext _songContext;

        public SongRepository()
        {
            _songContext = new SongContext();
        }
        public void Delete(Song song)
        {
            _songContext.Songs.Remove(song);
        }

        public List<Song> GetAll()
        {
            return _songContext.Songs.ToList();
        }

        public void Insert(Song song)
        {
            _songContext.Songs.Add(song);
        }


        public void Save()
        {
            _songContext.SaveChanges();
        }
    }
}
