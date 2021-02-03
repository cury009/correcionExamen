using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace correcionExamen
{
    public class UserHandler
    {
        public ObservableCollection<User> userList { set; get; }

        public UserHandler()
        {
            userList = new ObservableCollection<User>();
        }

        public void AddUser(User user)
        {
            userList.Add(user);
        }
        
    }
}
