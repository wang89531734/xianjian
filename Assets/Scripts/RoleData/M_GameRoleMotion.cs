using System;
using UnityEngine;

/// <summary>
/// 游戏角色动作
/// </summary>
public class M_GameRoleMotion : MonoBehaviour
{
    private int m_RoleId;

    public int m_Id;

    public int m_FaceUpId;

    public int m_FaceDownId;

    private bool m_Destory;

    private float m_DelayTime = 0.1f;

    private string m_PlayMotionName;

    public ENUM_Motion m_MotionState;

    public string[] m_MotionName;

    public Animation m_Animation;

    public ENUM_Motion MotionState
    {
        get
        {
            return this.m_MotionState;
        }
        set
        {
            this.m_MotionState = value;
            int motionState = (int)this.m_MotionState;
            this.SetMotion(motionState);
        }
    }

    private void Start()
    {
    }

    public void Init(int roleID, int id)
    {
        this.m_RoleId = roleID;
        this.m_Animation = base.gameObject.GetComponentInChildren<Animation>();
        this.SetMotion(id);
        this.ClampMotion(id);
    }

    //	public void SetAlwaysAnimate(bool update)
    //	{
    //		if (this.m_Animation == null)
    //		{
    //			return;
    //		}
    //		if (update)
    //		{
    //			this.m_Animation.cullingType = AnimationCullingType.AlwaysAnimate;
    //			return;
    //		}
    //		this.m_Animation.cullingType = AnimationCullingType.BasedOnRenderers;
    //	}

    private void Update()
    {
        if (this.m_Destory && this.m_Animation)
        {
            Debug.Log("执行");
            //this.m_DelayTime -= Time.deltaTime;
            //if (this.IsMotionFinished() || this.m_DelayTime <= 0f)
            //{
            //    UnityEngine.Object.Destroy(base.gameObject);
            //}
        }
    }

    //	public void DestroyObj()
    //	{
    //		this.m_Destory = true;
    //		this.m_DelayTime = this.GetMotionTime(this.m_Id);
    //	}

    public void SetMotionState(int state)
    {
        this.m_MotionState = (ENUM_Motion)state;
        //if (!AnimationControlSystem.GetClip(base.gameObject, this.m_MotionName[state]))
        //{
        //	return;
        //}
        this.m_Animation.CrossFade(this.m_MotionName[state]);
    }

    //	public int GetMotion()
    //	{
    //		return this.m_Id;
    //	}

    public void SetMotion(int id)
    {
        if (id == 0)
        {
            return;
        }
        S_AnimationData data = GameDataDB.AnimationDB.GetData(id);
        Debug.Log(data.ClipName);
        S_AnimationData data1 = GameDataDB.AnimationDB.GetData(602);
        Debug.Log(data1.ClipName);
        S_AnimationData data2 = GameDataDB.AnimationDB.GetData(603);
        Debug.Log(data2.ClipName);
        S_AnimationData data3 = GameDataDB.AnimationDB.GetData(604);
        Debug.Log(data3.ClipName);
        S_AnimationData data4 = GameDataDB.AnimationDB.GetData(605);
        Debug.Log(data4.ClipName);
        S_AnimationData data5 = GameDataDB.AnimationDB.GetData(606);
        Debug.Log(data5.ClipName);
        string m_ClipName="";
        if (id == 601)
        {
            m_ClipName = "Stand";
        }
        this.m_Id = id;    
        this.m_PlayMotionName = m_ClipName;       
        this.m_Animation.Play(this.m_PlayMotionName);
    }

    public void SetCrossMotion(int id)
    {
        if (id == 0)
        {
            return;
        }
        //S_AnimationData data = GameDataDB.AnimationDB.GetData(id);
        //if (data == null)
        //{
        //    if (Swd6Application.instance.m_ResourceType == ENUM_ResourceType.Develop)
        //    {
        //        string text = string.Concat(new object[]
        //        {
        //                "角色",
        //                this.m_RoleId,
        //                "_DBF沒有這個動作 : ",
        //                id
        //        });
        //        Debug.LogWarning(text);
        //        UI_OkCancelBox.Instance.ClearSysMsg();
        //        UI_OkCancelBox.Instance.AddSysMsg(text, 10f);
        //    }
        //    return;
        //}
        //if (this.m_Animation == null)
        //{
        //    if (Swd6Application.instance.m_ResourceType == ENUM_ResourceType.Develop)
        //    {
        //        string text2 = string.Concat(new object[]
        //        {
        //                "角色",
        //                this.m_RoleId,
        //                "_身上沒有這個動作_NULL_ : ",
        //                data.ClipName
        //        });
        //        Debug.LogWarning(text2);
        //        UI_OkCancelBox.Instance.ClearSysMsg();
        //        UI_OkCancelBox.Instance.AddSysMsg(text2, 10f);
        //    }
        //    return;
        //}
        //if (!AnimationControlSystem.GetClip(base.gameObject, data.ClipName))
        //{
        //    return;
        //}
        //this.m_Id = id;
        ////this.m_PlayMotionName = data.ClipName;
        //this.m_Animation.CrossFade(this.m_PlayMotionName);
    }

    //	public void SetMotionQueued(int id)
    //	{
    //		if (id == 0)
    //		{
    //			return;
    //		}
    //		S_AnimationData data = GameDataDB.AnimationDB.GetData(id);
    //		if (data == null)
    //		{
    //			if (Swd6Application.instance.m_ResourceType == ENUM_ResourceType.Develop)
    //			{
    //				string text = string.Concat(new object[]
    //				{
    //					"角色",
    //					this.m_RoleId,
    //					"_DBF沒有這個動作 : ",
    //					id
    //				});
    //				Debug.LogWarning(text);
    //				UI_OkCancelBox.Instance.ClearSysMsg();
    //				UI_OkCancelBox.Instance.AddSysMsg(text, 10f);
    //			}
    //			return;
    //		}
    //		if (this.m_Animation == null)
    //		{
    //			if (Swd6Application.instance.m_ResourceType == ENUM_ResourceType.Develop)
    //			{
    //				string text2 = string.Concat(new object[]
    //				{
    //					"角色",
    //					this.m_RoleId,
    //					"_身上沒有這個動作_NULL_ : ",
    //					data.ClipName
    //				});
    //				Debug.LogWarning(text2);
    //				UI_OkCancelBox.Instance.ClearSysMsg();
    //				UI_OkCancelBox.Instance.AddSysMsg(text2, 10f);
    //			}
    //			return;
    //		}
    //		if (!AnimationControlSystem.GetClip(base.gameObject, data.ClipName))
    //		{
    //			return;
    //		}
    //		AnimationState arg_110_0 = this.m_Animation[data.ClipName];
    //		this.m_Animation.PlayQueued(data.ClipName);
    //	}

    //	public void SetMotion(string name)
    //	{
    //		this.m_PlayMotionName = name;
    //		if (!AnimationControlSystem.GetClip(base.gameObject, this.m_PlayMotionName))
    //		{
    //			return;
    //		}
    //		this.m_Animation.CrossFade(name);
    //	}

    //	public void SetMotionSpeed(int id, float speed)
    //	{
    //		if (id == 0)
    //		{
    //			return;
    //		}
    //		S_AnimationData data = GameDataDB.AnimationDB.GetData(id);
    //		if (data == null)
    //		{
    //			return;
    //		}
    //		if (this.m_Animation == null)
    //		{
    //			return;
    //		}
    //		if (!AnimationControlSystem.GetClip(base.gameObject, data.ClipName))
    //		{
    //			return;
    //		}
    //		AnimationState animationState = this.m_Animation[data.ClipName];
    //		animationState.speed = speed;
    //	}

    //	public bool IsMotionFinished()
    //	{
    //		return !this.m_Animation.IsPlaying(this.m_PlayMotionName);
    //	}

    //	public bool IsMotionFinished(int id)
    //	{
    //		if (id == 0)
    //		{
    //			return true;
    //		}
    //		S_AnimationData data = GameDataDB.AnimationDB.GetData(id);
    //		if (data == null)
    //		{
    //			return true;
    //		}
    //		if (this.m_Animation == null)
    //		{
    //			Debug.Log(this.m_RoleId + "_m_Animation == null_" + this.m_Id);
    //			return true;
    //		}
    //		AnimationState animationState = this.m_Animation[data.ClipName];
    //		return animationState == null || animationState.time >= animationState.length || !this.m_Animation.IsPlaying(data.ClipName);
    //	}

    public void ClampMotion(int id)
    {
        if (id == 0)
        {
            return;
        }
 
        if (this.m_Animation == null)
        {
            return;
        }

        string m_ClipName = "";
        if (id == 601)
        {
            m_ClipName = "Stand";
        }

        AnimationState animationState = this.m_Animation[m_ClipName];
        if (animationState == null)
        {
            return;
        }

        if (animationState.wrapMode != WrapMode.Loop)
        {
            animationState.time = animationState.length;
            this.m_Animation.Play(m_ClipName);
        }
    }

    //	public float GetMotionTime(int id)
    //	{
    //		if (id == 0)
    //		{
    //			return 0f;
    //		}
    //		S_AnimationData data = GameDataDB.AnimationDB.GetData(id);
    //		if (data == null)
    //		{
    //			return 0f;
    //		}
    //		if (this.m_Animation == null)
    //		{
    //			return 0f;
    //		}
    //		if (!AnimationControlSystem.GetClip(base.gameObject, data.ClipName))
    //		{
    //			return 0f;
    //		}
    //		AnimationState animationState = this.m_Animation[data.ClipName];
    //		if (animationState == null)
    //		{
    //			return 0f;
    //		}
    //		return animationState.length;
    //	}

    //	public void PlayExpression_Up(int id)
    //	{
    //		if (this.m_FaceUpId == id)
    //		{
    //			return;
    //		}
    //		S_AnimationData data = GameDataDB.AnimationDB.GetData(id);
    //		if (data == null)
    //		{
    //			return;
    //		}
    //		if (this.m_Animation == null)
    //		{
    //			return;
    //		}
    //		if (!AnimationControlSystem.GetClip(base.gameObject, data.ClipName))
    //		{
    //			return;
    //		}
    //		this.m_FaceUpId = id;
    //		AnimationControlSystem.PlayExpression_Up(base.gameObject, data.ClipName);
    //	}

    //	public void PlayExpression_Down(int id)
    //	{
    //		if (this.m_FaceDownId == id)
    //		{
    //			return;
    //		}
    //		S_AnimationData data = GameDataDB.AnimationDB.GetData(id);
    //		if (data == null)
    //		{
    //			return;
    //		}
    //		if (this.m_Animation == null)
    //		{
    //			return;
    //		}
    //		if (!AnimationControlSystem.GetClip(base.gameObject, data.ClipName))
    //		{
    //			return;
    //		}
    //		this.m_FaceDownId = id;
    //		AnimationControlSystem.PlayExpression_Down(base.gameObject, data.ClipName);
    //	}

    //	public void Idle()
    //	{
    //		this.MotionState = ENUM_Motion.Idle;
    //	}

    //	public void Walk()
    //	{
    //		this.MotionState = ENUM_Motion.Walk;
    //	}

    //	public void Run()
    //	{
    //		this.MotionState = ENUM_Motion.Run;
    //	}

    //	public void Jump()
    //	{
    //		this.MotionState = ENUM_Motion.Jump;
    //	}

    //	public void JumpLand()
    //	{
    //		this.MotionState = ENUM_Motion.Idle;
    //	}
}
