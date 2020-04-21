using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scaler : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        SpriteRenderer sr = GetComponent<SpriteRenderer>(); //  lay component cua sprite hien tai la background
        Vector3 tempScale = transform.localScale; // lay chi so Scale hien tai

        float heightBG = sr.bounds.size.y; // lay chieu dai height cua background
        float widthBG = sr.bounds.size.x; // lay chieu rong width cua back ground

        float height = Camera.main.orthographicSize * 2f; // chieu dai ve 2 phia nen phai nhan 2 chieu cao
        float width = height * Screen.width / Screen.height; // Screen.with / Screen.height la ti le cua man hinh using resolution chieu rong    

        tempScale.y = height / heightBG; // ti le scale cua background thoa cong thuc heightBG(cua background) * tempScale. y = height(cua Camera)
        tempScale.x = width / widthBG; // tuong tu

        transform.localScale = new Vector3(tempScale.x, tempScale.y, 0); // Gan ti le trên vào chi so scale cua back ground bang cah cho vector do bang
        // voi vector voi x y z lan luot la tempScale.x, tempScale.y va 0
    }

    // Update is called once per frame
    void Update()
    {

    }
}