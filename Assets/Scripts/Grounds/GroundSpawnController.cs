using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundSpawnController : MonoBehaviour
{

    public GameObject lastGroundObject;

    [SerializeField] public GameObject groundPrefabs;

    private GameObject newGroundObject;

    private int groundDirections;

    void Start()
    {
        GenerateRandomGround();
    }


    public void GenerateRandomGround()
    {
        for (int i = 0; i < 75 ; i++)
        {
            CreateGround();
        }
    }
    public void CreateGround()
    {
        groundDirections = Random.Range(0, 2);

        if (groundDirections == 0)
        {
            newGroundObject = Instantiate(groundPrefabs, new Vector3(lastGroundObject.transform.position.x - 1f, lastGroundObject.transform.position.y, lastGroundObject.transform.position.z), Quaternion.identity);
            lastGroundObject= newGroundObject;
        }
        else
        {
            newGroundObject = Instantiate(groundPrefabs, new Vector3(lastGroundObject.transform.position.x, lastGroundObject.transform.position.y, lastGroundObject.transform.position.z + 1f), Quaternion.identity);
            lastGroundObject = newGroundObject;
        }
    }
}
