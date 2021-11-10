using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class InputIf : MonoBehaviour
{
    // InputField‚ÌTextQÆ—p
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

    // “ü—Í‚µ‚½’l‚ğ•Ï”‚ÉŠi”[
    public void EndIf()
    {
        inputIf = FieldIf.text;

        yourIf = Convert.ToInt32(inputIf);
        Debug.Log(yourIf);
    }
}
