/*
*	<copyright file="MedicAssignment.cs" company="IPCA">
*		Copyright (c) 2023 All Rights Reserved
*	</copyright>
* 	<author>Flavio Carvalho 21206</author>
*	<description> used to assign different medics to available cases </description>
**/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class MedicAssignment
    {
        private List<Medic> medics;

        /// <summary>
        /// medicAssignment constrctor
        /// </summary>
        /// <param name="medics"></param>
        public MedicAssignment(List<Medic> medics)
        {
            this.medics = medics;
        }

        /// <summary>
        /// assigns a random medic to an available case
        /// </summary>
        /// <param name="activeCase"></param>
        /// <returns></returns>
        public bool AssignMedic(Case activeCase)
        {
            // Check if there are available medics
            if (medics.Count > 0)
            {
                // Assign a random available medic to the case
                Random random = new Random();
                int index = random.Next(medics.Count);
                activeCase.AssignedMedic = medics[index];

                // Remove the assigned medic from the available medics list
                medics.RemoveAt(index);

                return true;
            }

            // No available medics to assign
            return false;
        }
    }
}
