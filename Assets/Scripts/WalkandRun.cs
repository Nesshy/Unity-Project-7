using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WalkandRun : MonoBehaviour
{
    [SerializeField] float jumpForce = 1f;
    Rigidbody rb;
    private Animator animator;
    public float rotationAmount = 90f;
    private Quaternion localRotation;
    public Vector3 characterPosition;


    void Start()
    {
        animator = GetComponent<Animator>();
        rb= GetComponent<Rigidbody>();
        rb.constraints = RigidbodyConstraints.FreezeRotationX | RigidbodyConstraints.FreezeRotationZ;

    }

    void Update()
    {
        Vector3 characterPosition = transform.position;

        if (Input.GetKeyDown(KeyCode.Space))
        {
            animator.SetBool("isJumping", true);
        }
        else
        {
            animator.SetBool("isJumping", false);

        }
        if(Input.GetKeyDown(KeyCode.Space)) 
        {
            GetComponent<BoxCollider>().transform.localPosition = characterPosition + Vector3.up*jumpForce;
        }
    }
    private void FixedUpdate()
    {
        if(Input.GetKey(KeyCode.W))
        {
            if (Input.GetKey(KeyCode.LeftShift))
            {
                animator.SetBool("isWalking", false);
                animator.SetBool("isRunning", true);
                transform.Translate(new Vector3(0f, 0f, 4f) * Time.deltaTime);
            }
            else
            {
                animator.SetBool("isRunning", false);
                animator.SetBool("isWalking", true);
                transform.Translate(new Vector3(0f, 0f, 2f) * Time.deltaTime);
            }
        }
        else
        {
            animator.SetBool("isWalking", false);
        }
    }
}
