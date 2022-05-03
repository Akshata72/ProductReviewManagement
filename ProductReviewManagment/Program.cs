using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductReviewManagment
{
    class program
    {
        static void Main(string[]args)
        {
            Console.WriteLine("Welcome to Product Review Managment Program");

            List<ProductReview> productReviewsList = new List<ProductReview>()
            {
                new ProductReview() { ProductID = 1, UserID = 1, Rating = 7, Review ="Good", IsLike = true },
                new ProductReview() { ProductID = 2, UserID = 1, Rating = 4, Review = "Good", IsLike = true },
                new ProductReview() { ProductID = 3, UserID = 1, Rating = 5, Review = "Good", IsLike = true },
                new ProductReview() { ProductID = 4, UserID = 1, Rating = 6, Review = "Good", IsLike = false },
                new ProductReview() { ProductID = 5, UserID = 1, Rating = 2, Review = "nice", IsLike = true },
                new ProductReview() { ProductID = 5, UserID = 1, Rating = 1, Review = "bad", IsLike = true },
                new ProductReview() { ProductID = 7, UserID = 1, Rating = 1, Review = "Good", IsLike = false },
                new ProductReview() { ProductID = 8, UserID = 1, Rating = 9, Review = "nice", IsLike = true },
                new ProductReview() { ProductID = 8, UserID = 1, Rating = 2, Review = "bad", IsLike = true },
                new ProductReview() { ProductID = 10, UserID = 1, Rating = 8, Review = "nice", IsLike = true },
                new ProductReview() { ProductID = 11, UserID = 1, Rating = 3, Review = "nice", IsLike = true },
                new ProductReview() { ProductID = 12, UserID = 1, Rating = 2, Review = "Good", IsLike = true },
                new ProductReview() { ProductID = 13, UserID = 1, Rating = 4, Review = "Good", IsLike = true },
                new ProductReview() { ProductID = 14, UserID = 1, Rating = 5, Review = "Good", IsLike = true },
                new ProductReview() { ProductID = 14, UserID = 1, Rating = 6, Review = "Good", IsLike = false },
                new ProductReview() { ProductID = 16, UserID = 1, Rating = 2, Review = "nice", IsLike = true },
                new ProductReview() { ProductID = 17, UserID = 1, Rating = 1, Review = "bad", IsLike = true },
                new ProductReview() { ProductID = 18, UserID = 1, Rating = 2, Review = "bad", IsLike = true },
                new ProductReview() { ProductID = 19, UserID = 1, Rating = 1, Review = "Good", IsLike = false },
                new ProductReview() { ProductID = 20, UserID = 1, Rating = 9, Review = "nice", IsLike = true },
                new ProductReview() { ProductID = 21, UserID = 1, Rating = 10, Review = "nice", IsLike = true },
                new ProductReview() { ProductID = 22, UserID = 1, Rating = 8, Review = "nice", IsLike = true },
                new ProductReview() { ProductID = 23, UserID = 1, Rating = 3, Review = "nice", IsLike = true },
                new ProductReview() { ProductID = 24, UserID = 1, Rating = 10, Review = "nice", IsLike = true },
                new ProductReview() { ProductID = 25, UserID = 1, Rating = 8, Review = "nice", IsLike = true }
            };
            foreach(var list in productReviewsList)
            {
                Console.WriteLine("ProductID:- " + list.ProductID + " " + "UserID:- " + list.UserID
                    + " " + "Rating:- " + list.Rating + " " + "Review:- " + list.Review + " " + "isLike:- " + list.IsLike);
            }
            int Option = 0;
            do
            {
                Managment managment = new Managment();
                DataTableOpration dataTableOpration = new DataTableOpration();
                Console.WriteLine("\nEnter 1 for Top 3 records: ");
                Console.WriteLine("Enter 2 for Rating greater than 3 with product id of 1,4,or 9:");
                Console.WriteLine("Enter 3 for Count Records:");
                Console.WriteLine("Enter 4 for Review with ProductID:");
                Console.WriteLine("Enter 5 for skiping top 5 records:");
                Console.WriteLine("Enter 6 for Creating DataTable:");
                Console.WriteLine("Enter 7 for who’s isLike value is true:");
                Console.WriteLine("Enter 0 Exit: ");

                try
                {
                    Option = int.Parse(Console.ReadLine());
                    switch (Option)
                    {
                        case 1:
                            Console.WriteLine("\nFollowing are the top 3 records from the list who’s rating is high:\n");
                            managment.TopRecords(productReviewsList);
                            break;
                        case 2:
                            managment.SelectedRecord(productReviewsList);
                            break;
                        case 3:
                            managment.CountRecords(productReviewsList);
                            break;
                        case 4:
                            managment.RetrieveProductIDAndReview(productReviewsList);
                            break;
                        case 5:
                            managment.Skip5Records(productReviewsList);
                            break;
                        case 6:
                            dataTableOpration.CreateTabel();
                            break;
                        case 7:
                            managment.ISLikeValuetrue(productReviewsList);
                            break;
                    }
                }
                 catch(Exception)
                {
                    Console.WriteLine("Choose Correct Option...");
                }
            } while (Option != 0);
        }
    }
}
