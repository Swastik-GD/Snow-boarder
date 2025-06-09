using UnityEngine;

public class PlayerController : MonoBehaviour
{

    [SerializeField] float TorqueAmount = 1f;
    [SerializeField] float Basespeed = 20f;
    [SerializeField] float Boostspeed = 30f;
    bool canMove = true;

    SurfaceEffector2D surfaceEffector;
    Rigidbody2D rb2D;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb2D = GetComponent<Rigidbody2D>();
        surfaceEffector = FindAnyObjectByType<SurfaceEffector2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (canMove)
        {
            RotatePlayer();
            RespondToBoost();
        }
    }

    public void DisableMovement()
    {
        canMove = false;
    }

    void RespondToBoost()
    {
        if(Input.GetKey(KeyCode.UpArrow))
        {
            surfaceEffector.speed = Boostspeed;
        }

        else
        {
            surfaceEffector.speed = Basespeed;
        }
    }

    void RotatePlayer()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            rb2D.AddTorque(TorqueAmount);
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            rb2D.AddTorque(-TorqueAmount);
        }
    }
}

