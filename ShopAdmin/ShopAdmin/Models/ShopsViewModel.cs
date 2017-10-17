﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopAdmin.Models
{
    public class ShopsViewModel
    {
        public Shop Store { get; set; }

        public ShopsViewModel(Shop shop)
        {
            this.Store = shop;
        }

        public string Monday { get { return string.Format("{0} - {1}", Store.MondayOpen, Store.MondayClose); } }
        public string Tuesday { get { return string.Format("{0} - {1}", Store.TuesdayOpen, Store.TuesdayClose); } }
        public string Wednesday { get { return string.Format("{0} - {1}", Store.WednesdayOpen, Store.WednesdayClose); } }
        public string Thursday { get { return string.Format("{0} - {1}", Store.ThursdayOpen, Store.ThursdayClose); } }
        public string Friday { get { return string.Format("{0} - {1}", Store.FridayOpen, Store.FridayClose); } }
        public string Saturday { get { return string.Format("{0} - {1}", Store.SaturdayOpen, Store.SaturdayClose); } }
        public string Sunday { get { return string.Format("{0} - {1}", Store.SundayOpen, Store.SundayClose); } }


        public string Address1 { get { return Store.StreetAddress; } }
        public string Address2 { get { return string.Format("{0}, {1} {2}", Store.City, Store.State, Store.ZipCode); } }
    }
}