﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NAVI : MonoBehaviour
{
    // Start is called before the first frame update
    public void LoadMyScene(string scene)
    {
        SceneManager.LoadScene(scene);
    }
    public void LoadMyScene(int scenenumber)
    {
        SceneManager.LoadScene(scenenumber);
    }
    void Start()

    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}
