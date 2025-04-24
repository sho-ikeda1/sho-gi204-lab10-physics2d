using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    Rigidbody2D rd2d;

    float move;
    [SerializeField] float speed;

       void Start()
    {
        rd2d = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        move = Input.GetAxis("Horizontal");

        rd2d.linearVelocity = new Vector2(move * speed, rd2d.linearVelocity.y);
    }
}
