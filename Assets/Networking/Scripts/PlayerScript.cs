using UnityEngine;
using Unity.Netcode;


public class PlayerScript : NetworkBehaviour
{
private void Update()
    {
        if (!IsOwner) return; // Only the owner can control the player; if not onwner return

        Vector3 moveDir = new Vector3(0, 0, 0);

        if (Input.GetKey(KeyCode.W)) moveDir.z += 1;
        if (Input.GetKey(KeyCode.S)) moveDir.z -= 1;
        if (Input.GetKey(KeyCode.A)) moveDir.x -= 1;
        if (Input.GetKey(KeyCode.D)) moveDir.x += 1;

        float moveSpeed = 5f;
        transform.Translate(moveDir * moveSpeed * Time.deltaTime);
       
    }
}
