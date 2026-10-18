using UnityEngine;

public class MyCamera : MonoBehaviour
{
    public Transform myPlayer;
    public float mySmooth = 0.125f;
    public Vector3 myOffset = new Vector3(10, 3, 0); // Камера справа

    void LateUpdate()
    {
        if (myPlayer != null)
        {
            // Камера следит по Y (высота), по Z (глубина), X фиксирован
            Vector3 pos = new Vector3(myOffset.x, myPlayer.position.y + myOffset.y, myPlayer.position.z + myOffset.z);

            transform.position = Vector3.Lerp(transform.position, pos, mySmooth);
            transform.rotation = Quaternion.Euler(0, -90, 0); // Смотрим слева направо
        }
    }
}