using FFXIVClientStructs.Havok.Common.Base.Container.Array;
using FFXIVClientStructs.Havok.Common.Base.Math.QsTransform;
using FFXIVClientStructs.Havok.Common.Base.Types.Geometry;

namespace FFXIVClientStructs.Havok.Animation.Rig;

[GenerateInterop]
[StructLayout(LayoutKind.Explicit, Size = 0x50)]
public unsafe partial struct hkaPose {
    public enum PoseSpace {
        ModelSpace = 0,
        LocalSpace = 1,
    }

    public enum PropagateOrNot {
        DontPropagate = 0,
        Propagate = 1,
    }

    public enum BoneFlag {
        BoneLocalDirty = 0,
        BoneModelDirty = 1,
    }

    [FieldOffset(0x00)] public hkaSkeleton* Skeleton;
    [FieldOffset(0x08)] public hkArray<hkQsTransformf> LocalPose;
    [FieldOffset(0x18)] public hkArray<hkQsTransformf> ModelPose;
    [FieldOffset(0x28)] public hkArray<uint> BoneFlags;
    [FieldOffset(0x38)] public byte ModelInSync;
    [FieldOffset(0x39)] public byte LocalInSync;
    [FieldOffset(0x40)] public hkArray<float> FloatSlotValues;

    [MemberFunction("40 53 48 83 EC 20 4C 89 01")]
    public partial void Ctor1(PoseSpace space, hkaSkeleton* skeleton, hkArray<hkQsTransformf>* pose);

    [MemberFunction("40 53 48 83 EC 30 4C 89 01")]
    public partial void Ctor2(PoseSpace space, hkaSkeleton* skeleton, hkQsTransformf* pose, int numBones);

    // [MemberFunction("")]
    // public partial hkaSkeleton* GetSkeleton();

    [MemberFunction("E8 ?? ?? ?? ?? 45 33 C0 4C 8B D0")]
    public partial hkArray<hkQsTransformf>* GetSyncedPoseLocalSpace();

    [MemberFunction("E8 ?? ?? ?? ?? 4B 8D 1C 7F")]
    public partial hkArray<hkQsTransformf>* GetSyncedPoseModelSpace();

    // [MemberFunction("")]
    // public partial hkArray<float>* GetFloatSlotValues_const();

    [MemberFunction("48 8B 01 4C 8B C1 4C 63 48 30 48 8B 02 48 8B 51 08")]
    public partial void SetPoseLocalSpace(hkArray<hkQsTransformf>* poseLocal);

    [MemberFunction("E8 ?? ?? ?? ?? 48 8B 06 48 8D 5E 40")]
    public partial void SetPoseModelSpace(hkArray<hkQsTransformf>* poseModel);

    // [MemberFunction("")]
    // public partial void SetFloatSlotValues(hkArray<float>* floatSlotValues);

    // [MemberFunction("")]
    // public partial hkQsTransformf* GetBoneLocalSpace(int boneIdx);

    // [MemberFunction("")]
    // public partial hkQsTransformf* GetBoneModelSpace(int boneIdx);

    // [MemberFunction("")]
    // public partial float GetFloatSlotValue(int floatSlotIdx);

    // [MemberFunction("")]
    // public partial void SetBoneLocalSpace(int boneIdx, hkQsTransformf* boneLocal);

    // [MemberFunction("")]
    // public partial void SetBoneModelSpace(int boneIdx, hkQsTransformf* boneModel, PropagateOrNot propagateOrNot);

    // [MemberFunction("")]
    // public partial void SetFloatSlotValue(int floatSlotIdx, float value);

    [MemberFunction("E8 ?? ?? ?? ?? 48 8B CF 48 83 C4 58")]
    public partial void SyncLocalSpace();

    [MemberFunction("48 83 EC 18 80 79 38 00")]
    public partial void SyncModelSpace();

    [MemberFunction("E8 ?? ?? ?? ?? 8B 4C 3B 04")]
    public partial hkQsTransformf* AccessBoneLocalSpace(int boneIdx);

    [MemberFunction("E8 ?? ?? ?? ?? 0F 10 47 10")]
    public partial hkQsTransformf* AccessBoneModelSpace(int boneIdx, PropagateOrNot propagateOrNot);

    [MemberFunction("E8 ?? ?? ?? ?? 8B 57 08 4C 8B E0")]
    public partial hkArray<hkQsTransformf>* AccessSyncedPoseLocalSpace();

    [MemberFunction("E8 ?? ?? ?? ?? 49 8B 8D ?? ?? ?? ?? 8B 58 08")]
    public partial hkArray<hkQsTransformf>* AccessSyncedPoseModelSpace();

    [MemberFunction("E8 ?? ?? ?? ?? 41 0F 2F F6")]
    public partial hkArray<hkQsTransformf>* AccessUnsyncedPoseLocalSpace();

    // [MemberFunction("")]
    // public partial hkArray<float>* GetFloatSlotValues();

    [MemberFunction("48 8B 01 4C 8B C9 4C 8B 41 08")]
    public partial void SetToReferencePose();

    [MemberFunction("48 89 5C 24 ?? 57 48 83 EC 20 48 8B 01 48 8B D9 48 63 78 30")]
    public partial void EnforceSkeletonConstraintsLocalSpace();

    [MemberFunction("40 53 48 83 EC 30 48 8B 01 48 8B D9 48 89 74 24")]
    public partial void EnforceSkeletonConstraintsModelSpace();

    [MemberFunction("48 89 5C 24 ?? 48 89 74 24 ?? 57 48 83 EC 20 0F 28 05")]
    public partial void GetModelSpaceAabb(hkAabb* aabbOut);

    [MemberFunction("48 89 5C 24 ?? 48 89 6C 24 ?? 56 57 41 56 48 83 EC 30 48 8B 01 49 8B E9")]
    public partial void Init(PoseSpace space, hkaSkeleton* skeleton, hkArray<hkQsTransformf>* pose);

    [MemberFunction("E8 ?? ?? ?? ?? 0F 28 2F")]
    public partial hkQsTransformf* CalculateBoneModelSpace(int boneIdx);

    [MemberFunction("48 89 5C 24 ?? 48 8B 01 45 33 C0")]
    public partial byte CheckPoseValidity();

    [MemberFunction("48 89 5C 24 ?? 48 89 6C 24 ?? 48 89 74 24 ?? 48 89 7C 24 ?? 41 56 48 83 EC 30 48 8B 01 33 FF 0F 29 74 24 ??")]
    public partial byte CheckPoseTransformsValidity();
}
