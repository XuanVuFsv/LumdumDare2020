using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlBullet : MonoBehaviour
{

    public GameObject bulletGreen, bulletRed, gunRed, gunGreen;
    bool statusGreen, statusRed, statusGunGreen, statusGunRed;

    public static ControlBullet instance;

    void MakeInstance()
    {
        if(instance == null)
        {
            instance = this;
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        MakeInstance();
        statusGreen = statusGunGreen = true;
        statusRed = statusGunRed = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.S))
        {
            statusRed = !statusRed;
            statusGreen = !statusGreen;
            statusGunGreen = !statusGunGreen;
            statusGunRed = !statusGunRed;
            if (statusGunRed == true) gunRed.gameObject.transform.position = gunGreen.gameObject.transform.position;
            if (statusGunGreen == true) gunGreen.gameObject.transform.position = gunRed.gameObject.transform.position;
            bulletGreen.SetActive(statusGreen);
            bulletRed.SetActive(statusRed);
            gunGreen.SetActive(statusGunGreen);
            gunRed.SetActive(statusGunRed);
            Debug.Log(IsGreenBullet());
        }
    }

    public bool IsGreenBullet()
    {
        if (statusGreen)
        {
            return true;
        }
        else return false;
    }
}
