int annualTrainingFee = int.Parse(Console.ReadLine());

double sneakersPrice = 0.6 * annualTrainingFee;
double outfitPrice = 0.8 * sneakersPrice;
double ballPrice = 0.25 * outfitPrice;
double accessoriesPrice = 0.2 * ballPrice;

double totalPrice = annualTrainingFee + sneakersPrice + outfitPrice + ballPrice + accessoriesPrice;

Console.WriteLine(totalPrice);