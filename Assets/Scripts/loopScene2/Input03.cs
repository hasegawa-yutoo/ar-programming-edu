using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Input03 : MonoBehaviour
{
    // InputField��Text�Q�Ɨp
    private TMP_InputField FieldThird;
    private int yourThird;
    string inputThird;

    public int YourThird
    {
        get { return yourThird; }
        set { yourThird = value; }
    }

    void Start()
    {
        FieldThird = GameObject.Find("InputThird").GetComponent<TMP_InputField>();
    }

    // ���͂����l��ϐ��Ɋi�[
    public void EndThird()
    {
        inputThird = FieldThird.text;
        yourThird = Convert.ToInt32(inputThird);
    }
}
