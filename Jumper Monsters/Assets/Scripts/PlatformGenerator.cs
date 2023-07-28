using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformGenerator : MonoBehaviour
{
    [SerializeField] GameObject platform;
    Transform firstPlatformTransform;
    [SerializeField] float maxY = 2.5f;
    [SerializeField] float minY = 2.3f;
    [SerializeField] float platformX = 4.5f;
    int numberOfPlatform = 0;
    int maxPlatformNumber = 5;
    Vector3 firstPos;
    float lastYPos;

    void Awake()
    {
        firstPlatformTransform = FindObjectOfType<Platform>().transform;
        firstPos = firstPlatformTransform.position;
        InstantiatePlatform();
    }


    void Update()
    {
        numberOfPlatform = FindObjectsOfType<Platform>().Length;
        Debug.Log(numberOfPlatform);
        if (maxPlatformNumber > numberOfPlatform)
        {
            InstantiatePlatform();
        }
    }
    void InstantiatePlatform()
    {
        //oluşturulacak objelerin büyüklüğü ayarlanacak
        
        float randomX = Random.Range(-platformX, platformX);
        float randomY = Random.Range(minY, maxY);
        lastYPos += randomY;
        Vector3 newPos = new Vector3(randomX, lastYPos + firstPos.y, firstPos.z);
        Instantiate(platform, newPos, Quaternion.identity);
        numberOfPlatform++;

    }
}
