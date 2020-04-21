﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ControlButtonLevel2 : MonoBehaviour
{
    public GameObject start, end;
    public string nameScene;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void StartLevel2()
    {
        start.gameObject.SetActive(false);
        end.gameObject.SetActive(true);
    }

    public void NextLevel()
    {
        SceneManager.LoadScene(nameScene);
    }
}
