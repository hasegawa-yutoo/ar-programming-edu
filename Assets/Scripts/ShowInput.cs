using UnityEngine;
using Microsoft.MixedReality.Toolkit.Experimental.UI;
using UnityEngine.UI;

public class ShowInput : MonoBehaviour
{
    // �L�[�{�[�h��錾
    UnityEngine.TouchScreenKeyboard keyboard;
    // ���͓��e���i�[����ϐ���錾
    public static string keyboardText = "";

    // �e�L�X�g�\���p�ϐ���錾
    public Text TextFrame;


    public void OnShowKeyboard()
    {
        // �L�[�{�[�h�̏o��
        keyboard = TouchScreenKeyboard.Open("���O�����", TouchScreenKeyboardType.ASCIICapable);
        // ���͓��e��ϐ��Ɋi�[
        keyboardText = keyboard.text;

    }
}