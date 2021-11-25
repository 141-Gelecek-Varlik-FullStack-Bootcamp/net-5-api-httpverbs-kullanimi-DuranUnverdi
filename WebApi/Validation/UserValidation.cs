using EntityLayer;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApi.Validation
{
    public class UserValidation : AbstractValidator<User>
    {
        public UserValidation()
        {
            RuleFor(x => x.UserName).NotEmpty().WithMessage("Kullanıcı Adı  Boş Bırakmayınız...");
            RuleFor(x => x.UserPassword).NotEmpty().WithMessage("Şifre Alanını Boş Bırakmayınız...");
            RuleFor(x => x.UserPassword).MinimumLength(5).WithMessage("Lütfen 5 karakterden fazla veri girişi yapınız");
            RuleFor(x => x.UserPassword).MaximumLength(8).WithMessage("Lütfen 8 karakterden fazla veri girişi yapınız");
            RuleFor(x => x.UserName).MaximumLength(60).WithMessage("Lütfen 60 karakterden az veri girişi yapınız");
            RuleFor(x => x.UserName).MinimumLength(10).WithMessage("Lütfen 10 karakterden fazla veri girişi yapınız");
        }
    }
}
