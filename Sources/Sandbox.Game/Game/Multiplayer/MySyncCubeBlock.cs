﻿using ProtoBuf;
using Sandbox.Game.Entities;
using Sandbox.Game.Entities.Cube;
using Sandbox.Game.World;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sandbox.Game.Multiplayer
{
    [PreloadRequired]
    class MySyncCubeBlock : MySyncEntity
    {
        public MySyncCubeBlock(MyCubeBlock block)
            : base(block)
        {
        }

        public override void UpdatePosition()
        {
        }

        public override void SendCloseRequest()
        {
        }
    }
}
