using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    [SerializeField] private Transform playerTransform;
    [SerializeField] private float cameraDistance = 10f;
    [SerializeField] private float cameraHeight = 5f;
    [SerializeField] private float cameraDamping = 0.4f;

    [SerializeField] private Vector3 pivotOffset = new Vector3(0f, 1.5f, 0f);
    private Vector3 cameraVelocity;

    private void LateUpdate()
    {
        Vector3 cameraTargetPosition = playerTransform.position - playerTransform.forward * cameraDistance + Vector3.up * cameraHeight;
        transform.position = Vector3.SmoothDamp(transform.position, cameraTargetPosition, ref cameraVelocity, cameraDamping);
        transform.LookAt(playerTransform.position + pivotOffset);
    }
}