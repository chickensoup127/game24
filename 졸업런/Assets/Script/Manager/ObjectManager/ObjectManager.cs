﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectManager : Manager
{
    public class ObjectPool
    {
        class PoolableObject
        {
            public bool isActive = false;
            public GameObject obj;
        }
        List<PoolableObject> objLst = new List<PoolableObject>();

        public void AddObj(GameObject obj, int cnt)
        {
            for (int i = 0; i < cnt; i++)
            {
                GameObject gameObj = Instantiate(obj);
                PoolableObject poolableObj = new PoolableObject();
                poolableObj.obj = gameObj;
                gameObj.SetActive(false);
                objLst.Add(poolableObj);
            }

        }
        public GameObject GetObj()
        {
            GameObject ret = null;

            foreach (var item in objLst)
            {
                if (item.isActive == false)
                {
                    ret = item.obj;
                    item.isActive = true;
                    break;
                }
            }

            // 풀에 쓸 아이템이 없는 경우 새로 생성해 준다.
            if (ret != null)
            {
                ret.SetActive(true);
            }

            return ret;
        }
        public void ReleaseObj(GameObject obj)
        {
            foreach (var item in objLst)
            {
                if (item.obj == obj)
                {
                    obj.SetActive(false);
                    item.isActive = false;
                    break;
                }
            }
        }
    }
    public static ObjectManager instance = null;

    List<GameObject> _removeLst = new List<GameObject>();

    Dictionary<string, ObjectPool> _dictObjPool = new Dictionary<string, ObjectPool>();

    private void Awake()
    {
        instance = this;
    }
    // Start is called before the first frame update
    void Start()
    {
        GeneObjPool("Player_Missile", "PlayerMissile", 100);

    }

    void GeneObjPool(string tag, string path, int cnt)
    {
        ObjectPool objPool = new ObjectPool();
        GameObject prefab = Resources.Load(path) as GameObject;
        objPool.AddObj(prefab, cnt);
        _dictObjPool.Add(tag, objPool);
    }

    public GameObject GenerateObj(string tag, string path = "")
    {
        GameObject ret = null;

        if (_dictObjPool[tag] != null)
        {
            ret = _dictObjPool[tag].GetObj();
        }
        else
        {
            // ret에 path를 이용해 만든 객체를 리턴해준다. 빈 문자열은 체크해서 예외처리
        }

        return ret;
    }

    public void ReleaseObj(GameObject obj)
    {

        if (_dictObjPool.ContainsKey(obj.tag))
        {
            _dictObjPool[obj.tag].ReleaseObj(obj);
        }
        else
        {
            Destroy(obj);
        }
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void AddRemoveObj(GameObject obj)
    {
        _removeLst.Add(obj);
    }

    private void LateUpdate()
    {
        foreach (var item in _removeLst)
        {
            //Destroy(item.gameObject);
            ObjectManager.instance.ReleaseObj(item.gameObject);
        }
        _removeLst.Clear();
    }
}
