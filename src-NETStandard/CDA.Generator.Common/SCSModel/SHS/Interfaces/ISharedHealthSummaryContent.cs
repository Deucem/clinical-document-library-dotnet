﻿/*
 * Copyright 2013 NEHTA
 *
 * Licensed under the NEHTA Open Source (Apache) License; you may not use this
 * file except in compliance with the License. A copy of the License is in the
 * 'license.txt' file, which should be provided with this work.
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS, WITHOUT
 * WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied. See the
 * License for the specific language governing permissions and limitations
 * under the License.
 */

using System.Collections.Generic;
using JetBrains.Annotations;
using Nehta.HL7.CDA;
using Nehta.VendorLibrary.CDA.SCSModel.Common.Entities;
using Nehta.VendorLibrary.Common;

namespace Nehta.VendorLibrary.CDA.SCSModel
{
    /// <summary>
    /// This interface encapsulates all the SCS specific content for a shared health summary
    /// </summary>
    public interface ISharedHealthSummaryContent
    {
        /// <summary>
        /// Provide a custom Narrative 
        /// </summary>
        [CanBeNull]
        StrucDocText CustomNarrativeAdministrativeObservations { get; set; }

        /// <summary>
        /// A list of referenced documents that is the payload for this CDA document
        /// </summary>
        [CanBeNull]
        List<ExternalData> StructuredBodyFiles { get; set; }

        /// <summary>
        /// The reviewed adverse substance reactions
        /// </summary>
        [CanBeNull]
        IAdverseReactions AdverseReactions { get; set; }

        /// <summary>
        /// The reviewed medications
        /// </summary>
        [CanBeNull]
        IMedications Medications { get; set; }

        /// <summary>
        /// The reviewed medical history
        /// </summary>
        [CanBeNull]
        IMedicalHistory MedicalHistory { get; set; }

        /// <summary>
        /// The reviewed immunisations
        /// </summary>
        [CanBeNull]
        Immunisations Immunisations { get; set; }

        /// <summary>
        /// Validates this Shared Health Summary content
        /// </summary>
        /// <param name="path">The path to this object as a string</param>
        /// <param name="messages">the validation messages, these may be added to within this method</param>
        void Validate(string path, List<ValidationMessage> messages);
    }
}
