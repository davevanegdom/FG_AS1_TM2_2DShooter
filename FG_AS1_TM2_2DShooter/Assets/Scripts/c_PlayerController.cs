using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class c_PlayerController : MonoBehaviour
{
    [SerializeField] GameObject player;
    private Vector2 moveDirection;

    [SerializeField] float moveSpeed;
    [SerializeField] float defaultSpeed;
    [SerializeField] float turnRate;
    [SerializeField] float defaultTurnRate;

    [SerializeField] float boostMultiplier;
    [SerializeField] float defaultBoostMultiplier;

    [SerializeField] float warpDistance;
    [SerializeField] float defaultWarpDistance;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void Update()
    {
        //Input system
        #region Input

        //Move forward
        if (Input.GetKeyDown(KeyCode.W) || Input.GetKeyDown(KeyCode.UpArrow))
        {
            //Move
        }


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


}
