﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OKInvestir.Model
{
    public class Client
    {
        public int Id { get; set; }
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]
        [StringLength(30)]
        [Index(IsUnique = true)]
        public string IdCardNumber { get; set; }
        [NotMapped]
        public string FullName
        {
            get
            {
                return FirstName + " " + LastName;
            }
            private set { }
        }

        public List<Account> AccountList { get; set; }

        public Client() { }

        public Client(string firstName, string lastName, string idCardNumber)
        {
            FirstName = firstName;
            LastName = lastName;
            IdCardNumber = idCardNumber;
        }
    }
}
