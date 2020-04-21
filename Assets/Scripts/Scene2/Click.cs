using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Click : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseDown()
    {
        if (gameObject.name == "VirtualButton1")
        {
            Debug.Log("realease" + gameObject.name);
            SceneManager.LoadScene("Scene2.1");
        }
        if (gameObject.name == "VirtualButton2")
        {
            Debug.Log("realease" + gameObject.name);
            SceneManager.LoadScene("Scene2.2");
        }
        if (gameObject.name == "VirtualButton3")
        {
            Debug.Log("realease" + gameObject.name);
            SceneManager.LoadScene("Scene2.3");
        }
    }
}
