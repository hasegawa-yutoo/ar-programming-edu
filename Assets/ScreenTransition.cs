using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScreenTransition : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Invoke("ChangeScene", 1.5f);
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void PushButton()
    {
        SceneManager.LoadScene("VariableScene");
    }
}
