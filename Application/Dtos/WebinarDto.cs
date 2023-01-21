using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Dtos
{
    public class WebinarDto
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public DateTime ScheduledOn { get; set; }
        public bool IsActive { get; set; }
    }
}
