using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{

    public GameObject muzzle;
    public GameObject bulletGreen, bulletRed;
    float timeAllowShoot;

    // Start is called before the first frame update
    void Start()
    {
        timeAllowShoot = Time.time;   
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time >= timeAllowShoot)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                timeAllowShoot = Time.time + 0.75f;
                if (ControlBullet.instance.IsGreenBullet())
                {
                    GameObject newBullet = Instantiate(bulletGreen, muzzle.transform.position, Quaternion.identity);
                }
                else
                {
                    GameObject newBullet = Instantiate(bulletRed, muzzle.transform.position, Quaternion.identity);
                }
            }
        }
    }
}
