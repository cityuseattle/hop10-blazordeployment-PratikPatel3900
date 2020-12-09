using System;
using System.Linq;
//add SQLite package
using System.Data.SQLite;

using System.Threading.Tasks;

namespace BlazorApp.Data
{
    //add inheritance
    public class LoginService : SqliteService
    {
        private int loginstat{get; set;}
        private static MemberData userdata{get; set;}

        //set the constructore, by default, login status is 0
        //0 == not logged in
        public LoginService(){
            loginstat = 0;
            //username is instant created from MemberData class
            //in MemberData.cs
            userdata = new MemberData();
        }

        public void setlogin (int login){
            this.loginstat = login;

        }
        public int getlogin(){
            return this.loginstat;

        }

        //returned logged in user data
        public MemberData GetLoginUserInfo(){
            return userdata;
        }

        public Task<int>GetLoginAsync()   // return login status
        {
            return Task.FromResult(getlogin());
        }


        public Task<bool> LoginVerify(string username, string passwd){
            string stm = "SELECT * FROM member";
            using var cmd = new SQLiteCommand(stm,con);
            using SQLiteDataReader rdr = cmd.ExecuteReader();
            string name= "";
            string password = "";

            while (rdr.Read())
            {
                name = rdr.GetString(1);
                password = rdr.GetString(2);

                if (name == username && password == passwd){
                    setlogin(1);
                    userdata.Name=username;
                    userdata.Password=passwd;
                    return Task.FromResult(true);

               }
           }
        return Task.FromResult(false);
       }
        
    }
}