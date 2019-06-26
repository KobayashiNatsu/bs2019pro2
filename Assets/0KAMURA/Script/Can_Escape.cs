using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Can_Escape : MonoBehaviour {
    public GameObject DOOR_04, ESCAPE_04,OLD_ESCAPE04;
    public Puzzle_Clear Puzzle_Clear;
    bool CREATE_E;
    // Use this for initialization
    void Start () {

    }

    // Update is called once per frame
    void Update () {
        if (Puzzle_Clear.ALL_CLEAR && CREATE_E == false)
        {
            Destroy(OLD_ESCAPE04);
            Destroy(DOOR_04);
            Instantiate(ESCAPE_04, this.transform.position, this.transform.rotation);
            CREATE_E = true;
        }
    }
}
