using System;
using System.Collections.Generic;

public class QuestRecord
{
	public int ID;

	public ENUM_QuestState State;

	public Dictionary<int, S_FinishMob> FinishMob;

	public QuestRecord()
	{
		this.FinishMob = new Dictionary<int, S_FinishMob>();
	}
}
