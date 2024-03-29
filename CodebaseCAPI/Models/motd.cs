﻿using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace CodebaseCAPI.Models
{
    public class motd : BaseEntity
    {
        [Key]
        public int motd_id { get { return id; } set { id = value; } }
        [ForeignKey("account.account_id")]
        public int account_id { get; set; }
        [Required]
        public string title { get; set; }
        [Required]
        public string content { get; set; }
        [Required]
        public DateTime motd_date { get; set; }
    }
}
