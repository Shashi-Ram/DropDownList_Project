using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DropDownList_Project.Models
{
    public class City 
    {
        public int Id { get; set; }
        public int CityName { get; set; }
        public State State { get; set; }
    }
}
