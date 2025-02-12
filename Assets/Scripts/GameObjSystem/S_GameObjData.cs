using System;
using UnityEngine;

public class S_GameObjData
{
	public int Id;

	public int OrgMapId;

	public int MapId;

	public Vector3 Pos;

	public float Dir;

    public float Dir2;

    public int Motion;

	public GameObjState State;

	public ENUM_QuestState QuestState;

	public float SpawnTime;

	public int[] AttachID = new int[2];

	public bool HairNoLight;

	public GameObject GameObj;

	public M_GameRoleBase RoleBase;

	public S_GameObjData()
	{
	}

    /// <summary>
    /// 游戏物体数据
    /// </summary>
    /// <param name="roleid">角色ID</param>
    /// <param name="mapid">地图ID</param>
    /// <param name="pos">位置</param>
    /// <param name="angle">朝向</param>
    /// <param name="motion">动作</param>
    /// <param name="state">状态</param>
    /// <param name="gameObj">物体</param>
	public S_GameObjData(int roleid, int mapid, Vector3 pos, float angle, int motion, GameObjState state, GameObject gameObj)
	{
		this.Id = roleid;
		this.MapId = mapid;
		this.Motion = motion;
		this.Pos = pos;
		this.Dir = angle;
		this.State = state;
		this.GameObj = gameObj;
		this.OrgMapId = mapid;
        this.Dir2 = 1000f;
    }

	//public S_GameObjData(GameObjCreateParam CreateParam, GameObject gameObj)
	//{
	//	this.Id = CreateParam.Id;
	//	this.MapId = CreateParam.MapId;
	//	this.Motion = CreateParam.Motion;
	//	this.Pos = CreateParam.Pos;
	//	this.Dir = CreateParam.Dir;
	//	this.State = CreateParam.State;
	//	this.QuestState = CreateParam.QuestState;
	//	this.GameObj = gameObj;
	//	this.OrgMapId = this.Id;
	//}

	//public void SetData(S_SaveGameObjData data)
	//{
	//	this.Id = data.Id;
	//	this.OrgMapId = data.OrgMapId;
	//	this.MapId = data.MapId;
	//	this.Pos.x = data.PosX;
	//	this.Pos.y = data.PosY;
	//	this.Pos.z = data.PosZ;
	//	this.Dir = data.Dir;
	//	this.Motion = data.Motion;
	//	this.State = data.State;
	//	this.QuestState = data.QuestState;
	//	this.SpawnTime = data.SpawnTime;
	//}

	public void Save(GameFileStream stream)
	{
		stream.WriteInt(this.Id);
		stream.WriteInt(this.OrgMapId);
		stream.WriteInt(this.MapId);
		stream.WriteVector3(this.Pos);
		stream.WriteFloat(this.Dir);
		stream.WriteInt(this.Motion);
		stream.WriteInt((int)this.QuestState);
		stream.WriteInt((int)this.State.Get());
		stream.WriteFloat(this.SpawnTime);
		stream.WriteInt(this.AttachID[0]);
		stream.WriteInt(this.AttachID[1]);
		stream.WriteBool(this.HairNoLight);
	}

	public void Load(GameFileStream stream)
	{
		this.Id = stream.ReadInt();
		this.OrgMapId = stream.ReadInt();
		this.MapId = stream.ReadInt();
		this.Pos = stream.ReadVector3();
		this.Dir = stream.ReadFloat();
		this.Motion = stream.ReadInt();
		this.QuestState = (ENUM_QuestState)stream.ReadInt();
		ENUM_GameObjFlag state = (ENUM_GameObjFlag)stream.ReadInt();
		this.State = new GameObjState();
		this.State.Set(state);
		this.SpawnTime = stream.ReadFloat();
		float num = float.Parse("0.0004");
		//if (Swd6Application.instance.m_SaveloadSystem.m_Version >= num)
		//{
		//	this.AttachID[0] = stream.ReadInt();
		//	this.AttachID[1] = stream.ReadInt();
		//	this.HairNoLight = stream.ReadBool();
		//}
	}
}
