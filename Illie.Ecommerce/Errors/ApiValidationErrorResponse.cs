using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Illie.Ecommerce.Errors
{
    public class ApiValidationErrorResponse : ApiResponse
    {
        public IEnumerable<string> Errors { get; set; }

        public ApiValidationErrorResponse() : base(400)
        {

        }
    }
}
