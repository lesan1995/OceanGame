using UnityEngine;
using System.Collections;

public class SpawnerBarrier : MonoBehaviour {

    [SerializeField]
    public GameObject _weed;
    public GameObject _crab;
    private GameObject[] obj;
    void Start()
    {
        StartCoroutine(spawer());
        GameObject[] g = { _weed, _crab};
        obj = g;
    }
    void Update()
    {

    }
    IEnumerator spawer()
    {
        int time = Random.Range(2,10);
        yield return new WaitForSeconds(time);
        GameObject g = obj[Random.Range(0, obj.Length)];
        Vector3 temp = g.transform.position;
        Instantiate(g, temp, Quaternion.identity);
        StartCoroutine(spawer());
    }
}
