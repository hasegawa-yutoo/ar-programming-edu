using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
public class InputIncrement : MonoBehaviour
{
    // InputField��Text�Q�Ɨp
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

    // ���͂����l��ϐ��Ɋi�[
    public void EndIncrement()
    {
        inputIncrement = FieldIncrement.text;
        yourIncrement = inputIncrement;
        Debug.Log(yourIncrement);
    }
}