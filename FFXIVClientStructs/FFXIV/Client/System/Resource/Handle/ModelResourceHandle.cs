using System.Text;

namespace FFXIVClientStructs.FFXIV.Client.System.Resource.Handle;

// Client::System::Resource::Handle::ModelResourceHandle
//   Client::System::Resource::Handle::ResourceHandle
//     Client::System::Common::NonCopyable
[GenerateInterop]
[Inherits<ResourceHandle>]
[StructLayout(LayoutKind.Explicit, Size = 0x260)]
public unsafe partial struct ModelResourceHandle {
    public readonly ModelHeader* Header => (ModelHeader*)(StringTable + (((uint*)StringTable)[1] + 8));
    
    [FieldOffset(0xB0)] public uint FileVersion;
    [FieldOffset(0xB4)] public uint FileLength;
    [FieldOffset(0xB4)] public uint IndexVertexBufferSizes;
    [FieldOffset(0xC0)] public VertexDeclaration* VertexDeclarations; // MeshCount total elements
    [FieldOffset(0xC8)] public byte* StringTable;
    [FieldOffset(0xD0)] public uint RuntimeSize;
    [FieldOffset(0xD4)] public uint FileLength2;
    [FieldOffset(0xD8)] public ElementId* ElementIds;
    [FieldOffset(0xE0)] public Lod* Lods;
    public readonly ExtraLod* ExtraLods => (Header->Flags2 & 0x10) != 0 ? (ExtraLod*)(Lods + 3) : null;
    [FieldOffset(0xE8)] public Mesh* Meshes;
    [FieldOffset(0xF0)] public TerrainShadowMesh* TerrainShadowMeshes;
    [FieldOffset(0xF8)] public uint* AttributeNameOffsets;
    [FieldOffset(0x100)] public Submesh* Submeshes;
    [FieldOffset(0x108)] public TerrainShadowSubmesh* TerrainShadowSubmeshes;
    [FieldOffset(0x110)] public uint* MaterialNameOffsets;
    [FieldOffset(0x118)] public uint* BoneNameOffsets;
    [FieldOffset(0x120)] public BoneTable* BoneTables;
    [FieldOffset(0x128)] public Shape* ShapesPtr;
    [FieldOffset(0x130)] public ShapeMesh* ShapeMeshes;
    [FieldOffset(0x138)] public ShapeValue* ShapeValues;
    [FieldOffset(0x140)] public uint* SubmeshBoneMapByteSize;
    [FieldOffset(0x148)] public ushort* SubmeshBoneMap;
    [FieldOffset(0x150)] public BoundingBox* BoundingBoxes;
    [FieldOffset(0x158)] public BoundingBox* ModelBoundingBoxes;
    [FieldOffset(0x160)] public BoundingBox* WaterBoundingBoxes;
    [FieldOffset(0x168)] public BoundingBox* VerticalFogBoundingBoxes;
    [FieldOffset(0x170)] public BoundingBox* BoneBoundingBoxes;
    [FieldOffset(0x178)] public byte* Unknown4Data;

    [FieldOffset(0x180)] public VertexDeclaration** KernelVertexDeclarations;
    [FieldOffset(0x188)] public fixed byte VertexBuffers[3 * 8];
    [FieldOffset(0x1A0)] public fixed byte IndexBuffers[3 * 8];
    [FieldOffset(0x1D0)] public fixed byte IndexData[3 * 8];

    
    [FieldOffset(0x208)] public StdMap<Pointer<byte>, short> Attributes;
    [FieldOffset(0x228)] public StdMap<Pointer<byte>, short> Shapes;

    [MemberFunction("E8 ?? ?? ?? ?? 44 8B CD 48 89 44 24 ?? 41 B8 ?? ?? ?? ??")]
    public unsafe partial byte* GetMaterialFileNameBySlot(uint slot);

    public unsafe ReadOnlySpan<byte> GetMaterialFileNameBySlotAsSpan(uint slot)
        => MemoryMarshal.CreateReadOnlySpanFromNullTerminated(GetMaterialFileNameBySlot(slot));

    public string GetMaterialFileNameBySlotAsString(uint slot)
        => Encoding.UTF8.GetString(GetMaterialFileNameBySlotAsSpan(slot));
    
    [GenerateInterop]
    [StructLayout(LayoutKind.Explicit, Size = 32)]
    public partial struct ElementId {
        [FieldOffset(0)] public uint Id;
        [FieldOffset(4)] public uint ParentBoneName;
        [FieldOffset(8), FixedSizeArray] internal FixedSizeArray3<float> _translate;
        [FieldOffset(20), FixedSizeArray] internal FixedSizeArray3<float> _rotate;
    }

    [StructLayout(LayoutKind.Sequential, Size = 60)]
    public unsafe partial struct Lod {
        public ushort MeshIndex;
        public ushort MeshCount;

        public float ModelLodRange;
        public float TextureLodRange;

        public ushort WaterMeshIndex;
        public ushort WaterMeshCount;

        public ushort ShadowMeshIndex;
        public ushort ShadowMeshCount;

        public ushort TerrainShadowMeshIndex;
        public ushort TerrainShadowMeshCount;

        public ushort VerticalFogMeshIndex;
        public ushort VerticalFogMeshCount;

        public uint EdgeGeometrySize;
        public uint EdgeGeometryDataOffset;

        public uint PolygonCount;
        public uint Unknown1;

        public uint VertexBufferSize;
        public uint IndexBufferSize;

        public uint VertexDataOffset;
        public uint IndexDataOffset;
    }

    [StructLayout(LayoutKind.Sequential, Size = 40)]
    public unsafe partial struct ExtraLod {
        public ushort LightShaftMeshIndex;
        public ushort LightShaftMeshCount;

        public ushort GlassMeshIndex;
        public ushort GlassMeshCount;

        public ushort MaterialChangeMeshIndex;
        public ushort MaterialChangeMeshCount;

        public ushort CrestChangeMeshIndex;
        public ushort CrestChangeMeshCount;

        public ushort Unknown1;
        public ushort Unknown2;
        public ushort Unknown3;
        public ushort Unknown4;
        public ushort Unknown5;
        public ushort Unknown6;
        public ushort Unknown7;
        public ushort Unknown8;
        public ushort Unknown9;
        public ushort Unknown10;
        public ushort Unknown11;
        public ushort Unknown12;
    }

    [GenerateInterop]
    [StructLayout(LayoutKind.Explicit, Size = 36)]
    public partial struct Mesh {
        [FieldOffset(0)] public ushort VertexCount;
        [FieldOffset(2)] public ushort Padding;
        [FieldOffset(4)] public uint IndexCount;
        [FieldOffset(8)] public ushort MaterialIndex;
        [FieldOffset(10)] public ushort SubMeshIndex;
        [FieldOffset(12)] public ushort SubMeshCount;
        [FieldOffset(14)] public ushort BoneTableIndex;
        [FieldOffset(16)] public uint StartIndex;
        [FieldOffset(20), FixedSizeArray]
        internal FixedSizeArray3<uint> _vertexBufferOffset;
        [FieldOffset(32), FixedSizeArray]
        internal FixedSizeArray3<byte> _vertexBufferStride;
        [FieldOffset(35)]
        public byte VertexStreamCount;
    }

    [StructLayout(LayoutKind.Sequential, Size = 20)]
    public struct TerrainShadowMesh {
        public uint IndexCount;
        public uint StartIndex;
        public uint VertexBufferOffset;
        public ushort VertexCount;
        public ushort SubMeshIndex;
        public ushort SubMeshCount;
        public byte VertexBufferStride;
    }

    [StructLayout(LayoutKind.Sequential, Size = 16)]
    public struct Submesh {
        public uint IndexOffset;
        public uint IndexCount;
        public uint AttributeIndexMask;
        public ushort BoneStartIndex;
        public ushort BoneCount;
    }

    [StructLayout(LayoutKind.Sequential, Size = 12)]
    public struct TerrainShadowSubmesh {
        public uint IndexOffset;
        public uint IndexCount;
        public ushort Unknown1;
        public ushort Unknown2;
    }

    [GenerateInterop]
    [StructLayout(LayoutKind.Explicit, Size = 132)]
    public partial struct BoneTable {
        [FieldOffset(0), FixedSizeArray]
        internal FixedSizeArray64<ushort> _boneIndex;
        [FieldOffset(128)]
        public byte BoneCount;
    }

    [GenerateInterop]
    [StructLayout(LayoutKind.Explicit, Size = 16)]
    public partial struct Shape {
        [FieldOffset(0)] public uint StringOffset;
        [FieldOffset(4), FixedSizeArray]
        internal FixedSizeArray3<ushort> _shapeMeshStartIndex;
        [FieldOffset(10), FixedSizeArray]
        internal FixedSizeArray3<ushort> _shapeMeshCount;
    }

    [StructLayout(LayoutKind.Sequential, Size = 12)]
    public struct ShapeMesh {
        public uint MeshIndexOffset;
        public uint ShapeValueCount;
        public uint ShapeValueOffset;
    }

    [StructLayout(LayoutKind.Sequential, Size = 4)]
    public struct ShapeValue {
        public ushort BaseIndicesIndex;
        public ushort ReplacingVertexIndex;
    }

    [GenerateInterop, StructLayout(LayoutKind.Explicit, Size = 32)]
    public partial struct BoundingBox {
        [FieldOffset(0), FixedSizeArray]
        internal FixedSizeArray4<float> _min;
        [FieldOffset(16), FixedSizeArray]
        internal FixedSizeArray4<float> _max;
    }

    [StructLayout(LayoutKind.Sequential, Size = 8)]
    public struct VertexElement {
        public byte Stream;
        public byte Offset;
        public byte Type;
        public byte Usage;
        public byte UsageIndex;
    }

    [GenerateInterop]
    [StructLayout(LayoutKind.Explicit, Size = 17 * 8)]
    public unsafe partial struct VertexDeclaration {
        [FieldOffset(0), FixedSizeArray]
        internal FixedSizeArray17<VertexElement> _elements;
    }

    [StructLayout(LayoutKind.Sequential, Size = 56)]
    public struct ModelHeader {
        public float Radius;
        public ushort MeshCount;
        public ushort AttributeCount;
        public ushort SubmeshCount;
        public ushort MaterialCount;
        public ushort BoneCount;
        public ushort BoneTableCount;
        public ushort ShapeCount;
        public ushort ShapeMeshCount;
        public ushort ShapeValueCount;
        public byte LodCount;
        public byte Flags1;
        public ushort ElementIdCount;
        public byte TerrainShadowMeshCount;
        public byte Flags2;
        public float ModelClipOutDistance;
        public float ShadowClipOutDistance;
        public ushort Unknown4;
        public ushort TerrainShadowSubmeshCount;
        public byte Unknown5;
        public byte BGChangeMaterialIndex;
        public byte BGCrestChangeMaterialIndex;
        public byte Unknown6;
        public ushort BoneTableArrayCountTotal;
        public ushort Unknown8;
        public ushort Unknown9;
    }
}
