﻿using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour {

    public void OnStartGame(string sceneName)
    {
        Application.LoadLevel(sceneName);
    }
}
