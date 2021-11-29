using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectInfoSetting : MonoBehaviour
{
    /// <summary>
    /// �󂯎�����g�����X�t�H�[�����I�u�W�F�N�g�ɔ��f����
    /// </summary>
    /// <param name="a_transform"></param>
    public void SetTransform(Transform a_transform)
    {
        this.transform.SetPositionAndRotation(a_transform.position, a_transform.rotation);
    }
}
