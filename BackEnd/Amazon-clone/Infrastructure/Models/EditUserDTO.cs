﻿using System;
namespace Infrastructure.Models
{
    public class EditUserDTO
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string UserName { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Phone { get; set; }
        public string State { get; set; }
        public DateTime BirthData { get; set; }
        public string FathersName { get; set; }
        public string AvatarImage { get; set; }
    }
}

