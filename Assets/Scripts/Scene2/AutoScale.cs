using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoScale : MonoBehaviour
{
    public float delta, orginalDelta;

    float scaleValue;
    bool status;

    // Start is called before the first frame update
    void Start()
    {
        scaleValue = 0;
        status = true;
    }

    // Update is called once per frame
    void Update()
    {

        if(status)
        {
            scaleValue += delta;
            if (scaleValue >= delta*20) status = false;
        }
        else
        {
            scaleValue -= delta;
            if (scaleValue <= -delta*20) status = true;
        }
        gameObject.transform.localScale = new Vector3(scaleValue + orginalDelta, scaleValue + orginalDelta, 0);
    }
}
