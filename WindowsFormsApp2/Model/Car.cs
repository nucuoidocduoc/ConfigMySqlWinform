using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2.Model
{
    [Table("Car")]
    public class Car
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}