using ConCode.NET.Domain.Interfaces;
using ConCode.NET.Web.Controllers;
using ConCode.NET.Web.Models.SessionViewModels;
using Microsoft.AspNetCore.Mvc;
using Moq;
using Xunit;

namespace ConCode.NET.Tests.Web.Controllers.Session
{
    public class tpsDev_when_requesting_details_on_SessionController
    {
        [Fact]
        public void should_return_a_view_with_a_SessionDetailsViewModel()
        {
            var sessionService = new Mock<ISessionService>();
            var talkService = new Mock<ITalkService>();
            var venueService = new Mock<IVenueService>();
            var controller = new SessionController(sessionService.Object, talkService.Object, venueService.Object);

            var Id = 1234;
            var result = controller.Details(Id);

            Assert.NotNull(result);
            Assert.IsType<SessionDetailsViewModel>(((ViewResult)result).Model);
        }



    }
}
