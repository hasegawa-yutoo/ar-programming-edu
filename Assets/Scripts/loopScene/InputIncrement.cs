using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
public class InputIncrement : MonoBehaviour
{
    // InputFieldのText参照用
    private TMP_InputField FieldIncrement;
    private string yourIncrement;
    string inputIncrement;

    public string YourIncrement
    {
        get { return yourIncrement; }
        set { yourIncrement = value; }
    }

    void Start()
    {
        FieldIncrement = GameObject.Find("InputIncrement").GetComponent<TMP_InputField>();
    }

    // 入力した値を変数に格納
    public void EndIncrement()
    {
        inputIncrement = FieldIncrement.text;
        yourIncrement = inputIncrement;
        Debug.Log(yourIncrement);
    }
}