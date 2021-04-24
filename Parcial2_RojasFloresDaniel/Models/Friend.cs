using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Parcial2_RojasFloresDaniel.Models
{
    public class Friend
    {
        [Key]
        public int FriendID { get; set; }
        [Required]
        [StringLength(30, MinimumLength =3)]
        public string Name { get; set; }
        public string NickName { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime Birthday { get; set; }

    }
}