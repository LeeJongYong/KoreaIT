using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web.Configuration;
using DevUser.Models;

namespace DevUser.Repositories
{
    public class UserRepository
    {
        private SqlConnection con;
        
        public UserRepository()
        {
            con = new SqlConnection();
            con.ConnectionString = WebConfigurationManager.ConnectionStrings["ConnectingString"].ConnectionString;

        }

        public void addUser(string userId, string password)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "WriteUsers";
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@UserID", userId);
            cmd.Parameters.AddWithValue("@Password", password);

            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }

        public UserViewModel getUserByUserId(string userId)
        {
            UserViewModel uvm = new UserViewModel();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "select * from Users where UserID = @UserID";
            cmd.CommandType = CommandType.Text;

            cmd.Parameters.AddWithValue("@UserID", userId);

            con.Open();
            IDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                uvm.id = dr.GetInt32(0);
                uvm.userId = dr.GetString(1);
                uvm.password = dr.GetString(1);
            }
            con.Close();

            return uvm;
        }

        public void modifyUser(int uid, string userId, string password)
        {
            SqlCommand cmd = new SqlCommand();

            cmd.Connection = con;
            cmd.CommandText = "ModifyUsers";
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@UID", uid);
            cmd.Parameters.AddWithValue("@UserID", userId);
            cmd.Parameters.AddWithValue("@password", password);

            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }

        public bool IsCorrectUser(string userId, string password)
        {
            bool result = false;

            con.Open();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "select * from Users where UserID = @UserID and Password = @Password";
            cmd.CommandType = CommandType.Text;

            cmd.Parameters.AddWithValue("@UserID", userId);
            cmd.Parameters.AddWithValue("@Password", password);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                result = true;
            }

            dr.Close();
            con.Close();
            return result;
        }
    }
}