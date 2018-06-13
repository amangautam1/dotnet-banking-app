using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApnaBank
{
    static  class  Session
    {
        public static String id { get; set; }
        public static String fname { get; set; }
        public static String lname { get; set; }
        public static String email { get; set; }
        public static String phone { get; set; }
        public static String aadhar { get; set; }
        public static String username { get; set; }
        public static String password { get; set; }
        public static Users_DB user { get; set; }
        public static void  CreateSession(Users_DB user1)
        {
            id = user1.id;
            fname = user1.fname;
            lname = user1.lname;
            email = user1.email;
            aadhar = user1.aadhar;
            phone = user1.phone;
            username = user1.username;
            password = user1.password;
            user = user1;
        }
        public static  void DestroySession()
        {
            id = null;
        }
    }
}
