using System;

namespace CORE.Users.Interfaces
{
    public interface ILogin: IDisposable
    {
        Models.LoginModel Login(Models.LoginMinModel user);
    }
}