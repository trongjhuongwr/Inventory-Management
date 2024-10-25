﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Drawing;
using System.IO;

namespace Inventory_Management
{
    public class Keyboard: Product
    {
        [JsonConstructor]
        public Keyboard(string productId, string name, string category, int quantity, double price) : base(productId, name, category, quantity, price)
        {
        }
        public Keyboard():base() { }
        public override void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            base.GetObjectData(info, context);
        }
        public override double PriceQuantity()
        {
            return Price * Quantity;
        }
    }
}