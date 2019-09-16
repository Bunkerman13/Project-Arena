using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ProjectArena
{
    public class MyGameManager_Test : MonoBehaviour
    {
        public List<GameObject> environmentPieces;
        
        // Start is called before the first frame update
        void Start()
        {
            BuildLevel();
        }

        // Update is called once per frame
        void Update()
        {

        }

        void BuildLevel()
        {
            Instantiate(environmentPieces[0], new Vector3(0, 0, 15), Quaternion.identity);
            Instantiate(environmentPieces[0], new Vector3(0, 15, 0), new Quaternion(0, Mathf.Sqrt(.5f), Mathf.Sqrt(.5f), 0));
            Instantiate(environmentPieces[0], new Vector3(0, 0, -15), new Quaternion(Mathf.Sqrt(.5f), Mathf.Sqrt(.5f), 0, 0));
            Instantiate(environmentPieces[0], new Vector3(0, -15, 0), new Quaternion(Mathf.Sqrt(.5f), 0, 0, Mathf.Sqrt(.5f)));
            Instantiate(environmentPieces[0], new Vector3(15, 0, 0), new Quaternion(Mathf.Sqrt(.5f), 0, 0, 0));
            //Instantiate(environmentPieces[0], new Vector3(0, -15, 0), new Quaternion(Mathf.Sqrt(.5f), 0, 0, Mathf.Sqrt(.5f)));
        }
    }
}