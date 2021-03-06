//------------------------------------------------------------------------------
// <auto-generated>
//   GenStringMap 1.0
// </auto-generated>
//------------------------------------------------------------------------------

namespace BPerfCPUSamplesCollector
{
    using System;
    using System.Runtime.CompilerServices;

    public static class Strings
    {
        public enum Key : long
        {
            BPFCreatePerCPUArrayError = 257698037760,
            BPFCreatePerfEventArrayMapError = 283467841597,
            BPFCreateStackTraceMapError = 266287972480,
            BPFMapFixupFailed = 85899346111,
            BPFProgLoadFailed = 115964117204,
            BPFUpdateElemFailed = 163208757488,
            EPollControlFailed = 163208757527,
            EPollCreateFailed = 163208757566,
            EPollWaitFailed = 77309411685,
            GPL = 12884902264,
            NewLine = 4294967676,
            PerfEventEnableFailed = 141733921150,
            SetRLimitFailed = 68719477152,
            StacksEBF = 47244640689,
            StatXError = 150323855805,
            UProbeType = 176093659617,
        }

        public static ref readonly byte BPFCreatePerCPUArrayError => ref GetCString(Key.BPFCreatePerCPUArrayError);

        public static ref readonly byte BPFCreatePerfEventArrayMapError => ref GetCString(Key.BPFCreatePerfEventArrayMapError);

        public static ref readonly byte BPFCreateStackTraceMapError => ref GetCString(Key.BPFCreateStackTraceMapError);

        public static ref readonly byte BPFMapFixupFailed => ref GetCString(Key.BPFMapFixupFailed);

        public static ref readonly byte BPFProgLoadFailed => ref GetCString(Key.BPFProgLoadFailed);

        public static ref readonly byte BPFUpdateElemFailed => ref GetCString(Key.BPFUpdateElemFailed);

        public static ref readonly byte EPollControlFailed => ref GetCString(Key.EPollControlFailed);

        public static ref readonly byte EPollCreateFailed => ref GetCString(Key.EPollCreateFailed);

        public static ref readonly byte EPollWaitFailed => ref GetCString(Key.EPollWaitFailed);

        public static ref readonly byte GPL => ref GetCString(Key.GPL);

        public static ref readonly byte NewLine => ref GetCString(Key.NewLine);

        public static ref readonly byte PerfEventEnableFailed => ref GetCString(Key.PerfEventEnableFailed);

        public static ref readonly byte SetRLimitFailed => ref GetCString(Key.SetRLimitFailed);

        public static ref readonly byte StacksEBF => ref GetCString(Key.StacksEBF);

        public static ref readonly byte StatXError => ref GetCString(Key.StatXError);

        public static ref readonly byte UProbeType => ref GetCString(Key.UProbeType);

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static ref readonly byte GetCString(Key arg)
        {
            long value = (long)arg;
            return ref GetStringMap((int)(value & uint.MaxValue));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static ref readonly byte GetCStringWithLength(Key arg, out int length)
        {
            long value = (long)arg;
            length = (int)(value >> 32);
            return ref GetStringMap((int)(value & uint.MaxValue));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        private static ref readonly byte GetStringMap(int offset)
        {
            var data = new ReadOnlySpan<byte>(new byte[] { 
                
                0x42,0x50,0x46,0x43,0x72,0x65,0x61,0x74,0x65,0x50,0x65,0x72,0x43,0x50,0x55,0x41,0x72,0x72,0x61,0x79,0x20,0x66,0x61,0x69,0x6c,0x65,0x64,0x2e,0x20,0x42,0x50,0x65,0x72,0x66,0x20,0x72,0x65,0x71,0x75,0x69,
                0x72,0x65,0x73,0x20,0x72,0x6f,0x6f,0x74,0x20,0x70,0x72,0x69,0x76,0x69,0x6c,0x65,0x67,0x65,0x73,0x2e,0x00,0x42,0x50,0x46,0x43,0x72,0x65,0x61,0x74,0x65,0x50,0x65,0x72,0x66,0x45,0x76,0x65,0x6e,0x74,0x41,
                0x72,0x72,0x61,0x79,0x4d,0x61,0x70,0x20,0x66,0x61,0x69,0x6c,0x65,0x64,0x2e,0x20,0x42,0x50,0x65,0x72,0x66,0x20,0x72,0x65,0x71,0x75,0x69,0x72,0x65,0x73,0x20,0x72,0x6f,0x6f,0x74,0x20,0x70,0x72,0x69,0x76,
                0x69,0x6c,0x65,0x67,0x65,0x73,0x2e,0x00,0x42,0x50,0x46,0x43,0x72,0x65,0x61,0x74,0x65,0x53,0x74,0x61,0x63,0x6b,0x54,0x72,0x61,0x63,0x65,0x4d,0x61,0x70,0x20,0x66,0x61,0x69,0x6c,0x65,0x64,0x2e,0x20,0x42,
                0x50,0x65,0x72,0x66,0x20,0x72,0x65,0x71,0x75,0x69,0x72,0x65,0x73,0x20,0x72,0x6f,0x6f,0x74,0x20,0x70,0x72,0x69,0x76,0x69,0x6c,0x65,0x67,0x65,0x73,0x2e,0x00,0x42,0x50,0x46,0x20,0x4d,0x61,0x70,0x20,0x46,
                0x69,0x78,0x75,0x70,0x20,0x46,0x61,0x69,0x6c,0x65,0x64,0x00,0x42,0x50,0x46,0x20,0x50,0x72,0x6f,0x67,0x72,0x61,0x6d,0x20,0x4c,0x6f,0x61,0x64,0x69,0x6e,0x67,0x20,0x66,0x61,0x69,0x6c,0x65,0x64,0x2e,0x00,
                0x42,0x50,0x46,0x55,0x70,0x64,0x61,0x74,0x65,0x45,0x6c,0x65,0x6d,0x20,0x66,0x61,0x69,0x6c,0x65,0x64,0x20,0x77,0x68,0x65,0x6e,0x20,0x75,0x70,0x64,0x61,0x74,0x69,0x6e,0x67,0x20,0x6d,0x61,0x70,0x00,0x55,
                0x6e,0x61,0x62,0x6c,0x65,0x20,0x74,0x6f,0x20,0x61,0x64,0x64,0x20,0x66,0x69,0x6c,0x65,0x20,0x64,0x65,0x73,0x63,0x72,0x69,0x70,0x74,0x6f,0x72,0x20,0x74,0x6f,0x20,0x65,0x70,0x6f,0x6c,0x6c,0x00,0x55,0x6e,
                0x61,0x62,0x6c,0x65,0x20,0x74,0x6f,0x20,0x63,0x72,0x65,0x61,0x74,0x65,0x20,0x65,0x70,0x6f,0x6c,0x6c,0x20,0x66,0x69,0x6c,0x65,0x20,0x64,0x65,0x73,0x63,0x72,0x69,0x70,0x74,0x6f,0x72,0x00,0x65,0x70,0x6f,
                0x6c,0x6c,0x5f,0x77,0x61,0x69,0x74,0x20,0x66,0x61,0x69,0x6c,0x65,0x64,0x2e,0x00,0x47,0x50,0x4c,0x00,0x0a,0x00,0x69,0x6f,0x63,0x74,0x6c,0x20,0x74,0x6f,0x20,0x65,0x6e,0x61,0x62,0x6c,0x65,0x20,0x70,0x65,
                0x72,0x66,0x20,0x65,0x76,0x65,0x6e,0x74,0x20,0x66,0x61,0x69,0x6c,0x65,0x64,0x00,0x73,0x65,0x74,0x72,0x6c,0x69,0x6d,0x69,0x74,0x20,0x66,0x61,0x69,0x6c,0x65,0x64,0x00,0x73,0x74,0x61,0x63,0x6b,0x73,0x2e,
                0x65,0x62,0x70,0x66,0x00,0x53,0x74,0x61,0x74,0x58,0x20,0x53,0x79,0x73,0x74,0x65,0x6d,0x20,0x43,0x61,0x6c,0x6c,0x20,0x72,0x65,0x74,0x75,0x72,0x6e,0x65,0x64,0x20,0x61,0x6e,0x20,0x65,0x72,0x72,0x6f,0x72,
                0x00,0x2f,0x73,0x79,0x73,0x2f,0x62,0x75,0x73,0x2f,0x65,0x76,0x65,0x6e,0x74,0x5f,0x73,0x6f,0x75,0x72,0x63,0x65,0x2f,0x64,0x65,0x76,0x69,0x63,0x65,0x73,0x2f,0x75,0x70,0x72,0x6f,0x62,0x65,0x2f,0x74,0x79,
                0x70,0x65,0x00,
            });

            return ref Unsafe.AsRef<byte>(data[offset]);
        }
    }
}
