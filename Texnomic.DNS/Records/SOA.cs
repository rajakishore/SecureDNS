﻿using BinarySerialization;
using Texnomic.DNS.Abstractions;
using Texnomic.DNS.Models;

namespace Texnomic.DNS.Records
{
    public class SOA : IRecord
    {
        [FieldOrder(0)]
        public Domain PrimaryNameServer { get; set; }

        [FieldOrder(1)] 
        public Domain ResponsibleAuthorityMailbox { get; set; }

        [FieldOrder(2), FieldEndianness(Endianness.Big)]
        public uint SerialNumber { get; set; }

        [FieldOrder(3), FieldEndianness(Endianness.Big)]
        public uint RefreshInterval { get; set; }

        [FieldOrder(4), FieldEndianness(Endianness.Big)]
        public uint RetryInterval { get; set; }

        [FieldOrder(5), FieldEndianness(Endianness.Big)]
        public uint ExpiryLimit { get; set; }

        [FieldOrder(6), FieldEndianness(Endianness.Big)]
        public uint TTL { get; set; }
    }
}
