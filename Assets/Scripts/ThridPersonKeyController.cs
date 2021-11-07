using System;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

namespace UnityStandardAssets.Characters.ThirdPerson
{
    public class ThridPersonKeyController : MonoBehaviour
    {
        //private ThirdPersonCharacter m_Character; // A reference to the ThirdPersonCharacter on the object
        //private Transform m_Cam;                  // A reference to the main camera in the scenes transform
        //private Vector3 m_CamForward;             // The current forward direction of the camera
        //private Vector3 m_Move;
        //private bool m_Jump;                      // the world-relative desired move direction, calculated from the camForward and user input.
        public float speed = 0.3f;
        bool keyUp;
        bool keyDown;
        bool keyLeft;
        bool keyRight;
        private Animator animator;

        void Start()
        {
            animator = GetComponent<Animator>();
        }

        void Update()
        {
            if(keyUp)
            {
                transform.position += transform.forward * speed * Time.deltaTime;
                animator.SetBool("is_running", true);
            }
            if (keyDown)
            {
                transform.position += transform.forward * speed * Time.deltaTime;
                animator.SetBool("is_running", true);
            }
            if (keyLeft)
            {
                transform.position += transform.forward * speed * Time.deltaTime;
                animator.SetBool("is_running", true);
            }
            if (keyRight)
            {
                transform.position += transform.forward * speed * Time.deltaTime;
                animator.SetBool("is_running", true);
            }
        }

        public void keepUp()
        {
            keyUp = true;
            animator.SetBool("is_running", true);
            transform.rotation = Quaternion.identity;
        }
        public void endUp()
        {
            keyUp = false;
            animator.SetBool("is_running", false);
        }

        public void keepDown()
        {
            keyDown = true;
            animator.SetBool("is_running", true);
            transform.rotation = Quaternion.identity;
            transform.Rotate(0, 180, 0);
        }
        public void endDown()
        {
            keyDown = false;
            animator.SetBool("is_running", false);
        }

        public void keepLeft()
        {
            keyLeft = true;
            animator.SetBool("is_running", true);
            transform.rotation = Quaternion.identity;
            transform.Rotate(0, 270, 0);
        }
        public void endLeft()
        {
            keyLeft = false;
            animator.SetBool("is_running", false);
        }

        public void keepRight()
        {
            keyRight = true;
            animator.SetBool("is_running", true);
            transform.rotation = Quaternion.identity;
            transform.Rotate(0, 90, 0);
        }
        public void endRight()
        {
            keyRight = false;
            animator.SetBool("is_running", false);
        }
    }

}