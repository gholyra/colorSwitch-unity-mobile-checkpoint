using UnityEngine;

public class SpinningCircle : MonoBehaviour
{
    
    [SerializeField] private Color[] colors;
    
    private Rigidbody2D rigidBody;
    private SpriteRenderer spriteRenderer;
    
    private float radius;
    private float circumference;
    
    private void Awake()
    {
        rigidBody = GetComponent<Rigidbody2D>();
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    private void Start()
    {
        radius = transform.localScale.x / 2;
        circumference = CalcCircleCircumference();
    }

    private void Update()
    {
        transform.Rotate(new Vector3(0f, 0f, 360f) * 5f);
        Debug.Log(circumference/4);
        
        
    }

    private float CalcCircleCircumference()
    {
        float c = 2f * Mathf.PI * radius;
        return c;
    }
}
