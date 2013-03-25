using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WumpusTest
{
        class Cave
            {
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
