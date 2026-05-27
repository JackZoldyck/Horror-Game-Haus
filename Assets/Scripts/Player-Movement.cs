using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 5f;

    private CharacterController controller;

    void Start()
    {
        controller = GetComponent<CharacterController>();
    }

    void Update()
    {
        // Eingaben holen
        float moveX = Input.GetAxis("Horizontal"); // A / D
        float moveZ = Input.GetAxis("Vertical");   // W / S

        // Bewegungsrichtung
        Vector3 move = transform.right * moveX + transform.forward * moveZ;

        // Bewegung anwenden
        controller.Move(move * speed * Time.deltaTime);
    }
}