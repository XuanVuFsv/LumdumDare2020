using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlStuff : MonoBehaviour
{

    public GameObject mask, thermometer, iso, gun;
    bool statusMask, statusThermometer, statusIso;
    [SerializeField]int status;

    public static ControlStuff instance;

    void MakeInstance()
    {
        if (instance == null)
        {
            instance = this;
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        status = 0;
        MakeInstance();
        statusMask = true;
        statusThermometer = statusIso = false;

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.S))
        {
            status++;
            if (status == 3) status = 0;
            if (status == 1)
            {
                statusMask = false;
                statusThermometer = true;
                statusIso = false;
                mask.SetActive(statusMask);
                thermometer.SetActive(statusThermometer);
                iso.SetActive(statusIso);
            }
            else if (status == 2)
            {
                statusMask = false;
                statusThermometer = false;
                statusIso = true;
                mask.SetActive(statusMask);
                thermometer.SetActive(statusThermometer);
                iso.SetActive(statusIso);
            }
            else if (status == 0)
            {
                statusMask = true;
                statusThermometer = false;
                statusIso = false;
                mask.SetActive(statusMask);
                thermometer.SetActive(statusThermometer);
                iso.SetActive(statusIso);
            }
        }
    }

    public int TypeStuff()
    {
        if (statusMask)
        {
            return 1;
        }
        else if(statusThermometer)
        {
            return 2;
        }
        else if(statusIso)
        {
            return 3;
        }
        return 0;
    }
}
