﻿using System.Collections.Generic;
using GameProject.Interfaces;

namespace GameProject.Models
{
    public class Inventory
    {
        private List<IItem> items = new List<IItem>();

        public List<IItem> Items
        {
            get { return this.items; }

            set { this.items = value; }
        }
    }
}