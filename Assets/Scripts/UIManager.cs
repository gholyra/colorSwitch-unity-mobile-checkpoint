using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    public static UIManager Instance;
    
    [SerializeField] private GameObject GameOverScreen;
    
    [SerializeField] private List<TextMeshProUGUI> playerPointsTexts;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
    }

    private void Start()
    {
        SetGameOverScreen(false);
    }

    private void Update()
    {
        foreach (TextMeshProUGUI playerPointsText in playerPointsTexts)
        {
            playerPointsText.text = GameManager.Instance.playerPoints.ToString();
        }
    }

    public void SetGameOverScreen(bool isGameOver)
    {
        GameOverScreen.SetActive(isGameOver);
    }
}
