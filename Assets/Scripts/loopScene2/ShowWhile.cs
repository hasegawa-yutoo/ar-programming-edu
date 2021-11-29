using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class ShowWhile : MonoBehaviour
{
    private Input01 VarZero;
    private Input02 VarSecond;
    private Input03 VarThird;

    TextMeshProUGUI WhileSentence;

    private int whileZero;
    private string whileSecond;
    private int whileThird;

    void Start()
    {
        WhileSentence = this.transform.Find("while/Content/Content/GridLayout/Column/Title").GetComponent<TextMeshProUGUI>();
        Debug.Log(WhileSentence);
    }

    public void CompleteZero()
    {
        this.VarZero = FindObjectOfType<Input01>();
        whileZero = VarZero.YourZero;
        WhileSentence.text = "int second = 0;\nwhile (second < " + whileZero + " && second >= 0){\n  �`Unity�����1�b�ԑ��鏈���`\n  second [��Q]= [��R];\n  System.out.println(second);}";
    }

    public void CompleteSecond()
    {
        this.VarSecond = FindObjectOfType<Input02>();
        whileSecond = VarSecond.YourSecond;
        WhileSentence.text = "int second = 0;\nwhile (second < " + whileZero + " && second >= 0){\n  �`Unity�����1�b�ԑ��鏈���`\n  second " + whileSecond + "= [��R];\n  System.out.println(second);}";
    }

    public void CompleteThird()
    {
        this.VarThird = FindObjectOfType<Input03>();
        whileThird = VarThird.YourThird;
        WhileSentence.text = "int second = 0;\nwhile (second < " + whileZero + " && second >= 0){\n  �`Unity�����1�b�ԑ��鏈���`\n  second " + whileSecond + "= " + whileThird + ";\n  System.out.println(second);}";
    }
}
