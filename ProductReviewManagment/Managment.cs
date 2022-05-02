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
    }
}
