﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class MainMenuController : MonoBehaviour
{
    public void _PlayButton()
    {
        //Application.LoadLevel("GamePlay");
        SceneManager.LoadScene("GamePlay");
    }
}
