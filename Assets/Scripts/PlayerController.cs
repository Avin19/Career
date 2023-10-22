using System.Collections;
using System.Collections.Generic;


using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private Animator animator;
    [SerializeField] float movSpeed = 5f;
    [SerializeField] float rotateSpeed = 10f;
    private void Awake()
    {
        animator = transform.Find("Aj").GetComponent<Animator>();
    }

    private void Update()
    {

        Movement();

    }
    private void Movement()
    {
        float xAisx = Input.GetAxisRaw("Horizontal");
        float zAxis = Input.GetAxisRaw("Vertical");
        Vector3 movDir = new Vector3(xAisx, 0f, zAxis);
        transform.position += movSpeed * Time.deltaTime * movDir;
        if (movDir != Vector3.zero)
        {
            animator.SetTrigger("Running");
            Quaternion toRotate = Quaternion.LookRotation(movDir, Vector3.up);
            transform.rotation = Quaternion.RotateTowards(transform.rotation, toRotate, -rotateSpeed * Time.deltaTime);
        }
        else
        {
            animator.SetTrigger("Idle");
            
        }

    }

}
