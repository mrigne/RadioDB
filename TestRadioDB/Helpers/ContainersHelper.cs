using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestRadioDB.Helpers;
using TestRadioDB.Models;

namespace TestRadioDB
{
    class ContainersHelper
    {
        public static ContainersHelper instance;
        public static List<ContainerRow> containers = new List<ContainerRow>();
        public static ContainersHelper GetInstance()
        {
            if (instance == null)
            {
                instance = new ContainersHelper();
            }
            return instance;
        }

        private ContainersHelper()
        {
            
        }

        public void GetContainers()
        {
            containers = DBHelper.GetInstance().GetContainers();
            containers.Sort(SortHelper.SortByName);
        }
    }
}
