using UnityEngine;

public class DeathGround : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.gameObject.CompareTag("Player"))
        {
            PlayerController.Instance.OnWallOrGroundCollision();
        }
    }
}
