using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class MovimientoJugador : MonoBehaviour
{


    public int playerNumber;
    public int playerHP;
    public bool buff = false;
    public bool debuff = false;

    



    [SerializeField] private float speed = 5f;
    [SerializeField] private float jumpingPower = 10f;
    [SerializeField] private Transform tf;
    private bool isFacingRight = true;
    private float horizontal;
    private float vertical;
    

    public LayerMask groundLayer;
    public Transform groundCheck;
    public Rigidbody2D rb;



    //public GameObject pickaxePrefab;





    void Update()
    {


        rb.velocity = new Vector2(horizontal * speed, rb.velocity.y);

        if (!isFacingRight && horizontal > 0f)
        {
            Flip();
        }

        else if (isFacingRight && horizontal < 0f)
        {
            Flip();
        }
    }


    public void Jump(InputAction.CallbackContext context)
    {
        if (context.performed && IsGrounded())
        {
            rb.velocity = new Vector2(rb.velocity.x, jumpingPower);
        }

        if (context.canceled && rb.velocity.y > 0f)
        {
            rb.velocity = new Vector2(rb.velocity.x, rb.velocity.y * 0.5f);
        }

    }



    private bool IsGrounded()
    {
        return Physics2D.OverlapCircle(groundCheck.position, 1f, groundLayer);

    }


    private void Flip()
    {

        isFacingRight = !isFacingRight;
        Vector3 localScale = transform.localScale;
        localScale.x *= -1f;
        transform.localScale = localScale;
    }


    public void Move(InputAction.CallbackContext context)
    {
        horizontal = context.ReadValue<Vector2>().x;
        vertical = context.ReadValue<Vector2>().y;
    }




    public void Mine(InputAction.CallbackContext context)
    {

        if (context.performed)
        {
            FindObjectOfType<Minar>().Pickaxe(isFacingRight, horizontal, vertical, tf, buff, debuff);

        }

    }



    public void Skill(InputAction.CallbackContext context)
    {
        if (context.performed)
        {
            //Rellenar de ah� con los valores necesarios
            FindObjectOfType<AtributosPowerups>().UsarGema(playerNumber);

        }
    }

}
