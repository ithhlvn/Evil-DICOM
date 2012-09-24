﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EvilDICOM.Core.Enums;
using EvilDICOM.Core.Interfaces;
using EvilDICOM.Core.Element;
using EvilDICOM.Core.Helpers;

namespace EvilDICOM.Core.IO.Writing
{
    public class SequenceWriter
    {
        private static byte[] _endOfSequence_LE = new byte[] { 0xFE, 0xFF, 0xDD, 0xE0, 0x00, 0x00, 0x00, 0x00 };
        private static byte[] _endOfSequence_BE = new byte[] { 0xFF, 0xFE, 0xE0, 0xDD, 0x00, 0x00, 0x00, 0x00 };

        public static void WriteLittleEndian(DICOMBinaryWriter dw, DICOMWriteSettings settings, IDICOMElement toWrite)
        {
            Sequence s = toWrite as Sequence;
            DICOMTagWriter.WriteLittleEndian(dw, toWrite.Tag);
            VRWriter.WriteVR(dw, settings, VR.Sequence);
            if (settings.DoWriteIndefiniteSequences)
            {
                WriteIndefiniteLength(settings, dw);
                SequenceItemWriter.WriteItemsLittleEndian(dw, settings, s.Items);
                WriteEndOfSequenceLittleEndian(dw);
            }
            else
            {
                byte[] itemsBytes = SequenceItemWriter.WriteItemsLittleEndian(settings, s.Items);
                LengthWriter.WriteLittleEndian(dw, VR.Sequence, settings, itemsBytes.Length);
                dw.Write(itemsBytes);
            }
        }

        private static void WriteIndefiniteLength(DICOMWriteSettings settings, DICOMBinaryWriter dw)
        {
            if (!(settings.TransferSyntax == TransferSyntax.IMPLICIT_VR_LITTLE_ENDIAN))
            {
                dw.WriteNullBytes(2);
            }
            dw.Write(new byte[] { 0xFF, 0xFF, 0xFF, 0xFF });
        }

        private static void WriteEndOfSequenceLittleEndian(DICOMBinaryWriter dw)
        {
            dw.Write(_endOfSequence_LE);
        }

        private static void WriteEndOfSequenceBigEndian(DICOMBinaryWriter dw)
        {
            dw.Write(_endOfSequence_BE);
        }


    }
}
