using System;
using System.Collections.Generic;
using System.IO;
using UnityEditor;
using UnityEngine;

public class DataManager : BaseManager<DataManager>
{
    public const string GAME_DATA_PATH = "GameData";

    private GameData _gameData;

    private JsonManager _jsonManager;

    public override void Init()
    {
        _jsonManager = new JsonManager();
        _gameData = _jsonManager.ReadDataFromFile<GameData>(GAME_DATA_PATH);  
    }

    public void SaveGame() => _jsonManager.WriteDataToFile(_gameData, GAME_DATA_PATH);

    public int Money { get => _gameData.playerMoney; set => _gameData.playerMoney = value;}
    public int CurrentLv { get => _gameData.currentLv; set => _gameData.currentLv = value;}
    public int UnlockLv { get => _gameData.unlockLv; set => _gameData.unlockLv = value; }


    private void OnDestroy()
    {
        SaveGame();
    }
}