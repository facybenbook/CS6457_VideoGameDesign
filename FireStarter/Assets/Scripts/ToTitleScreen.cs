﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToTitleScreen : MonoBehaviour
{
    //public GameObject levelchanger;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void ScreenChange()
    {
        Time.timeScale = 1f;
        UnityEngine.SceneManagement.SceneManager.LoadScene("Title Screen");
        //levelchanger.GetComponent<LevelChanger>().FadeOut("Title Screen");
    }
}
