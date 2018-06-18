using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicItem : MonoBehaviour{



    public virtual void OnCollisionEnter(Collision player)
    {
        
    }
    public virtual void GiveEnergy(int value)
    {
        PlayerStats.instance.energy += value;
    }
    public virtual void GiveHunger(int value)
    {
        PlayerStats.instance.hunger += value;
    }
    public virtual void GiveHygene(int value)
    {
        PlayerStats.instance.hygene += value;
    }
    public virtual void GiveThirst(int value)
    {
        PlayerStats.instance.thirst += value;
    }
}

