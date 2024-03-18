using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Partes do código foram retiradas dos tutoriais abaixo
// https://www.youtube.com/watch?v=wZ2UUOC17AY&ab_channel=Dave%2FGameDevelopment
// https://www.youtube.com/watch?v=EwiUomzehKU&ab_channel=Unity3DSchool 
public class CubeController : MonoBehaviour
{

    public GameObject bullet;
    public Transform bulletSpawnPoint;
    public float bulletForce;
    public float timeBetweenEachBullet;
    public float initialTimeToStartShooting;

    // Start is called before the first frame update
    void Start()
    {
        // start the coroutine to shoot the bullets
        StartCoroutine(ShootCoroutine());
    }


    private IEnumerator ShootCoroutine(){
        // wait for a certain time before starting to shoot
        yield return new WaitForSeconds(initialTimeToStartShooting);
        
        while(true){
            Shoot();
            yield return new WaitForSeconds(timeBetweenEachBullet);
        }
    }

    private void Shoot(){
        // create a bullet object and sends it to the target point, which is the position of the player
        Vector3 targetPoint;
        targetPoint = GameObject.Find("Player").transform.position;
        GameObject bulletObject = Instantiate(bullet, transform.position, Quaternion.identity);
        bulletObject.GetComponent<Rigidbody>().AddForce((targetPoint - bulletSpawnPoint.position).normalized * bulletForce, ForceMode.Impulse);

    }
}
