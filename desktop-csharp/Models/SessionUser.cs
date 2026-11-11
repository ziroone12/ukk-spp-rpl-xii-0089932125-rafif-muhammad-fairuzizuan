using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySqlX.XDevAPI;

namespace desktop_csharp.Models
{
    internal class SessionUser
    {
        public SessionUser(string idpetugas, string username, string namapetugas, string level, string isLogin)
        {
            Idpetugas = idpetugas;
            this.username = username;
            Namapetugas = namapetugas;
            Level = level;
            IsLogin = IsLogin;
        }

        public string Idpetugas { get; set; }
        public string username { get; set; }
        public string Namapetugas { get; set; }
        public string Level { get; set; }
        public bool IsLogin { get; set;  }



       public static void clearSession(int Idpetugas, string username, string Namapetugas, string Level,bool IsLogin) 
        {
            Idpetugas = 0;
            username = null;
            Namapetugas = null;
            Level = null;
            IsLogin = true;

        }

    }

}
