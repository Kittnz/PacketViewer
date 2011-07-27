﻿using System;
using System.Text;
using WowTools.Core;

namespace WoWPacketViewer
{
    public enum AccountDataType : uint
    {
        GLOBAL_CONFIG_CACHE = 0,            // 0x01 g
        PER_CHARACTER_CONFIG_CACHE = 1,     // 0x02 p
        GLOBAL_BINDINGS_CACHE = 2,          // 0x04 g
        PER_CHARACTER_BINDINGS_CACHE = 3,   // 0x08 p
        GLOBAL_MACROS_CACHE = 4,            // 0x10 g
        PER_CHARACTER_MACROS_CACHE = 5,     // 0x20 p
        PER_CHARACTER_LAYOUT_CACHE = 6,     // 0x40 p
        PER_CHARACTER_CHAT_CACHE = 7,       // 0x80 p
    };

    
    public class AccountHandler : Parser
    {
        private const int NUM_ACCOUNT_DATA_TYPES = 8;

        [Parser(OpCodes.SMSG_ACCOUNT_DATA_TIMES)]
        public void AccountDataTimes(Parser packet)
        {
            packet.ReadTime("Time");
            packet.ReadByte("Unk byte (1)");
            int mask = packet.ReadInt32("Mask");
            for (int i = 0; i < NUM_ACCOUNT_DATA_TYPES; ++i)
            {
                if ((mask & (1 << i)) != 0)
                    packet.ReadTime(((AccountDataType)i).ToString());
            }
        }

        [Parser(OpCodes.CMSG_REQUEST_ACCOUNT_DATA)]
        public void AccountDataRequest(Parser packet)
        {
            packet.ReadEnum<AccountDataType>("Type");
        }

        [Parser(OpCodes.SMSG_UPDATE_ACCOUNT_DATA)]
        public void AccountUpdateData(Parser packet)
        {
            UTF8Encoding encoder = new System.Text.UTF8Encoding();

            packet.ReadUInt64("GUID: {0:X16}");
            packet.ReadEnum<AccountDataType>("Type");
            packet.ReadTime("Time");

            byte[] compressedData = Reader.ReadBytes((int)Reader.BaseStream.Length - (int)Reader.BaseStream.Position);
            byte[] data = compressedData.Decompress();
            AppendFormatLine("Data: {0}", encoder.GetString(data));
        }

        [Parser(OpCodes.CMSG_UPDATE_ACCOUNT_DATA)]
        public void AccountDataUpdate(Parser packet)
        {
            UTF8Encoding encoder = new System.Text.UTF8Encoding();

            packet.ReadEnum<AccountDataType>("Type");
            packet.ReadTime("Time");

            byte[] compressedData = Reader.ReadBytes((int)Reader.BaseStream.Length - (int)Reader.BaseStream.Position);
            byte[] data = compressedData.Decompress();
            AppendFormatLine("Data: {0}", encoder.GetString(data));
        }
    }
}
