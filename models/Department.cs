using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TestTask.models
{
    [Table("Department", Schema = "public")]
    //[TableName("department")]
    public class Department
    {
        [Key]
        [Column("id")]
        //[MapField("id"), PrimaryKey, NonUpdatable, DisplayName("ID")]
        public int ID { get; set; }
        [Column("name")]
        //[MapField("name"), DisplayName("Name")]
        public string Name { get; set; }

    }
}
