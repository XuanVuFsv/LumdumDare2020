using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePeoPle : MonoBehaviour
{
    public GameObject button, end;
    public float speed;

    // Start is called before the first frame update
    void Start()
    {
        end = GameObject.Find("End");
        button = GameObject.Find("Quit");
        speed = 0.5f;
    }

    // Update is called once per frame
    void Update()
    {
        speed += Time.deltaTime * 0.2f;
        gameObject.transform.position -= Vector3.up * Time.deltaTime * speed;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "destroy")
        {
            Destroy(collision.gameObject);
            ControlLevelScene22.instance.ReStart();
        }
    }
}
