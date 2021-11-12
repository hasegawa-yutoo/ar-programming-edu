using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class ShowLoop : MonoBehaviour
{
    private InputDefault VarDefault;
    private InputIf VarIf;
    private InputIncrement VarIncrement;

    TextMeshProUGUI ForSentence;

    int loopDefault;
    int loopIf;
    string loopIncrement;

    void Start()
    {
        ForSentence = this.transform.Find("for/Content/Content/GridLayout/Column/Title").GetComponent<TextMeshProUGUI>();
        Debug.Log(ForSentence);
    }

    public void CompleteLoop()
    {
        this.VarIncrement = FindObjectOfType<InputIncrement>();
        loopIncrement = VarIncrement.YourIncrement;
        ForSentence.text = "for( int i = " + loopDefault + "; i < " + loopIf + "; i" + loopIncrement + " ){\n    `Unity‚¿‚á‚ñ‚ª‚P•bŠÔ‘–‚éˆ—`\n}";
    }

    public void CompleteIf()
    {
        this.VarIf = FindObjectOfType<InputIf>();
        loopIf = VarIf.YourIf;
        ForSentence.text = "for( int i = " + loopDefault + "; i < " + loopIf + "; i›› ){\n    `Unity‚¿‚á‚ñ‚ª‚P•bŠÔ‘–‚éˆ—`\n}";
    }

    public void CompleteDefault()
    {
        this.VarDefault = FindObjectOfType<InputDefault>();
        loopDefault = VarDefault.YourDefault;
        ForSentence.text = "for( int i = " + loopDefault + "; i < ››; i›› ){\n    `Unity‚¿‚á‚ñ‚ª‚P•bŠÔ‘–‚éˆ—`\n}";
    }

}
