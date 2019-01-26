using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WheelView : MonoBehaviour
{
    public Transform wheelCircle;
    public void SetWheelRotation(Quaternion rotation)
    {
        wheelCircle.rotation = rotation;
    }
    public void ResetWheelRotation()
    {
        wheelCircle.eulerAngles = new Vector3(0f, 0f, 0f);
    }
}
