using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace CustomList.Viewmodels
{
    public class TestListViewModel : BaseViewModel
    {
        private CustomerListList data = new CustomerListList();


        public class Customer
        {
            public int ID { get; set; }
            public string NAME { get; set; }
            public string FROM { get; set; }
            public string TO { get; set; }
        }

        public class CustomerList
        {
            public int ID { get; set; }
            public List<Customer> customers { get; set; }

            [JsonIgnore]
            public int widthSize { get; set; }

            [JsonIgnore]
            public bool SeparatorVisible { get; set; }

        }

        public class CustomerListList
        {
            public int ID { get; set; }
            public List<CustomerList> customersList { get; set; }
        }

        public TestListViewModel()
        {
            var listA = new List<Customer>();
            listA.Add(new Customer { ID = 1, NAME = "007FRZA000072", FROM = "Paris", TO = "Cape Town" });
            listA.Add(new Customer { ID = 2, NAME = "007FRZA000073", FROM = "Paris", TO = "Port Louis" });

            var listB = new List<Customer>();
            listB.Add(new Customer { ID = 3, NAME = "007FRZA000074", FROM = "London", TO = "New York" });

            var listC = new List<Customer>();
            listC.Add(new Customer { ID = 4, NAME = "007FRZA000075", FROM = "Madrid", TO = "Paris" });

            var listD = new List<Customer>();
            listD.Add(new Customer { ID = 4, NAME = "007FRZA000076", FROM = "Madrid", TO = "Paris" });
            listD.Add(new Customer { ID = 1, NAME = "007FRZA000077", FROM = "Paris", TO = "Cape Town" });
            listD.Add(new Customer { ID = 3, NAME = "007FRZA000078", FROM = "London", TO = "New York" });

            var listE = new List<Customer>();
            listE.Add(new Customer { ID = 3, NAME = "007FRZA000079", FROM = "London", TO = "New York" });
            listE.Add(new Customer { ID = 1, NAME = "007FRZA000080", FROM = "Paris", TO = "Cape Town" });
            listE.Add(new Customer { ID = 4, NAME = "007FRZA000081", FROM = "Madrid", TO = "Paris" });

            var listParentA = new CustomerList { ID = 1, customers = listA, widthSize = (listA.Count * 225), SeparatorVisible = listA.Count > 1 ? true : false };
            var listParentB = new CustomerList { ID = 1, customers = listB, widthSize = (listB.Count * 225), SeparatorVisible = listB.Count > 1 ? true : false };
            var listParentC = new CustomerList { ID = 1, customers = listC, widthSize = (listC.Count * 225), SeparatorVisible = listC.Count > 1 ? true : false };
            var listParentD = new CustomerList { ID = 1, customers = listD, widthSize = (listD.Count * 225), SeparatorVisible = listD.Count > 1 ? true : false };
            var listParentE = new CustomerList { ID = 1, customers = listE, widthSize = (listE.Count * 225), SeparatorVisible = listE.Count > 1 ? true : false };


            var ff = new List<CustomerList>();
            ff.Add(listParentA);
            ff.Add(listParentB);
            ff.Add(listParentC);
            ff.Add(listParentD);
            ff.Add(listParentE);

            data = new CustomerListList { ID = 1, customersList = ff };
        }

        public CustomerListList AllData
        {
            get => data;
            set => SetProperty(ref data, value);
        }

    }
}
