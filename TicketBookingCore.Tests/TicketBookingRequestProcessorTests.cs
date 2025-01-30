using System.ComponentModel.DataAnnotations;

namespace TicketBookingCore.Tests
{
    public class TicketBookingRequestProcessorTests
    {
        private readonly TicketBookingRequestProcessor _processor;
        public TicketBookingRequestProcessorTests()
        {
            _processor = new TicketBookingRequestProcessor();
        }

        [Fact]
        public void ShouldReturnTicketBookingResultWithRequestValues()
        {
            //Arrange

            var request = new TicketBookingRequest
            {
                FirstName = "Emilia",
                LastName = "Almgren",
                Email = "emilia@hotmail.com"
            };

            //Act
            TicketBookingResponse response = _processor.Book(request);

            //Assert
            Assert.NotNull(response);
            Assert.Equal(request.FirstName, response.FirstName);
            Assert.Equal(request.LastName, response.LastName);
            Assert.Equal(request.Email, response.Email);
        }
        [Fact]
        public void ShouldThrowExceptionIfRequestIsNull()
        {
            //Arrange
            

            //Act
            var exception = Assert.Throws<ArgumentNullException>(() => _processor.Book(null));

            //Assert
            Assert.Equal("request", exception.ParamName);
        }
        [Fact]
        public void ShouldSaveToDataBase()
        {
            //Arrange
            var request = new TicketBookingRequest
            {
                FirstName = "Emilia",
                LastName = "Almgren",
                Email = "emilia@hotmail.com"
            };

            //Act

            var response = _processor.Book(request);

            //Assert


        }
    }
}