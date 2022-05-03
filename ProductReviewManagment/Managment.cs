using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductReviewManagment
{
    public class Managment
    {
        public readonly DataTable dataTable = new DataTable();
        // UC2-Retrieve top 3 records from the list who’s rating is high using LINQ
        public void TopRecords(List<ProductReview> listProductReview)
        {
            var RecordedData = (from productReviwes in listProductReview
                                orderby productReviwes.Rating descending
                                select productReviwes).Take(3);

            foreach(var list in RecordedData)
            {
                Console.WriteLine("ProductID:- " + list.ProductID + " " + "UserID:- " + list.UserID
                    + " " + "Rating:- " + list.Rating + " " + "Review:- " + list.Review + " " + "isLike:- " + list.IsLike);
            }
        }

        //UC3-Retrieve all record from the list who’s rating are greater then 3 and productID is 1 or 4 or 9 using LINQ
        public void SelectedRecord(List<ProductReview> listProductReview)
        {
            var RecordedData = (from productReview in listProductReview
                                where (productReview.ProductID == 1 || productReview.ProductID == 4 || productReview.ProductID == 9)
                                && productReview.Rating > 3
                                select productReview);
            Console.WriteLine("Rating greater than 3 with product id of 1,4,or 9: \n");
            foreach (var list in RecordedData)
            {
                Console.WriteLine("ProductID:- " + list.ProductID + " " + "UserID:- " + list.UserID
                   + " " + "Rating:- " + list.Rating + " " + "Review:- " + list.Review + " " + "isLike:- " + list.IsLike);
            }
        }

        //UC4-Retrieve only productId and review from the list for all records using LINQ select operator.
        public void CountRecords(List<ProductReview> listProductReview)
        {
            var RecordedData =listProductReview.GroupBy(x => x.ProductID).Select(x => new { ProductID = x.Key, Count = x.Count() });
            Console.WriteLine("Count of records by ProductID: ");
            foreach (var list in RecordedData)
            {
                Console.WriteLine("ProductID:" + list.ProductID + "----->" + "Count: " + list.Count);

            }
        }

        //UC5-Management - Retrieve only productId and review from the list for all records.
        public void RetrieveProductIDAndReview(List<ProductReview> listProductReview)
        {
            var RecordedData = listProductReview.Select(x => new { ProductID = x.ProductID, Review = x.Review });
            Console.WriteLine("Product ID with Review: ");
            foreach(var list in RecordedData)
            {
                Console.WriteLine("ProductID: " + list.ProductID + "====> " + list.Review);
            }
        }

        //UC6-skip top 5 records from the list using LINQ and display other records
        public void Skip5Records(List<ProductReview> listProductReview)
        {
            var RecordedData = (from productReview in listProductReview
                                select productReview).Skip(5);
            foreach (var list in RecordedData)
            {
                Console.WriteLine("ProductID:- " + list.ProductID + " " + "UserID:- " + list.UserID
                    + " " + "Rating:- " + list.Rating + " " + "Review:- " + list.Review + " " + "isLike:- " + list.IsLike);
            }
        }

        //UC8-Retrieve all the records from the datatable variable who’s isLike value is true using LINQ
        public void ISLikeValuetrue(List<ProductReview> listProductReview)
        {
            var RecordedData = (from productReview in listProductReview
                                where (productReview.IsLike == true)
                                select productReview);
            foreach (var list in RecordedData)
            {
                Console.WriteLine("ProductID:- " + list.ProductID + " " + "UserID:- " + list.UserID
                    + " " + "Rating:- " + list.Rating + " " + "Review:- " + list.Review + " " + "isLike:- " + list.IsLike);
            }
        }

        //UC9-Find average rating of the each productId using LINQ
        public void AvrageRating(List<ProductReview> listProductReview)
        {
            var RecordedData = (from productReview in listProductReview
                                group productReview by productReview.ProductID).Select(x => x.Average(a => a.Rating));
            foreach(var list in RecordedData)
            {
                Console.WriteLine(list);
            }            
        }

        //UC10-Retreive all records from the list who’s review message contain “nice”
        public void ReviewMassageShouldbeNice(List<ProductReview> listProductReview)
        {
            var RecordedData = (from productReview in listProductReview
                                where (productReview.Review == "nice")
                                select productReview);
            foreach (var list in RecordedData)
            {
                Console.WriteLine("ProductID:- " + list.ProductID + " " + "UserID:- " + list.UserID
                    + " " + "Rating:- " + list.Rating + " " + "Review:- " + list.Review + " " + "isLike:- " + list.IsLike);
            }
        }

        //UC11-Retreive all records from the list who’s Userid = 10 and order by rating
        public void ProductIdIs10(List<ProductReview> listProductReview)
        {
            var RecordedData = (from productReviwes in listProductReview
                                where (productReviwes.ProductID == 10)
                                orderby productReviwes.Rating ascending
                                select productReviwes);

            foreach (var list in RecordedData)
            {
                Console.WriteLine("ProductID:- " + list.ProductID + " " + "UserID:- " + list.UserID
                    + " " + "Rating:- " + list.Rating + " " + "Review:- " + list.Review + " " + "isLike:- " + list.IsLike);
            }
        }
    }
}
