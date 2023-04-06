using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MongoDB_WebAPI.Model;
using MongoDB_WebAPI.Service;
using MongoDB_WebAPI.Settings;
using System.Collections.Generic;

namespace MongoDB_WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        UserService _userService;

        public UserController(IDbSettings settings)
        {
            _userService = new UserService(settings);
        }

        [HttpGet]
        public ActionResult<List<User>> GetAll()
        {
            return _userService.GetAll();
        }

        //Tek bir kullanıcıyı getirme
        [HttpGet("{id}")]
        public ActionResult<User> GetById(string id)
        {
            return _userService.GetSingle(id);
        }

        [HttpPost]
        public ActionResult<User> Add(User user)
        {
            return _userService.Add(user);
        }

        [HttpPut]
        public ActionResult Update(User currentUser)
        {
            var user = _userService.GetSingle(currentUser.Id);
            if (user == null)
                return NotFound();

            _userService.Update(currentUser);
            return Ok();
        }

        //Kullanıcıyı silme
        [HttpDelete("{id}")]
        public ActionResult Delete(string id)
        {
            var user = _userService.GetSingle(id);

            if (user == null)
                return NotFound();

            _userService.Delete(id);
            return Ok();
        }
    }
}

