using System;
using CRM.REST.Models;
using CRM.REST.Services;
using Microsoft.AspNetCore.Mvc;

namespace CRM.REST.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class UsersController : Controller
    {
        // GET: <controller>
        [HttpGet]
        public JsonResult GetAll()
        {
            Console.WriteLine("In GetAll");
            return Json(UserService.GetInstance().GetAll());
        }

        // POST: <controller>
        [HttpPost("Add")]
        public JsonResult Add(UserModel user)
        {
            Console.WriteLine("In Add");
            return Json(UserService.GetInstance().Add(user));
        }

        // PUT: <controller>
        [HttpPut("Update")]
        public JsonResult Update(UserModel user)
        {
            Console.WriteLine("In Update");
            return Json(UserService.GetInstance().Update(user));
        }

        // DELETE: <controller>
        [HttpDelete("Delete/{id}")]
        public JsonResult Delete(string id)
        {
            Console.WriteLine("In Delete");
            return Json(UserService.GetInstance().Delete(id));
        }
    }
}