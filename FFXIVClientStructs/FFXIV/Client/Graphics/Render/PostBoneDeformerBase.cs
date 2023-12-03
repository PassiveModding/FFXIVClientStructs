using Task = FFXIVClientStructs.FFXIV.Client.System.Framework.Task;

namespace FFXIVClientStructs.FFXIV.Client.Graphics.Render;

[StructLayout(LayoutKind.Explicit, Size = 0x50)]
public unsafe partial struct PostBoneDeformerBase {
    [FieldOffset(0x00)] public Task Task;
}
