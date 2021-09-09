using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionDetection : MonoBehaviour
{
    [SerializeField] GameObject correct;
    [SerializeField] GameObject incorrect;

    void OnCollisionEnter(Collision collision)
    {

        if (collision.gameObject.name == "variableInt")
        {
            correct.GetComponent<UiSwitch>().Switch();
        } else if((collision.gameObject.name == "variableString") || (collision.gameObject.name == "variableFloat")) {
            incorrect.GetComponent<UiSwitch>().Switch();
        }
    }
}
