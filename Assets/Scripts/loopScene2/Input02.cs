using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Input02 : MonoBehaviour
{
    // InputField��Text�Q�Ɨp
    private TMP_InputField FieldSecond;
    private string yourSecond;
    string inputSecond;
    public GameObject complete02;

    public string YourSecond
    {
        get { return yourSecond; }
        set { yourSecond = value; }
    }

    void Start()
    {
        FieldSecond = GameObject.Find("InputSecond").GetComponent<TMP_InputField>();
    }

    // ���͂����l��ϐ��Ɋi�[
    public void EndSecond()
    {
        inputSecond = FieldSecond.text;

        if (!(inputSecond == ""))
        {
            complete02.SetActive(true);
            yourSecond = inputSecond;
        }
        else
        {
            complete02.SetActive(false);
        }
    }
}
