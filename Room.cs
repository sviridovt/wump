using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WumpusTest
{
    class Room
    {
        private int roomNumber;
        private int[] adjacentRooms;
        private bool[] connectedRooms;
        private int[] directions = { 0, 1, 2, 3, 4, 5 };

        /// <summary>
        /// creates a single Room object
        /// </summary>
        /// <param name="newAdjacentRooms">array of rooms which this room is adjacent to</param>
        /// <param name="newConnectedRooms">array of rooms which this room is connected to</param>
        public Room(int newNumber, int[] newAdjacentRooms, bool[] newConnectedRooms)
        {
            this.adjacentRooms = newAdjacentRooms;
            this.connectedRooms = newConnectedRooms;
            roomNumber = newNumber;
        }

        /// <summary>
        /// gets the connected romos
        /// </summary>
        /// <returns>array of room numbers representing connected rooms</returns>
        public bool[] getConnectedRooms()
        {
            return connectedRooms;
        }

        /// <summary>
        /// opens up the connection between two rooms
        /// </summary>
        /// <param name="roomNumber">room number of the room to open tunnel with</param>
        public void openTunnel(int roomNumber)
        {
            for (int i = 0; i < 6; i++)
            {
                if (adjacentRooms[i] == roomNumber)
                {
                    connectedRooms[i] = true;
                }
            }
        }

        /// <summary>
        /// checks if two rooms are connected
        /// </summary>
        /// <param name="roomNumber">room number of the room to check</param>
        /// <returns>true if rooms are connected, otherwise false</returns>
        public bool isConnected(int roomNumber)
        {
            for (int i = 0; i < 6; i++)
            {
                if (roomNumber == adjacentRooms[i])
                {
                    if (connectedRooms[i] == true)
                    {
                        return true;
                    }
                }
            }
            return false;
        }

    }
}
