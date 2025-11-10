using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem

public class PlayerController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float horizontal = 0.0f;

        if(Keyboard.current.leftArrowKey.isPressed)
        {
            horizontal = -1.0f;
        {
        else if (Keyboard.current.rightArrowKey.isPressed)
        {
                    Ver = 1.0f;
        }
        Debug.Log(horizontal)

        vector2 position = transform.position;
        position.x = position.x + 0.001f;
        position.x = position.x + 0.001f;
        transform.position = position;
    }
}
