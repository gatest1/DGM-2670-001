using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class RecycleLevel : MonoBehaviour {
    // This script was created on 9/26/2016

    private List<SendToRecycler> recycleList;
    private Vector3 movePos;
        void SendThisHandler (SendToRecycler _r)
    {
        recycleList.Add(_r);
        print(recycleList.Count);
    }

	void Start () {
        recycleList = new List<SendToRecycler>();
        SendToRecycler.SendThis += SendThisHandler;
	}

    void OnTrggerEnter ()
    {
        movePos.x = Statics.nextPosition;
        recycleList[0].transform.position = movePos;
        Statics.nextPosition += Statics.distance; 
    }
	
}
