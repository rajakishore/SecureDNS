﻿using Texnomic.DNS.Abstractions.Enums;

namespace Texnomic.DNS.Abstractions
{
    public interface ILabel
    {
        LabelType Type { get; set; }
        long Offset { get; set; }
        ushort Count { get; set; }
        string Text { get; set; }
    }
}
