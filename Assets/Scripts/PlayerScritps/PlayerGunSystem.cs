using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerGunSystem : MonoBehaviour {
    [SerializeField]
    private Transform GunNozzleLeft;
    [SerializeField]
    private Transform GunNozzleRight;
    [SerializeField]
    private GameObject BulletPrefab;
    [SerializeField]
    private GameObject LaserPrefab;
     
    private void ShootBullets() {
        Instantiate(BulletPrefab, new Vector3(GunNozzleLeft.transform.position.x, GunNozzleLeft.transform.position.y, GunNozzleLeft.transform.position.z + .3f), this.transform.rotation);
        Instantiate(BulletPrefab, new Vector3(GunNozzleRight.transform.position.x, GunNozzleRight.transform.position.y, GunNozzleRight.transform.position.z + .3f), this.transform.rotation);
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            ShootBullets();
        }
    }
}
