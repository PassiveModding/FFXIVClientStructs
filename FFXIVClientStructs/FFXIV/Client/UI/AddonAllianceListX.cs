using FFXIVClientStructs.FFXIV.Component.GUI;

namespace FFXIVClientStructs.FFXIV.Client.UI;

// Client::UI::AddonAllianceListX
//   Component::GUI::AtkUnitBase
//     Component::GUI::AtkEventListener
[Addon("_AllianceList1", "_AllianceList2")]
[GenerateInterop]
[Inherits<AtkUnitBase>]
[StructLayout(LayoutKind.Explicit, Size = 0x470)]
public unsafe partial struct AddonAllianceListX {
    [FieldOffset(0x230)] public AtkTextNode* HeaderText;
    [FieldOffset(0x238), FixedSizeArray] internal FixedSizeArray8<AllianceMemberStruct> _allianceMembers;
    [FieldOffset(0x438), FixedSizeArray] internal FixedSizeArray8<ushort> _uIFlags;
    [FieldOffset(0x448), FixedSizeArray] internal FixedSizeArray8<uint> _allianceClassJobIconIds;
    [FieldOffset(0x468)] public sbyte HoveredSlot;
    [FieldOffset(0x469)] public sbyte TargetedSlot;
    [FieldOffset(0x46A)] public byte Slots;
    [FieldOffset(0x46B)] public byte SlotsFilled;


    [StructLayout(LayoutKind.Explicit, Size = 0x40)]
    public unsafe partial struct AllianceMemberStruct {
        [FieldOffset(0x00)] public AtkComponentBase* ComponentBase;
        [FieldOffset(0x08)] public AtkResNode* DebuffContainer;
        [FieldOffset(0x10)] public AtkImageNode* ClassJobImageNode;
        [FieldOffset(0x20)] public AtkComponentGaugeBar* HealthBar;
        [FieldOffset(0x28)] public AtkResNode* AggroContainer;
        [FieldOffset(0x30)] public AtkResNode* TargetGlowContainer;
        [FieldOffset(0x38)] public AtkCollisionNode* AtkCollisionNode;
    }
}
