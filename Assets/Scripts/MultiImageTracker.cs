using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;
using UnityEngine.XR.ARSubsystems;

public class MultiImageTracker : MonoBehaviour
{
    [SerializeField] private ARTrackedImageManager trackedImageManager;
    public List<GameObject> prefabsToSpawn;

    private Dictionary<string, GameObject> spawnedPrefabs = new Dictionary<string, GameObject>();

    void OnEnable()
    {
        trackedImageManager.trackablesChanged += OnTrackedImagesChanged;
    }

    void OnDisable()
    {
        trackedImageManager.trackablesChanged -= OnTrackedImagesChanged;
    }

    // Versi baru pakai ARTrackablesChangedEventArgs<T>
    private void OnTrackedImagesChanged(ARTrackablesChangedEventArgs<ARTrackedImage> eventArgs)
    {
        foreach (var trackedImage in eventArgs.added)
        {
            SpawnOrUpdatePrefab(trackedImage);
        }

        foreach (var trackedImage in eventArgs.updated)
        {
            SpawnOrUpdatePrefab(trackedImage);
        }

        foreach (var trackedImage in eventArgs.removed)
        {
            string imageName = trackedImage.referenceImage.name;
            if (spawnedPrefabs.ContainsKey(imageName))
            {
                spawnedPrefabs[imageName].SetActive(false);
            }
        }
    }

    private void SpawnOrUpdatePrefab(ARTrackedImage trackedImage)
    {
        string imageName = trackedImage.referenceImage.name;

        if (!spawnedPrefabs.ContainsKey(imageName))
        {
            foreach (var prefab in prefabsToSpawn)
            {
                if (prefab.name == imageName)
                {
                    GameObject newPrefab = Instantiate(prefab, trackedImage.transform);
                    newPrefab.transform.localPosition = Vector3.zero;
                    newPrefab.transform.localRotation = Quaternion.identity;
                    newPrefab.SetActive(true);

                    spawnedPrefabs.Add(imageName, newPrefab);
                    break;
                }
            }
        }
        else
        {
            GameObject prefab = spawnedPrefabs[imageName];
            prefab.transform.SetParent(trackedImage.transform);
            prefab.transform.localPosition = Vector3.zero;
            prefab.transform.localRotation = Quaternion.identity;
            prefab.SetActive(trackedImage.trackingState == TrackingState.Tracking);
        }
    }
}
