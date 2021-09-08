using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class c_PlayerController : MonoBehaviour
{
    [SerializeField] GameObject player;
    private Rigidbody2D rbPlayer;

    [SerializeField] float moveSpeed;
    [SerializeField] float defaultMoveSpeed;
    [SerializeField] float turnRate;
    [SerializeField] float defaultTurnRate;

    [SerializeField] float boostMultiplier;
    [SerializeField] float defaultBoostMultiplier;

    [SerializeField] float warpDistance;
    [SerializeField] float defaultWarpDistance;

    // Start is called before the first frame update
    void Start()
    {
        rbPlayer = GetComponent<Rigidbody2D>();
        moveSpeed = defaultMoveSpeed;
        boostMultiplier = defaultBoostMultiplier;

    }

    private void Update()
    {
        //Input system
        #region Movement System

        //Move up
        if (Input.GetAxis("Vertical") != 0) 
        {
            MovePlayer(new Vector2(0, Input.GetAxis("Vertical")));
        }

        if (Input.GetAxis("Horizontal") != 0)
        {
            MovePlayer(new Vector2(Input.GetAxis("Horizontal"), 0));
        }

        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            boostMultiplier = 2;
        }
        #endregion



        #region Shooting System

        //Shoot the gun when the left mouse button is clicked
        if (Input.GetMouseButton(0))
        {
            Debug.Log("Shoot");
        }

        //Focus fire by pressing the right mouse button
        if (Input.GetMouseButton(1))
        {
            Debug.Log("Focus fire"); //Zoom camera in?
        }
        #endregion
    }

    void MovePlayer(Vector2 deltaMove)
    {
        rbPlayer.velocity += deltaMove * (1/moveSpeed) * boostMultiplier * Time.deltaTime;
        Debug.Log(rbPlayer.velocity);
    }
}
