
using GitCollab.Controllers;
using GitCollab.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Testing;
using Microsoft.VisualStudio.TestPlatform.TestHost;

namespace TestingGitAPI
{
    public class GitCollabTest // Fully qualify the Program class
    {
      
        [Fact]
        public async Task GetUsers_ShouldReturnUsers_WhenUserExistsUser()
        {
            var controllers = new ValuesController();
          
            var result = controllers.GetUsers(1);
            
            var okResult = Assert.IsType<OkObjectResult>(result);
            var returnedUser = Assert.IsType<User>(okResult.Value);
            Assert.Equal("kRISHNA", returnedUser.Name);

        }

        [Fact]
        public async Task GetUsers_ShouldReturnNotFound_WhenUserNotExists()
        {
            var controllers = new ValuesController();

            var result = controllers.GetUsers(3);

            var okResult = Assert.IsType<NotFoundResult>(result);
            

        }
    }
}