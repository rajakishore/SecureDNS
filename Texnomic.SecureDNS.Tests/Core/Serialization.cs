﻿using System;

using Microsoft.VisualStudio.TestTools.UnitTesting;

using Texnomic.SecureDNS.Serialization;

namespace Texnomic.SecureDNS.Tests.Core
{
    [TestClass]
    public class Serialization
    {
        [TestMethod]
        public void DeserializeDNSCryptStamp()
        {
            var Stamp = DnSerializer.Deserialize("sdns://AQYAAAAAAAAADTkuOS45LjEwOjg0NDMgZ8hHuMh1jNEgJFVDvnVnRt803x2EwAuMRwNo34Idhj4ZMi5kbnNjcnlwdC1jZXJ0LnF1YWQ5Lm5ldA");
        }

        [TestMethod]
        public void DeserializeDoHStamp()
        {
            var Stamp = DnSerializer.Deserialize("sdns://AgcAAAAAAAAABzEuMC4wLjESZG5zLmNsb3VkZmxhcmUuY29tCi9kbnMtcXVlcnk");
        }

        [TestMethod]
        public void DeserializeDNSCrypt()
        {
            var ResponseBytes = new byte[]
            {
                0x69, 0x28, 0x80, 0x00, 0x00, 0x01, 0x00, 0x02, 0x00, 0x00, 0x00, 0x00, 0x01, 0x32, 0x0D, 0x64, 0x6E,
                0x73, 0x63, 0x72, 0x79, 0x70, 0x74, 0x2D, 0x63, 0x65, 0x72, 0x74, 0x05, 0x71, 0x75, 0x61, 0x64, 0x39,
                0x03, 0x6E, 0x65, 0x74, 0x00, 0x00, 0x10, 0x00, 0x01, 0xC0, 0x0C, 0x00, 0x10, 0x00, 0x01, 0x00, 0x00,
                0x0E, 0x10, 0x00, 0x7D, 0x7C, 0x44, 0x4E, 0x53, 0x43, 0x00, 0x01, 0x00, 0x00, 0x64, 0x07, 0xB7, 0x64,
                0xF6, 0x28, 0x69, 0xD8, 0x22, 0xE0, 0xCB, 0x7F, 0x29, 0xF8, 0x37, 0x89, 0xA7, 0xA6, 0xFE, 0xED, 0x7F,
                0xA5, 0x2E, 0xA4, 0xBB, 0x6C, 0xB5, 0xDB, 0x35, 0xD4, 0x86, 0x4F, 0x89, 0xAF, 0xF9, 0xC3, 0x25, 0x6A,
                0x69, 0xE2, 0xE8, 0x21, 0x76, 0x66, 0x0C, 0x7A, 0xED, 0xF0, 0x2A, 0x92, 0xD5, 0x66, 0x91, 0x81, 0x20,
                0x81, 0x54, 0x6A, 0xFE, 0x84, 0xD4, 0xE5, 0xB0, 0x02, 0xF9, 0xCC, 0x51, 0xC4, 0xD4, 0x61, 0x70, 0xDF,
                0x0D, 0x6B, 0x9A, 0x97, 0x32, 0x45, 0xCB, 0x2B, 0x8F, 0xA4, 0xE5, 0x99, 0xC7, 0x39, 0x5A, 0xE8, 0xDD,
                0xF7, 0x2C, 0x73, 0xC3, 0xDE, 0x56, 0x7C, 0xF9, 0xCC, 0x51, 0xC4, 0xD4, 0x61, 0x70, 0xDF, 0x78, 0x67,
                0x18, 
                0x1D, 0x5E, 0x52, 0x0A, 0xC6, 0x60, 0x34, 0x8F, 0xC6, 0xC0, 0x0C, 0x00, 0x10, 0x00, 0x01, 0x00, 0x00,
                0x0E, 0x10, 0x00, 0x7D, 0x7C, 0x44, 0x4E, 0x53, 0x43, 0x00, 0x02, 0x00, 0x00, 0x6C, 0xE5, 0xBB, 0x97,
                0xCB, 0xE2, 0xBC, 0x3C, 0x9A, 0x65, 0xA3, 0x16, 0x9D, 0x9E, 0xAF, 0x4E, 0x2C, 0x34, 0xF7, 0x32, 0xA2,
                0xCA, 0x5D, 0x3E, 0x97, 0x99, 0x27, 0x07, 0x5A, 0xE6, 0x80, 0x80, 0x93, 0xE8, 0xFF, 0x28, 0x8F, 0x8E,
                0x99, 0xE7, 0xD2, 0xDA, 0x48, 0xF3, 0x20, 0x72, 0x87, 0x38, 0x45, 0xAA, 0xE5, 0xCF, 0xFD, 0xA1, 0xC2,
                0xD6, 0x3C, 0x23, 0xA0, 0xA1, 0x7A, 0xEE, 0x16, 0x0F, 0x7B, 0x9D, 0x78, 0xFD, 0x52, 0xED, 0x4E, 0xA6,
                0xE2, 0xE1, 0xC3, 0xA6, 0xC9, 0x5D, 0x99, 0x4D, 0x27, 0xAA, 0x7F, 0x17, 0x14, 0x0D, 0x92, 0xBF, 0xFC,
                0x92, 0x08, 0x8C, 0xD6, 0x65, 0xBB, 0x4A, 0x7B, 0x9D, 0x78, 0xFD, 0x52, 0xED, 0x4E, 0xA6, 0x78, 0x67,
                0x18, 0x1E, 0x5E, 0x52, 0x09, 0x78, 0x60, 0x34, 0x8E, 0x78
            };

            var ResponseMessage = DnSerializer.Deserialize(in ResponseBytes);

            var Bytes = DnSerializer.Serialize(ResponseMessage);

            for (var I = 0; I < ResponseBytes.Length; I++)
            {
                Assert.AreEqual(ResponseBytes[I], Bytes[I]);
            }
        }

        [TestMethod]
        [ExpectedException(typeof(FormatException))]
        public void DeserializeMalformed()
        {
            var ResponseBytes = new byte[]
            {
                0x02, 0xBD, 0x01, 0x00, 0x00, 0x01, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x04, 0x74, 0x69, 0x6D, 0x65,
                0x05, 0x63, 0x68, 0x74, 0x74, 0x6C, 0x03, 0x63, 0x6F, 0x6D, 0x02, 0x74, 0x77
            };

            var ResponseMessage = DnSerializer.Deserialize(in ResponseBytes);
        }

        [TestMethod]
        public void DeserializeFast()
        {
            //api.fast.com A Record
            var ResponseBytes = new byte[]
            {
                0xc8, 0xe8, 0x81, 0x80, 0x00, 0x01, 0x00, 0x05,
                0x00, 0x00, 0x00, 0x00, 0x03, 0x61, 0x70, 0x69,
                0x04, 0x66, 0x61, 0x73, 0x74, 0x03, 0x63, 0x6f,
                0x6d, 0x00, 0x00, 0x01, 0x00, 0x01, 0xc0, 0x0c,
                0x00, 0x05, 0x00, 0x01, 0x00, 0x00, 0x07, 0xef,
                0x00, 0x13, 0x04, 0x66, 0x61, 0x73, 0x74, 0x03,
                0x67, 0x65, 0x6f, 0x07, 0x6e, 0x65, 0x74, 0x66,
                0x6c, 0x69, 0x78, 0xc0, 0x15, 0xc0, 0x2a, 0x00,
                0x05, 0x00, 0x01, 0x00, 0x00, 0x01, 0x57, 0x00,
                0x18, 0x04, 0x66, 0x61, 0x73, 0x74, 0x09, 0x65,
                0x75, 0x2d, 0x77, 0x65, 0x73, 0x74, 0x2d, 0x31,
                0x06, 0x70, 0x72, 0x6f, 0x64, 0x61, 0x61, 0xc0,
                0x33, 0xc0, 0x49, 0x00, 0x01, 0x00, 0x01, 0x00,
                0x00, 0x00, 0x2e, 0x00, 0x04, 0x34, 0x11, 0xb5,
                0xdc, 0xc0, 0x49, 0x00, 0x01, 0x00, 0x01, 0x00,
                0x00, 0x00, 0x2e, 0x00, 0x04, 0x34, 0x12, 0xe8,
                0xb3, 0xc0, 0x49, 0x00, 0x01, 0x00, 0x01, 0x00,
                0x00, 0x00, 0x2e, 0x00, 0x04, 0x36, 0x9a, 0xca,
                0x23
            };

            var ResponseMessage = DnSerializer.Deserialize(in ResponseBytes);
        }

        [TestMethod]
        public void SerializeFast()
        {
            //api.fast.com A Record
            var ResponseBytes = new byte[]
            {
                0xc8, 0xe8, 0x81, 0x80, 0x00, 0x01, 0x00, 0x05,
                0x00, 0x00, 0x00, 0x00, 0x03, 0x61, 0x70, 0x69,
                0x04, 0x66, 0x61, 0x73, 0x74, 0x03, 0x63, 0x6f,
                0x6d, 0x00, 0x00, 0x01, 0x00, 0x01, 0xc0, 0x0c,
                0x00, 0x05, 0x00, 0x01, 0x00, 0x00, 0x07, 0xef,
                0x00, 0x13, 0x04, 0x66, 0x61, 0x73, 0x74, 0x03,
                0x67, 0x65, 0x6f, 0x07, 0x6e, 0x65, 0x74, 0x66,
                0x6c, 0x69, 0x78, 0xc0, 0x15, 0xc0, 0x2a, 0x00,
                0x05, 0x00, 0x01, 0x00, 0x00, 0x01, 0x57, 0x00,
                0x18, 0x04, 0x66, 0x61, 0x73, 0x74, 0x09, 0x65,
                0x75, 0x2d, 0x77, 0x65, 0x73, 0x74, 0x2d, 0x31,
                0x06, 0x70, 0x72, 0x6f, 0x64, 0x61, 0x61, 0xc0,
                0x33, 0xc0, 0x49, 0x00, 0x01, 0x00, 0x01, 0x00,
                0x00, 0x00, 0x2e, 0x00, 0x04, 0x34, 0x11, 0xb5,
                0xdc, 0xc0, 0x49, 0x00, 0x01, 0x00, 0x01, 0x00,
                0x00, 0x00, 0x2e, 0x00, 0x04, 0x34, 0x12, 0xe8,
                0xb3, 0xc0, 0x49, 0x00, 0x01, 0x00, 0x01, 0x00,
                0x00, 0x00, 0x2e, 0x00, 0x04, 0x36, 0x9a, 0xca,
                0x23
            };

            var ResponseMessage = DnSerializer.Deserialize(in ResponseBytes);

            var Bytes = DnSerializer.Serialize(ResponseMessage);

            for (var I = 0; I < Bytes.Length; I++)
            {
                Assert.AreEqual(ResponseBytes[I], Bytes[I]);
            }

            var Size = DnSerializer.SizeOf(ResponseMessage);

            Assert.AreEqual(ResponseBytes.Length, Size);
        }

        [TestMethod]
        public void RequestYouTube()
        {
            //youtube.com A Record
            var RequestBytes = new byte[]
            {
                0x13, 0x1e, 0x01, 0x00, 0x00, 0x01, 0x00, 0x00,
                0x00, 0x00, 0x00, 0x00, 0x07, 0x79, 0x6f, 0x75,
                0x74, 0x75, 0x62, 0x65, 0x03, 0x63, 0x6f, 0x6d,
                0x00, 0x00, 0x01, 0x00, 0x01
            };

            var RequestMessage = DnSerializer.Deserialize(in RequestBytes);
        }

        [TestMethod]
        public void ResponseYouTube()
        {
            //www.youtube.com A Record
            var ResponseBytes = new byte[]
            {
                0x1d, 0xce, 0x81, 0x80, 0x00, 0x01, 0x00, 0x08,
                0x00, 0x00, 0x00, 0x00, 0x03, 0x77, 0x77, 0x77,
                0x07, 0x79, 0x6f, 0x75, 0x74, 0x75, 0x62, 0x65,
                0x03, 0x63, 0x6f, 0x6d, 0x00, 0x00, 0x01, 0x00,
                0x01, 0xc0, 0x0c, 0x00, 0x05, 0x00, 0x01, 0x00,
                0x00, 0x53, 0xdc, 0x00, 0x16, 0x0a, 0x79, 0x6f,
                0x75, 0x74, 0x75, 0x62, 0x65, 0x2d, 0x75, 0x69,
                0x01, 0x6c, 0x06, 0x67, 0x6f, 0x6f, 0x67, 0x6c,
                0x65, 0xc0, 0x18, 0xc0, 0x2d, 0x00, 0x01, 0x00,
                0x01, 0x00, 0x00, 0x01, 0x11, 0x00, 0x04, 0xac,
                0xd9, 0x13, 0x2e, 0xc0, 0x2d, 0x00, 0x01, 0x00,
                0x01, 0x00, 0x00, 0x01, 0x11, 0x00, 0x04, 0xac,
                0xd9, 0x13, 0x8e, 0xc0, 0x2d, 0x00, 0x01, 0x00,
                0x01, 0x00, 0x00, 0x01, 0x11, 0x00, 0x04, 0xac,
                0xd9, 0xab, 0xce, 0xc0, 0x2d, 0x00, 0x01, 0x00,
                0x01, 0x00, 0x00, 0x01, 0x11, 0x00, 0x04, 0xac,
                0xd9, 0xab, 0xee, 0xc0, 0x2d, 0x00, 0x01, 0x00,
                0x01, 0x00, 0x00, 0x01, 0x11, 0x00, 0x04, 0xd8,
                0x3a, 0xc6, 0x4e, 0xc0, 0x2d, 0x00, 0x01, 0x00,
                0x01, 0x00, 0x00, 0x01, 0x11, 0x00, 0x04, 0xac,
                0xd9, 0x12, 0x2e, 0xc0, 0x2d, 0x00, 0x01, 0x00,
                0x01, 0x00, 0x00, 0x01, 0x11, 0x00, 0x04, 0xac,
                0xd9, 0x12, 0xee
            };

            var ResponseMessage = DnSerializer.Deserialize(in ResponseBytes);
        }

        [TestMethod]
        public void SerializeYouTube()
        {
            //www.youtube.com A Record
            var ResponseBytes = new byte[]
            {
                0x1d, 0xce, 0x81, 0x80, 0x00, 0x01, 0x00, 0x08,
                0x00, 0x00, 0x00, 0x00, 0x03, 0x77, 0x77, 0x77,
                0x07, 0x79, 0x6f, 0x75, 0x74, 0x75, 0x62, 0x65,
                0x03, 0x63, 0x6f, 0x6d, 0x00, 0x00, 0x01, 0x00,
                0x01, 0xc0, 0x0c, 0x00, 0x05, 0x00, 0x01, 0x00,
                0x00, 0x53, 0xdc, 0x00, 0x16, 0x0a, 0x79, 0x6f,
                0x75, 0x74, 0x75, 0x62, 0x65, 0x2d, 0x75, 0x69,
                0x01, 0x6c, 0x06, 0x67, 0x6f, 0x6f, 0x67, 0x6c,
                0x65, 0xc0, 0x18, 0xc0, 0x2d, 0x00, 0x01, 0x00,
                0x01, 0x00, 0x00, 0x01, 0x11, 0x00, 0x04, 0xac,
                0xd9, 0x13, 0x2e, 0xc0, 0x2d, 0x00, 0x01, 0x00,
                0x01, 0x00, 0x00, 0x01, 0x11, 0x00, 0x04, 0xac,
                0xd9, 0x13, 0x8e, 0xc0, 0x2d, 0x00, 0x01, 0x00,
                0x01, 0x00, 0x00, 0x01, 0x11, 0x00, 0x04, 0xac,
                0xd9, 0xab, 0xce, 0xc0, 0x2d, 0x00, 0x01, 0x00,
                0x01, 0x00, 0x00, 0x01, 0x11, 0x00, 0x04, 0xac,
                0xd9, 0xab, 0xee, 0xc0, 0x2d, 0x00, 0x01, 0x00,
                0x01, 0x00, 0x00, 0x01, 0x11, 0x00, 0x04, 0xd8,
                0x3a, 0xc6, 0x4e, 0xc0, 0x2d, 0x00, 0x01, 0x00,
                0x01, 0x00, 0x00, 0x01, 0x11, 0x00, 0x04, 0xac,
                0xd9, 0x12, 0x2e, 0xc0, 0x2d, 0x00, 0x01, 0x00,
                0x01, 0x00, 0x00, 0x01, 0x11, 0x00, 0x04, 0xac,
                0xd9, 0x12, 0xee
            };

            var ResponseMessage = DnSerializer.Deserialize(in ResponseBytes);

            var Bytes = DnSerializer.Serialize(ResponseMessage);

            for (var I = 0; I < Bytes.Length; I++)
            {
                Assert.AreEqual(ResponseBytes[I], Bytes[I]);
            }

            var Size = DnSerializer.SizeOf(ResponseMessage);

            Assert.AreEqual(ResponseBytes.Length, Size);
        }
    }
}
