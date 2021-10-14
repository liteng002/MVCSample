using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCSample.Models
{
    [Serializable]
    public class RegisterModel
    {
        public string INvitedBy { get; set; }

        [Display(Name = "用户名")]
        [Required(ErrorMessage = "* 用户名不能为空")]
        public string Name { get; set; }

        [Required(ErrorMessage = "* 密码不能为空")]
        public string Password { get; set; }

        //[Required(ErrorMessage = "* 确认密码不能为空")]
        public string ComFirmPassword { get; set; }
        //public DateTime BirthDay { get; set; }
        //[Display(Name = "性别")]
        //public bool IsMale { get; set; }
        //public bool Remember { get; set; }

        //public IList<RestItem> Rests { get; set; }

        //public int? BirthMonth { get; set; }

        //public IList<SelectListItem> keywords { get; set; }

        //public Hobby OnDuty { get; set; }
    }

    //public enum Hobby
    //{
    //    [Display(Name = "篮球")]
    //    BasketBall,
    //    TableTenis,
    //    Football
    //}
    //public class KeywordModel
    //{
    //    public int Id { get; set; }
    //    public string Content { get; set; }
    //    public int UserId { get; set; }
    //}

    //public class RestItem
    //{
    //    public bool Selected { get; set; }
    //    public DayOfWeek DayOfWeek { get; set; }
    //}
}