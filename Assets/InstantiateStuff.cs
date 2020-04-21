using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstantiateStuff : MonoBehaviour
{
    public GameObject stuff1, stuff2, stuff3, end, button;
    public GameObject muzzle;
    public float timePerStage, speeedInstantiate;

    float timeNextStage, timeAllowInstantiate;
    int x;


    // Start is called before the first frame update
    void Start()
    {
        end = GameObject.Find("End");
        button = GameObject.Find("Quit");
        timeNextStage = Time.time + timePerStage;
        timeAllowInstantiate = Time.time;
    }

    // Update is called once per frame
    void Update()
    {
        if (speeedInstantiate <= 1f)
        {
            end.SetActive(false);
            button.transform.Find("Quit").gameObject.SetActive(true);
        }

        Instantiate();
        if (Time.time >= timeNextStage)
        {
            timeNextStage = Time.time + timePerStage;
            speeedInstantiate -= 0.1f;
        }
    }

    void Instantiate()
    {
        x = (int)Mathf.Round(Random.Range(0, 4));
        if (Time.time >= timeAllowInstantiate)
        {
            timeAllowInstantiate = Time.time + speeedInstantiate;
            if (x == 1)
            {
                GameObject newStatement = Instantiate(stuff1, muzzle.transform.position, Quaternion.identity);
            }
            else if (x == 2)
            {
                GameObject newStatement = Instantiate(stuff2, muzzle.transform.position, Quaternion.identity);
            }
            else if (x == 3)
            {
                GameObject newStatement = Instantiate(stuff3, muzzle.transform.position, Quaternion.identity);
            }
        }
    }
}
