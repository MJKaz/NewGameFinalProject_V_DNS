using UnityEngine;

[CreateAssetMenu(menuName = "Building/Buildable Object")]
public class BuildableObject : ScriptableObject
{
    public string objectName;
    public GameObject previewPrefab;
    public GameObject finalPrefab;
    public Vector3 placementOffset;

    [Header("Buildable Info")]
    public string buildID;     // unique ID for saving/loading
    public string resourceName;
    public GameObject prefab;  // reference to self prefab
    public Transform transform;

    [Header("Runtime State")]
    public bool isPreview = false;
    public bool isPlaced = false; // true after confirm placement



    [Header("Build Requirements")]
    public ItemCost[] buildCost;

    [Header("Refund Settings")]
    [Range(0f, 1f)] public float refundRate = 0.5f; // 50% refund



}
