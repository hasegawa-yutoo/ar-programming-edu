using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UiSwitch : MonoBehaviour
{

    //renderer = gameObject.GetComponent<Renderer>();

    public void SwitchActive()
    {
        gameObject.SetActive(true);
    }

    public void SwitchInactive()
    {
        gameObject.SetActive(false);
    }

    //public void SwitchEnabled()
    //{
    //    renderer.enabled = true;
    //}

    //public void SwitchDisabled()
    //{
    //    renderert.enabled = false;
    //}

}
