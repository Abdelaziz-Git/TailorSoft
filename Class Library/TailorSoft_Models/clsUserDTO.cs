using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TailorSoft_Models
{
    public class clsUserDTO
    {
        public int Id {  get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Phone {  get; set; }
        public string? Email { get; set; }
        public string City {  get; set; }
        public string? Adress { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public bool Status { get; set; }

        public clsUserDTO()
        {
            this.Id = -1;
            this.FirstName = "";
            this.LastName = "";
            this.Phone= string.Empty;
            this.Email= string.Empty;
            this.City= string.Empty;
            this.Adress= string.Empty;
            this.Username= string.Empty;
            this.Password= string.Empty;
            this.Status = false;
        }
        public clsUserDTO(clsUserDTO UserDTO)
        {
            Id = UserDTO.Id;
            FirstName = UserDTO.FirstName;
            LastName = UserDTO.LastName;
            Phone = UserDTO.Phone;
            Email = UserDTO.Email;
            City = UserDTO.City;
            Adress = UserDTO.Adress;
            Username = UserDTO.Username;
            Password = UserDTO.Password;
            Status = UserDTO.Status;
        }
        
    }
}
