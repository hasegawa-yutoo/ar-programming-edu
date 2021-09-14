using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UiSwitch : MonoBehaviour
{

    void Start()
    {
        gameObject.SetActive(false);
    }

    public void SwitchActive()
    {
        gameObject.SetActive(true);
    }

    public void SwitchInactive()
    {
        gameObject.SetActive(false);
    }

}
