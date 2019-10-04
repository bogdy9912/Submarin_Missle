using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPoints : MonoBehaviour
{
    public GameObject Spw;
    public GameObject Submarin;
    public int x;
    public int y;
    public float spawnTimePoint = 3f;
    public float Timp;
    public int verif;
    // Start is called before the first frame update
    void Start()
    {
       StartCoroutine(Example());
        
    }

    IEnumerator Example()
    {
        yield return new WaitForSecondsRealtime(Timp);
        
        InvokeRepeating("Spawn", spawnTimePoint, spawnTimePoint);
        
    }
    // Update is called once per frame
    void Spawn()
    {
        Debug.Log("Micro" + Submarin.transform.position);
        if (verif == 1)
        {
            Vector3 spwlocation = Submarin.transform.position +
                                          new Vector3(Random.Range(Submarin.transform.position.x - 11,
                                                                      Submarin.transform.position.x + 11),
                                                      Random.Range(Submarin.transform.position.y - 7, 
                                                                    Submarin.transform.position.y-5), 0);
            Debug.Log("spawn1" + spwlocation);
            Spw.transform.position = spwlocation;
        }
        else
            if (verif == 2)
        {
            Vector3 spwlocation = Submarin.transform.position +
                                          new Vector3(Random.Range(Submarin.transform.position.x - 13,
                                                                      Submarin.transform.position.x - 11),
                                                      Random.Range(Submarin.transform.position.y - 5,
                                                      Submarin.transform.position.y + 5), 0);
            Debug.Log("spawn2" + spwlocation);
            Spw.transform.position = spwlocation;
        }
    }
    void Update()
    {

            
    }
}
