
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace SampleMvc.Models
{
    public class StudentSubject
    {


        public int StudentId { get; set; }


        public string Name { get; set; }

        public string Class { get; set; }

        public string? Subject_Name { get; set; }

    }
}