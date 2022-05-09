
using DesignPatterns.FactoryPattern;

var storeSaleFactory = new StoreSaleFactory(10);
var internetSaleFactory = new InternetSaleFactory(10);

ISale sale1 = storeSaleFactory.GetSale();
sale1.Sell(15);

ISale sale2 = internetSaleFactory.GetSale();
sale2.Sell(15);