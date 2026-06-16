namespace LINQ2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Question 1
    //        var top3Expensive = products
    //.OrderByDescending(p => p.UnitPrice)
    //.Take(3);
            #endregion

            #region Question 2
    //        var page2 = products
    //.Skip(5)
    //.Take(5);
            #endregion

            #region Question 3
    //        var cheapProducts = products
    //.OrderBy(p => p.UnitPrice)
    //.TakeWhile(p => p.UnitPrice < 25);
            #endregion

            #region Question 4
    //        bool allSeafoodInStock = products
    //.Where(p => p.Category == "Seafood") 
    //.All(p => p.UnitsInStock > 0);
            #endregion

            #region Question 5
            //int[] ids = { 3, 9, 13, 18 };
            //bool containsNine = ids.Contains(9);
            #endregion

            #region Question 6
            //var groupedByCount = products.GroupBy(p => p.Category);

            //foreach (var group in groupedByCount)
            //{
            //    Console.WriteLine($"Category: {group.Key}, Count: {group.Count()}");
            //}
            #endregion

            #region Question 7
//            var productNamesByCategory = products.GroupBy(
//    p => p.Category,
//    p => p.ProductName
//);
            #endregion

            #region Question 8
    //        var largeCategories = products
    //.GroupBy(p => p.Category)
    //.Where(g => g.Count() > 3)
    //.Select(g => g.Key);
            #endregion

            #region Question 9
            //var customerStats = from c in customers
            //                    group c by c.Country into countryGroup
            //                    select new
            //                    {
            //                        Country = countryGroup.Key,
            //                        Count = countryGroup.Count(),
            //                        TotalOrderValue = countryGroup.Sum(c => c.Orders.Sum(o => o.OrderTotal))
            //                    };
            #endregion

            #region Question 10
            //int totalStock = products.Sum(p => p.UnitsInStock);
            #endregion

            #region Question 11
            //decimal minPrice = products.Min(p => p.UnitPrice);
            //decimal maxPrice = products.Max(p => p.UnitPrice);
            #endregion

            #region Question 12
    //        var distinctCategories = products
    //.Select(p => p.Category)
    //.Distinct();
            #endregion

            #region Question 13
            //int[] setA = { 1, 3, 5, 7, 9, 11, 13 };
            //int[] setB = { 3, 6, 9, 12, 15, 13 };

            //var difference = setA.Except(setB);
            #endregion

            #region Question 14
            //string[] list1 = { "Germany", "France", "UK", "Spain" };
            //string[] list2 = { "france", "SPAIN", "Italy" };

            //var uniqueCountries = list1.Except(list2, StringComparer.OrdinalIgnoreCase);
            #endregion

            #region Question 15
            //Dictionary<int, Product> productDict = products.ToDictionary(p => p.ProductID);

            //if (productDict.TryGetValue(18, out Product targetProduct))
            //{
            //    Console.WriteLine($"Found: {targetProduct.ProductName}");
            //}
            #endregion

            #region Question 16
            //var firstExpensiveProduct = products.First(p => p.UnitPrice > 50);
            #endregion

            #region Question 17
            var tryGetProduct = products.FirstOrDefault(p => p.UnitPrice > 500);
            #endregion

            #region Question 18
            var tableOfSeven = Enumerable.Range(1, 12).Select(i => $"{i} x 7 = {i * 7}");
            #endregion

            #region Question 19
            var evenNumbers = Enumerable.Range(1, 30).Where(n => n % 2 == 0);
            #endregion

            #region Question 20
            var first3Products = products.Take(3).Select(p => p.ProductName);
            var first3Customers = customers.Take(3).Select(c => c.CompanyName);

            var concatenatedSequence = first3Products.Concat(first3Customers);
            #endregion

            #region Question 21
            var pairedPairs = products.Zip(customers, (p, c) => $"{p.ProductName} sold to {c.CompanyName}");
            #endregion
        }
    }
}
