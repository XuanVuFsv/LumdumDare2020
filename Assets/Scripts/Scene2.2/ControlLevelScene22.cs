using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ControlLevelScene22 : MonoBehaviour
{

    public static ControlLevelScene22 instance;

    void MakeInstance()
    {
        if (instance == null)
        {
            instance = this;
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        MakeInstance();
    }

    public void ReStart()
    {
        SceneManager.LoadScene("Scene2.2");
    }

    public void NextLevel()
    {
        ControlLevel.level++;
        SceneManager.LoadScene("SceneEnd");
    }
}
