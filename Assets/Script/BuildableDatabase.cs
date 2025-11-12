using UnityEngine;
using System.Collections.Generic;


[CreateAssetMenu(menuName = "Building/Buildable Database")]
public class BuildableDatabase : ScriptableObject
{
    public List<BuildableObject> buildables = new List<BuildableObject>();
    
    public List<ResourceItem> resources = new List<ResourceItem>();

    public BuildableObject GetBuildableByID(string id)
    {
        return buildables.Find(b => b.buildID == id);
    }

    public ResourceItem GetResourceByName(string name)
    {
        return resources.Find(r => r.itemName == name);
    }




}
