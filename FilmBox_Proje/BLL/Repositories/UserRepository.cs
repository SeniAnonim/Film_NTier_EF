using DAL;
using DTO.FilmBoxDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Repositories
{
    public class UserRepository
    {
        FilmBox_DbEntities db = Db_Tools.DbInstance;
        public List<UsersDTO> GetAll()
        {
           return db.Users.Select(c => new UsersDTO { UserID = c.usersID, UserName = c.KullaniciAdi, Password = c.Sifre }).ToList();
        }
        public void Delete(int id)
        {
            User gelen = db.Users.Find(id);
            db.Users.Remove(gelen);
            db.SaveChanges();
        }

        public UsersDTO GetByName(string kullanici,string sifre)
        {
          User gelen=  db.Users.Find(kullanici);
            return new UsersDTO { UserName = gelen.KullaniciAdi,Password=gelen.Sifre };

        }

        public void Insert(UsersDTO item)
        {
            db.Users.Add(new User { KullaniciAdi = item.UserName, Sifre = item.Password});
            db.SaveChanges();
        }

        public void Update(UsersDTO item)
        {
            User gelen = db.Users.Find(item.UserID);
            gelen.Sifre = item.Password;
            db.SaveChanges();
        }
    }
}
