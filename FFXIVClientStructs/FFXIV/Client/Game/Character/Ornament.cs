namespace FFXIVClientStructs.FFXIV.Client.Game.Character;
// Client::Game::Character::Ornament
//   Client::Game::Character::Character
//     Client::Game::Object::GameObject
//     Client::Graphics::Vfx::VfxDataListenner
// ornament = accessory

// ctor E8 ?? ?? ?? ?? 48 8B C8 EB 03 48 8B CF 48 8B 46 08 45 33 C9
[StructLayout(LayoutKind.Explicit, Size = 0x1BF0)]
[Inheritance<Character>]
public unsafe partial struct Ornament {

    [FieldOffset(0x1BD0)] public uint OrnamentId;
    [FieldOffset(0x1BD4)] public byte AttachmentPoint;

    [MemberFunction("48 89 5C 24 ?? 41 54 41 56 41 57 48 83 EC ?? 4D 8B F8")]
    public partial void SetupOrnament(uint* unk1, float* unk2);
}
