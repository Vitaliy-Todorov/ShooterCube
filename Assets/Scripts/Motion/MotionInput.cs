using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MotionInput : MonoBehaviour
{
    private bool click;
    private Motion motion;

    private void Start()
    {
        motion = gameObject.GetComponent<Motion>();
    }

    private void FixedUpdate()
    {
        _ = motion;
        motion.horizontal = 0.0f;
        motion.vertical = 0.0f;
        if (Input.GetAxis("Horizontal") != 0.0f && click)
        {
            click = false;
            motion.horizontal = Input.GetAxis("Horizontal");
        }
        if (Input.GetAxis("Horizontal") == 0.0f)
        {
            click = true;
        }
        if (Input.GetAxis("Vertical") != 0.0f && click)
        {
            click = false;
            motion.vertical = Input.GetAxis("Vertical");
        }
        if (Input.GetAxis("Vertical") == 0.0f)
        {
            click = true;
        }

        motion.Move();
    }
}
