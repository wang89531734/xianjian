﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Toggle))]
public abstract class UICharacterAction : UIBase
{
    public UISkill uiSkill;
    public Text textRemainsTurns;
    public Image imageRemainsTurnsGage;
    public int skillIndex;
    public CharacterSkill skill;

    private UICharacterActionManager actionManager;
    public UICharacterActionManager ActionManager
    {
        get { return actionManager; }
        set
        {
            if (value == null)
                return;
            actionManager = value;
            TempToggle.group = actionManager.TempToggleGroup;
        }
    }

    private Toggle tempToggle;
    public Toggle TempToggle
    {
        get
        {
            if (tempToggle == null)
                tempToggle = GetComponent<Toggle>();
            return tempToggle;
        }
    }

    public bool IsOn
    {
        get { return TempToggle.isOn; }
        set { TempToggle.isOn = value; }
    }

    protected override void Awake()
    {
        base.Awake();
        TempToggle.onValueChanged.RemoveListener(OnSelected);
        TempToggle.onValueChanged.AddListener(OnSelected);
    }

    protected void OnSelected(bool select)
    {
        //if (!ActionManager.IsPlayerCharacterActive || ActionManager.ActiveCharacter.IsDoingAction || !select)
        //    return;
        ActionManager.ActiveCharacter.SetAction(skillIndex);
        //OnActionSelected();
        Debug.Log("直接执行");
    }

    protected abstract void OnActionSelected();
}
