using System.Collections;
using System.Collections.Generic;
using Cinemachine;
using StarterAssets;
using UnityEngine;

public class WeaponZoom : MonoBehaviour
{
    //[SerializeField] private CinemachineVirtualCamera FPSCamera;
    //[SerializeField] private float zoomedOutFOV = 60;
    //[SerializeField] private float zoomedInFOV = 20;
    [SerializeField] private Animator animator;
    [SerializeField] private float ZoomOutSensitivity =1f;
    [SerializeField] private float ZoomInSensitivity = 0.25f;
    [SerializeField] private FirstPersonController fpsController;
    private bool zoomedInToggle = false;
    // Start is called before the first frame update
    void Start()
    {
        // fpsController = GetComponent<FirstPersonController>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(1))
        {
            if (!zoomedInToggle)
            {
                zoomedInToggle = true;
                fpsController.RotationSpeed = ZoomInSensitivity;
                //FPSCamera.m_Lens.FieldOfView = zoomedInFOV;
                animator.SetBool("isZoomed", true);
            }
            else
            {
                zoomedInToggle = false;
                fpsController.RotationSpeed = ZoomOutSensitivity;
                //FPSCamera.m_Lens.FieldOfView = zoomedOutFOV;
                animator.SetBool("isZoomed", false);
            }
        }
    }
}
