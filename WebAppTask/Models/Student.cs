using System.ComponentModel.DataAnnotations.Schema;



namespace WebAppTask.Models
{
        public class Student
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public string Title { get; set; }
            public int Age { get; set; }
        }
    }
