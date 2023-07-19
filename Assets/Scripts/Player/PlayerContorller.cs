using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerContorller : MonoBehaviour
{
    [SerializeField]
    private Rigidbody rb;
    [SerializeField]
    private Camera cam;
    private Vector3 velocity = Vector3.zero; // 速度：每秒移动的距离
    private Vector3 yRotation = Vector3.zero; // 旋转角色
    private Vector3 xRotation = Vector3.zero; //旋转视角

    // Start is called before the first frame update
    public void Move(Vector3 _velocity)
    {
        velocity = _velocity;
    }
    public void Rotate(Vector3 _yRotatiom , Vector3 _xRotation)
    {
        yRotation = _yRotatiom;
        xRotation = _xRotation;
    }
    private void PerformMovement()
    {
        if(velocity !=Vector3.zero)
        {
            rb.MovePosition(rb.position + velocity * Time.fixedDeltaTime);
        }
    }
    private void PerformRotation()
    {
        if (yRotation != Vector3.zero)
        {
            rb.transform.Rotate(yRotation);
        }

        if (xRotation != Vector3.zero)
        {
            cam.transform.Rotate(xRotation);
        }
    }
    private void FixedUpdate()
    {
        PerformMovement();  
        PerformRotation();
    }
}
