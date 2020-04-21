using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoMove : MonoBehaviour
{
    public float distanceMove;
    public float speed;
    public int direction;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Move(distanceMove, speed, direction);
    }

    void Move(float distanceMove, float speed, int direction)
    {
        if(direction == 1) // up
        {
            gameObject.transform.position += new Vector3(0, speed * Time.deltaTime, 0);
        }
        else if(direction == -1) //down
        {
            gameObject.transform.position -= new Vector3(0, speed * Time.deltaTime, 0);
        }
        else if(direction == 2) // right
        {
            gameObject.transform.position += new Vector3(speed * Time.deltaTime, 0, 0);
        }
        else if(direction == -2) //left
        {
            gameObject.transform.position -= new Vector3(speed * Time.deltaTime, 0, 0);
        }
    }
}
