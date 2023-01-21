using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Exceptions
{
    public class WebinarNotFoundException : Exception
    {
        public WebinarNotFoundException(Guid id)
            : base($"Webinar with id {id} was not found") { }
    }
}
