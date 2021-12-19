using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoalInfoSetting : MonoBehaviour
{
    [SerializeField] GameObject Goal;
    [SerializeField] GameObject UnityChan;
    [SerializeField] GameObject ReButton;
    [SerializeField] GameObject SetButtons;
    [SerializeField] GameObject Alert;

    public void DistanceCheck()
    {
        Vector3 posA = Goal.transform.position;
        Vector3 posB = UnityChan.transform.position;
        float dis = Vector3.Distance(posA, posB);
        Debug.Log("‹——£ : " + dis);
        if(dis < 1.0)
        {
            ReButton.SetActive(true);
            Alert.SetActive(true);
        } else
        {
            SetButtons.SetActive(true);
        }
    }
}
