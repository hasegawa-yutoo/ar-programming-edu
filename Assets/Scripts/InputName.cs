using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
//using TMPro.EditorUtilities;
using UnityEngine;
using UnityEngine.UI;
public class InputName : MonoBehaviour
{
    // InputField��Text�Q�Ɨp
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

    // ����A�ϐ�������Ă��A�^�b�`����Ă���X�N���v�g����\��(setActive false)�ɂȂ邩���������ϐ�������������Ă��܂�
    // ������Fenabled���g�����A�ŏ����炷�ׂĕ\�������Ă����Ă��������ɃA�j���[�V���������邩
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