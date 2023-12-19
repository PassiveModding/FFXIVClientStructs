namespace FFXIVClientStructs.FFXIV.Client.Graphics.Kernel;

// Inheritance:
// - Client::Graphics::DelayedReleaseClassBase
//   - Client::Graphics::ReferencedClassBase
// - Client::Graphics::Kernel::Notifier

[StructLayout(LayoutKind.Explicit, Size = 0x60)]
public unsafe partial struct VertexBuffer {
    [FieldOffset(0x00)] public void* vtbl;

    [FieldOffset(0x20)] public Notifier Notifier;

    [FieldOffset(0x40)] public nint DxPtr1; // ID3D11Buffer
    [FieldOffset(0x48)] public nint DxPtr2; // Same as DxPtr1
    [FieldOffset(0x50)] public nint DxPtr3; // Same as DxPtr1
}
