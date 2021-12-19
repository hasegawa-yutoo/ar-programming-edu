using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoalCheck : MonoBehaviour
{
    [SerializeField] GameObject NextButton;
    [SerializeField] GameObject Correct;
    private Animator animator;

    void Start()
    {
        animator = GetComponent<Animator>();
    }

    void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.name == "Goal")
        {
            NextButton.SetActive(true);
            Correct.SetActive(true);
        }
    }
}
