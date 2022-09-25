using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LicenseControl.Models.Dtos
{
    public class GetProcessorDto
    {
        public string Architecture { get; set; }
        public string Caption { get; set; }
        public string Family { get; set; }
        public string ProcessorId { get; set; }
    }
}
