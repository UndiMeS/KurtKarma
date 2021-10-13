// using System.Collections;
// using System.Collections.Generic;
// using UnityEngine;
// using UnityEngine.XR;
// using UnityEngine.XR.ARFoundation;

// public class ImageRecognition : MonoBehaviour
// {

//     public GameObject mainCamera;
//     public GameObject arCamera;
//     public GameObject arScreen;
//     public GameObject gameScreen;
//     public GameObject junkRoom;
//     public GameObject controlRoom;

//     private ARTrackedImageManager _arTrackedImageManager;

//     private void Awake()
//     {
//         _arTrackedImageManager = FindObjectOfType<ARTrackedImageManager>();
//     }

//     public void OnEnable()
//     {
//         _arTrackedImageManager.trackedImagesChanged += OnImageChanged;
//     }

//         public void OnDisable()
//     {
//         _arTrackedImageManager.trackedImagesChanged -= OnImageChanged;
//     }

//     public void OnImageChanged(ARTrackedImagesChangedEventArgs args)
//     {
//         foreach (var trackedImage in args.added)
//         {
//             arScreen.SetActive(false);
//             arCamera.SetActive(false);
//             mainCamera.SetActive(true);
//             gameScreen.SetActive(true);
//             controlRoom.SetActive(false);
//             junkRoom.SetActive(true);
//         }
//     }


//     // Start is called before the first frame update
//     void Start()
//     {
        
//     }

//     // Update is called once per frame
//     void Update()
//     {
        
//     }
// }
