using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionDetection : MonoBehaviour
{
    public GameObject correct;
    public GameObject incorrect;
    public GameObject complete;


    void OnCollisionEnter(Collision collision)
    {

        if (collision.gameObject.name == "variableInt" && gameObject.name == "ValueInt" || collision.gameObject.name == "variableString" && gameObject.name == "ValueString" || collision.gameObject.name == "variableFloat" && gameObject.name == "ValueFloat")
        {
            StartCoroutine(ShowImageSecond(correct, 1f));
            StartCoroutine(InactiveObj(collision.gameObject, 1f));
            StartCoroutine(InactiveObj(gameObject, 1f));
            incorrect.GetComponent<UiSwitch>().SwitchInactive();
            DifVar.correctNum++;
            Debug.Log(DifVar.correctNum);
            if(DifVar.correctNum >= 3)
            {
                complete.GetComponent<UiSwitch>().SwitchActive();
            }
        } else
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

    IEnumerator InactiveObj(GameObject targetObj, float sec)
    {
        yield return new WaitForSeconds(sec); // 引数で指定された秒数待つ
        targetObj.SetActive(false); //引数で指定されたオブジェクトを非表示にする
    }

}
