using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
//using TMPro.EditorUtilities;
using UnityEngine;
using UnityEngine.UI;
public class InputHobby : MonoBehaviour
{
    // InputField��Text�Q�Ɨp
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

    // ����A�ϐ�������Ă��A�^�b�`����Ă���X�N���v�g����\��(setActive false)�ɂȂ邩���������ϐ�������������Ă��܂�
    // ������Fenabled���g�����A�ŏ����炷�ׂĕ\�������Ă����Ă��������ɃA�j���[�V���������邩
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