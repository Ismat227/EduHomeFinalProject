using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BackendProject.Helpers
{
    public class CustomErrorLanguage:IdentityErrorDescriber
    {
        public override IdentityError PasswordRequiresDigit()
        {
            return new IdentityError
            {
                Code = nameof(PasswordRequiresDigit),
                Description="Parolda reqem olmalidi"
            };
        }
        public override IdentityError PasswordTooShort(int length)
        {
            return new IdentityError
            {
                Code=nameof(PasswordTooShort),
                Description= $"Parolun uzunlugu {length}-bu qeder olmalidi"
            };
        }
        public override IdentityError PasswordRequiresLower()
        {
            return new IdentityError
            {
                Code = nameof(PasswordRequiresLower),
                Description = "Parolda kiçik hərflər də daxil elə"
            };
        }
        public override IdentityError PasswordRequiresUpper()
        {
            return new IdentityError
            {
                Code=nameof(PasswordRequiresUpper),
                Description= "Parola böyük hərflər də daxil elə"
            };
        }
        public override IdentityError PasswordRequiresNonAlphanumeric()
        {
            return new IdentityError
            {
                Code=nameof(PasswordRequiresNonAlphanumeric),
                Description= "Parola simvol daxil et"
            };
        }
        public override IdentityError DuplicateEmail(string email)
        {
            return new IdentityError
            {
                Code=nameof(DuplicateEmail),
                Description="Bu email istiade olunub"
            };
        }
    }
}
