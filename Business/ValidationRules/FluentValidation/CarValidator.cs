using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.ValidationRules.FluentValidation
{
    public class CarValidator:AbstractValidator<Car>
        //Dogrulama kuralları yani bir nesne eklenmeden once 
        //barındırması zorunlu seyler 
    {

        public CarValidator()
        {
            RuleFor(p=>p.CarName).NotEmpty();
            RuleFor(p => p.CarName).MaximumLength(2);
            RuleFor(p=>p.DailyPrice).NotEmpty();

        }


    }
}
