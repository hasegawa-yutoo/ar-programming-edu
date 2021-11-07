using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
//using TMPro.EditorUtilities;
using UnityEngine;
using UnityEngine.UI;
public class InputName : MonoBehaviour
{
    // InputFieldのText参照用
    private TMP_InputField FieldName;
    private string yourName;
    string inputName;

    public string YourName
    {
        get { return yourName; }
        set { yourName = value; }
    }

    void Start()
    {
        FieldName = GameObject.Find("InputName").GetComponent<TMP_InputField>();
    }

    // 現状、変数代入してもアタッチされているスクリプトが非表示(setActive false)になるから代入した変数が初期化されてしまう
    // 解決策：enabledを使うか、最初からすべて表示させておいていい感じにアニメーションさせるか
    public void EndName()
    {
        inputName = FieldName.text;

        yourName = inputName;
        Debug.Log(yourName);
    }

    public void DebugVar()
    {
        Debug.Log(yourName);
    }
}