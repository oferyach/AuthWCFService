using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;


namespace AuthService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service : LoyaltyService
    {
        public AuthResult GetAuth(string card,string stationcode)
        {
            AuthResult res = new AuthResult(); // { Allowed = true, DriverName = "Ofer" };

            if (stationcode == "3")
            {
                res.Allowed = false;
                res.ErrorDesc = "Not allowed in this station";
                res.DriverName = "Ofer";
                return res;
            }

            if (card == "7215701085369600")
            {
                res.Allowed = true;
                res.DriverName = "Ofer";
                res.Discount = 5.0;
                res.Limit = 5000;

                res.Reference = "ABCD";

                

                res.ProductsList.Add(new ProductItem());

                res.ProductsList[0].Code = 103;
                res.ProductsList[0].Discount = 5;
                res.ProductsList[0].DiscountType = "Abs";

                res.ProductsList.Add(new ProductItem());

                res.ProductsList[1].Code = 104;
                res.ProductsList[1].Discount = 5;
                res.ProductsList[1].DiscountType = "%";


                
            }
            else
            {
                res.Allowed = false;
                res.ErrorDesc = "Unknow card.";
                res.DriverName = "Lionel";
            }
            return res;
        }

        public TransactionCompleteResult TransactionComplete(string referece, double amount, double volume, int ProductCode,DateTime datetime)
        {
            TransactionCompleteResult res = new TransactionCompleteResult();

            res.Recived = true;
            res.ErrorDesc = "OK";
            
            return res;
        }

       
    }
}
