﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.FactoryPattern
{
    // Creator 
    public abstract class SaleFactory
    {
        public abstract ISale GetSale();
    }

    // Concrete Creator
    public class StoreSaleFactory : SaleFactory
    {

        private decimal _extra;

        public StoreSaleFactory(decimal extra)
        {
            extra = _extra;
        }

        public override ISale GetSale()
        {
            return new StoreSale(_extra);
        }
    }

    public class InternetSaleFactory : SaleFactory
    {
        private decimal _discount;

        public InternetSaleFactory(decimal discount)
        {
            _discount = discount;
        }

        public override ISale GetSale()
        {
            return new InternetSale(_discount);
        }
    }

    // Concrete Product
    public class StoreSale : ISale
    {
        private decimal _extra;
        public StoreSale(decimal extra)
        {
            _extra = extra;
        }

        public void Sell(decimal total)
        {
            Console.WriteLine($"Total value of the sell {total + _extra}");
        }
    }

    public class InternetSale : ISale
    {
        private decimal _discount;

        public InternetSale(decimal discount)
        {
            discount = _discount;
        }

        public void Sell(decimal total)
        {
            Console.WriteLine($"Total value of the sell {total - _discount}");
        }
    }

    // Product
    public interface ISale
    {
        public void Sell(decimal total);
    }
}
