using System.Collections.Generic;
using UnityEngine;

public class SpinningObstacle : MonoBehaviour
{
    [SerializeField] private List<GameObject> obstacleWalls;
    [SerializeField] private List<Color> colors;
    [SerializeField] private float spinningVelocity;
    
    private Rigidbody2D rigidBody;
    
    private void Awake()
    {
        rigidBody = GetComponent<Rigidbody2D>();
    }

    private void Start()
    {
        for (int i = 0; i < obstacleWalls.Count; i++)
        {
            int colorIndex = Random.Range(0, colors.Count);
            obstacleWalls[i].GetComponent<SpriteRenderer>().color = colors[colorIndex];
            colors.Remove(colors[colorIndex]);
        }
    }

    private void Update()
    {
        transform.Rotate(new Vector3(0f, 0f, 1f) * spinningVelocity * Time.deltaTime);
    }

}
