using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
//using TMPro.EditorUtilities;
using UnityEngine;
using UnityEngine.UI;
public class InputAge : MonoBehaviour
{
    // InputField��Text�Q�Ɨp
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

    // ����A�ϐ�������Ă��A�^�b�`����Ă���X�N���v�g����\��(setActive false)�ɂȂ邩���������ϐ�������������Ă��܂�
    // ������Fenabled���g�����A�ŏ����炷�ׂĕ\�������Ă����Ă��������ɃA�j���[�V���������邩
   
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