// <auto-generated/>
namespace FFXIVClientStructs.FFXIV.Component.Excel.Sheets;

[StructLayout(LayoutKind.Explicit, Size = 0x18)]
public unsafe partial struct ActionTimeline {
    [FieldOffset(0x00)] public int Key_Offset;
    /// <remarks>WeaponTimeline</remarks>
    [FieldOffset(0x04)] public ushort WeaponTimeline;
    [FieldOffset(0x06)] public ushort KillUpper;
    [FieldOffset(0x08)] public byte Unknown_70;
    [FieldOffset(0x09)] public byte Type;
    [FieldOffset(0x0A)] public byte Priority;
    [FieldOffset(0x0B)] public byte Stance;
    [FieldOffset(0x0C)] public byte Slot;
    [FieldOffset(0x0D)] public byte LookAtMode;
    [FieldOffset(0x0E)] public byte ActionTimelineIDMode;
    [FieldOffset(0x0F)] public byte LoadType;
    [FieldOffset(0x10)] public byte StartAttach;
    [FieldOffset(0x11)] public byte ResidentPap;
    [FieldOffset(0x12)] public byte Unknown6;
    [FieldOffset(0x13)] public byte Unknown1;
    [FieldOffset(0x14)] public BitField14Flags BitField14;
    public bool Pause => BitField14.HasFlag(BitField14Flags.Pause);
    public bool Resident => BitField14.HasFlag(BitField14Flags.Resident);
    public bool IsMotionCanceledByMoving => BitField14.HasFlag(BitField14Flags.IsMotionCanceledByMoving);
    public bool Unknown2 => BitField14.HasFlag(BitField14Flags.Unknown2);
    public bool Unknown3 => BitField14.HasFlag(BitField14Flags.Unknown3);
    public bool IsLoop => BitField14.HasFlag(BitField14Flags.IsLoop);
    public bool Unknown4 => BitField14.HasFlag(BitField14Flags.Unknown4);

    [Flags]
    public enum BitField14Flags : byte {
    	Pause = 1 << 0,
    	Resident = 1 << 1,
    	IsMotionCanceledByMoving = 1 << 2,
    	Unknown2 = 1 << 3,
    	Unknown3 = 1 << 4,
    	IsLoop = 1 << 5,
    	Unknown4 = 1 << 6,
    }
}