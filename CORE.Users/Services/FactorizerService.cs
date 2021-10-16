using System;
using CORE.Users.Configuration;
using CORE.Users.Interfaces;
using CORE.Users.Models;

namespace CORE.Users.Services
{
    public class FactorizerService
    {
        public static IUser Inicializar(EServer typeServer)
        {
            return typeServer switch
            {
                EServer.UDEFINED => throw new NullReferenceException(),
                EServer.LOCAL => new UserService(BridgeDBConnection<UserModel>.Create(ConnectionStrings.LocalServer, CORE.Connection.Models.DbEnum.Sql), ConnectionStrings.LocalServer),
                EServer.CLOUD => new UserService(BridgeDBConnection<UserModel>.Create(ConnectionStrings.CloudServer, CORE.Connection.Models.DbEnum.Sql), ConnectionStrings.CloudServer),
                _ => throw new NullReferenceException(),
            };

        }

        public static ILogin Login(EServer typeServer)
        {
            return typeServer switch
            {
                EServer.UDEFINED => throw new NullReferenceException(),
                EServer.LOCAL => new LoginService(BridgeDBConnection<LoginModel>.Create(ConnectionStrings.LocalServer, CORE.Connection.Models.DbEnum.Sql)),
                EServer.CLOUD => new LoginService(BridgeDBConnection<LoginModel>.Create(ConnectionStrings.CloudServer, CORE.Connection.Models.DbEnum.Sql)),
                _ => throw new NullReferenceException(),
            };
        }
    
    }
}