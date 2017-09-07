using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Lesson1.Models
{
    public class GuestResponse
    {
        [Required(ErrorMessage = "Пожалуйста, введите имя")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Пожалуйста, введите почтовый адресс")]
        [RegularExpression(".+\\@.+\\..+", ErrorMessage = "Вы ввели некоррекстный почтовый адресс")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Пожалуйста, введите телефон")]
        public string Phone { get; set; }

        [Required(ErrorMessage ="Пожалуйста, укажите, приймете ли вы участие в вечеринке")]
        public bool? WillAttend { get; set; }
    }
}