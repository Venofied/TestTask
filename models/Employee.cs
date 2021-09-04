using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TestTask.models
{
    [Table("Employee", Schema = "public")]
    public class Employee
    {
        [Key]
        [Column("id")]
        public int ID { get; set; }

        [Column("name")]
        public string Name { get; set; }

        [Column("salary")]
        public int Salary { get; set; }

        [Column("id_department")]
        public int Id_department { get; set; }

        [Column("name_department")]
        public string Name_department { get; set; }

    }
}
