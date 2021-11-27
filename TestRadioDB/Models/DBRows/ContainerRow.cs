using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestRadioDB.Models
{
    public class ContainerRow
    {
        public string ContainerId { get; set; } = Guid.NewGuid().ToString();
        public string Name { get; set; }
        public string? Barcode { get; set; }
        public int DetailsCount { get; set; } = 0;
    }
}
