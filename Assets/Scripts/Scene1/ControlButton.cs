using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ControlButton : MonoBehaviour
{
    public static int numPress;
    public string nameScene;

    public GameObject statement, statement1, statement2;
    public GameObject nextTextButton;

    // Start is called before the first frame update
    void Start()
    {
        numPress = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ChangeScene()
    {
        SceneManager.LoadScene(nameScene);
        ControlLevel.level++;
    }

    public void NextText()
    {
        numPress++;
        statement.gameObject.SetActive(false);
        if (numPress == 1)
        {
            statement1.GetComponent<Text>().text += DisplayInScene1.textFieldString;
            statement1.gameObject.SetActive(true);
        }
        else if (numPress == 2)
        {
            statement1.gameObject.SetActive(false);
            statement2.gameObject.SetActive(true);
        }
        else nextTextButton.gameObject.SetActive(false);
    }
}
