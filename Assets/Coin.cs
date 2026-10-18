using UnityEngine;

public class Coin : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player") || other.CompareTag("Ball"))
        {
            // Уведомляем менеджер о сборе монеты
            GameManager.Instance.CollectCoin();

            // Уничтожаем монету
            Destroy(gameObject);
        }
    }
}