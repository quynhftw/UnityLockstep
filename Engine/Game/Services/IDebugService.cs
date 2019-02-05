﻿using Lockstep.Core.Services;

namespace Lockstep.Game.Services
{
    public interface IDebugService : IService
    {
        void Register(uint tick, long hash);
        long GetHash(uint tick);
        bool HasHash(uint tick);
    }
}
