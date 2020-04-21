using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoScaleWord : MonoBehaviour
{

    public float minScale, maxScale;
    public static float speed;

    float scale;

    // Start is called before the first frame update
    void Start()
    {
        speed = 1;
        scale = Random.Range(minScale, maxScale);
        gameObject.transform.localScale = new Vector3(scale, scale, scale);
    }

    // Update is called once per frame
    void Update()
    {
        speed += Time.deltaTime * 0.7f;
        gameObject.transform.position -= Vector3.up * Time.deltaTime * speed;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (gameObject.tag == "can")
        {
            Destroy(collision.gameObject);
        }
        if (collision.gameObject.name == "destroy")
        {
            Destroy(gameObject);
            ControlLevelScene21.instance.ReStart();
            Debug.Log("Lose");
            
        }
    }
}
