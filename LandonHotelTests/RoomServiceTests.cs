using LandonHotel.Services;
using System;
using Xunit;
using Moq;
using System.Collections.Generic;
using LandonHotel.Data;

namespace LandonHotelTests
{
    public class RoomServiceTests
    {
        //TODO: Class setup
        // Inline
        //Negative testing
        // Moq the services
        // Gets called once
        // Controller
        // Repository


        [Fact]
        public void Should_Get_All_Rooms_True()
        {
            // arrange 
            var RoomService = new Mock<IRoomService>().Object;

            // act
            IList<Room> response = RoomService.GetAllRooms();

            // assert
            Assert.Equal(null, response);
        }
    }
}
