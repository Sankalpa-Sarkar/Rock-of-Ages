using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroyer : MonoBehaviour
{
    [SerializeField]
    GameObject prefabExplosion;

    //timer support
    Timer explodeTimer;

    // Start is called before the first frame update
    void Start()
    {
        explodeTimer = gameObject.AddComponent<Timer>();
        explodeTimer.Duration = 1;
        explodeTimer.Run();
    }

    // Update is called once per frame
    void Update()
    {
        //check for timer finished and restart
        if (explodeTimer.Finished)
        {
            explodeTimer.Run();
            //blow up C4 Rock
            
        }
    }
}
