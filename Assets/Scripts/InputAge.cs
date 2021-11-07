using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
//using TMPro.EditorUtilities;
using UnityEngine;
using UnityEngine.UI;
public class InputAge : MonoBehaviour
{
    // InputFieldのText参照用
    private TMP_InputField FieldAge;
    private int yourAge;
    string inputAge;

    public int YourAge
    {
        get { return yourAge; }
        set { yourAge = value; }
    }

    void Start()
    {
        FieldAge = GameObject.Find("InputAge").GetComponent<TMP_InputField>();
    }

    // 現状、変数代入してもアタッチされているスクリプトが非表示(setActive false)になるから代入した変数が初期化されてしまう
    // 解決策：enabledを使うか、最初からすべて表示させておいていい感じにアニメーションさせるか
   
    public void EndAge()
    {
        inputAge = FieldAge.text;
        yourAge = Convert.ToInt32(inputAge);
        Debug.Log(yourAge);
    }

    public void DebugVar()
    {
        Debug.Log(yourAge);
    }
}