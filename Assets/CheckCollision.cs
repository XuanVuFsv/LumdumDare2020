using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckCollision : MonoBehaviour
{
    public GameObject button, end;
    // Start is called before the first frame update
    void Start()
    {
        end = GameObject.Find("End");
        button = GameObject.Find("Quit");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if((gameObject.tag == "faceMask" && collision.gameObject.tag == "cough") || (gameObject.tag == "theo" && collision.gameObject.tag == "fever") || (gameObject.tag == "iso" && collision.gameObject.tag == "beSick"))
        {
            Destroy(gameObject);
            Destroy(collision.gameObject);
        }
        else
        {
            ControlLevelScene22.instance.ReStart();
        }
    }
}
