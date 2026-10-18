using UnityEngine;

public class DeathZone : MonoBehaviour
{
    // Точка респавна
    private Vector3 spawnPoint = new Vector3(2, 3, -9);

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player") || other.CompareTag("Ball"))
        {
            // ТЕЛЕПОРТАЦИЯ
            other.transform.position = spawnPoint;

            // СБРОС СКОРОСТИ - самое важное!
            Rigidbody rb = other.GetComponent<Rigidbody>();
            if (rb != null)
            {
                rb.linearVelocity = Vector3.zero;
                rb.angularVelocity = Vector3.zero;
            }
        }
    }
}