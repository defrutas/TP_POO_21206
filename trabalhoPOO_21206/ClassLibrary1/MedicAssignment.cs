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
        private int lastAssignedMedicIndex = 0;

        public MedicAssignment(List<Medic> medics)
        {
            this.medics = medics;
        }

        public void AssignMedics(List<Case> cases)
        {
            foreach (var caseItem in cases)
            {
                if (lastAssignedMedicIndex >= medics.Count)
                {
                    lastAssignedMedicIndex = 0; // Reset to the first medic if we reach the end of the list
                }

                // Assign the medic to the case
                caseItem.AssignedMedic = medics[lastAssignedMedicIndex];

                // Move to the next medic
                lastAssignedMedicIndex++;
            }
        }
    }
}
