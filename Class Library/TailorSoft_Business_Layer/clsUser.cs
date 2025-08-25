using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TailorSoft_Models;
using TailorSoft_Data_Layer;

namespace TailorSoft_Business_Layer
{
    public class clsUser
    {
        enum enMode { AddNew, Edit }
        private enMode _Mode = enMode.AddNew;

        public int? Id { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? FullName => $"{FirstName} {LastName}".Trim();
        public string? Phone { get; set; }
        public string? Email { get; set; }
        public string? City { get; set; }
        public string? Adress { get; set; }
        public string? Username { get; set; }
        public bool? Status { get; set; }

        public clsUser()
        {
            Id = 0;
            FirstName = null;
            LastName = null;
            Phone = null;
            Email = null;
            City = null;
            Adress = null;
            Username = null;
            Status = null;
        }
        private clsUser(clsUserDTO userDTO)
        {
            Id = userDTO.Id;
            FirstName = userDTO.FirstName;
            LastName = userDTO.LastName;
            Phone = userDTO.Phone;
            Email = userDTO.Email;
            City = userDTO.City;
            Adress = userDTO.Adress;
            Username = userDTO.Username;
            Status = userDTO.Status;    
        }
        public static clsUser? Find(string username)
        {
            if (string.IsNullOrEmpty(username))
                return null;

            clsUserDTO? userDTO = clsUserData.GetUserByUsername(username);
            return userDTO != null ? new clsUser(userDTO) : null;
        }
        public static bool IsExists(string username)
        {
            if (string.IsNullOrEmpty(username))
                return false;

            return clsUserData.IsUserExistByUsername(username);
        }   
        public static string? GetPasswordHash(string username)
        {
            if (string.IsNullOrEmpty(username))
                return null;
            return clsUserData.GetPasswordHashByUsername(username);
        }   
    }
}
