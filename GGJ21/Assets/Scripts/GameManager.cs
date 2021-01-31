using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    int partsGathered = 0;  // number of tower parts collected

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        #region win condition (parts gathered)
        if (partsGathered == 4)
        {
            // win game event
        }
        #endregion

    }
}
