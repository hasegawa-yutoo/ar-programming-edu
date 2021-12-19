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
        private int Up = 0;
        private int Down = 0;
        private int Left = 0;
        private int Right = 0;
        [SerializeField] GameObject CompleteButton;
        [SerializeField] GameObject AgainButton;

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
                if(Up != 1)
                {
                    Up++;
                }
                if (CompleteButton && AgainButton)
                {
                    CompleteIfTutorial();
                }
            }
            if (keyDown)
            {
                transform.position -= transform.forward * speed * Time.deltaTime;
                animator.SetBool("is_back", true);
                if(Down != 1)
                {
                    Down++;
                }
                if (CompleteButton && AgainButton)
                {
                    CompleteIfTutorial();
                }
            }
            if (keyLeft)
            {
                transform.Rotate(new Vector3(0, -1.0f, 0));
                if(Left != 1)
                {
                    Left++;
                }
                if (CompleteButton && AgainButton)
                {
                    CompleteIfTutorial();
                }
            }
            if (keyRight)
            {
                transform.Rotate(new Vector3(0, 1.0f, 0));
                if(Right != 1)
                {
                    Right++;
                }
                if (CompleteButton && AgainButton)
                {
                    CompleteIfTutorial();
                }
            }
        }

        void CompleteIfTutorial()
        {
            if(Up == 1 && Down == 1 && Left == 1 && Right == 1)
            {
                CompleteButton.SetActive(true);
                AgainButton.SetActive(true);
            }
        }

        public void keepUp()
        {
            keyUp = true;
            animator.SetBool("is_running", true);
        }
        public void endUp()
        {
            keyUp = false;
            animator.SetBool("is_running", false);
        }

        public void keepDown()
        {
            keyDown = true;
            animator.SetBool("is_back", true);
        }
        public void endDown()
        {
            keyDown = false;
            animator.SetBool("is_back", false);
        }

        public void keepLeft()
        {
            keyLeft = true;
        }
        public void endLeft()
        {
            keyLeft = false;
            animator.SetBool("is_running", false);
        }

        public void keepRight()
        {
            keyRight = true;
        }
        public void endRight()
        {
            keyRight = false;
            animator.SetBool("is_running", false);
        }
    }

}