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

    public void ChangeVariableScene()
    {
        SceneManager.LoadScene("VariableScene");
    }

    public void ChangeTextScene()
    {
        SceneManager.LoadScene("TextScene");
    }

    public void ChangeTextScene2()
    {
        SceneManager.LoadScene("TextScene2");
    }

    public void ChangeVariableScene2()
    {
        SceneManager.LoadScene("VariableScene2");
    }

    public void ChangeIfScene()
    {
        SceneManager.LoadScene("IfScene");
    }

    public void ChangeIfTextScene()
    {
        SceneManager.LoadScene("IfTextScene");
    }

    public void ChangeLoopScene()
    {
        SceneManager.LoadScene("LoopScene");
    }

    public void ChangeLoopScene2()
    {
        SceneManager.LoadScene("LoopScene2");
    }
}
