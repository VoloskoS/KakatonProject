using UnityEngine;
using System.Collections;

public class planeSpawn : MonoBehaviour
{

    [SerializeField]
    private GameObject plane;
    [SerializeField]
    private GameObject badPlane;
    [SerializeField]
    private float yMin, yMax, waitSpawn;

    // Use this for initialization
    void Start()
    {
        StartCoroutine(SpawmPlanes());
    }

    IEnumerator SpawmPlanes()
    {
        while (true)
        {
            Instantiate(plane, new Vector3(11f, Random.Range(yMin, yMax), 0f), Quaternion.identity);
            yield return new WaitForSeconds(waitSpawn);
        }
    }

}
