using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    public int totalCoins = 0;
    public int collectedCoins = 0;

    [SerializeField] private TextMeshProUGUI coinText;
    [SerializeField] private TextMeshProUGUI finishText;
    [SerializeField] private GameObject finishTrigger;
    [SerializeField] private string nextLevelName = "Level2";

    void Awake()
    {
        if (Instance == null)
            Instance = this;
        else
            Destroy(gameObject);
    }

    void Start()
    {
        totalCoins = FindObjectsByType<Coin>(FindObjectsSortMode.None).Length;

        if (finishTrigger != null)
            finishTrigger.SetActive(false);
        if (finishText != null)
            finishText.text = "";

        UpdateUI();
    }

    public void CollectCoin()
    {
        collectedCoins++;
        UpdateUI();

        if (collectedCoins >= totalCoins)
        {
            OpenFinish();
        }
    }

    private void OpenFinish()
    {
        if (finishTrigger != null)
            finishTrigger.SetActive(true);
        if (finishText != null)
            finishText.text = "Финиш открыт!";
    }

    public void ReachFinish()
    {
        SceneManager.LoadScene(nextLevelName);
    }

    private void UpdateUI()
    {
        if (coinText != null)
            coinText.text = $"Монеты: {collectedCoins}/{totalCoins}";
    }
}