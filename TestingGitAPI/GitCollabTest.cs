
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
            var result = controllers.GetUsers();
           
           Assert.IsType<ActionResult<User>>(result);

        }
    }
}