using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControllerClickLevel : MonoBehaviour
{

    public GameObject virtualButton1, virtualButton2, virtualButton3, virtualButton4;
    public GameObject cursor;
    Vector3 cursorPosition1, cursorPosition2, cursorPosition3, cursorPosition4;

    // Start is called before the first frame update
    void Start()
    {
        cursorPosition4 = new Vector3(0.051105f, 3.90085f, -2);
        cursorPosition1 = new Vector3(0.2f, -0.51f, -2);
        cursorPosition2 = new Vector3(-0.52f, 2.18f, -2);
        cursorPosition3 = new Vector3(0.92f, 2.18f, -2);
    }

    // Update is called once per frame
    void Update()
    {
        if (ControlLevel.level == 1)
        {
            virtualButton1.gameObject.SetActive(true);
            cursor.gameObject.transform.position = cursorPosition1;
        }
        if (ControlLevel.level == 2)
        {
            cursor.gameObject.transform.position = cursorPosition2;
            virtualButton1.gameObject.SetActive(false);
            virtualButton2.gameObject.SetActive(true);
        }
        if (ControlLevel.level == 3)
        {
            cursor.gameObject.transform.position = cursorPosition3;
            virtualButton2.gameObject.SetActive(false);
            virtualButton3.gameObject.SetActive(true);
        }
        if (ControlLevel.level == 4)
        {
            cursor.gameObject.transform.position = cursorPosition4;
            virtualButton3.gameObject.SetActive(false);
            virtualButton4.gameObject.SetActive(true);
        }
    }
}
