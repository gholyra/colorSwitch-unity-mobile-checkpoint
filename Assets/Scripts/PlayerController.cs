using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public static PlayerController Instance;
    
    private Rigidbody2D rigidBody;
    
    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        rigidBody = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            Debug.Log(rigidBody.velocity);
            rigidBody.velocity = new Vector2(rigidBody.velocity.x, 5f);
        }
    }

    public void OnDeathGroundCollision()
    {
        Destroy(this.gameObject);
    }
}
