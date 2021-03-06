﻿namespace BeatTogether.MasterServer.Kernel.Configuration
{
    public class MasterServerConfiguration
    {
        public string EndPoint { get; set; } = "127.0.0.1:2328";
        public string PrivateKeyPath { get; set; } = "key.pem";
        public string CertificatePath { get; set; } = "cert.pem";
    }
}
