using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestRadioDB.Models
{
    public class DetailRow : ICloneable
    {
        public string DetailId { get; set; } = Guid.NewGuid().ToString();
        public string Name { get; set; }
        public string? ContainerId { get; set; }
        public string? ContainerName { get; set; }
        public string? ContainerBarcode { get; set; }
        public int Count { get; set; } = 1;

        public DetailRow Clone()
        {
            return (DetailRow)this.MemberwiseClone();
        }

        public DetailRow CopyDetailRowWihtNewId()
        {
            var clonedRow = this.Clone();
            clonedRow.DetailId = Guid.NewGuid().ToString();
            return clonedRow;
        }

        object ICloneable.Clone()
        {
            return Clone();
        }
    }
}
