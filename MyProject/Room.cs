using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject {
    class Room {
        static int totalNumberOfRoom = 0;
        int capacity;
        string owner;
        int rent;

        public Room(int capacity, string owner, int rent)
        {
            this.capacity = capacity;
            this.owner = owner;
            this.rent = rent;
            totalNumberOfRoom += 1;
        }

        public override string ToString()
        {
            return $"Capacity: {this.capacity}\tOwner: {this.owner}\tRent: {this.rent}";
        }

        public int getTheTotalNumberOfRooms()
        {
            return totalNumberOfRoom;
        }

    }
}
