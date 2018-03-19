using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Hotel
{
    class Invoice
    {
        private string idRoom;
        private string roomView;
        private int roomQuantity;
        private decimal pricePerRoom;

        public Invoice() : this("001", "Room View is :Sea ", 1, 100) { }

        public Invoice(string idRoom, string roomView, int roomQuantity, decimal pricePerRoom)
        {
            this.IdRoom = idRoom;
            this.RoomView = roomView;
            this.RoomQuantity = roomQuantity;
            this.PricePerRoom = pricePerRoom;
        }

        public string IdRoom { get => idRoom; set => idRoom = value; }
        public string RoomView { get => roomView; set => roomView = value; }



        public int RoomQuantity
        {
            get => roomQuantity;
            set
            {
                if (value > 0)
                    roomQuantity = value;



            }
        }
        public decimal PricePerRoom
        {
            get => pricePerRoom;
            set
            {
                this.pricePerRoom = value;
                if (this.pricePerRoom < 0)
                {
                    throw new MyException("negative number are not allowed");

                }
            }

        }

        public decimal GetInvoiceAmount()
        {
            return (roomQuantity * pricePerRoom);
        }
    }

    [Serializable]
    internal class MyException : Exception
    {
        public MyException()
        {
        }

        public MyException(string message) : base(message)
        {
        }

        public MyException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected MyException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
