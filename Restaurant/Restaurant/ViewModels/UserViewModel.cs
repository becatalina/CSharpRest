using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Entity.Infrastructure;
using System.Linq;

namespace Restaurant.ViewModels
{
    public class UserViewModel : BaseViewModel
    {
        #region Members
        public Employee Employee { get; set; }
        public User User { get; set; }
        #endregion

        #region Methods
        public UserViewModel()
        {

        }
        public bool isUser(string email, string password) {
            using (var context = new RestautantEntities())
            {
                
                var query = from user in context.Users
                            where user.Email == email
                            where user.Password == password
                            select user;

                if (query.FirstOrDefault() != null) {
                    User = query.FirstOrDefault();
                    return true;
                }

                var empl = from employee in context.Employees
                        where employee.Email == email
                        select employee;

                if (empl.FirstOrDefault() != null)
                {
                    Employee = empl.FirstOrDefault();
                    return true;
                }
               

            }
            return false;
        }

        #endregion



    }
}
