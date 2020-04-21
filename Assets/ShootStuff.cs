using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootStuff : MonoBehaviour
{

    public GameObject muzzle;
    public GameObject mask, thermometer, iso;
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
                if (ControlStuff.instance.TypeStuff() == 1)
                {
                    GameObject newBullet = Instantiate(mask, muzzle.transform.position, Quaternion.identity);
                }
                else if (ControlStuff.instance.TypeStuff() == 2)
                {
                    GameObject newBullet = Instantiate(thermometer, muzzle.transform.position, Quaternion.identity);
                }
                else if (ControlStuff.instance.TypeStuff() == 3)
                {
                    GameObject newBullet = Instantiate(iso, muzzle.transform.position, Quaternion.identity);
                }
            }
        }
    }
}
