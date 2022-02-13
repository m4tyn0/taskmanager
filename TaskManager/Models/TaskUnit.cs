using System;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;

namespace TaskManager.Models
{
    public class TaskUnit
    {
        [Key]
        public string Id { get; set; }
        public string Name { get; set; }
        public string Content { get; set; }
        public string tag { get; set; }
        [DataType(DataType.DateTime)]
        public DateTime TimeCreated { get; }
        [DataType(DataType.DateTime)]
        protected TimeSpan TimeElapsed { get; set; }



        public TaskUnit()
        {
            TimeCreated = DateTime.Now;
            TimeElapsed = ReturnElapsed();
            


        }


        public TimeSpan ReturnElapsed()
        {
            return this.TimeElapsed = this.TimeCreated - DateTime.Now;

        }
    }
}
//dotnet-aspnet-codegenerator controller -name TaskManagerController -m TaskUnit -dc TaskManagerContext --relativeFolderPath Controllers --useDefaultLayout --referenceScriptLibraries -sqlite -f
