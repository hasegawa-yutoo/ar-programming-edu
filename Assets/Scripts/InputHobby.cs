using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
//using TMPro.EditorUtilities;
using UnityEngine;
using UnityEngine.UI;
public class InputHobby : MonoBehaviour
{
    // InputFieldのText参照用
    private TMP_InputField FieldHobby;
    private string yourHobby;
    string inputHobby;

    public string YourHobby
    {
        get { return yourHobby; }
        set { yourHobby = value; }
    }

    void Start()
    {
        FieldHobby = GameObject.Find("InputHobby").GetComponent<TMP_InputField>();
    }

    // 現状、変数代入してもアタッチされているスクリプトが非表示(setActive false)になるから代入した変数が初期化されてしまう
    // 解決策：enabledを使うか、最初からすべて表示させておいていい感じにアニメーションさせるか
    public void EndHobby()
    {
        inputHobby = FieldHobby.text;
        yourHobby = inputHobby;
        Debug.Log(yourHobby);
    }

    public void DebugVar()
    {
        Debug.Log(yourHobby);
    }
}