﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TitleScreen : MonoBehaviour
{
    public void StartButtonClicked()
    {
        SceneManager.LoadScene("test scene");
    }

    public void CreditsButtonClicked()
    {
        SceneManager.LoadScene("credits scene");
    }
}
