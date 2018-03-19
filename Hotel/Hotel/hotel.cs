using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel
{
    class hotel
    {
        private int nrOfRooms;
        private List<Room> rooms;
        private List<Client> client;
       
       
        


        public hotel(int nrOfRooms, List<Room> rooms, List<Client> client)
        {
            this.nrOfRooms = nrOfRooms;
            this.rooms = rooms;
            this.client = client;

        }

        public int getNrOfRooms()
        {
            return nrOfRooms;
        }
        public void setNrOfRooms(int nrOfRooms)
        {
            this.nrOfRooms = nrOfRooms;
        }


    }
}
