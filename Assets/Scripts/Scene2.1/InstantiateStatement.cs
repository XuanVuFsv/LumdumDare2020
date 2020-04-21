using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstantiateStatement : MonoBehaviour
{
    public GameObject can, cannot;
    public GameObject muzzle;
    public float timePerStage, speeedInstantiate;

    float timeNextStage, timeAllowInstantiate;


    // Start is called before the first frame update
    void Start()
    {
        timeNextStage = Time.time + timePerStage;
        timeAllowInstantiate = Time.time;
    }

    // Update is called once per frame
    void Update()
    {
        if(speeedInstantiate <= 0.9f)
        {
            ControlLevelScene21.instance.NextLevel();
        }

        Instantiate();
        if (Time.time >= timeNextStage)
        {
            timeNextStage = Time.time + timePerStage;
            speeedInstantiate -= 0.07f;
        }
    }

    void Instantiate()
    {
        if (Time.time >= timeAllowInstantiate)
        {
            timeAllowInstantiate = Time.time + speeedInstantiate;
            if (Mathf.Round(Random.Range(0, 10)) % 2 ==0)
            {
                GameObject newStatement = Instantiate(can, muzzle.transform.position, Quaternion.identity);
            }
            else
            {
                GameObject newStatement = Instantiate(cannot, muzzle.transform.position, Quaternion.identity);
            }
        }
    }
}
