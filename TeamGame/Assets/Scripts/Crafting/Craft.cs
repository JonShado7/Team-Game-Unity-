﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Craft : MonoBehaviour, ICraftingContainer
{
    public CraftingRecipe craft;
    public ItemDatabase crystals;
    public ItemDatabase essence;
    public ItemDatabase database;

    ICraftingContainer iCraft;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void CraftItem()
    {
        //iCraft.ItemCounter(essence);
        //iCraft.ItemCounter(crystals);
        //iCraft.ItemCounter(database);
        craft.CanCraft(iCraft);
        craft.Craft(iCraft);
    }

    public int ItemCounter(ItemDatabase item)
    {
        throw new System.NotImplementedException();
    }

    public bool ContainsItems(ItemDatabase item)
    {
        throw new System.NotImplementedException();
    }

    public bool RemoveItems(ItemDatabase item)
    {
        throw new System.NotImplementedException();
    }

    public bool AddItems(ItemDatabase item)
    {
        throw new System.NotImplementedException();
    }
}
