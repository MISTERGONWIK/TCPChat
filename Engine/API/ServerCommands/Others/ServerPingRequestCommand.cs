﻿using Engine.API.ClientCommands;
using Engine.Model.Server;
using System.Security;

namespace Engine.API.ServerCommands
{
  [SecurityCritical]
  class ServerPingRequestCommand : ServerCommand
  {
    public const long CommandId = (long)ServerCommandId.PingRequest;

    public override long Id
    {
      [SecuritySafeCritical]
      get { return CommandId; }
    }

    [SecuritySafeCritical]
    protected override void OnRun(ServerCommandArgs args)
    {
      ServerModel.Server.SendMessage(args.ConnectionId, ClientPingResponceCommand.CommandId, true);
    }
  }
}
