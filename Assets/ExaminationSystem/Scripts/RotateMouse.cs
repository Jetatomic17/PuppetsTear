using UnityEngine;
using System.Collections;

public class RotateMouse : MonoBehaviour
{
    [SerializeField] private InteractObject examineObject;

    [Tooltip("Speed of Horizontal movement when rotating an object")]
    [SerializeField] private float horizontalSpeed = 5.0F;

    [Tooltip("Speed of Vertical movement when rotating an object")]
    [SerializeField] private float verticalSpeed = 5.0F;

    private Vector3 startPos;
    private bool doOnce;
    private Material thisMat;
    private RaycastManager_Examine raycastManager;

    void Start()
    {
        startPos = this.gameObject.transform.localEulerAngles;
        doOnce = false;
        raycastManager = GameObject.FindGameObjectWithTag("MainCamera").GetComponent<RaycastManager_Examine>();
        thisMat = GetComponent<Renderer>().material;
        thisMat.DisableKeyword("_EMISSION");
    }

    void Update()
    {
        if (this.gameObject.activeSelf && !doOnce)
        {
            DisableManager.instance.DisableExamine(true);
            doOnce = true;

            if (doOnce)
            {
                this.gameObject.transform.localEulerAngles = startPos;
            }
        }

        float h = horizontalSpeed * Input.GetAxis("Mouse X"); //This is the rotation control for mouse input, you can change this if you need another input style
        float v = verticalSpeed * Input.GetAxis("Mouse Y");

        if (Input.GetMouseButton(0))
        {
            this.gameObject.transform.Rotate(v, h, 0); //On left click held down we perform the rotation of the object
        }

        else if(Input.GetMouseButtonDown(1)) //When we right click we enable all player functionality once again
        {
            DisableManager.instance.DisableExamine(false);
            examineObject.ExamineObject(false);
            doOnce = false;
            raycastManager.interacting = false;
            this.gameObject.SetActive(false);
        }
    }
}
