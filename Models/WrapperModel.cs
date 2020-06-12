using System;
using System.ComponentModel.DataAnnotations;

namespace LoginAndRegistration.Models
{
    public class WrapperModel
    {
        public User NewUser {get;set;}
        public LoginUser LoginUser {get;set;}
    }
}