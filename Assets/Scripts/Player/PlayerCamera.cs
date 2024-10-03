using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform player; // referensi ke pemain
    public Vector3 offset;   // jarak antara kamera dan pemain

    void Update()
    {
        if (player != null)
        {
            // Update posisi kamera sesuai dengan posisi pemain ditambah offset
            transform.position = new Vector3(player.position.x + offset.x, player.position.y + offset.y, offset.z);
        }
    }
}
