using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace XReactor.XSockets
{
    public enum XCommunicateEnum : byte
    {
        Header = 254,
        LoginRequest = 2,
        LoginRequestResponse = 3,
        UserInfoRequest = 4,
        UserInfoRequestResponse = 5,
        GamePermRequest = 6,
        GamePermRequestResponse = 7,
    }
}
