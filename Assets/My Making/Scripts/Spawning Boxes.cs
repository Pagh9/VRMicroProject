using NUnit.Framework;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;


public class SpawningBoxes : MonoBehaviour
{
    public GameObject RedBox;
   

    public GameObject[] SpawnPoints;



    public int SpawnCount;
    public int DeSpawn;

    public int MoveSpeed;


    public List<Move> moves = new List<Move>(); 

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
       

        moves.Add(new Move( new int[4] { 1, 1, 1, 1 }));
        moves.Add(new Move(new int[4] {2,2,2,2 }));
        moves.Add(new Move(new int[4] { 3,3,3,3 }));
        moves.Add(new Move(new int[4] { 4,4,4,4 }));
        moves.Add(new Move(new int[4] { 4,3,1,2 }));
        moves.Add(new Move(new int[4] { 1,1,1,4}));
        moves.Add(new Move(new int[4] { 1,1,1,2 }));
        moves.Add(new Move(new int[4] { 4,4,4,3 }));
        moves.Add(new Move(new int[4] { 1,3,1,4 }));
        moves.Add(new Move(new int[4] { 4,1,2,4 }));
        moves.Add(new Move(new int[4] { 2,3,2,1 }));
        moves.Add(new Move(new int[4] { 4,3,3,2 }));
        moves.Add(new Move(new int[4] { 3,4,2,1 }));

        InvokeRepeating("startBox",0,4);

    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public IEnumerator BoxSpawner()
    {
        int i = UnityEngine.Random.Range(0, moves.Count-1);
        foreach (int point in moves[i].movePoints)
        {
            GameObject g = Instantiate(RedBox, SpawnPoints[point - 1].transform.position, transform.rotation);
            switch(UnityEngine.Random.Range(0, 2))
            {
                case 0: g.GetComponent<MeshRenderer>().material.color = Color.red; break;
                case 1: g.GetComponent<MeshRenderer>().material.color = Color.blue; break;
            }
            yield return new WaitForSeconds(1);
            
        }
        
    }

    public void startBox()
    {
        StartCoroutine(BoxSpawner());
    }

}

public class Move 
{
    public int[] movePoints;

    public int[] MovePoints
    {
        get { return movePoints; }
        set { movePoints = value; }
    }

    public Move(int[] points)
    {
        movePoints = points;
    }

}
