using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ProjectArena
{
    public class MyGameManager_Test : MonoBehaviour
    {
        public List<GameObject> environmentPieces;
        public GameObject arena;
        public GameObject player;
        public GameObject sceneCamera;

        const float CUBE_DIMENSION = 15f;
        
        // Start is called before the first frame update
        void Start()
        {
            BuildLevel();
            Instantiate(player, new Vector3(7.5f, 7.5f, 7.5f), Quaternion.identity);
            sceneCamera.SetActive(false);
        }

        // Update is called once per frame
        void Update()
        {

        }

        void BuildLevel()
        {
            GameObject wall;

            wall = Instantiate(environmentPieces[0], new Vector3(0, 0, 15), Quaternion.identity);
            wall.transform.SetParent(arena.transform);
            wall = Instantiate(environmentPieces[0], new Vector3(0, 15, 0), new Quaternion(0, Mathf.Sqrt(.5f), Mathf.Sqrt(.5f), 0));
            wall.transform.SetParent(arena.transform);
            wall = Instantiate(environmentPieces[0], new Vector3(0, 0, -15), new Quaternion(Mathf.Sqrt(.5f), Mathf.Sqrt(.5f), 0, 0));
            wall.transform.SetParent(arena.transform);
            wall = Instantiate(environmentPieces[0], new Vector3(0, -15, 0), new Quaternion(Mathf.Sqrt(.5f), 0, 0, Mathf.Sqrt(.5f)));
            wall.transform.SetParent(arena.transform);
            wall = Instantiate(environmentPieces[0], new Vector3(15, 0, 0), new Quaternion(Mathf.Sqrt(.5f), 0, Mathf.Sqrt(.5f), 0));
            wall.transform.SetParent(arena.transform);
            wall = Instantiate(environmentPieces[0], new Vector3(-15, 0, 0), new Quaternion(0, -Mathf.Sqrt(.5f), 0, Mathf.Sqrt(.5f)));
            wall.transform.SetParent(arena.transform);

            PlatformConstruction();
        }

        void PlatformConstruction()
        {
            GameObject platform;
            for(int x = 0; x < 15; x++)
            {
                platform = Instantiate(environmentPieces[1], new Vector3(Random.Range(-CUBE_DIMENSION, CUBE_DIMENSION), Random.Range(-CUBE_DIMENSION, CUBE_DIMENSION), Random.Range(-CUBE_DIMENSION, CUBE_DIMENSION)), Quaternion.identity);
                platform.GetComponent<Transform>().localScale *= Random.Range(1f, CUBE_DIMENSION / 2f);
                platform.transform.SetParent(arena.transform);
            }
        }
    }
}