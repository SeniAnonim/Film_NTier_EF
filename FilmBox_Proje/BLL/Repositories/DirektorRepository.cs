﻿using DAL;
using DTO.FilmBoxDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Repositories
{
    public class DirektorRepository : IFilmBox<DirectorCs>
    {
        FilmBox_DbEntities db = Db_Tools.DbInstance;
        public void Delete(int id)
        {
            Director gelen = db.Directors.Find(id);
            db.Directors.Remove(gelen);
            db.SaveChanges();
        }

        public List<DirectorCs> GetAll()
        {
            return db.Directors.Select(c => new DirectorCs { DirectorId = c.DirectorId, DirectorName = c.DirectorName, DirectorLastName = c.DirectorLastName,Gender=c.Gender,Age=(int)c.Age,Awards=(int)c.Awards }).ToList();
        }

        public DirectorCs GetByID(int ID)
        {
            Director gelen = db.Directors.Find(ID);
            return new DirectorCs { DirectorId = gelen.DirectorId, DirectorName = gelen.DirectorName, DirectorLastName = gelen.DirectorLastName, Gender = gelen.Gender, Age = (int)gelen.Age, Awards = (int)gelen.Awards };

        }

        public void Insert(DirectorCs item)
        {
            db.Directors.Add(new Director { DirectorId = item.DirectorId, DirectorName = item.DirectorName, DirectorLastName = item.DirectorLastName, Gender = item.Gender, Age = (int)item.Age, Awards = (int)item.Awards });
            db.SaveChanges();
        }

        public void Update(DirectorCs item)
        {
            Director gelen= db.Directors.Find(item.DirectorId);
            gelen.DirectorName = item.DirectorName;
            gelen.DirectorLastName = item.DirectorLastName;
            gelen.Gender = item.Gender;
            gelen.Age = item.Age;
            gelen.Awards = item.Awards;
            db.SaveChanges();

        }
    }
}
