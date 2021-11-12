using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputAnimController : MonoBehaviour
{

    private Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    public void ActivateAnimation()
    {
        animator.SetBool("is_active", true);
    }

    public void ActivateBackAnimation()
    {
        animator.SetBool("is_active", false);
    }

    public void ActivateAnimation2()
    {
        animator.SetBool("is_active2", true);
    }

    public void ActivateBackAnimation2()
    {
        animator.SetBool("is_active2", false);
    }

    public void ActivateAnimation3()
    {
        animator.SetBool("is_active3", true);
    }

    public void ActivateSlideOut()
    {
        animator.SetBool("is_active4", true);
    }
}
