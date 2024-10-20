using System;
using UnityEngine;

public class CameraBehaviour : MonoBehaviour
{
    private float higherYValue;
    
    private void Update()
    {
        if (PlayerController.Instance)
        {
            CheckHigherYValue();
        }
        transform.position = new Vector3(transform.position.x, higherYValue, transform.position.z);
    }

    private void CheckHigherYValue()
    {
        if (PlayerController.Instance.transform.position.y > higherYValue)
            higherYValue = PlayerController.Instance.transform.position.y;
    }
}
