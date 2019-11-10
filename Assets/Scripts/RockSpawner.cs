using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RockSpawner : MonoBehaviour
{
    [SerializeField]
    GameObject prefabGreenRock;
    [SerializeField]
    GameObject prefabMagentaRock;
    [SerializeField]
    GameObject prefabWhiteRock;
    
    //saved for efficiency

     /*[SerializeField]
     Sprite greenrock;
     [SerializeField]
     Sprite magentarock;
     [SerializeField]
     Sprite whiterock;*/

     const float MinSpawnDelay = 1;
     const float MaxSpawnDelay = 2;
     Timer SpawnTimer;
     void Start()
     {
        SpawnTimer = gameObject.AddComponent<Timer>();
        SpawnTimer.Duration = Random.Range(MinSpawnDelay, MaxSpawnDelay);
        SpawnTimer.Run();
     }

    // Update is called once per frame
    void Update()
    {
        if(SpawnTimer.Finished)
        {
            SpawnRock();

            SpawnTimer.Duration = Random.Range(MinSpawnDelay, MaxSpawnDelay);
            SpawnTimer.Run();
        }
    }

    void SpawnRock()
    {
        GameObject[] Rock = GameObject.FindGameObjectsWithTag("C4Rock");
        if (Rock != null || Rock.Length < 3)
        {
            Vector3 location = new Vector3(Screen.width / 2, Screen.height / 2, - Camera.main.transform.position.z);
            Vector3 worldLocation = Camera.main.ScreenToWorldPoint(location);
            /*GameObject GreenRock = Instantiate(prefabGreenRock) as GameObject;
               GameObject MagentaRock = Instantiate(prefabMagentaRock) as GameObject;
               GameObject WhiteRock = Instantiate(prefabWhiteRock) as GameObject;
               GreenRock.transform.position = worldLocation;
               MagentaRock.transform.position = worldLocation;
               WhiteRock.transform.position = worldLocation;


               SpriteRenderer spriteRenderer = Rock.GetComponent<SpriteRenderer>();*/
            int prefabNumber = Random.Range(0, 3);
            if (prefabNumber == 0)
            {
                Instantiate<GameObject>(prefabGreenRock, worldLocation, Quaternion.identity);
            }

            else if (prefabNumber == 1)
            {
                Instantiate<GameObject>(prefabMagentaRock, worldLocation, Quaternion.identity);
            }
            else
            {
                Instantiate<GameObject>(prefabWhiteRock, worldLocation, Quaternion.identity);
            }
        }
    }
}
