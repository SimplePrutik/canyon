﻿using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class ExpertSystem : MonoBehaviour {

    public float sp;
    public float l_s;
    public float middle_s;
    public float r_s;

    public class Function
    {
        public float bottom_left;
        public float top_left;
        public float top_right;
        public float bottom_right;

        public Function(float x1, float x2, float x3, float x4)
        {
            bottom_left = x1;
            top_left = x2;
            top_right = x3;
            bottom_right = x4;
        }

        public float ComputeFunc(float x)
        {
            if (x > bottom_right || x < bottom_left)
                return 0;
            if (x <= top_right && x >= top_left)
                return 1;
            if (x < top_left)
                return (x - bottom_left) / (top_left - bottom_left);
            if (x > top_right)
                return 1 - (x - top_right) / (bottom_right - top_right);
            return -1;
        }
    }

    private float SpeedSquare(int i, float k)
    {
        switch (i)
        {
            case -1:
                return SpeedLeftSquare(k);
            case 0:
                return SpeedMiddleSquare(k);
            case 1:
                return SpeedRightSquare(k);
            default:
                return -1;

        }
    }

    private float SpeedLeftSquare(float k)
    {
        Accelaration acc = GetComponent<Accelaration>();
        float topside = (acc.z3 - acc.z2) + (acc.z4 - acc.z3 + acc.z2 - acc.z1) * (1 - k);
        float bottomside = acc.z4 - acc.z1;
        return (topside + bottomside) / 2 * k;
    }

    private float SpeedMiddleSquare(float k)
    {
        Accelaration acc = GetComponent<Accelaration>();
        float topside = (acc.o3 - acc.o2) + (acc.o4 - acc.o3 + acc.o2 - acc.o1) * (1 - k);
        float bottomside = acc.o4 - acc.o1;
        return (topside + bottomside) / 2 * k;
    }

    private float SpeedRightSquare(float k)
    {
        Accelaration acc = GetComponent<Accelaration>();
        float topside = (acc.t3 - acc.t2) + (acc.t4 - acc.t3 + acc.t2 - acc.t1) * (1 - k);
        float bottomside = acc.t4 - acc.t1;
        return (topside + bottomside) / 2 * k;
    }

    private float RotationSquare(int i, float k)
    {
        switch (i)
        {
            case -1:
                return RotateLeftSquare(k);
            case 0:
                return RotateMiddleSquare(k);
            case 1:
                return RotateRightSquare(k);
            default:
                return -1;

        }
    }

    private float RotateLeftSquare(float k)
    {
        Rotation rot = GetComponent<Rotation>();
        float topside = (rot.z3 - rot.z2) + (rot.z4 - rot.z3 + rot.z2 - rot.z1) * (1 - k);
        float bottomside = rot.z4 - rot.z1;
        return (topside + bottomside) / 2 * k;
    }

    private float RotateMiddleSquare(float k)
    {
        Rotation rot = GetComponent<Rotation>();
        float topside = (rot.o3 - rot.o2) + (rot.o4 - rot.o3 + rot.o2 - rot.o1) * (1 - k);
        float bottomside = rot.o4 - rot.o1;
        return (topside + bottomside) / 2 * k;
    }

    private float RotateRightSquare(float k)
    {
        Rotation rot = GetComponent<Rotation>();
        float topside = (rot.t3 - rot.t2) + (rot.t4 - rot.t3 + rot.t2 - rot.t1) * (1 - k);
        float bottomside = rot.t4 - rot.t1;
        return (topside + bottomside) / 2 * k;
    }

    private float SpeedCenter(int i, float k)
    {
        switch (i)
        {
            case -1:
                return SpeedLeftCenter(k);
            case 0:
                return SpeedMiddleCenter(k);
            case 1:
                return SpeedRightCenter(k);
            default:
                return -1;

        }
    }

    private float SpeedLeftCenter(float k)
    {
        Accelaration acc = GetComponent<Accelaration>();
        float topside = (acc.z3 - acc.z2) + (acc.z4 - acc.z3 + acc.z2 - acc.z1) * (1 - k);
        float bottomside = acc.z4 - acc.z1;
        float leftside = (acc.z2 - acc.z1) * k * (acc.z2 - acc.z1) * k + k * k;
        float rightside = (acc.z4 - acc.z3) * k * (acc.z4 - acc.z3) * k + k * k;
        return bottomside / 2 + (2 * topside + bottomside) * (leftside - rightside) / (6 * (bottomside * bottomside - topside * topside)) + acc.z1;
    }

    private float SpeedMiddleCenter(float k)
    {
        Accelaration acc = GetComponent<Accelaration>();
        float topside = (acc.o3 - acc.o2) + (acc.o4 - acc.o3 + acc.o2 - acc.o1) * (1 - k);
        float bottomside = acc.o4 - acc.o1;
        float leftside = (acc.o2 - acc.o1) * k * (acc.o2 - acc.o1) * k + k * k;
        float rightside = (acc.o4 - acc.o3) * k * (acc.o4 - acc.o3) * k + k * k;
        return bottomside / 2 + (2 * topside + bottomside) * (leftside - rightside) / (6 * (bottomside * bottomside - topside * topside)) + acc.o1;
    }

    private float SpeedRightCenter(float k)
    {
        Accelaration acc = GetComponent<Accelaration>();
        float topside = (acc.t3 - acc.t2) + (acc.t4 - acc.t3 + acc.t2 - acc.t1) * (1 - k); ;
        float bottomside = acc.t4 - acc.t1;
        float leftside = (acc.t2 - acc.t1) * k * (acc.t2 - acc.t1) * k + k * k;
        float rightside = (acc.t4 - acc.t3) * k * (acc.t4 - acc.t3) * k + k * k;
        return bottomside / 2 + (2 * topside + bottomside) * (leftside - rightside) / (6 * (bottomside * bottomside - topside * topside)) + acc.t1;
    }

    private float RotationCenter(int i, float k)
    {
        switch (i)
        {
            case -1:
                return RotateLeftCenter(k);
            case 0:
                return RotateMiddleCenter(k);
            case 1:
                return RotateRightCenter(k);
            default:
                return -1;

        }
    }

    private float RotateLeftCenter(float k)
    {
        Rotation rot = GetComponent<Rotation>();
        float topside = (rot.z3 - rot.z2) + (rot.z4 - rot.z3 + rot.z2 - rot.z1) * (1 - k); 
        float bottomside = rot.z4 - rot.z1;
        float leftside = (rot.z2 - rot.z1) * k * (rot.z2 - rot.z1) * k + k * k;
        float rightside = (rot.z4 - rot.z3) * k * (rot.z4 - rot.z3) * k + k * k;
        return bottomside / 2 + (2 * topside + bottomside) * (leftside - rightside) / (6 * (bottomside * bottomside - topside * topside)) + rot.z1;
    }

    private float RotateMiddleCenter(float k)
    {
        Rotation rot = GetComponent<Rotation>();
        float topside = (rot.o3 - rot.o2) + (rot.o4 - rot.o3 + rot.o2 - rot.o1) * (1 - k);
        float bottomside = rot.o4 - rot.o1;
        float leftside = (rot.o2 - rot.o1) * k * (rot.o2 - rot.o1) * k + k * k;
        float rightside = (rot.o4 - rot.o3) * k * (rot.o4 - rot.o3) * k + k * k;
        return bottomside / 2 + (2 * topside + bottomside) * (leftside - rightside) / (6 * (bottomside * bottomside - topside * topside)) + rot.o1;
    }

    private float RotateRightCenter(float k)
    {
        Rotation rot = GetComponent<Rotation>();
        float topside = (rot.t3 - rot.t2) + (rot.t4 - rot.t3 + rot.t2 - rot.t1) * (1 - k); 
        float bottomside = rot.t4 - rot.t1;
        float leftside = (rot.t2 - rot.t1) * k * (rot.t2 - rot.t1) * k + k * k;
        float rightside = (rot.t4 - rot.t3) * k * (rot.t4 - rot.t3) * k + k * k;
        return bottomside / 2 + (2 * topside + bottomside) * (leftside - rightside) / (6 * (bottomside * bottomside - topside * topside)) + rot.t1;
    }

    private float Min(List<float> l)
    {
        float min;
        if (l[0] < l[1])
            min = l[0];
        else
            min = l[1];
        if (min > l[2])
            min = l[2];
        if (min > l[3])
            min = l[3];
        return min;
    }

    private Vector3 Forward()
    {
        return new Vector3(Mathf.Cos(transform.rotation.eulerAngles.z * Mathf.Deg2Rad), Mathf.Sin(transform.rotation.eulerAngles.z * Mathf.Deg2Rad), 0);
    }

    public List<Function> speed_list, ls_list, ms_list, rs_list;

    void Start()
    {
        Speed speed = GetComponent<Speed>();
        speed_list = new List<Function>();
        speed_list.Add(new Function(speed.z1, speed.z2, speed.z3, speed.z4));
        speed_list.Add(new Function(speed.o1, speed.o2, speed.o3, speed.o4));
        speed_list.Add(new Function(speed.t1, speed.t2, speed.t3, speed.t4));


        Left_Sensor ls = GetComponent<Left_Sensor>();
        ls_list = new List<Function>();
        ls_list.Add(new Function(ls.z1, ls.z2, ls.z3, ls.z4));
        ls_list.Add(new Function(ls.o1, ls.o2, ls.o3, ls.o4));
        ls_list.Add(new Function(ls.t1, ls.t2, ls.t3, ls.t4));

        Middle_Sensor ms = GetComponent<Middle_Sensor>();
        ms_list = new List<Function>();
        ms_list.Add(new Function(ms.z1, ms.z2, ms.z3, ms.z4));
        ms_list.Add(new Function(ms.o1, ms.o2, ms.o3, ms.o4));
        ms_list.Add(new Function(ms.t1, ms.t2, ms.t3, ms.t4));

        Right_Sensor rs = GetComponent<Right_Sensor>();
        rs_list = new List<Function>();
        rs_list.Add(new Function(rs.z1, rs.z2, rs.z3, rs.z4));
        rs_list.Add(new Function(rs.o1, rs.o2, rs.o3, rs.o4));
        rs_list.Add(new Function(rs.t1, rs.t2, rs.t3, rs.t4));
    }

    void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.name == "MapQuit(Clone)")
            Application.Quit();
    }

    void Update()
    {
        

        float massS = 0, centerS = 0, massR = 0, centerR = 0;

        Debug.Log(speed_list[0].ComputeFunc(sp).ToString() + " " + ls_list[0].ComputeFunc(l_s).ToString() + " " + ms_list[0].ComputeFunc(middle_s).ToString() + " " + rs_list[0].ComputeFunc(r_s).ToString()
                + '\n' + speed_list[1].ComputeFunc(sp).ToString() + " " + ls_list[1].ComputeFunc(l_s).ToString() + " " + ms_list[1].ComputeFunc(middle_s).ToString() + " " + rs_list[1].ComputeFunc(r_s).ToString()
                    + '\n' + speed_list[2].ComputeFunc(sp).ToString() + " " + ls_list[2].ComputeFunc(l_s).ToString() + " " + ms_list[2].ComputeFunc(middle_s).ToString() + " " + rs_list[2].ComputeFunc(r_s).ToString());

        for (int i = 0; i < 3; ++i)
            for (int j = 0; j < 3; ++j)
                for (int k = 0; k < 3; ++k)
                    for (int l = 0; l < 3; ++l)
                    {
                        ReadMatrix rm = GetComponent<ReadMatrix>();
                        int rot = rm.rules[i][2 - j][2 - k][2 - l].Value;
                        int a = rm.rules[i][2 - j][2 - k][2 - l].Key;

                        List<float> li = new List<float>();
                        li.Add(speed_list[i].ComputeFunc(sp));
                        li.Add(ls_list[j].ComputeFunc(l_s));
                        li.Add(ms_list[k].ComputeFunc(middle_s));
                        li.Add(rs_list[l].ComputeFunc(r_s));
                        float min = Min(li);
                        if (min != 0)
                        {
                            //Debug.Log(i.ToString() + j.ToString() + k.ToString() + l.ToString());
                            //Debug.Log("Minimum" + min.ToString());
                            //Debug.Log(speed_list[i].ComputeFunc(sp).ToString() + " " + ls_list[j].ComputeFunc(l_s).ToString() + " " + ms_list[k].ComputeFunc(middle_s).ToString() + " " + rs_list[l].ComputeFunc(r_s).ToString());
                            //Debug.Log("Acceleration " + a.ToString() + " Rotation " + rot.ToString());
                            float mass_speed = SpeedSquare(a, min);
                            float center_speed = SpeedCenter(a, min);
                            float mass_rotation = RotationSquare(rot, min);
                            float center_rotation = RotationCenter(rot, min);
                            //Debug.Log("Square" + mass_speed.ToString() + " Center" + center_speed.ToString());
                            //Debug.Log("Square" + mass_rotation.ToString() + " Center" + center_rotation.ToString());
                            if (massS == 0)
                            {
                                massS = mass_speed;
                                centerS = center_speed;
                            }
                            else
                            {
                                if (centerS < center_speed)
                                    centerS += (center_speed - centerS) * (mass_speed / (mass_speed + massS));
                                else
                                    centerS -= (centerS - center_speed) * (mass_speed / (mass_speed + massS));
                                massS += mass_speed;
                            }
                            if (massR == 0)
                            {
                                massR = mass_rotation;
                                centerR = center_rotation;
                            }
                            else
                            {
                                if (centerR < center_speed)
                                    centerR += (center_speed - centerR) * (mass_speed / (mass_speed + massR));
                                else
                                    centerR -= (centerR - center_speed) * (mass_speed / (mass_speed + massR));
                                massS += mass_speed;
                            }
                        }
                    }

        //Debug.Log("ASFSGASFGSDFSADGASDGASDFASDFASDGSdgasdgasdfasdfasFasdfasdfasdgfsdfasdfasdfasdfasdfafsdfsdfsdfsdfs");
        sp += centerS;
        if (sp < 0.05f)
            sp = 0.05f;
        transform.position += Forward() * sp;
        Debug.Log("Speed = " + sp.ToString() + " Acceleration = " + centerS.ToString() + " Rotation = " + centerR.ToString());
        transform.Rotate(new Vector3(0, 0, -centerR));
    }
}
    
