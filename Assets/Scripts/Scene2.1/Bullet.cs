using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{

    public float speed;
    Rigidbody2D rigid;

    // Start is called before the first frame update
    void Start()
    {
        rigid = gameObject.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        rigid.AddForce(Vector2.up * Time.deltaTime * speed);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log(gameObject.tag + " " + collision.gameObject.tag);
        if (collision.gameObject.tag == "can" && gameObject.tag == "BulletGreen")
        {
            Destroy(collision.gameObject);
            Destroy(gameObject);
            Debug.Log("+");
        }
        if (collision.gameObject.tag == "cannot" && gameObject.tag == "BulletGreen")
        {
            Debug.Log("Lose");
            ControlLevelScene21.instance.ReStart();
            Destroy(gameObject);
        }

        if (collision.gameObject.tag == "cannot" && gameObject.tag == "BulletRed")
        {
            Destroy(collision.gameObject);
            Destroy(gameObject);
            Debug.Log("+");
        }
        if (collision.gameObject.tag == "can" && gameObject.tag == "BulletRed")
        {
            Debug.Log("Lose");
            ControlLevelScene21.instance.ReStart();
            Destroy(gameObject);
        }
    }
}
