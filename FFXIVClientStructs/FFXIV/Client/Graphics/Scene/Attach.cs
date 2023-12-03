using FFXIVClientStructs.FFXIV.Client.Graphics.Render;
using FFXIVClientStructs.Havok;

namespace FFXIVClientStructs.FFXIV.Client.Graphics.Scene;

[StructLayout(LayoutKind.Explicit, Size = 0x78)]
public unsafe partial struct Attach {
    [FieldOffset(0x00)] public PostBoneDeformerBase Base;
    [FieldOffset(0x50)] public int ExecuteType;
    [FieldOffset(0x54)] public int UnkValue;

    // All fields below are actually part of a union based on ExecuteType.
    // Only the fields for ExecuteType 4 are defined here, which are used by Weapon CharacterBases.
    [FieldOffset(0x58)] public Skeleton* TargetSkeleton;
    [FieldOffset(0x60)] public Skeleton* OwnerSkeleton;
    [FieldOffset(0x68)] public int AttachmentCount;
    [FieldOffset(0x70)] public Attachment* SkeletonBoneAttachments;

    [StructLayout(LayoutKind.Explicit, Size = 0x40)]
    public unsafe partial struct Attachment {
        [FieldOffset(0x02)] public ushort SkeletonIdxBoneIdx;
        [FieldOffset(0x10)] public hkQsTransformf ChildTransform;

        public readonly byte SkeletonIdx => (byte)((SkeletonIdxBoneIdx >> 12) & 0xF);
        public readonly ushort BoneIdx => (ushort)(SkeletonIdxBoneIdx & 0xFFF);
    }
}
