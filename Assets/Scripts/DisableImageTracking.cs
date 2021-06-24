using UnityEngine;
using UnityEngine.UI;
using UnityEngine.XR.ARFoundation;


public class DisableImageTracking : MonoBehaviour
{
    [SerializeField]
    private Camera ARcamera;
    [SerializeField]
    private Button toggleButton;
    [SerializeField]
    public Text text;

    [SerializeField]
    ARTrackedImageManager m_TrackedImageManager;

    public GameObject arSessionObject;
    private ARSession arSession;

    void OnEnable() => m_TrackedImageManager.trackedImagesChanged += OnChanged;

    void OnDisable() => m_TrackedImageManager.trackedImagesChanged -= OnChanged;

    private void Awake()
    {
        m_TrackedImageManager = GetComponent<ARTrackedImageManager>();
        arSession = arSessionObject.GetComponent<ARSession>();

        if (toggleButton != null)
        {
            toggleButton.onClick.AddListener(ListAllImages);
            toggleButton.onClick.AddListener(ResetSession);

        }
    }

    void ResetSession()  //resets the session when pushing the button, all detected images gets deleted an tracking gets enabled
    {
        //foreach (var image in m_TrackedImageManager.trackables)
            //image.gameObject.SetActive(false);



        arSession.Reset();
        Debug.Log("Session reset and tracking enabled");
        m_TrackedImageManager.enabled = true;
    }

    void OnChanged(ARTrackedImagesChangedEventArgs eventArgs) //if the marker is detected, tracking gets disabled
    {
        foreach (var newImage in eventArgs.added) 
        {
            // Handle added event
            Debug.Log("new Image detected, tracking disabled");
            m_TrackedImageManager.enabled = false;

            foreach (var updatedImage in eventArgs.updated)
            {
                // Handle updated event
                //Debug.Log("Image updated");

            }

            foreach (var removedImage in eventArgs.removed)
            {
                // Handle removed event
                Debug.Log("Image removed ");


            }
        }

    }
        void ListAllImages() //lists the number of detected images to check if disabling tracking is working properly
        {
            //Debug.Log( $"There are {m_TrackedImageManager.trackables.count} images being tracked.");

            foreach (var trackedImage in m_TrackedImageManager.trackables)
            {
                Debug.Log($"Image: {trackedImage.referenceImage.name} is at " +
                          $"{trackedImage.transform.position}");

            }
        }

    }
