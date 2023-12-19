namespace FFXIVClientStructs.FFXIV.Client.Graphics.Kernel;

[StructLayout(LayoutKind.Sequential, Size = 4)]
// Type and Usage are neither VertexType/VertexUsage in .mdl files nor DXGI_FORMAT in DX11
public unsafe partial struct VertexElement {
    public byte Stream;
    public byte Offset;
    public byte Type;
    public byte Usage;
}
