using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Input03 : MonoBehaviour
{
    // InputFieldのText参照用
    private TMP_InputField FieldThird;
    private int yourThird;
    string inputThird;
    public GameObject complete03;

    public int YourThird
    {
        get { return yourThird; }
        set { yourThird = value; }
    }

    void Start()
    {
        FieldThird = GameObject.Find("InputThird").GetComponent<TMP_InputField>();
    }

    // 入力した値を変数に格納
    public void EndThird()
    {
        inputThird = FieldThird.text;

        if (!(inputThird == ""))
        {
            complete03.SetActive(true);
            yourThird = Convert.ToInt32(inputThird);
        }
        else
        {
            complete03.SetActive(false);
        }
    }
}
