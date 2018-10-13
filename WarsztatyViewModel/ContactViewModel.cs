using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
namespace WarsztatyViewModel
{
    public class ContactViewModel
    {
        public string Name { get; set; }
        public int Number { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }

        public DateTime CreateDate { get; set; }
        public bool IsActive { get; set; }

    }
}
