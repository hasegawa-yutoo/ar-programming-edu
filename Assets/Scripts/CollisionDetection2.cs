using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class CollisionDetection2 : MonoBehaviour
{
    public GameObject correct;
    public GameObject incorrect;
    public GameObject complete;
    public GameObject nextButton;
    bool flag = true;
    private InputName VarName;
    private InputAge VarAge;
    private InputHobby VarHobby;
    TextMeshProUGUI SelfIntroduction;

    public void CompleteIntro()
    {
        //インスタンス化
        this.VarName = FindObjectOfType<InputName>();
        this.VarAge = FindObjectOfType<InputAge>();
        this.VarHobby = FindObjectOfType<InputHobby>();

        SelfIntroduction = GameObject.Find("complete/Content/Content/GridLayout/Column/Description").GetComponent<TextMeshProUGUI>();

        // ゲッター
        string introName = VarName.YourName;
        int introAge = VarAge.YourAge;
        string introHobby = VarHobby.YourHobby;
        Debug.Log(introName);
        Debug.Log(introAge);
        Debug.Log(introHobby);

        SelfIntroduction.text = "私の名前は" + introName + "です。年齢は" + introAge + "歳で、趣味は" + introHobby + "です。";
    }


    void OnCollisionEnter(Collision collision)
    {

        if (collision.gameObject.name == "variableAge" && gameObject.name == "ValueAge" || collision.gameObject.name == "variableName" && gameObject.name == "ValueName" || collision.gameObject.name == "variableHobby" && gameObject.name == "ValueHobby")
        {
            if (flag == true)
            {
                StartCoroutine(ShowImageSecond(correct, 1f));
                StartCoroutine(InactiveObj(collision.gameObject, 1f));
                StartCoroutine(InactiveObj(gameObject, 1f));
                incorrect.GetComponent<UiSwitch>().SwitchInactive();
                DifVar.correctNum++;
                Debug.Log(DifVar.correctNum);
                flag = false;
            }
            if (DifVar.correctNum >= 3)
            {
                complete.GetComponent<UiSwitch>().SwitchActive();
                nextButton.GetComponent<UiSwitch>().SwitchActive();
                DifVar.correctNum = 0;
                CompleteIntro();
            }
        }
        else if (collision.gameObject.name == "variableAge" && !(gameObject.name == "ValueAge") || collision.gameObject.name == "variableName" && !(gameObject.name == "ValueName") || collision.gameObject.name == "variableHobby" && !(gameObject.name == "ValueHobby"))
        {
            StartCoroutine(ShowImageSecond(incorrect, 2f));
            correct.GetComponent<UiSwitch>().SwitchInactive();
        }
    }

    IEnumerator ShowImageSecond(GameObject targetObj, float sec)
    {
        targetObj.SetActive(true); //引数で指定されたオブジェクトを表示する
        yield return new WaitForSeconds(sec); // 引数で指定された秒数待つ
        targetObj.SetActive(false); //引数で指定されたオブジェクトを非表示にする
    }

    IEnumerator InactiveObj(GameObject targetObj,float sec)
    {
        yield return new WaitForSeconds(sec); // 引数で指定された秒数待つ
        targetObj.SetActive(false); //引数で指定されたオブジェクトを非表示にする
    }

}
