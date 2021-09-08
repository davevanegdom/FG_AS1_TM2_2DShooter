using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class c_CameraManager : MonoBehaviour
{
    public GameObject player;
    private Camera mCamera;

    [SerializeField] float cameraDefaultMovespeed;
    [SerializeField] float cameraMinMoveSpeed;
    [SerializeField] float cameraMaxMoveSpeed;

    [SerializeField] float cameraDefaultSize;
    [SerializeField] float cameraMaxSize;
    [SerializeField] float cameraMinSize;


    // Start is called before the first frame update
    void Start()
    {
        mCamera = Camera.main;
        mCamera.orthographicSize = cameraDefaultSize;
    }

    // Update is called once per frame
    void Update()
    {
        FollowPlayer();
    }

    void FollowPlayer()
    {

    }
}
