﻿using System.Net;
using BeatTogether.MasterServer.Models;

namespace BeatTogether.MasterServer.Abstractions
{
    public interface ISessionService
    {
        bool AddSession(Session session);
        bool RemoveSession(Session session);

        Session GetSession(EndPoint endpoint);
        bool TryGetSession(EndPoint endpoint, out Session session);
        Session GetSession(string userId);
        bool TryGetSession(string userId, out Session session);
    }
}
