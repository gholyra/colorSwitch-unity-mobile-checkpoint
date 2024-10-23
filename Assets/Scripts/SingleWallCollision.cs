using Unity.VisualScripting;
using UnityEngine;

public class SingleWallCollision : MonoBehaviour
{
    public static SingleWallCollision Instance;
    
    private BoxCollider2D wallCollider;
    private SpriteRenderer spriteRenderer;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        wallCollider = GetComponent<BoxCollider2D>();
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    private void Update()
    {
        if (spriteRenderer.color.ToHexString().Contains(PlayerController.Instance.GetSpriteRenderer().color.ToHexString()))
        {
            wallCollider.enabled = false;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            PlayerController.Instance.OnWallOrGroundCollision();
        }
    }
}
