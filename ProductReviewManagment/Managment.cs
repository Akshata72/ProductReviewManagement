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
    }
}
