using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    bool canMove = true;

    [SerializeField] float moveSpeed;
    [SerializeField] float maxPos;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(canMove)
        {
            Move();
        }
    }

    void Move()
    {
        float inputX = Input.GetAxis("Horizontal");
        transform.position += Vector3.right * moveSpeed * inputX * Time.deltaTime;

        float posX = Mathf.Clamp(transform.position.x, -maxPos, maxPos);
        transform.position = new Vector3(posX, transform.position.y, transform.position.z);
    }
}
