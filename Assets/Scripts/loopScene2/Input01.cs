using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Input01 : MonoBehaviour
{
    // InputField��Text�Q�Ɨp
    private TMP_InputField FieldZero;
    private int yourZero;
    string inputZero;

    public int YourZero
    {
        get { return yourZero; }
        set { yourZero = value; }
    }

    void Start()
    {
        FieldZero = GameObject.Find("InputZero").GetComponent<TMP_InputField>();
    }

    // ���͂����l��ϐ��Ɋi�[
    public void EndZero()
    {
        inputZero = FieldZero.text;
        yourZero = Convert.ToInt32(inputZero);
    }
}
