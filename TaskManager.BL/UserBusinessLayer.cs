using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Text;
using System.Data.Entity;
using System.Threading.Tasks;
using TaskManager.DL;
using TaskManager.Entities;


namespace TaskManager.BL
{
    public class UserBusinessLayer
    {
        private DataContext db = new DataContext();

        public DbSet<UserTable> GetAllUsers()
        {
            return db.Users;
        }

        public List<UserTable> GetUserSummary()
        {
            return db.Users.ToList();
          
        }

        public bool Add(UserTable users)
        {
            try
            {
                db.Users.Add(users);
                db.SaveChanges();
            }
            catch (Exception)
            {
                return false;
            }
            return true;

        }
        public bool Delete(int userId)
        {
            try
            {
                var query = (from update in db.Users.Where(x => x.UserId == userId)
                             select update).SingleOrDefault();
                if (query != null)
                {
                    query.UserId = userId;
                    query.Deleted = true;

                    db.Entry(query).State = EntityState.Modified;
                    db.SaveChanges();
                }
            }
            catch (Exception)
            {
                return false;
            }
            return true;
        }

        public bool Update(int userId, UserTable users)
        {
            try
            {
                var query = (from update in db.Users.Where(x => x.UserId == userId)
                             select update).SingleOrDefault();
                if (query != null)
                {
                    query.UserId = userId;
                    query.FirstName = users.FirstName;
                    query.LastName = users.LastName;
                    query.EmployeeId = users.EmployeeId;

                    db.Entry(query).State = EntityState.Modified;
                    db.SaveChanges();
                }
            }
            catch (Exception)
            {
                return false;
            }
            return true;
        }


    }

    public class User
    {
        public string FirstName;
        public string LastName;
        public int EmployeeId;
        public bool Deleted;
    }
}
