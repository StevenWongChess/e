using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
	public int rupee_count = 0;
    // Start is called before the first frame update
    public void AddRupees(int num_rupees){
    	rupee_count += num_rupees;
    }
    // public void AddRupees(){
    // 	rupee_count ++;
    // }

    public int GetRupees(){
    	return rupee_count;
    }
}
