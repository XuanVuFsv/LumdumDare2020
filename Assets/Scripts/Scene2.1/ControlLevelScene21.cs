using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ControlLevelScene21 : MonoBehaviour
{

    public static ControlLevelScene21 instance;

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
        SceneManager.LoadScene("Scene2.1");
    }
    
    public void NextLevel()
    {
        ControlLevel.level++;
        SceneManager.LoadScene("Scene2");
    }
}
