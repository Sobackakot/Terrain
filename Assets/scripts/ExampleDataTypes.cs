using TMPro; 
using UnityEngine;
using UnityEngine.UI;

public class ExampleDataTypes : MonoBehaviour
{
    [Header("--------------- Objets data types ---------------")]

    [SerializeField] private GameObject myObject;
    [SerializeField] private Camera myCamera;
    [SerializeField] private AudioSource mySource;
    [SerializeField] private Light myLight;
    [SerializeField] private ParticleSystem myParticl;
    [SerializeField] private TextMeshProUGUI myText;
    [SerializeField] private TMP_InputField myInputField;
    [SerializeField] private Button myButton;
    [SerializeField] private Sprite mySprite;
    [SerializeField] private Image myImage;
     
    [Header("--------------- Components data types ---------------")]

    [SerializeField] private Transform myTransform;
    [SerializeField] private Collider myCollider;
    [SerializeField] private Rigidbody myRigidbody;
    [SerializeField] private Material myMaterial;
    [SerializeField] private MeshRenderer myMeshRenderer; 
    [SerializeField] private Texture myTexture; 
    [SerializeField] private AudioClip myAoudio;
    [SerializeField] private Animation myAnimation; 

    [Header("--------------- Complex data types ---------------")]

    [SerializeField] private Vector3 myPosition;
    [SerializeField] private Vector2 my2DPosition;
    [SerializeField] private Quaternion myRotation; 
    [SerializeField] private Color myColor;
    [SerializeField] private LayerMask myLayerMask;

    [Header("--------------- Simple data types ---------------")]

    [SerializeField] private string text = " ";
    [SerializeField] private char myChar = ' ';
    [SerializeField] private int myNumber = 0;
    [SerializeField] private float myCount = 0f;
    [SerializeField] private bool isHas = false;


    public void Start()
    {
        isHas = false;
        myTransform.position = new Vector3 (0, 0, 0);

        myTransform.rotation = new Quaternion(0,0,0,1f); 

        myTransform.localScale = new Vector3(0,0,0);
    }
    public void Update ()
    {

    } 
}
