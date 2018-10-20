using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class InteractObject : MonoBehaviour
{
	[Header ("Interactable Item")]
    public string ItemName;                 //The name of the item

    [Header ("Use this for autotagging objects")]
    [SerializeField] private bool autoTag;
    [SerializeField] private string tagName;

    [Header("Reference")]
    public GameObject ExaminableObject;

    private Text itemNameText;
    private bool Examined;                  
    private bool Interactable;             
    [HideInInspector] public Material thisMat;


    void Start()
    {
        itemNameText = GameObject.FindGameObjectWithTag("ItemName").GetComponent<Text>(); //Finding the text UI inside the canvas with a particular tag
        thisMat = GetComponent<Renderer>().material; //Getting the material renderer for the material currently on the gameobject
        thisMat.DisableKeyword("_EMISSION"); //Disabling the emissive values at the start

        if (autoTag)
        {
            gameObject.tag = tagName; //Autotag if you want let the script automatically tag your objects - NOT REQUIRED
        }
    }

    public void MainHighlight(bool isHighlighted) //This enables and disables the emission on the said material
    {
        if (isHighlighted)
        {
            thisMat.EnableKeyword("_EMISSION");
        }

        else
        {
            thisMat.DisableKeyword("_EMISSION");
        }
    }

    public void ExamineObject(bool isExamined)
    {
        if (isExamined)
        {
            Examined = true;
            ExamineAudioManager.instance.InteractSound(1); //Remove this if you want to use your own audio manager, but it just plays the audio in the current manager
            ExaminableObject.SetActive(true);

            if (Examined)
            {
                itemNameText.text = ItemName;
            }
        }

        else
        {
            Examined = false;
            itemNameText.text = null;
        }
    }
}