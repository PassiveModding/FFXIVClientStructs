namespace FFXIVClientStructs.FFXIV.Client.Graphics.Kernel;

// Inheritance:
// - Client::Graphics::DelayedReleaseClassBase
//   - Client::Graphics::ReferencedClassBase
// - Client::Graphics::Kernel::Notifier

[StructLayout(LayoutKind.Explicit, Size = 0x70)]
public unsafe partial struct IndexBuffer {
    [FieldOffset(0x00)] public void* vtbl;

    [FieldOffset(0x20)] public Notifier Notifier;
    [FieldOffset(0x38)] public uint Size; // in bytes
    [FieldOffset(0x40)] public uint Flags;

    [FieldOffset(0x48)] public nint DxPtr1; // Can be null if not mapped
    [FieldOffset(0x50)] public nint DxPtr2; // Same as DxPtr1
    [FieldOffset(0x58)] public nint DxPtr3; // Same as DxPtr1

    [FieldOffset(0x60)] public nint Data; // Contains pointer to data
    [FieldOffset(0x68)] public nint Data2; // Can contain data instead (if Flags & 0x11 != 0 && Flags & 0x40 == 0)

    public readonly Span<byte> AsSpan() {
        if (Data == 0)
            return Span<byte>.Empty;
        return new Span<byte>((void*)Data, (int)Size);
    }
}
