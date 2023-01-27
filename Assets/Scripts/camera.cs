using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camera : MonoBehaviour
{
    public GameObject character;
    // Start is called before the first frame update
    void Start()
    {
        character = GameObject.Find("Hero");
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(character.transform.position.x, character.transform.position.y, character.transform.position.z - 2);
    }
}
