using UnityEngine;
using Microsoft.MixedReality.Toolkit.Experimental.UI;
using UnityEngine.UI;

public class ShowInput : MonoBehaviour
{
    // キーボードを宣言
    UnityEngine.TouchScreenKeyboard keyboard;
    // 入力内容を格納する変数を宣言
    public static string keyboardText = "";

    // テキスト表示用変数を宣言
    public Text TextFrame;


    public void OnShowKeyboard()
    {
        // キーボードの出現
        keyboard = TouchScreenKeyboard.Open("名前を入力", TouchScreenKeyboardType.ASCIICapable);
        // 入力内容を変数に格納
        keyboardText = keyboard.text;

    }
}