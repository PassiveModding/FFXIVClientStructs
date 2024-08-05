﻿using FFXIVClientStructs.FFXIV.Client.Graphics.Render;
using FFXIVClientStructs.FFXIV.Common.Math;
using FFXIVClientStructs.Havok.Common.Base.Math.QsTransform;

namespace FFXIVClientStructs.FFXIV.Client.Graphics.Scene;

[StructLayout(LayoutKind.Explicit, Size = 0x78)]
public unsafe partial struct Attach {
    //[FieldOffset(0x00)] public PostBoneDeformerBase Base;
    //[FieldOffset(0x38)] public Attach* LinkedListPrevious;
    //[FieldOffset(0x40)] public Attach* LinkedListNext;
    
    [FieldOffset(0x50)] public int ExecuteType;
    [FieldOffset(0x54)] public int UnkValue;

    // type 0: - root object
    // - mount
    // - unmounted player
    // type 1: - ?
    // type 2: - ?
    // type 3:
    // - ornament
    // - mounted player
    // type 4:
    // - weapon
    // type 5: - 
    
    [FieldOffset(0x58)] public Skeleton* TargetSkeleton; // ExecuteType 3/4
    [FieldOffset(0x60)] public Skeleton* OwnerSkeleton; // ExecuteType 4
    [FieldOffset(0x60)] public CharacterBase* OwnerCharacter; // ExecuteType 3
    [FieldOffset(0x68)] public int AttachmentCount;
    
    [FieldOffset(0x70)] public Attachment* SkeletonBoneAttachments;
    
    public Span<Pointer<Attachment>> SkeletonBoneAttachmentSpan => new(SkeletonBoneAttachments, AttachmentCount);


    [StructLayout(LayoutKind.Explicit, Size = 0x58)]
    public struct Attachment {
        [FieldOffset(0x02)] public Skeleton.BoneIndexMask BoneIndexMask;
        [FieldOffset(0x10)] public hkQsTransformf ChildTransform;
    }
}
