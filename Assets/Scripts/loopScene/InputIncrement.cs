using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
public class InputIncrement : MonoBehaviour
{
    // InputField‚ÌTextQÆ—p
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

    // “ü—Í‚µ‚½’l‚ğ•Ï”‚ÉŠi”[
    public void EndIncrement()
    {
        inputIncrement = FieldIncrement.text;
        yourIncrement = inputIncrement;
        Debug.Log(yourIncrement);
    }
}