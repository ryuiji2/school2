using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Guns : MonoBehaviour {

    public int currClip;
    public int clip;
    public int ammo;
    public int fireRate;
    public int reloadTime;
    public GameObject bullet;

    void Start () {
        currClip = clip;
        }

    void Update () {
        Shooting ();
        Reload ();
        }

    public virtual void Shooting() {
        if (Input.GetMouseButton (0) && currClip >0) {
            currClip -= 1;
            }
	}
	
	public virtual void Reload () {
        if (Input.GetButtonDown ("Reload") && ammo > 0) { 
            if(ammo + currClip >= clip) {
                ammo -= (clip - currClip);
                currClip = clip;
                } else {
                currClip += ammo;
                ammo = 0;
                }

            }
	}
}
