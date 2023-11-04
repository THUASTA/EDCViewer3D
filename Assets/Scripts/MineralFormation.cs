using System.Collections;
using System;
using System.Collections.Generic;
using EDCViewer.Messages;
using UnityEngine;


public class MineralFormation : MonoBehaviour
{
    public GameObject IronOre;
    public GameObject GoldOre;
    public GameObject DiamondOre;

    public void OreFormation(CompetitionUpdate.Mine.OreType oreType, string mineId, Vector3 orePosition)
    {
        if (oreType == CompetitionUpdate.Mine.OreType.IronOre)
        {
            IronOreFormation(mineId, orePosition);
        }
        else if (oreType == CompetitionUpdate.Mine.OreType.GoldOre)
        {
            GoldOreFormation(mineId, orePosition);
        }
        else if (oreType == CompetitionUpdate.Mine.OreType.DiamondOre)
        {
            DiamondOreFormation(mineId, orePosition);
        }
    }

    void IronOreFormation(string mineId, Vector3 IronOrePosition)
    {
        GameObject ironOre = Instantiate(IronOre, IronOrePosition, Quaternion.identity);
        Controller.Mines.Add(mineId, ironOre);
    }

    

    void GoldOreFormation(string mineId, Vector3 GoldMinePosition)
    {
        GameObject goldOre = Instantiate(GoldOre, GoldMinePosition, Quaternion.identity);
        Controller.Mines.Add(mineId, goldOre);
    }

    

    void DiamondOreFormation(string mineId, Vector3 DiamondMinePosition)
    {
        GameObject diamondOre = Instantiate( DiamondOre, DiamondMinePosition, Quaternion.identity);
        Controller.Mines.Add(mineId, diamondOre);
    }

    public void OreDestroy(string mineId,int playerId)
    {
        Controller.Mines[mineId].transform.Translate(Controller.PlayerSteve[playerId].transform.position * Time.deltaTime);
        float distance = Vector3.Distance(Controller.Mines[mineId].transform.position, Controller.PlayerSteve[playerId].transform.position);
        if(distance < 0.5f)
        {
            Destroy(Controller.Mines[mineId]);
            Controller.Mines.Remove(mineId);
        }
    }
}
