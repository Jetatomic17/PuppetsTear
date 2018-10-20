using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityStandardAssets.Characters.FirstPerson;
using UnityStandardAssets.ImageEffects;

public class DisableManager : MonoBehaviour
{
    [SerializeField] private Image crosshair;
    [SerializeField] private FirstPersonController player;
    [SerializeField] private RaycastManager_Examine raycastManager;
    //[SerializeField] private BlurOptimized blur;

    public static DisableManager instance;

    void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
    }

    public void DisableExamine(bool disable)
    {
        if (disable)
        {
            raycastManager.enabled = false;
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
           // blur.enabled = true;
            crosshair.enabled = false;
            player.enabled = false;
        }
        else
        {
            raycastManager.enabled = true;
            Cursor.lockState = CursorLockMode.Locked;
            Cursor.visible = false;
           // blur.enabled = false;
            crosshair.enabled = true;
            player.enabled = true;
        }
    }
}