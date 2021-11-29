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

            // インスタンス化
            if (SceneManager.GetActiveScene().name == "LoopScene")
            {
                this.Default = FindObjectOfType<InputDefault>();
                this.MaxCount = FindObjectOfType<InputIf>();
                this.Increment = FindObjectOfType<InputIncrement>();
                if (Increment.YourIncrement == "++" || Increment.YourIncrement == "＋＋")
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
            if (count == 5 && Increment.YourIncrement == "++" || Increment.YourIncrement == "＋＋")
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
                if(Second.YourSecond == "+" || Second.YourSecond == "＋")
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
            consoleText.text = "<b>コンソール</b>\n";
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
                tipsText.text = "<size=42><b>Unityちゃんは走りませんでした。</b></size>\n\n";
            } else
            {
                tipsText.text = "<size=42><b>Unityちゃんは" + count + "秒間走りました。</b></size>\n\n";
            }

            if(count == 4)
            {
                tipsText.text += "おめでとうございます！比較演算子をよく見て正解することができましたね。";
            } else
            {
                tipsText.text += "<b>TIPS</b>\n";
                if (Second.YourSecond == "+" || Second.YourSecond == "＋")
                {
                    if(Zero.YourZero <= 0)
                    {
                        tipsText.text += "変数secondの値は0のため一度も実行されませんでした。条件式が成り立つように数字を変えてみましょう。";
                    } else
                    {
                        tipsText.text += "惜しい、あと少しです。４回処理を実行するにはどのような条件式が成り立つか考えてみましょう。";
                    }
                } 
                else if(Second.YourSecond == "-" || Second.YourSecond == "ー")
                {
                    tipsText.text += "無限ループに陥ってしまいました。代入演算子「-=」は代入した数字を引きます。では、足していく比較演算子は何でしょうか？";
                } 
                else if (Second.YourSecond == "*" || Second.YourSecond == "＊")
                {
                    tipsText.text += "無限ループに陥ってしまいました。代入演算子「*=」は代入した数字をかけます。今回の問題では、0に" + Third.YourThird + "をかけるのでずっと値は0になってしまいます。では、足していく比較演算子は何でしょうか？";
                }
                else if (Second.YourSecond == "/" || Second.YourSecond == "／")
                {
                    tipsText.text += "無限ループに陥ってしまいました。代入演算子「/=」は代入した数字を割ります。今回の問題では、0に" + Third.YourThird + "を割るのでずっと値は0になってしまいます。では、足していく比較演算子は何でしょうか？";
                }
                else if (Second.YourSecond == "%" || Second.YourSecond == "％")
                {
                    tipsText.text += "無限ループに陥ってしまいました。代入演算子「%=」は代入した数字を割った余りを出力します。今回の問題では、0に" + Third.YourThird + "を割るのでずっと値は0になってしまいます。では、足していく比較演算子は何でしょうか？";
                }
                else
                {
                    tipsText.text += "「" + Second.YourSecond + "=」この式は成り立ちません。算術演算子を使用してください。";
                }
            }
        }

        void ShowForTips()
        {
            tips.SetActive(true);
            if (count <= 0)
            {
                tipsText.text = "<size=42><b>Unityちゃんは走りませんでした。</b></size>\n\n";
            }
            else
            {
                tipsText.text = "<size=42><b>Unityちゃんは" + count + "秒間走りました。</b></size>\n\n";
            }

            if (count == 5)
            {
                tipsText.text += "おめでとうございます！構文をよく見て正解することができましたね。";
            }
            else
            {
                tipsText.text += "<b>TIPS</b>\n";
                if (Increment.YourIncrement == "++" || Increment.YourIncrement == "＋＋")
                {
                    if (MaxCount.YourIf <= Default.YourDefault)
                    {
                        tipsText.text += "変数iの値は" + Default.YourDefault + "で条件が成り立たないため一度も実行されませんでした。条件式が成り立つように数字を変えてみましょう。";
                    }
                    else
                    {
                        tipsText.text += "惜しい、あと少しです。5回処理を実行するにはどのような条件式が成り立つか考えてみましょう。";
                    }
                }
                else if (Increment.YourIncrement == "--" || Increment.YourIncrement == "ーー")
                {
                    tipsText.text += "無限ループに陥ってしまいました。「--」は代入した数字を引きます。では、足していく比較演算子は何でしょうか？";
                }
                else
                {
                    tipsText.text += "「" + Increment.YourIncrement + "」この式は成り立ちません。インクリメントはどのように記述しますか？";
                }
            }
        }
    }

}