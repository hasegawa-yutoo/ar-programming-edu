using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class InputIf : MonoBehaviour
{
    // InputField��Text�Q�Ɨp
    private TMP_InputField FieldIf;
    private int yourIf;
    string inputIf;

    public int YourIf
    {
        get { return yourIf; }
        set { yourIf = value; }
    }

    void Start()
    {
        FieldIf = GameObject.Find("InputIf").GetComponent<TMP_InputField>();
    }

    // ���͂����l��ϐ��Ɋi�[
    public void EndIf()
    {
        inputIf = FieldIf.text;

        yourIf = Convert.ToInt32(inputIf);
        Debug.Log(yourIf);
    }
}
