using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;
using UnityEngine.SceneManagement;

namespace UnityStandardAssets.Characters.ThirdPerson
{
    public class ThirdPersonRunController : MonoBehaviour
    {
        
        private InputDefault Default;
        private InputIf MaxCount;
        private InputIncrement Increment;
    
        private Input01 Zero;
        private Input02 Second;
        private Input03 Third;

        private Animator animator;
        private bool flag = false;
        private float speed = 0.3f;

        public GameObject correct;
        public GameObject incorrect;
        public GameObject nextButton;
        public GameObject prevButton;

        int count;

        void Start()
        {
            animator = GetComponent<Animator>();
        }

        void Update()
        {
            if (flag)
            {
                transform.position += transform.forward * speed * Time.deltaTime;
                animator.SetBool("is_running", true);
            }
        }

        public void Run()
        {
            flag = true;
            animator.SetBool("is_running", true);

            // インスタンス化
            if (SceneManager.GetActiveScene().name == "LoopScene")
            {
                this.Default = FindObjectOfType<InputDefault>();
                this.MaxCount = FindObjectOfType<InputIf>();
                this.Increment = FindObjectOfType<InputIncrement>();
                count = MaxCount.YourIf - Default.YourDefault;
            }

            Invoke(nameof(StopRun), count);
            if(count == 5 && Increment.YourIncrement == "++")
            {

                Invoke(nameof(CorrectActivate), count);
            } else
            {
                Invoke(nameof(IncorrectActivate), count);
            }
        }

        public void RunWhile()
        {
            flag = true;
            animator.SetBool("is_running", true);

            // インスタンス化
            if (SceneManager.GetActiveScene().name == "LoopScene2")
            {
                this.Zero = FindObjectOfType<Input01>();
                this.Second = FindObjectOfType<Input02>();
                this.Third = FindObjectOfType<Input03>();
                if(Second.YourSecond == "+")
                {
                    count = Zero.YourZero / Third.YourThird;
                } else
                {
                    count = 0;
                }
            }

            Invoke(nameof(StopRun), count);
            if (count == 4)
            {

                Invoke(nameof(CorrectActivate), count);
            }
            else
            {
                Invoke(nameof(IncorrectActivate), count);
            }
        }

        void StopRun()
        {
            flag = false;
            animator.SetBool("is_running", false);
        }

        void CorrectActivate()
        {
            correct.SetActive(true);
            nextButton.SetActive(true);
        }

        void IncorrectActivate()
        {
            incorrect.SetActive(true);
            prevButton.SetActive(true);
        }
    }

}