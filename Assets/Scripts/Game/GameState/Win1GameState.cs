using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Win1GameState : IState
{

    public Win1GameState()
    {

    }

    public void Enter()
    {
        Debug.Log("WIN GAME");

        DataManager.Instance.Money += GlobalSetting.Instance.moneyRewardOnLevel[DataManager.Instance.CurrentLv - 1];
        
        TimerManager.Instance.AddTimer(1f,() => { 
            UIManager.Instance.ShowPanelWithDG(typeof(WinLvPanel));
            SoundManager.Instance.Play(Sounds.WIN_LV);
        });
    }

    public void OnNexLv()
    {
        SceneController.Instance.NextScene();
    }

    public void Exit()
    {
        UIManager.Instance.HidePanelWithDG(typeof(WinLvPanel));
    }
}
