// <auto-generated/>
namespace FFXIVClientStructs.FFXIV.Component.Excel.Sheets;

[StructLayout(LayoutKind.Explicit, Size = 0x10)]
public unsafe partial struct DirectorType {
    [FieldOffset(0x00)] public int Unknown0_Offset;
    [FieldOffset(0x04)] public uint Unknown1;
    [FieldOffset(0x08)] public uint Unknown2;
    [FieldOffset(0x0C)] public BitField0CFlags BitField0C;
    public bool Unknown3 => BitField0C.HasFlag(BitField0CFlags.Unknown3);
    public bool Unknown4 => BitField0C.HasFlag(BitField0CFlags.Unknown4);
    public bool Unknown5 => BitField0C.HasFlag(BitField0CFlags.Unknown5);

    [Flags]
    public enum BitField0CFlags : byte {
    	Unknown3 = 1 << 0,
    	Unknown4 = 1 << 1,
    	Unknown5 = 1 << 2,
    }
}