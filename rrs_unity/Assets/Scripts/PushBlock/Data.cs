﻿using ProtoBuf;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    public class RawData : IRawData
    {
        public byte[] Data { get; set; }
        public int Length { get; set; }
    }

    public interface IRawData
    {
         byte[] Data { get; set; }
         int Length { get; set; }
    }

    public interface IData
    {
        int Version { get; set; }
    }

    [ProtoContract]
    public class RVector3
    {
        [ProtoMember(1)]
        public float x = 0;
        [ProtoMember(2)]
        public float y = 0;
        [ProtoMember(3)]
        public float z = 0;

        public RVector3(float a, float b, float c)
        {
            x = a;
            y = b;
            z = c;
        }

        public RVector3()
        {

        }
    }

    [ProtoContract]
    public class RVector6
    {
        [ProtoMember(1)]
        public float x = 0;
        [ProtoMember(2)]
        public float y = 0;
        [ProtoMember(3)]
        public float z = 0;
        [ProtoMember(4)]
        public float roll = 0;
        [ProtoMember(5)]
        public float pitch = 0;
        [ProtoMember(6)]
        public float yaw = 0;

        public RVector6(float a, float b, float c,float d,float e,float f)
        {
            x = a;
            y = b;
            z = c;

            roll = d;
            pitch = e;
            yaw = f;
        }

        public RVector6()
        {

        }
    }

    [ProtoContract]
    public class SVector3
    {
        [ProtoMember(1)]
        public float x = 0;
        [ProtoMember(2)]
        public float y = 0;
        [ProtoMember(3)]
        public float z = 0;

        public SVector3(float a, float b, float c)
        {
            x = a;
            y = b;
            z = c;
        }

        public SVector3()
        {

        }
    }

[Serializable]
[ProtoContract]
public class HapticCommand
{
    [ProtoMember(1)]
    public string cmd = "";
    [ProtoMember(2)]
    public RVector3 position = null;
    [ProtoMember(3)]
    public RVector3 rotation = null;
    [ProtoMember(4)]
    public RVector3 velocity_linear = null;
    [ProtoMember(5)]
    public RVector3 velocity_angular = null;
    [ProtoMember(6)]
    public float gripper_gap = 0;
    [ProtoMember(7)]
    public float gripper_angle = 0;
    [ProtoMember(8)]
    public float velocity_linear_gripper = 0;
    [ProtoMember(9)]
    public float velocity_angular_gripper = 0;
    [ProtoMember(10)]
    public int version = 1;
    [ProtoMember(11)]
    public ulong time_span = 0;

    public HapticCommand()
    {
    }
}

[ProtoContract]
public class SVector4
{
    [ProtoMember(1)]
    public float x = 0;
    [ProtoMember(2)]
    public float y = 0;
    [ProtoMember(3)]
    public float z = 0;
    [ProtoMember(4)]
    public float w = 0;

    public SVector4(float a, float b, float c, float d)
    {
        x = a;
        y = b;
        z = c;
        w = d;
    }

    public SVector4()
    {

    }
}

[Serializable]
[ProtoContract]
public class ObservationRL
{
    [ProtoMember(1)]
    public RVector3 block_position = null;
    [ProtoMember(2)]
    public RVector3 block_rotation = null;
    [ProtoMember(3)]
    public SVector4 block_rotation_q = null;
    [ProtoMember(4)]
    public RVector3 hand_position = null;
    [ProtoMember(5)]
    public RVector3 hand_rotation = null;
    [ProtoMember(6)]
    public SVector4 hand_rotation_q = null;

    public ObservationRL()
    {

    }
}
