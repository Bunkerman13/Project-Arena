using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ProjectArena
{
    public class Utilities_Test : MonoBehaviour
    {
        MyGameManager_Test myGameManager;
        private void Start()
        {
            myGameManager = GameObject.Find("MyGameManager").GetComponent<MyGameManager_Test>();
        }


    }
}
