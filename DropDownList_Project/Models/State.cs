using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DropDownList_Project.Models
{
    public class State
    {
        public int Id { get; set; }
        public int StateName { get; set; }
        public Country Country { get; set; }
    }
}
