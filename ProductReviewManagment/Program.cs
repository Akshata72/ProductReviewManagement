﻿using System;
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
                new ProductReview() { ProductID = 6, UserID = 1, Rating = 1, Review = "bas", IsLike = true },
                new ProductReview() { ProductID = 8, UserID = 1, Rating = 1, Review = "Good", IsLike = false },
                new ProductReview() { ProductID = 8, UserID = 1, Rating = 9, Review = "nice", IsLike = true },
                new ProductReview() { ProductID = 2, UserID = 1, Rating = 10, Review = "nice", IsLike = true },
                new ProductReview() { ProductID = 10, UserID = 1, Rating = 8, Review = "nice", IsLike = true },
                new ProductReview() { ProductID = 11, UserID = 1, Rating = 3, Review = "nice", IsLike = true },
                new ProductReview() { ProductID = 12, UserID = 1, Rating = 2, Review = "Good", IsLike = true },
                new ProductReview() { ProductID = 12, UserID = 1, Rating = 4, Review = "Good", IsLike = true },
                new ProductReview() { ProductID = 13, UserID = 1, Rating = 5, Review = "Good", IsLike = true },
                new ProductReview() { ProductID = 14, UserID = 1, Rating = 6, Review = "Good", IsLike = false },
                new ProductReview() { ProductID = 15, UserID = 1, Rating = 2, Review = "nice", IsLike = true },
                new ProductReview() { ProductID = 15, UserID = 1, Rating = 1, Review = "bad", IsLike = true },
                new ProductReview() { ProductID = 15, UserID = 1, Rating = 2, Review = "bad", IsLike = true },
                new ProductReview() { ProductID = 15, UserID = 1, Rating = 1, Review = "Good", IsLike = false },
                new ProductReview() { ProductID = 18, UserID = 1, Rating = 9, Review = "nice", IsLike = true },
                new ProductReview() { ProductID = 19, UserID = 1, Rating = 10, Review = "nice", IsLike = true },
                new ProductReview() { ProductID = 20, UserID = 1, Rating = 8, Review = "nice", IsLike = true },
                new ProductReview() { ProductID = 21, UserID = 1, Rating = 3, Review = "nice", IsLike = true },
                new ProductReview() { ProductID = 22, UserID = 1, Rating = 10, Review = "nice", IsLike = true },
                new ProductReview() { ProductID = 22, UserID = 1, Rating = 8, Review = "nice", IsLike = true },
                new ProductReview() { ProductID = 25, UserID = 1, Rating = 3, Review = "nice", IsLike = true }
            };
            foreach(var list in productReviewsList)
            {
                Console.WriteLine("\nProductID: " +list.ProductID+ " UserID: " +list.UserID+ " Rating: " +list.Rating+ " Review: "+list.Review+ " IsLike: " +list.IsLike);
            }
            Console.ReadLine();
        }
    }
}
