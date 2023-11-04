using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class Block : MonoBehaviour
{
    public GameObject go;
    public string[] MaterialNameList = 
    {
        "null",
        "azalea_leaves",
        "glass",
        "magenta_wool",
        "dirt",
        "oak_planks",
        "cobblestone",
        "deepslate_brick",
        "obsidian"
    };
    private readonly List<Material> _materials;
    // Start is called before the first frame update
    void Start()
    {
        foreach(string materialName in MaterialNameList)
        {
            _materials.Add(Resources.Load<Material>($"Images/BlockMaterials/Materials/{materialName}"));
        }

        go = gameObject;
        go.GetComponent<MeshRenderer>().material = _materials[0];
    }


    public void MaterialUpdate(int height)
    {
        go.GetComponent<MeshRenderer>().material = _materials[height];
    }
    //public void MaterialAdd(Vector3 MaterialPosition)
    //{
    //    if(_materials.Count < 8 && transform.position == MaterialPosition )
    //    {
    //        go.GetComponent<MeshRenderer>().material = Materials[materialCount];
    //    }
    //}

    //public void MaterialRemove(Vector3 MaterialPosition)
    //{
    //    if( materialCount > 0 && transform.position == MaterialPosition )
    //    {
    //        go.GetComponent<MeshRenderer>().material = Materials[materialCount];
    //    }
    //}
}
