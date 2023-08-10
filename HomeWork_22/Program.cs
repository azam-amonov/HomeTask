using HomeWork_22.N20_HT1;
using HomeWork_22.N20_HT1.Service;

Console.WriteLine("Online Marketplace\n");

IDebitCard marketCard = new MilliyHumo("9860 0101", "Ipoteka", 0);

IDebitCard uzCard = new KapitalUzCard("8600", "SQB", 1000);
IDebitCard humoCard = new MilliyHumo("9860", "Ipoteka", 1500);

IPaymentProvider payme = new PaymePaymentProvider(1);
IPaymentProvider uzum = new UzumPaymentProvider(0.5);

OnlineMarketService paymeMarket = new OnlineMarketService(marketCard ,payme);
OnlineMarketService uzumMarket = new OnlineMarketService(marketCard, uzum);

paymeMarket.Buy("Apple", 10, uzCard);

Console.WriteLine(uzCard.Balance);
paymeMarket.Display();
