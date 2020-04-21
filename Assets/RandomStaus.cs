using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomStaus : MonoBehaviour
{
    GameObject noneFaceMask, beSick, fever;
    int x;

    // Start is called before the first frame update
    void Start()
    {
        x = Mathf.RoundToInt(Random.Range(0, 4));
        if (x == 1)
        {
            noneFaceMask = gameObject.transform.Find("cough").gameObject;
            noneFaceMask.SetActive(true);
            gameObject.tag = "cough";
        }
        else if (x == 2)
        {
            fever = gameObject.transform.Find("fever").gameObject;
            fever.SetActive(true);
            gameObject.tag = "fever";
        }
        else
        {
            beSick = gameObject.transform.Find("nCov Virus").gameObject;
            beSick.SetActive(true);
            gameObject.tag = "beSick";
        }
    }
}
