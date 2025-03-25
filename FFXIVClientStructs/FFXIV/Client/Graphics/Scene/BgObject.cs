using FFXIVClientStructs.FFXIV.Client.System.Resource.Handle;

namespace FFXIVClientStructs.FFXIV.Client.Graphics.Scene;

[Inherits<DrawObject>]
[StructLayout(LayoutKind.Explicit, Size = 0xD0)]
public struct BgObject
{
    [FieldOffset(0x90)] public unsafe ModelResourceHandle* ModelResourceHandle;
    
    [FieldOffset(0x98)] public uint UnkFlags;
    

    [FieldOffset(0xBE)] public byte UnkFlags1; 
    [FieldOffset(0xC9)] public byte UnkFlags2;
}
