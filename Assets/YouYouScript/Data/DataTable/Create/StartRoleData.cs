// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace YouYou.DataTable
{

using global::System;
using global::FlatBuffers;

public struct StartRoleData : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static StartRoleData GetRootAsStartRoleData(ByteBuffer _bb) { return GetRootAsStartRoleData(_bb, new StartRoleData()); }
  public static StartRoleData GetRootAsStartRoleData(ByteBuffer _bb, StartRoleData obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p.bb_pos = _i; __p.bb = _bb; }
  public StartRoleData __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public int Id { get { int o = __p.__offset(4); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public string Name { get { int o = __p.__offset(6); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetNameBytes() { return __p.__vector_as_span(6); }
#else
  public ArraySegment<byte>? GetNameBytes() { return __p.__vector_as_arraysegment(6); }
#endif
  public byte[] GetNameArray() { return __p.__vector_as_array<byte>(6); }
  public string Desc { get { int o = __p.__offset(8); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetDescBytes() { return __p.__vector_as_span(8); }
#else
  public ArraySegment<byte>? GetDescBytes() { return __p.__vector_as_arraysegment(8); }
#endif
  public byte[] GetDescArray() { return __p.__vector_as_array<byte>(8); }
  public int Level { get { int o = __p.__offset(10); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public int HP { get { int o = __p.__offset(12); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public int MP { get { int o = __p.__offset(14); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public float AttackRang { get { int o = __p.__offset(16); return o != 0 ? __p.bb.GetFloat(o + __p.bb_pos) : (float)0.0f; } }
  public float MoveSpeed { get { int o = __p.__offset(18); return o != 0 ? __p.bb.GetFloat(o + __p.bb_pos) : (float)0.0f; } }
  public float DashSpeed { get { int o = __p.__offset(20); return o != 0 ? __p.bb.GetFloat(o + __p.bb_pos) : (float)0.0f; } }
  public float JumpHeight { get { int o = __p.__offset(22); return o != 0 ? __p.bb.GetFloat(o + __p.bb_pos) : (float)0.0f; } }
  public int StartExp { get { int o = __p.__offset(24); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public int EmElemntType { get { int o = __p.__offset(26); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public string Skill { get { int o = __p.__offset(28); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetSkillBytes() { return __p.__vector_as_span(28); }
#else
  public ArraySegment<byte>? GetSkillBytes() { return __p.__vector_as_arraysegment(28); }
#endif
  public byte[] GetSkillArray() { return __p.__vector_as_array<byte>(28); }
  public string Equip { get { int o = __p.__offset(30); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetEquipBytes() { return __p.__vector_as_span(30); }
#else
  public ArraySegment<byte>? GetEquipBytes() { return __p.__vector_as_arraysegment(30); }
#endif
  public byte[] GetEquipArray() { return __p.__vector_as_array<byte>(30); }

  public static Offset<StartRoleData> CreateStartRoleData(FlatBufferBuilder builder,
      int Id = 0,
      StringOffset NameOffset = default(StringOffset),
      StringOffset DescOffset = default(StringOffset),
      int Level = 0,
      int HP = 0,
      int MP = 0,
      float AttackRang = 0.0f,
      float MoveSpeed = 0.0f,
      float DashSpeed = 0.0f,
      float JumpHeight = 0.0f,
      int StartExp = 0,
      int emElemntType = 0,
      StringOffset SkillOffset = default(StringOffset),
      StringOffset EquipOffset = default(StringOffset)) {
    builder.StartObject(14);
    StartRoleData.AddEquip(builder, EquipOffset);
    StartRoleData.AddSkill(builder, SkillOffset);
    StartRoleData.AddEmElemntType(builder, emElemntType);
    StartRoleData.AddStartExp(builder, StartExp);
    StartRoleData.AddJumpHeight(builder, JumpHeight);
    StartRoleData.AddDashSpeed(builder, DashSpeed);
    StartRoleData.AddMoveSpeed(builder, MoveSpeed);
    StartRoleData.AddAttackRang(builder, AttackRang);
    StartRoleData.AddMP(builder, MP);
    StartRoleData.AddHP(builder, HP);
    StartRoleData.AddLevel(builder, Level);
    StartRoleData.AddDesc(builder, DescOffset);
    StartRoleData.AddName(builder, NameOffset);
    StartRoleData.AddId(builder, Id);
    return StartRoleData.EndStartRoleData(builder);
  }

  public static void StartStartRoleData(FlatBufferBuilder builder) { builder.StartObject(14); }
  public static void AddId(FlatBufferBuilder builder, int Id) { builder.AddInt(0, Id, 0); }
  public static void AddName(FlatBufferBuilder builder, StringOffset NameOffset) { builder.AddOffset(1, NameOffset.Value, 0); }
  public static void AddDesc(FlatBufferBuilder builder, StringOffset DescOffset) { builder.AddOffset(2, DescOffset.Value, 0); }
  public static void AddLevel(FlatBufferBuilder builder, int Level) { builder.AddInt(3, Level, 0); }
  public static void AddHP(FlatBufferBuilder builder, int HP) { builder.AddInt(4, HP, 0); }
  public static void AddMP(FlatBufferBuilder builder, int MP) { builder.AddInt(5, MP, 0); }
  public static void AddAttackRang(FlatBufferBuilder builder, float AttackRang) { builder.AddFloat(6, AttackRang, 0.0f); }
  public static void AddMoveSpeed(FlatBufferBuilder builder, float MoveSpeed) { builder.AddFloat(7, MoveSpeed, 0.0f); }
  public static void AddDashSpeed(FlatBufferBuilder builder, float DashSpeed) { builder.AddFloat(8, DashSpeed, 0.0f); }
  public static void AddJumpHeight(FlatBufferBuilder builder, float JumpHeight) { builder.AddFloat(9, JumpHeight, 0.0f); }
  public static void AddStartExp(FlatBufferBuilder builder, int StartExp) { builder.AddInt(10, StartExp, 0); }
  public static void AddEmElemntType(FlatBufferBuilder builder, int emElemntType) { builder.AddInt(11, emElemntType, 0); }
  public static void AddSkill(FlatBufferBuilder builder, StringOffset SkillOffset) { builder.AddOffset(12, SkillOffset.Value, 0); }
  public static void AddEquip(FlatBufferBuilder builder, StringOffset EquipOffset) { builder.AddOffset(13, EquipOffset.Value, 0); }
  public static Offset<StartRoleData> EndStartRoleData(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<StartRoleData>(o);
  }
};


}
