namespace ClassCoustmer.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public  class Users
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id { get; set; }
        [Required]
        [StringLength(10)]
        [Display(Name ="”√ªß√˚")]
        public string Name { get; set; }
        [Required]
        [StringLength(20)]
        [Display(Name = "√‹¬Î")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
    public class UserLogin
    {
        public bool About(Users model)
        {
            if (model.Name == "admin" && model.Password == "123456")
            {
                return true;
            }
            return false;
        }
    }
}
