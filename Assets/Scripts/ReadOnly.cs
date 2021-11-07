using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class ReadOnly : MonoBehaviour
{

    private TMP_InputField targetField;
    // Start is called before the first frame update
    void Start()
    {
        targetField = GetComponent<TMP_InputField>();
    }

    public void onReadOnly()
    {
        targetField.readOnly = true;
    }

    public void offReadOnly()
    {
        targetField.readOnly = false;
    }
}
