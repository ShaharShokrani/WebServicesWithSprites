using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace ToBeDeleted
{
    /// <summary>
    /// Summary description for WebService1
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    [System.Web.Script.Services.ScriptService]
    public class PaymentWebService : System.Web.Services.WebService
    {
        List<BookingPayment> objPayment = new List<BookingPayment>()
        {
            new BookingPayment {RoomId = 123, RoomType = "AC", BookingStatus = "Pending"},
            new BookingPayment {RoomId = 123, RoomType = "AC", BookingStatus = "Pending"},
            new BookingPayment {RoomId = 123, RoomType = "AC", BookingStatus = "Pending"}
        };

        [WebMethod]
        public List<BookingPayment> RoomBookingStatus()
        {
            return objPayment;
        }
        [WebMethod]
        public List<BookingPayment> RoomBookingStatusByRoomId(int roomId)
        {
            return objPayment.Where(b=>b.RoomId == roomId).ToList();
        }

        public class BookingPayment
        {
            public int RoomId { get; set; }
            public string RoomType { get; set; }
            public string BookingStatus { get; set; }
        }
    }
}
