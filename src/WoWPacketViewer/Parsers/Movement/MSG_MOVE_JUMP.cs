﻿using WowTools.Core;

namespace WoWPacketViewer.Parsers.Movement
{
    [Parser(OpCodes.MSG_MOVE_JUMP)]
    class MovementJumpParser : RegularMovementPacket
    {
            protected override MovementStatusElements[] Elements
            {
                get
                {
                    return new MovementStatusElements[] {
MovementStatusElements.GuidByte5,
MovementStatusElements.GuidByte1,
MovementStatusElements.GuidByte6,
MovementStatusElements.Flags,
MovementStatusElements.GuidByte2,
MovementStatusElements.HaveSpline,
MovementStatusElements.GuidByte3,
MovementStatusElements.Flags2,
MovementStatusElements.GuidByte4,
MovementStatusElements.GuidByte0,
MovementStatusElements.GuidByte7,
MovementStatusElements.HaveFallData,
MovementStatusElements.HaveFallDirection,
MovementStatusElements.HaveTransportData,
MovementStatusElements.TransportGuidByte6,
MovementStatusElements.TransportGuidByte3,
MovementStatusElements.TransportGuidByte7,
MovementStatusElements.TransportGuidByte4,
MovementStatusElements.TransportGuidByte1,
MovementStatusElements.TransportGuidByte0,
MovementStatusElements.TransportGuidByte2,
MovementStatusElements.TransportGuidByte5,
MovementStatusElements.TransportHaveTime3,
MovementStatusElements.TransportHaveTime2,
MovementStatusElements.HaveSplineElev,
MovementStatusElements.HavePitch,
MovementStatusElements.PositionO,
MovementStatusElements.PositionX,
MovementStatusElements.PositionY,
MovementStatusElements.PositionZ,
MovementStatusElements.Timestamp,
MovementStatusElements.GuidByte1_2,
MovementStatusElements.FallVerticalSpeed,
MovementStatusElements.FallTime,
MovementStatusElements.FallHorizontalSpeed,
MovementStatusElements.FallCosAngle,
MovementStatusElements.FallSinAngle,
MovementStatusElements.TransportTime,
MovementStatusElements.TransportPositionX,
MovementStatusElements.TransportPositionY,
MovementStatusElements.TransportPositionZ,
MovementStatusElements.TransportPositionO,
MovementStatusElements.TransportSeat,
MovementStatusElements.TransportGuidByte3_2,
MovementStatusElements.TransportGuidByte1_2,
MovementStatusElements.TransportTime3,
MovementStatusElements.TransportGuidByte6_2,
MovementStatusElements.TransportGuidByte0_2,
MovementStatusElements.TransportGuidByte5_2,
MovementStatusElements.TransportTime2,
MovementStatusElements.TransportGuidByte7_2,
MovementStatusElements.TransportGuidByte4_2,
MovementStatusElements.TransportGuidByte2_2,
MovementStatusElements.GuidByte6_2,
MovementStatusElements.GuidByte4_2,
MovementStatusElements.SplineElev,
MovementStatusElements.GuidByte0_2,
MovementStatusElements.Pitch,
MovementStatusElements.GuidByte5_2,
MovementStatusElements.GuidByte3_2,
MovementStatusElements.GuidByte7_2,
MovementStatusElements.GuidByte2_2,
                };
                }
            }
    }
}
