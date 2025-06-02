using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using WebApplication1.Models;

namespace WebApplication1.Models
{
    public class User
    {
        public User()
        {
            this.Products = new HashSet<Product>();
        }

        [Display(Name = "آیدی")]
        public int Id { get; set; }
        [Display(Name = "نام")]
        public string Name { get; set; }
        [Display(Name = "نام خانوادگی")]
        public string Family { get; set; }
        [Display(Name = "موبایل")]
        public string Phone { get; set; }
        [Display(Name = "رمز عبور")]
        public string password { get; set; }
        [Display(Name = "ایمیل")]
        public string Email { get; set; }
        [Display(Name = "تاریخ عضویت")]
        public System.DateTime Register_date { get; set; }
        [Display(Name = "جنسیت")]
        public Nullable<bool> gender { get; set; }
        [Display(Name = "وضعیت حساب")]
        public bool IsActive { get; set; }
        [Display(Name = "آیدی نقش کاربر")]
        public int UserRole_Id { get; set; }

        public virtual Role Role { get; set; }
        public virtual ICollection<Product> Products { get; set; }
    }
}