using UnityEngine;
using UnityEngine.InputSystem;

public class P1 : MonoBehaviour
{
    public float moveSpeed = 5f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        bool isPressingUp = Keyboard.current.wKey.isPressed;
        bool isPressingDown = Keyboard.current.sKey.isPressed;

        if (isPressingUp)
        {
            transform.position += Vector3.up * moveSpeed * Time.deltaTime;
        }
        if (isPressingDown)
        {
            transform.position += Vector3.down * moveSpeed * Time.deltaTime;
        }
    }
}
