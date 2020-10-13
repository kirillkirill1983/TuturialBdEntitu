using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace BD_temp
{
    public class Company
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; } // название компании

        public List<User> Users { get; set; }//  сотрудники компаниии
    }
}
