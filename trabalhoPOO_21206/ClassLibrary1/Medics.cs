/*
*	<copyright file="Medics.cs" company="IPCA">
*		Copyright (c) 2023 All Rights Reserved
*	</copyright>
* 	<author>Flavio Carvalho 21206</author>
*	<description>Creates lists of medics</description>
**/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Medics
    {
        private List<Medic> medicList;
        /// <summary>
        /// creates a new list of medics
        /// </summary>
        public Medics()
        {
            medicList = new List<Medic>();
        }
        /// <summary>
        /// adds medics to the list
        /// </summary>
        /// <param name="name"></param>
        /// <param age="age"></param>
        /// <param gender="gender"></param>
        /// <param email="email"></param>
        /// <param specialization="specialization"></param>
        public void AddMedic(string name, int age, GenderType gender, string email, SpecializationType specialization)
        {
            Medic newMedic = new Medic(name, age, gender, email, specialization);
            medicList.Add(newMedic);
        }
        /// <summary>
        /// returns the medics, used to display the list
        /// </summary>
        /// <returns></returns>
        public List<Medic> GetMedics()
        {
            return medicList;
        }
    }
}
