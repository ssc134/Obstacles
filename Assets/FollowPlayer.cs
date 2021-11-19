using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    private Vector3 distanceFromPlayer = new Vector3(0, 1.5f, -5);
    void Start()
    {
        Debug.Log("Player MainCamera Initialised...");
        Transform playerTransform = GameObject.Find("Player").GetComponent<Transform>();
        Transform cameraTransform = GameObject.Find("MainCamera").GetComponent<Transform>();
        cameraTransform.position = playerTransform.position + distanceFromPlayer;
    }

    // Update is called once per frame
    void Update()
    {
        Transform playerTransform = GameObject.Find("Player").GetComponent<Transform>();
        Transform cameraTransform = GameObject.Find("MainCamera").GetComponent<Transform>();
        cameraTransform.position = playerTransform.position + distanceFromPlayer;
    }
}
