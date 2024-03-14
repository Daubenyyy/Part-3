using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Thief : Villager
{
    public GameObject knifePrefab;
    public Transform spawnPoint;
    float knifeCount = 1;

    public override ChestType CanOpen()
    {
        return ChestType.Thief;
    }

    protected override void Attack()
    {
        destination = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        speed = 5;
        base.Attack();
        while (knifeCount <= 2)
        {
            knifeCount++;
            Instantiate(knifePrefab, spawnPoint.position, spawnPoint.rotation);
        }
        knifeCount = 1;
    }
}
