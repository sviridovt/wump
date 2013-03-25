using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WumpusTest
{
    class Cave
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

        private Room[] rooms;

        /// <summary>
        /// creates cave object
        /// </summary>
        /// <param name="caveType">integer representing cave type</param>
        public Cave(int caveType)
        {
        }

        /// <summary>
        /// checks if two rooms are connected
        /// </summary>
        /// <param name="room1">the number of the first room</param>
        /// <param name="room2">the number of the second room</param>
        /// <returns>returns true of rooms are connected, otherwise returns false</returns>
        public bool isConnected(int room1, int room2)
        {
            return true;
        }

        /// <summary>
        /// gets the room numbers of rooms connected to a given room
        /// </summary>
        /// <param name="roomNumber">the number of the room</param>
        /// <returns>array of room numbers for connected rooms</returns>
        public int[] getConnectedRooms(int roomNumber)
        {
            return null;
        }
    }
}
