using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;
using UnityEngine.SceneManagement;
using TMPro;
using UnityEngine.UI;

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

        [SerializeField] private GameObject correct;
        [SerializeField] private GameObject incorrect;
        [SerializeField] private GameObject nextButton;
        [SerializeField] private GameObject prevButton;
        [SerializeField] private GameObject tips;
        [SerializeField] private TextMeshProUGUI tipsText;
        [SerializeField] private GameObject console;
        [SerializeField] private TextMeshProUGUI consoleText;


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

            // �C���X�^���X��
            if (SceneManager.GetActiveScene().name == "LoopScene")
            {
                this.Default = FindObjectOfType<InputDefault>();
                this.MaxCount = FindObjectOfType<InputIf>();
                this.Increment = FindObjectOfType<InputIncrement>();
                if (Increment.YourIncrement == "++" || Increment.YourIncrement == "�{�{")
                {
                    count = MaxCount.YourIf - Default.YourDefault;
                    StartCoroutine("ShowConsole");
                }
                else
                {
                    count = 0;
                }
            }

            Invoke(nameof(StopRun), count);
            Invoke(nameof(ShowForTips), count);
            if (count == 5 && Increment.YourIncrement == "++" || Increment.YourIncrement == "�{�{")
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

            // �C���X�^���X��
            if (SceneManager.GetActiveScene().name == "LoopScene2")
            {
                this.Zero = FindObjectOfType<Input01>();
                this.Second = FindObjectOfType<Input02>();
                this.Third = FindObjectOfType<Input03>();
                if(Second.YourSecond == "+" || Second.YourSecond == "�{")
                {
                    count = Zero.YourZero / Third.YourThird;
                    StartCoroutine("ShowConsole");
                } else
                {
                    count = 0;
                }
            }

            Invoke(nameof(StopRun), count);
            Invoke(nameof(ShowWhileTips), count);
            if (count == 4)
            {
                Invoke(nameof(CorrectActivate), count);
            }
            else
            {
                Invoke(nameof(IncorrectActivate), count);
            }
        }

        private IEnumerator ShowConsole()
        {
            console.SetActive(true);
            consoleText.text = "<b>�R���\�[��</b>\n";
            int second = 0;
            while (second < count)
            {
                yield return new WaitForSeconds(1);
                second++;
                consoleText.text += second + "\n";
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

        void ShowWhileTips()
        {
            tips.SetActive(true);
            if (Zero.YourZero <= 0)
            {
                tipsText.text = "<size=42><b>Unity�����͑���܂���ł����B</b></size>\n\n";
            } else
            {
                tipsText.text = "<size=42><b>Unity������" + count + "�b�ԑ���܂����B</b></size>\n\n";
            }

            if(count == 4)
            {
                tipsText.text += "���߂łƂ��������܂��I��r���Z�q���悭���Đ������邱�Ƃ��ł��܂����ˁB";
            } else
            {
                tipsText.text += "<b>TIPS</b>\n";
                if (Second.YourSecond == "+" || Second.YourSecond == "�{")
                {
                    if(Zero.YourZero <= 0)
                    {
                        tipsText.text += "�ϐ�second�̒l��0�̂��߈�x�����s����܂���ł����B�����������藧�悤�ɐ�����ς��Ă݂܂��傤�B";
                    } else
                    {
                        tipsText.text += "�ɂ����A���Ə����ł��B�S�񏈗������s����ɂ͂ǂ̂悤�ȏ����������藧���l���Ă݂܂��傤�B";
                    }
                } 
                else if(Second.YourSecond == "-" || Second.YourSecond == "�[")
                {
                    tipsText.text += "�������[�v�Ɋׂ��Ă��܂��܂����B������Z�q�u-=�v�͑�����������������܂��B�ł́A�����Ă�����r���Z�q�͉��ł��傤���H";
                } 
                else if (Second.YourSecond == "*" || Second.YourSecond == "��")
                {
                    tipsText.text += "�������[�v�Ɋׂ��Ă��܂��܂����B������Z�q�u*=�v�͑�����������������܂��B����̖��ł́A0��" + Third.YourThird + "��������̂ł����ƒl��0�ɂȂ��Ă��܂��܂��B�ł́A�����Ă�����r���Z�q�͉��ł��傤���H";
                }
                else if (Second.YourSecond == "/" || Second.YourSecond == "�^")
                {
                    tipsText.text += "�������[�v�Ɋׂ��Ă��܂��܂����B������Z�q�u/=�v�͑����������������܂��B����̖��ł́A0��" + Third.YourThird + "������̂ł����ƒl��0�ɂȂ��Ă��܂��܂��B�ł́A�����Ă�����r���Z�q�͉��ł��傤���H";
                }
                else if (Second.YourSecond == "%" || Second.YourSecond == "��")
                {
                    tipsText.text += "�������[�v�Ɋׂ��Ă��܂��܂����B������Z�q�u%=�v�͑�������������������]����o�͂��܂��B����̖��ł́A0��" + Third.YourThird + "������̂ł����ƒl��0�ɂȂ��Ă��܂��܂��B�ł́A�����Ă�����r���Z�q�͉��ł��傤���H";
                }
                else
                {
                    tipsText.text += "�u" + Second.YourSecond + "=�v���̎��͐��藧���܂���B�Z�p���Z�q���g�p���Ă��������B";
                }
            }
        }

        void ShowForTips()
        {
            tips.SetActive(true);
            if (count <= 0)
            {
                tipsText.text = "<size=42><b>Unity�����͑���܂���ł����B</b></size>\n\n";
            }
            else
            {
                tipsText.text = "<size=42><b>Unity������" + count + "�b�ԑ���܂����B</b></size>\n\n";
            }

            if (count == 5)
            {
                tipsText.text += "���߂łƂ��������܂��I�\�����悭���Đ������邱�Ƃ��ł��܂����ˁB";
            }
            else
            {
                tipsText.text += "<b>TIPS</b>\n";
                if (Increment.YourIncrement == "++" || Increment.YourIncrement == "�{�{")
                {
                    if (MaxCount.YourIf <= Default.YourDefault)
                    {
                        tipsText.text += "�ϐ�i�̒l��" + Default.YourDefault + "�ŏ��������藧���Ȃ����߈�x�����s����܂���ł����B�����������藧�悤�ɐ�����ς��Ă݂܂��傤�B";
                    }
                    else
                    {
                        tipsText.text += "�ɂ����A���Ə����ł��B5�񏈗������s����ɂ͂ǂ̂悤�ȏ����������藧���l���Ă݂܂��傤�B";
                    }
                }
                else if (Increment.YourIncrement == "--" || Increment.YourIncrement == "�[�[")
                {
                    tipsText.text += "�������[�v�Ɋׂ��Ă��܂��܂����B�u--�v�͑�����������������܂��B�ł́A�����Ă�����r���Z�q�͉��ł��傤���H";
                }
                else
                {
                    tipsText.text += "�u" + Increment.YourIncrement + "�v���̎��͐��藧���܂���B�C���N�������g�͂ǂ̂悤�ɋL�q���܂����H";
                }
            }
        }
    }

}