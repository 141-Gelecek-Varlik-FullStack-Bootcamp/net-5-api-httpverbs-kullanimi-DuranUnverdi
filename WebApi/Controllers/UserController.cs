using EntityLayer;
using FluentValidation.Results;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApi.Validation;

namespace WebApi.Controllers
{

    //[Route("api/[controller]")]
    //[ApiController]

    public class UserController : Controller
    {
        private static List<User> userList = new List<User>() {
            new User{
                UserId = 1,
                UserPassword = "124567",
                UserName = "Deniz Aka"
            },
            new User{
                UserId = 2,
                UserPassword = "124567",
                UserName = "Cihan Acay"
            },
            new User{
                UserId = 3,
                UserPassword = "124544",
                UserName = "Yasin Uysal"
            },
            new User{
                UserId = 4,
                UserPassword = "124344",
                UserName = "Yunus Emre"
            },
            new User{
                UserId = 5,
                UserPassword = "124333",
                UserName = "Serdar Ali"
            },
            new User{
                UserId = 6,
                UserPassword = "124233",
                UserName = "Mehmet Bicer"
            },
            new User{
                UserId = 7,
                UserPassword = "144524",
                UserName = "Gökhan Gülhan"
            }
        };
        [Route("/user/userlist")]
        [HttpGet]
        public List<User> Get()
        {
            return userList;
        }
        [Route("/user/userlist/{id}")]
        [HttpGet("{id}")]
        public User GetById(int id)
        {
            var user = userList.FirstOrDefault(user => user.UserId == id);
            return user;
        }

        [Route("/user/useradd")]
        [HttpPost]
        public List<User> Post([FromBody] User user)
        {
            UserValidation userValidate = new UserValidation();
            ValidationResult results = userValidate.Validate(user);
            if (results.IsValid)
            {
                userList.Add(user);

            }
            return userList;
        }
        [Route("/user/userupdate")]
        [HttpPut]
        public User Put([FromBody] User user)
        {
            var updateUser = userList.FirstOrDefault(x => x.UserId == user.UserId);
            updateUser.UserName = user.UserName;
            updateUser.UserPassword = user.UserPassword;
            return user;
        }
        [Route("/user/userdelete/{id}")]
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            var deleteUser = userList.FirstOrDefault(x => x.UserId == id);
            userList.Remove(deleteUser);
        }
    }


}

