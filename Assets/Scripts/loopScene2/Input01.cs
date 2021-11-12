using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Input01 : MonoBehaviour
{
    // InputField‚ÌTextQÆ—p
    private TMP_InputField FieldZero;
    private int yourZero;
    string inputZero;
    public GameObject complete01;

    public int YourZero
    {
        get { return yourZero; }
        set { yourZero = value; }
    }

    void Start()
    {
        FieldZero = GameObject.Find("InputZero").GetComponent<TMP_InputField>();
    }

    // “ü—Í‚µ‚½’l‚ğ•Ï”‚ÉŠi”[
    public void EndZero()
    {
        inputZero = FieldZero.text;
        if (!(inputZero == ""))
        {
            complete01.SetActive(true);
            yourZero = Convert.ToInt32(inputZero);
        } else
        {
            complete01.SetActive(false);
        }
    }
}
