using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading;

namespace Clients.Models
{
    class OrganizationCommonProvider:IItemsProvider<OrganizationCommonModel>
    {
        private readonly int _count;

        /// <summary>
        /// Initializes a new instance of the <see cref="DemoCustomerProvider"/> class.
        /// </summary>
        /// <param name="count">The count.</param>
        /// <param name="fetchDelay">The fetch delay.</param>
        public OrganizationCommonProvider(int count)
        {
            _count = count;
        }

        /// <summary>
        /// Fetches the total number of items available.
        /// </summary>
        /// <returns></returns>
        public int FetchCount()
        {
            return _count;
        }

        /// <summary>
        /// Fetches a range of items.
        /// </summary>
        /// <param name="startIndex">The start index.</param>
        /// <param name="count">The number of items to fetch.</param>
        /// <returns></returns>
        public IList<OrganizationCommonModel> FetchRange(int startIndex, int count)
        {

            List<OrganizationCommonModel> list = new List<OrganizationCommonModel>();
            for (int i = startIndex; i < startIndex + count; i++)
            {
                /*
                OrganizationCommonModel customer = new OrganizationCommonModel { id = 1, OrgName = "Организация 4", DogovorED = "ЭД205/0120", DogovorEDDate = DateTime.Now, Activities = new List<string>() { "ЭД", "Склад" }, Inn = "312301002", OrdersState = OrderStateEnum.Canceled };
                list.Add(customer);
                */
            }
            return list;
        }
    }
}
