using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class Role
    {
        public Role()
        {
            this.Users = new HashSet<User>();
        }
        [Display(Name = "آیدی")]
        [Key]
        public int Role_Id { get; set; }
        [Display(Name = "نقش کاربری")]
        public string Role_Name { get; set; }
        [Display(Name = "سمت کاربری")]
        public string Role_Title { get; set; }

        public virtual ICollection<User> Users { get; set; }
    }
}