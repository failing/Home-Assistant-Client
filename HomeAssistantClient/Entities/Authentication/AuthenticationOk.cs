﻿namespace HomeAssistantClient.Messages

{
    public class AuthenticationOk : HassMessage
    {
        internal override dynamic Type => HassReturnType.AuthOk;
    }
}
