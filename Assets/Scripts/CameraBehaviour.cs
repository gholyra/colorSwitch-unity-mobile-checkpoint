using UnityEngine;

public class CameraBehaviour : MonoBehaviour
{
    private float highestYValue;
    
    private void Update()
    {
        if (PlayerController.Instance)
        {
            CheckHigherYValue();
        }
        transform.position = new Vector3(transform.position.x, highestYValue, transform.position.z);
    }

    private void CheckHigherYValue()
    {
        if (PlayerController.Instance.transform.position.y > highestYValue)
            highestYValue = PlayerController.Instance.transform.position.y;
    }
}
