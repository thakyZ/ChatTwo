﻿using System.Numerics;

namespace ChatTwo.Util;

internal static class IconUtil {
    internal static Vector4? GetBounds(byte id) => id switch {
        1 => new Vector4(0, 342, 40, 40),
        2 => new Vector4(40, 342, 40, 40),
        3 => new Vector4(80, 342, 40, 40),
        4 => new Vector4(120, 342, 40, 40),
        5 => new Vector4(160, 342, 40, 40),
        6 => new Vector4(0, 382, 40, 40),
        7 => new Vector4(40, 382, 40, 40),
        8 => new Vector4(80, 382, 40, 40),
        9 => new Vector4(120, 382, 40, 40),
        10 => new Vector4(160, 382, 40, 40),
        11 => new Vector4(0, 422, 40, 40),
        12 => new Vector4(40, 422, 40, 40),
        13 => new Vector4(80, 422, 40, 40),
        14 => new Vector4(120, 422, 40, 40),
        15 => new Vector4(160, 422, 40, 40),
        16 => new Vector4(120, 542, 40, 40),
        17 => new Vector4(160, 542, 40, 40),
        18 => new Vector4(0, 462, 108, 40),
        19 => new Vector4(108, 462, 108, 40),
        20 => new Vector4(120, 502, 40, 40),
        21 => new Vector4(0, 502, 56, 40),
        22 => new Vector4(56, 502, 64, 40),
        23 => new Vector4(160, 502, 40, 40),
        24 => new Vector4(0, 542, 56, 40),
        25 => new Vector4(56, 542, 64, 40),
        51 => new Vector4(248, 342, 40, 40),
        52 => new Vector4(288, 342, 40, 40),
        53 => new Vector4(328, 342, 40, 40),
        54 => new Vector4(200, 342, 24, 40),
        55 => new Vector4(224, 342, 24, 40),
        56 => new Vector4(200, 382, 40, 40),
        57 => new Vector4(240, 382, 40, 40),
        58 => new Vector4(280, 382, 40, 40),
        59 => new Vector4(200, 422, 40, 40),
        60 => new Vector4(240, 422, 40, 40),
        61 => new Vector4(280, 422, 40, 40),
        62 => new Vector4(320, 382, 40, 40),
        63 => new Vector4(320, 422, 40, 40),
        64 => new Vector4(368, 342, 40, 40),
        65 => new Vector4(408, 342, 40, 40),
        66 => new Vector4(448, 342, 40, 40),
        67 => new Vector4(360, 382, 40, 40),
        68 => new Vector4(400, 382, 40, 40),
        70 => new Vector4(360, 422, 40, 40),
        71 => new Vector4(400, 422, 40, 40),
        72 => new Vector4(440, 422, 40, 40),
        73 => new Vector4(440, 382, 40, 40),
        74 => new Vector4(216, 462, 40, 40),
        75 => new Vector4(256, 462, 40, 40),
        76 => new Vector4(296, 462, 40, 40),
        77 => new Vector4(336, 462, 40, 40),
        78 => new Vector4(376, 462, 40, 40),
        79 => new Vector4(416, 462, 40, 40),
        80 => new Vector4(456, 462, 40, 40),
        81 => new Vector4(200, 502, 40, 40),
        82 => new Vector4(240, 502, 40, 40),
        83 => new Vector4(280, 502, 40, 40),
        84 => new Vector4(320, 502, 40, 40),
        85 => new Vector4(360, 502, 40, 40),
        86 => new Vector4(400, 502, 40, 40),
        87 => new Vector4(440, 502, 40, 40),
        88 => new Vector4(200, 542, 40, 40),
        89 => new Vector4(240, 542, 40, 40),
        90 => new Vector4(280, 542, 40, 40),
        91 => new Vector4(320, 542, 40, 40),
        92 => new Vector4(360, 542, 40, 40),
        93 => new Vector4(400, 542, 40, 40),
        94 => new Vector4(440, 542, 40, 40),
        95 => new Vector4(0, 582, 40, 40),
        96 => new Vector4(40, 582, 40, 40),
        97 => new Vector4(80, 582, 40, 40),
        98 => new Vector4(120, 582, 40, 40),
        99 => new Vector4(160, 582, 40, 40),
        100 => new Vector4(200, 582, 40, 40),
        101 => new Vector4(240, 582, 40, 40),
        102 => new Vector4(280, 582, 40, 40),
        103 => new Vector4(320, 582, 40, 40),
        104 => new Vector4(360, 582, 40, 40),
        105 => new Vector4(400, 582, 40, 40),
        106 => new Vector4(440, 582, 40, 40),
        107 => new Vector4(0, 622, 40, 40),
        108 => new Vector4(40, 622, 40, 40),
        109 => new Vector4(80, 622, 40, 40),
        110 => new Vector4(120, 622, 40, 40),
        111 => new Vector4(160, 622, 40, 40),
        112 => new Vector4(200, 622, 40, 40),
        _ => null,
    };
}