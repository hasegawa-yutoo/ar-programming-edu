using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Input02 : MonoBehaviour
{
    // InputFieldのText参照用
    private TMP_InputField FieldSecond;
    private string yourSecond;
    string inputSecond;

    public string YourSecond
    {
        get { return yourSecond; }
        set { yourSecond = value; }
    }

    void Start()
    {
        FieldSecond = GameObject.Find("InputSecond").GetComponent<TMP_InputField>();
    }

    // 入力した値を変数に格納
    public void EndSecond()
    {
        inputSecond = FieldSecond.text;
        yourSecond = inputSecond;
    }
}
