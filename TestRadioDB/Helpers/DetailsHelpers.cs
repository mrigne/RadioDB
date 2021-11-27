using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestRadioDB.Models;

namespace TestRadioDB
{
    class DetailsHelpers
    {
        private static DetailsHelpers instance;
        public static DetailsHelpers GetInstance() {
            if (instance == null)
            {
                instance = new DetailsHelpers();
            }
            return instance;
        }

        public static List<DetailRow> details = new List<DetailRow>();

        public void GetDetails()
        {
            ContainersHelper.GetInstance().GetContainers();

            var detailsFromDb = DBHelper.GetInstance().GetDetails();
            detailsFromDb.ForEach(detail =>
            {
                var usedContainer = ContainersHelper.containers.Find(container => container.ContainerId == detail.ContainerId);
                if (usedContainer != null)
                {
                    detail.ContainerName = usedContainer.Name;
                    if (!String.IsNullOrEmpty(usedContainer.Barcode))
                    {
                        detail.ContainerBarcode = usedContainer.Barcode;
                    }
                }
            });
            details = detailsFromDb;
        }
    }
}
