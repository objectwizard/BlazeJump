﻿using BlazeJump.Common.Models;
using BlazeJump.Common.Models.SubtleCrypto;

namespace BlazeJump.Common.Services.Crypto
{
    public interface ICryptoService
    {
		string ECDHPublicKey { get; set; }
        string ECDHPrivateKey { get; set; }
        Task<Secp256k1KeyPair> GenerateKeyPair();
        Task<NEvent> SignEvent(NEvent nEvent);
        Tuple<string, byte[]> AesEncrypt(string plainText, string theirPublicKey, string myPrivateKey);
		string AesDecrypt(string base64CipherText, string theirPublicKey, string myPrivateKey, byte[] iv);
	}
}