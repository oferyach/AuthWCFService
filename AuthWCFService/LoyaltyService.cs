using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace AuthService
{
    [ServiceContract]
    public interface LoyaltyService
    {

        [OperationContract]
        AuthResult GetAuth(string card,string stationcode);


        [OperationContract]
        TransactionCompleteResult TransactionComplete(string referece, double amount, double volume, int ProductCode,DateTime datetime);

    }


    [DataContract]
    public class ProductItem
    {
        int code = 0;
        double discount = 0;
        string discounttype = "";

        [DataMember]
        public int Code
        {
            get { return code; }
            set { code = value; }
        }

        [DataMember]
        public double Discount
        {
            get { return discount; }
            set { discount = value; }
        }

        [DataMember]
        public string DiscountType
        {
            get { return discounttype; }
            set { discounttype = value; }
        }

    }
    
    [DataContract]
    public class AuthResult
    {
        bool allowed = true;
        bool cpassrequired = true;
        bool pinrequired = true;
        string pincode = "1234";
        string errordesc = "Authorized";
        string drivername = "Mike";
        double limit = 0;
        string limitype = "Money"; //"Volume", "Money"
        double discount = 0;
        string discounttype = "%"; //"%" , "ABS"
        List<ProductItem> productslist = new List<ProductItem>();
        string reference;

        [DataMember]
        public bool Allowed
        {
            get { return allowed; }
            set { allowed = value; }
        }

        [DataMember]
        public bool cPassRequired
        {
            get { return cpassrequired; }
            set { cpassrequired = value; }
        }

        [DataMember]
        public bool PINRequired
        {
            get { return pinrequired; }
            set { pinrequired = value; }
        }

        [DataMember]
        public string PinCode
        {
            get { return pincode; }
            set { pincode = value; }
        }

        [DataMember]
        public string ErrorDesc
        {
            get { return errordesc; }
            set { errordesc = value; }
        }

        [DataMember]
        public string DriverName
        {
            get { return drivername; }
            set { drivername = value; }
        }
        [DataMember]
        public double Limit
        {
            get { return limit; }
            set { limit = value; }
        }

        [DataMember]
        public string LimitType
        {
            get { return limitype; }
            set { limitype = value; }
        }

        [DataMember]
        public double Discount
        {
            get { return discount; }
            set { discount = value; }
        }

        [DataMember]
        public string DiscountType
        {
            get { return discounttype; }
            set { discounttype = value; }
        }

        [DataMember]
        public List<ProductItem> ProductsList
        {
            get { return productslist; }
            set { productslist = value; }
        }



        [DataMember]
        public string Reference
        {
            get { return reference; }
            set { reference = value; }
        }


    }


    [DataContract]
    public class TransactionCompleteResult
    {
        bool recived = true;
        string errordesc = "Authorized";
        

        [DataMember]
        public bool Recived
        {
            get { return recived; }
            set { recived = value; }
        }

        [DataMember]
        public string ErrorDesc
        {
            get { return errordesc; }
            set { errordesc = value; }
        }
    }

   
}
