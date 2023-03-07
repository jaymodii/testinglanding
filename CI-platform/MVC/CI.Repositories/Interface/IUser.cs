using CI.Entity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CI.Repositories.Interface
{
    public interface IUser
    {
        User Register(User obj);
        User Index(User obj);
        User ForgotPassword(User obj);
        PasswordReset ResetPassword(User obj, string token);

    }
}
