// <auto-generated/>
namespace FFXIVClientStructs.FFXIV.Component.Excel.Sheets;

[GenerateInterop]
[StructLayout(LayoutKind.Explicit, Size = 0x18)]
public unsafe partial struct CompanyCraftDraft {
    [FieldOffset(0x00)] public int Name_Offset;
    [FieldOffset(0x04)] public uint Order;
    [FieldOffset(0x08), FixedSizeArray] internal FixedSizeArray3<int> _requiredItem;
    /// <remarks>CompanyCraftDraftCategory</remarks>
    [FieldOffset(0x14)] public byte CompanyCraftDraftCategory;
    [FieldOffset(0x15), FixedSizeArray] internal FixedSizeArray3<byte> _requiredItemCount;
}