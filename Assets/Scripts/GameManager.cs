using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;
    
    public int playerPoints { get; private set; }

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        playerPoints = 0;
    }

    public void SumPlayersPoints()
    {
        playerPoints++;
    }

    public void RestartGame()
    {
        SceneManager.LoadScene("GameScene");
    }
}
