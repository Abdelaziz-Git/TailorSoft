using TailorSoft_Models;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace TailorSoft_Data_Layer
{
    public class clsUserData
    {
        public static bool AddNewUser(clsUserDTO userDTO)
        {
            if (userDTO == null)
            {
                throw new ArgumentNullException(nameof(userDTO), "User data cannot be null.");
            }
            try
            {
                using (SqlConnection conn = new SqlConnection(clsDatabaseSettings.OnlineConnection))
                {
                    using (SqlCommand cmd = new SqlCommand("SP_User_AddNew", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@FirstName", userDTO.FirstName);
                        cmd.Parameters.AddWithValue("@LastName", userDTO.LastName);
                        cmd.Parameters.AddWithValue("@Phone", userDTO.Phone);
                        cmd.Parameters.AddWithValue("@Email", userDTO.Email);
                        cmd.Parameters.AddWithValue("@City", userDTO.City);
                        cmd.Parameters.AddWithValue("@Adress", userDTO.Adress);
                        cmd.Parameters.AddWithValue("@Username", userDTO.Username);
                        cmd.Parameters.AddWithValue("@PasswordHash", userDTO.Password);
                        cmd.Parameters.AddWithValue("@Status", userDTO.Status);
                        conn.Open();
                        return cmd.ExecuteNonQuery() > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error adding new user", ex);
            }
        }
        public static clsUserDTO? GetUserByUsername(string username)
        {
            clsUserDTO userDTO;
            try
            {
                using(SqlConnection conn = new SqlConnection(clsDatabaseSettings.OnlineConnection))
                {
                    using (SqlCommand cmd = new SqlCommand("SP_User_GetByUsername", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@Username", username);
                        conn.Open();
                        using(SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if(reader.Read())
                            {
                                userDTO = new clsUserDTO();
                                userDTO.Id = reader.GetInt32("Id");
                                userDTO.FirstName = reader.GetString("FirstName");
                                userDTO.LastName = reader.GetString("LastName");
                                userDTO.Phone = reader.GetString("Phone");
                                userDTO.Email = reader.IsDBNull("Email") ? null : reader.GetString("Email");
                                userDTO.City = reader.GetString("City");
                                userDTO.Adress = reader.IsDBNull("Adress") ? null : reader.GetString("Adress");
                                userDTO.Username = reader.GetString("Username");
                                userDTO.Status = reader.GetBoolean("Status");
                                return userDTO;
                            }
                            else
                            {
                                return null;
                            }
                        }

                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error retrieving user by username", ex);
            }
        }
        public static bool UpdateUser(clsUserDTO userDTO)
        {
            if (userDTO == null || userDTO.Id <= 0)
            {
                throw new ArgumentException("Invalid user data provided for update.", nameof(userDTO));
            }

            try
            {
                using (SqlConnection conn = new SqlConnection(clsDatabaseSettings.OnlineConnection))
                {
                    using (SqlCommand cmd = new SqlCommand("SP_User_Update", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@Id", userDTO.Id);
                        cmd.Parameters.AddWithValue("@FirstName", userDTO.FirstName);
                        cmd.Parameters.AddWithValue("@LastName", userDTO.LastName);
                        cmd.Parameters.AddWithValue("@Phone", userDTO.Phone);
                        cmd.Parameters.AddWithValue("@Email", userDTO.Email);
                        cmd.Parameters.AddWithValue("@City", userDTO.City);
                        cmd.Parameters.AddWithValue("@Adress", userDTO.Adress);
                        cmd.Parameters.AddWithValue("@Username", userDTO.Username);
                        cmd.Parameters.AddWithValue("@Status", userDTO.Status);
                        conn.Open();
                        return cmd.ExecuteNonQuery() > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error updating user", ex);
            }
        }
        public static string? GetPasswordHashByUsername(string username)
        {
            if (string.IsNullOrEmpty(username))
                return null;
            try
            {
                using (SqlConnection conn = new SqlConnection(clsDatabaseSettings.OnlineConnection))
                {
                    using (SqlCommand cmd = new SqlCommand("SP_User_GetPasswordHashByUsername", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@Username", username);
                        conn.Open();
                        return cmd.ExecuteScalar()?.ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error retrieving password hash by username", ex);
            }
        }
        public static bool IsUserExistByUsername(string username)
        {
            if (string.IsNullOrEmpty(username))
                return false;
            try
            {
                using (SqlConnection conn = new SqlConnection(clsDatabaseSettings.OnlineConnection))
                {
                    using (SqlCommand cmd = new SqlCommand("SP_User_IsExistByUsername", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@Username", username);
                        conn.Open();
                       
                        return Convert.ToBoolean(cmd.ExecuteScalar());
                    }
                }
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }
    }
}
