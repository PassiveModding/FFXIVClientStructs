using FFXIVClientStructs.FFXIV.Client.Graphics.Kernel;
using FFXIVClientStructs.FFXIV.Client.System.Resource.Handle;
using FFXIVClientStructs.FFXIV.Common.Math;

namespace FFXIVClientStructs.FFXIV.Client.Graphics.Scene;

[StructLayout(LayoutKind.Explicit, Size = 0x410)]
public unsafe partial struct CharacterUtility {
    [StaticAddress("48 8B 05 ?? ?? ?? ?? 83 B9", 3, true)]
    public static partial CharacterUtility* Instance();

    public const int ResourceHandleCount = 87;

    [FieldOffset(0x0)] public void* vtbl;

    [FieldOffset(0x08)] public ResourceHandle* EquipmentParameter;
    [FieldOffset(0x10)] public ResourceHandle* EquipmentVfxParameter;
    [FieldOffset(0x18)] public ResourceHandle* GimmickParameter;
    [FixedSizeArray<Pointer<ResourceHandle>>(28)]
    [FieldOffset(0x20)] public fixed byte EquipmentDeformerParameters[28 * 8];
    [FixedSizeArray<Pointer<ResourceHandle>>(28)]
    [FieldOffset(0x100)] public fixed byte AccessoryDeformerParameters[28 * 8];
    [FieldOffset(0x1E0)] public ResourceHandle* AttachOffsetExist;
    [FieldOffset(0x1E8)] public ResourceHandle* WeaponTypeAttach;
    [FieldOffset(0x1F0)] public ResourceHandle* WeaponTypeMotion;
    [FieldOffset(0x1F8)] public ResourceHandle* WeaponTypeSe;
    [FieldOffset(0x200)] public ResourceHandle* BoneDeformerHuman;
    [FieldOffset(0x208)] public ResourceHandle* CharaMakeHuman;
    [FieldOffset(0x210)] public ResourceHandle* FaceSkeletonTemplate;
    [FieldOffset(0x218)] public ResourceHandle* HairSkeletonTemplate;
    [FieldOffset(0x220)] public ResourceHandle* ExtraMet;
    [FieldOffset(0x228)] public ResourceHandle* ExtraTop;
    [FieldOffset(0x230)] public ResourceHandle* DummyTex;
    [FieldOffset(0x238)] public ResourceHandle* BlackTex;
    [FieldOffset(0x240)] public ResourceHandle* WhiteTex;
    [FieldOffset(0x248)] public ResourceHandle* TransparentTex;
    [FieldOffset(0x250)] public ResourceHandle* StigmaDecal;
    [FieldOffset(0x258)] public ResourceHandle* TileDiffuse;
    [FieldOffset(0x260)] public ResourceHandle* TileNormal;
    [FieldOffset(0x268)] public ResourceHandle* SkinShpk;
    [FieldOffset(0x270)] public ResourceHandle* PapLoadTable;
    [FieldOffset(0x278)] public ResourceHandle* AnimationExchangeTable;
    [FieldOffset(0x280)] public ResourceHandle* MotionLineTable;
    [FieldOffset(0x288)] public ResourceHandle* SklMaterial;
    [FieldOffset(0x290)] public ResourceHandle* AnimWorkTableHuman;
    [FieldOffset(0x298)] public ResourceHandle* AnimWorkTableMonster;
    [FieldOffset(0x2A0)] public ResourceHandle* AnimWorkTableDemihuman;
    [FieldOffset(0x2A8)] public ResourceHandle* AnimWorkTableWeapon;
    [FieldOffset(0x2B0)] public ResourceHandle* StainingTemplate;

    [FieldOffset(0x2F8)] public ConstantBuffer* LegacyBodyDecalColorCBuffer;
    [FieldOffset(0x300)] public ConstantBuffer* FreeCompanyCrestColorCBuffer;
    [FieldOffset(0x308)] public ConstantBuffer* UnkCBuffer;
    [FixedSizeArray<Pointer<ConstantBuffer>>(16)]
    [FieldOffset(0x310)] public fixed byte UnkCBuffers[16 * 8];
    [FieldOffset(0x390)] public ConstantBuffer* UnkCBuffer2;
    [FieldOffset(0x398)] public ConstantBuffer* UnkCBuffer3;
    [FieldOffset(0x3A0)] public StdVector<Pointer<ResourceHandle>> UnkResourceHandles;
    [FieldOffset(0x3B8)] public uint g_CustomizeParameter;
    [FieldOffset(0x3BC)] public uint g_DecalColor;
    [FieldOffset(0x3C0)] public uint g_SamplerDecal;
    [FieldOffset(0x3C4)] public uint g_SamplerTileDiffuse;
    [FieldOffset(0x3C8)] public uint g_SamplerTileNormal;
    [FieldOffset(0x3CC)] public uint g_SamplerOcclusion;
    [FieldOffset(0x3D0)] public uint g_SamplerTable;
    [FieldOffset(0x3D4)] public uint g_InstanceParameter;
    [FieldOffset(0x3D8)] public uint g_ModelParameter;
    [FieldOffset(0x3DC)] public uint g_MaterialParameterDynamic;
    [FieldOffset(0x3E0)] public uint g_SceneParameter;

    public readonly ConstantBufferPointer<Vector4> LegacyBodyDecalColorTypedCBuffer => new(LegacyBodyDecalColorCBuffer);
    public readonly ConstantBufferPointer<Vector4> FreeCompanyCrestColorTypedCBuffer => new(FreeCompanyCrestColorCBuffer);
}
