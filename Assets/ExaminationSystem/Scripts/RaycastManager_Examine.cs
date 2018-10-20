using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class RaycastManager_Examine : MonoBehaviour
{
    private GameObject raycastedObj;

    [Tooltip("Change this value to increase/decrease the distance at which you can interact with an object")]
    [SerializeField] private float rayLength = 10;

    [Tooltip("Add the interaction layer from the dropdown, usually 'interact'. If not, create it")]
    [SerializeField] private LayerMask layerMaskInteract;

    [Tooltip("Add the crosshair image from the canvas here")]
    [SerializeField] private Image uiCrosshair;

    private bool isCrosshairActive;
    [HideInInspector]public bool interacting;

    void Update()
    {
        RaycastHit hit;
        Vector3 fwd = transform.TransformDirection(Vector3.forward);

        if(Physics.Raycast(transform.position, fwd, out hit, rayLength, layerMaskInteract.value))
        {
            if (hit.collider.CompareTag("PickupObj"))
            {
                if (!interacting)
                {
                    raycastedObj = hit.collider.gameObject;
                    CrosshairActive();
                    isCrosshairActive = true;
                }

                if(Input.GetMouseButtonDown(0))
                {
                    interacting = true;
                    raycastedObj.GetComponent<InteractObject>().ExamineObject(true);
                }
            }
        }

        else
        {
            if (isCrosshairActive)
            {
                CrosshairNormal();
            }
        }
    }

    void CrosshairActive()
    {
        uiCrosshair.color = Color.red;
        raycastedObj.GetComponent<InteractObject>().MainHighlight(true);
    }

    void CrosshairNormal()
    {
        uiCrosshair.color = Color.white;
        isCrosshairActive = false;
        raycastedObj.GetComponent<InteractObject>().MainHighlight(false);
    }
}
