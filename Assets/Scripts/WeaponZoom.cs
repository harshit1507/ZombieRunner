using System.Collections;
using System.Collections.Generic;
using Cinemachine;
using UnityEngine;

public class WeaponZoom : MonoBehaviour
{
    [SerializeField] private CinemachineVirtualCamera FPSCamera;
    [SerializeField] private float zoomedOutFOV = 60;
    [SerializeField] private float zoomedInFOV = 20;
    [SerializeField] private Animator animator;

    private bool zoomedInToggle = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(1))
        {
            if (!zoomedInToggle)
            {
                zoomedInToggle = true;
                //FPSCamera.m_Lens.FieldOfView = zoomedInFOV;
                animator.SetBool("isZoomed", true);
            }
            else
            {
                zoomedInToggle = false;
                //FPSCamera.m_Lens.FieldOfView = zoomedOutFOV;
                animator.SetBool("isZoomed", false);
            }
        }
    }
}
