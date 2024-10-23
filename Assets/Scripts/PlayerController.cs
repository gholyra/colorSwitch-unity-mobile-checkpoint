using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public static PlayerController Instance;
    
    [SerializeField] private float jumpForce;
    [SerializeField] private Color[] colors;
    
    private Rigidbody2D rigidBody;
    private SpriteRenderer spriteRenderer;
    
    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        rigidBody = GetComponent<Rigidbody2D>();
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    private void Start()
    {
        this.spriteRenderer.color = colors[Random.Range(0, colors.Length)];
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            Debug.Log(rigidBody.velocity);
            rigidBody.velocity = new Vector2(rigidBody.velocity.x, jumpForce);
        }
    }

    public SpriteRenderer GetSpriteRenderer()
    {
        return this.spriteRenderer;
    }
    
    public void OnWallOrGroundCollision()
    {
        UIManager.Instance.SetGameOverScreen(true);
        Destroy(this.gameObject);
    }
}
