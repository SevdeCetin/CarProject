using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarProject.API.DTOs
{
    public class ErrorDTO
    {
        public ErrorDTO()
        {
            Error = new List<string>();
        }
        public int StatusCode { get; set; }
        public List<string> Error { get; set; }
    }
}
