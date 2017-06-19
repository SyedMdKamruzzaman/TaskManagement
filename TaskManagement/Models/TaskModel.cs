using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TaskManagement.Models
{
    public class TaskModel
    {
        [Key]
        public Int64 id { get; set; }

        [Required]
        [Display(Name = "Task Name", Prompt = "Please enter task name")]
        public string name { get; set; }

        [Required]
        [Display(Name = "Task Description", Prompt = "Please enter task description")]
        public string description { get; set; }

        [ScaffoldColumn(false)]
        [DataType(DataType.DateTime)]
        public DateTime? dateCreated { get; set; }

        [ScaffoldColumn(false)]
        [DataType(DataType.DateTime)]
        public DateTime dateUpdated { get; set; }
    }
}