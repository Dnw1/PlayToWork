using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class End : MonoBehaviour {

    [SerializeField] private GameObject HoldScore;

    void Start()
    {
        HoldScore.gameObject.GetComponent<Score>().ShowScore();
    }
}
