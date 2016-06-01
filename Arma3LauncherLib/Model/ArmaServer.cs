﻿using System;
using System.Net;
using System.Net.NetworkInformation;
using System.Threading;
using System.Threading.Tasks;
using DerAtrox.Arma3LauncherLib.SSQLib.Model;
using DerAtrox.Arma3LauncherLib.SSQLib.Utilities;

namespace DerAtrox.Arma3LauncherLib.Model {
    /// <summary>
    /// Provides a collection of methods to use with a Arma server.
    /// </summary>
    public class ArmaServer : IArmaServer {
        private IPEndPoint _ipEndPoint;

        /// <summary>
        /// Initialzes a new Arma server using an <see cref="IPEndPoint">IPEndPoint.</see>
        /// </summary>
        /// <param name="ipEndPoint">IPEndPoint of Arma server with steamport (usually gameport + 1).</param>
        public ArmaServer(IPEndPoint ipEndPoint) {
            _ipEndPoint = ipEndPoint;
        }

        /// <summary>
        /// Initialzes a new Arma server using an <see cref="IPEndPoint">IPEndPoint.</see>
        /// </summary>
        /// <param name="ip">IP or hostname of Arma server.</param>
        /// <param name="port">Steamport of Arma server (usually gameport + 1).</param>
        public ArmaServer(string ip, int port) {
            IPEndPoint ipEndPoint = EndPointUtils.GetIpEndPointFromHostName(ip, port, true);

            _ipEndPoint = ipEndPoint;
        }

        public ServerInfo GetServerInfo() {
            throw new NotImplementedException();
        }

        public async Task<ServerInfo> GetServerInfoAsync() {
            return await Task.Run(() => GetServerInfo());
        }

        public PlayerInfo[] GetPlayerList() {
            throw new NotImplementedException();
        }

        public async Task<PlayerInfo[]> GetPlayerListAsync() {
            return await Task.Run(() => GetPlayerList());
        }

        public int PingServer() {
            throw new NotImplementedException();
        }

        public async Task<int> PingServerAsync() {
            return await Task.Run(() => PingServer());
        }

        public void Connect() {
            throw new NotImplementedException();
        }
    }
}