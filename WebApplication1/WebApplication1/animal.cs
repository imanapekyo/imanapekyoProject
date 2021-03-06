﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace WebApplication1
{
    [Serializable()]
    public class animal : ISerializable
    {
        public string Name { get;set }
        public double Weight { get; set }
        public double Height { get; set }
        public int AnimalID { get; set }

        public animal() { }
        public animal (string name = "No Name", double weight = 0, double height = 0)
        {
            Name = name;
            Weight = weight;
            Height = height;
        }
        public override string ToString()
        {
            return string.Format("{0} weights {1} lbs and is {2} inches tall",
               Name, Weight, Height);
        }
        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            info.AddValue("Name", Name);
            info.AddValue("Weight", Weight);
            info.AddValue("Height", Height);
            info.AddValue("AnimalID", AnimalID);

        }
        public animal(SerializationInfo info, StreamingContext ctxt)
        {
            Name = (string)info.GetValue("Name", typeof(string));
            Weight = (double)info.GetValue("Weight", typeof(double));
            Height = (double)info.GetValue("HEight", typeof(double));
            AnimalID = (int)info.GetValue("AnimalID", typeof(int));
        }
    }
           
}