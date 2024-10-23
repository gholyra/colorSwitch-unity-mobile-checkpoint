using UnityEngine;

public class StarPoint : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            GameManager.Instance.SumPlayersPoints();
            Destroy(this.gameObject);
        }
    }
}
