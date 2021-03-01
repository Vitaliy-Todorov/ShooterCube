using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Motion : MonoBehaviour
{
    private static bool click;
    private static float moveHorizontal;
    private static float moveVertical;

    // Start is called before the first frame update
    public static void HorizontalVertical(Transform transform, float speed)
    {
        moveHorizontal = 0.0f;
        moveVertical = 0.0f;
        if (Input.GetAxis("Horizontal") != 0.0f && click)
        {
            click = false;
            moveHorizontal = Input.GetAxis("Horizontal");
        }
        if (Input.GetAxis("Horizontal") == 0.0f)
        {
            click = true;
        }
        if (Input.GetAxis("Vertical") != 0.0f && click)
        {
            click = false;
            moveVertical = Input.GetAxis("Vertical");
        }
        if (Input.GetAxis("Vertical") == 0.0f)
        {
            click = true;
        }

        Vector3 movement = new Vector3(moveHorizontal, 0, moveVertical);

        transform.Translate(movement * speed * Time.fixedDeltaTime, Space.World);

        if (Input.GetKeyUp(KeyCode.Q))
        {
            transform.Rotate(0.0f, 90.0f, 0.0f);
        }
        if (Input.GetKeyUp(KeyCode.E))
        {
            transform.Rotate(0.0f, -90.0f, 0.0f);
        }
    }
}
