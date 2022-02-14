using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;
using System.Diagnostics;
namespace TaskManager.Models
{
    public class TaskUnit
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Content { get; set; }
        public string tag { get; set; }
        public DateTime TimeCreated { get; set; }
       


        public TaskUnit()
        {


        }


       
    }
}
