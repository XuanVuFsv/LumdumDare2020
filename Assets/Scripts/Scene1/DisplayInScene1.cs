using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DisplayInScene1 : MonoBehaviour
{
    public static string textFieldString;
    public float xPoition, yPoition;
    public float widthText, heightText;

    public GameObject answerGameObject, statementGameObject;
    public GameObject controlButton;

    // Start is called before the first frame update
    void Start()
    {
        textFieldString = "UPCASE";
    }

    // Update is called once per frame
    void Update()
    {
        if(textFieldString == "CORONA" || textFieldString == "COVID19" || textFieldString == "COVID" || textFieldString == "NCOV")
        {
            answerGameObject.gameObject.SetActive(true);
            answerGameObject.GetComponent<Text>().text = "Exactly.That's " + textFieldString;
            controlButton.gameObject.SetActive(true);
            if (ControlButton.numPress == 0) statementGameObject.gameObject.SetActive(true);
        }

    }

    private void OnGUI()
    {
        textFieldString = GUI.TextField(new Rect(xPoition, yPoition, widthText, heightText), textFieldString);
    }
}
