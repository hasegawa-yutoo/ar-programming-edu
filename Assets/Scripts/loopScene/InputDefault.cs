using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class InputDefault : MonoBehaviour
{
    // InputFieldのText参照用
    private TMP_InputField FieldDefault;
    private int yourDefault;
    string inputDefault;

    public int YourDefault
    {
        get { return yourDefault; }
        set { yourDefault = value; }
    }

    void Start()
    {
        FieldDefault = GameObject.Find("InputDefault").GetComponent<TMP_InputField>();
    }

    // 入力した値を変数に格納
    public void EndDefault()
    {
        inputDefault = FieldDefault.text;

        yourDefault = Convert.ToInt32(inputDefault);
        Debug.Log(yourDefault);
    }
}
