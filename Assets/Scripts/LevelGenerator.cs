using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelGenerator : MonoBehaviour
{
    public GameObject platformPrefab;
    public GameObject bonusOne;
    public GameObject bonusTwo;
    public GameObject bonusThree;

    public int numberOfPlatforms;
    public float levelWidth;

    public float startY;
    public static float endY;

    // Use this for initialization
    void Start()
    {
        bonusOne = GameObject.FindGameObjectsWithTag("BonusOne")[0];
        bonusTwo = GameObject.FindGameObjectsWithTag("BonusTwo")[0];
        bonusThree = GameObject.FindGameObjectsWithTag("BonusThree")[0];
       
        Vector3 spawnPosition = new Vector3();
        Vector3 bonusOneSpawnPosition = new Vector3();
        Vector3 bonusTwoSpawnPosition = new Vector3();
        Vector3 bonusThreeSpawnPosition = new Vector3();

        for (int i = 0; i < numberOfPlatforms; i++)
        {
            int randAdd = Random.Range(2,6);
            spawnPosition.y = startY + randAdd;
            startY += randAdd;

            spawnPosition.x = Random.Range(-levelWidth, levelWidth);

            Instantiate(platformPrefab, spawnPosition, Quaternion.identity);

            int bonusOneChanse = Random.Range(0, 20);
            int bonusTwoChanse = Random.Range(0, 10);
            int bonusThreeChanse = Random.Range(0, 5);

            if (bonusOneChanse < 2)
            {
                bonusOneSpawnPosition = spawnPosition;
                bonusOneSpawnPosition.y++;
                Instantiate(bonusOne, bonusOneSpawnPosition, Quaternion.identity);
                continue;
            }

            if (bonusTwoChanse < 2)
            {
                bonusTwoSpawnPosition = spawnPosition;
                bonusTwoSpawnPosition.y++;
                Instantiate(bonusTwo, bonusTwoSpawnPosition, Quaternion.identity);
                continue;
            }

            if (bonusThreeChanse < 2)
            {
                bonusThreeSpawnPosition = spawnPosition;
                bonusThreeSpawnPosition.y++;
                Instantiate(bonusThree, bonusThreeSpawnPosition, Quaternion.identity);
                continue;
            }

        }

        endY = startY;
    }
}
