using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform target; // Мячик
    public Vector3 offset = new Vector3(0, 5, -8); // Смещение камеры
    public float smoothSpeed = 0.125f;

    void FixedUpdate()
    {
        if (target != null)
        {
            // Позиция, где должна быть камера
            Vector3 desiredPosition = target.position + offset;

            // Плавное движение камеры
            Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed);

            transform.position = smoothedPosition;

            // Камера всегда смотрит на мячик
            transform.LookAt(target);
        }
    }
}