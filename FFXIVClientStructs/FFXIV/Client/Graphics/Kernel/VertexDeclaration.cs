namespace FFXIVClientStructs.FFXIV.Client.Graphics.Kernel;

// Inheritance:
// - (Some other base class; VertexDeclaration doesn't actually contain extra fields compared to this class)
//   - Client::Graphics::DelayedReleaseClassBase
//     - Client::Graphics::ReferencedClassBase

[StructLayout(LayoutKind.Explicit, Size = 0x48)]
public unsafe partial struct VertexDeclaration {
    [FieldOffset(0x00)] public void* vtbl;

    [FieldOffset(0x18)] public uint Unk18;

    [FieldOffset(0x20)] public VertexElement* Elements;
    [FieldOffset(0x28)] public uint ElementCount;
    public readonly Span<VertexElement> ElementsSpan => new(Elements, (int)ElementCount);

    [FieldOffset(0x2C)] public uint StreamCountMinus1;
    [FieldOffset(0x30)] public uint UsedStreamMask;
    [FieldOffset(0x34)] public uint UsedUsageMask;

    [FieldOffset(0x38)] public nint UnkMapSet;
}
