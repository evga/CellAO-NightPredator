﻿#region License

// Copyright (c) 2005-2014, CellAO Team
// 
// 
// All rights reserved.
// 
// 
// Redistribution and use in source and binary forms, with or without modification, are permitted provided that the following conditions are met:
// 
// 
//     * Redistributions of source code must retain the above copyright notice, this list of conditions and the following disclaimer.
//     * Redistributions in binary form must reproduce the above copyright notice, this list of conditions and the following disclaimer in the documentation and/or other materials provided with the distribution.
//     * Neither the name of the CellAO Team nor the names of its contributors may be used to endorse or promote products derived from this software without specific prior written permission.
// 
// 
// THIS SOFTWARE IS PROVIDED BY THE COPYRIGHT HOLDERS AND CONTRIBUTORS
// "AS IS" AND ANY EXPRESS OR IMPLIED WARRANTIES, INCLUDING, BUT NOT
// LIMITED TO, THE IMPLIED WARRANTIES OF MERCHANTABILITY AND FITNESS FOR
// A PARTICULAR PURPOSE ARE DISCLAIMED. IN NO EVENT SHALL THE COPYRIGHT OWNER OR
// CONTRIBUTORS BE LIABLE FOR ANY DIRECT, INDIRECT, INCIDENTAL, SPECIAL,
// EXEMPLARY, OR CONSEQUENTIAL DAMAGES (INCLUDING, BUT NOT LIMITED TO,
// PROCUREMENT OF SUBSTITUTE GOODS OR SERVICES; LOSS OF USE, DATA, OR
// PROFITS; OR BUSINESS INTERRUPTION) HOWEVER CAUSED AND ON ANY THEORY OF
// LIABILITY, WHETHER IN CONTRACT, STRICT LIABILITY, OR TORT (INCLUDING
// NEGLIGENCE OR OTHERWISE) ARISING IN ANY WAY OUT OF THE USE OF THIS
// SOFTWARE, EVEN IF ADVISED OF THE POSSIBILITY OF SUCH DAMAGE.
// 

#endregion

namespace CellAO.Core.Playfields
{
    #region Usings ...

    using System.Collections.Generic;
    using System.Linq;

    using CellAO.Core.Statels;

    using SmokeLounge.AOtomation.Messaging.GameData;

    #endregion

    /// <summary>
    /// </summary>
    public class PlayfieldData
    {
        #region Fields

        /// <summary>
        /// key is destinationIndex
        /// </summary>
        public Dictionary<byte, PlayfieldDestination> Destinations = new Dictionary<byte, PlayfieldDestination>();

        /// <summary>
        /// </summary>
        public List<Door> Doors1 = new List<Door>();

        /// <summary>
        /// </summary>
        public string Name;

        /// <summary>
        /// </summary>
        public int PlayfieldId;

        /// <summary>
        /// </summary>
        public List<StatelData> Statels = new List<StatelData>();

        /// <summary>
        /// </summary>
        public List<PlayfieldWalls> Walls = new List<PlayfieldWalls>();

        public StatelData GetStatel(int instance)
        {
            return this.Statels.FirstOrDefault(x => x.Identity.Instance == instance);
        }

        public StatelData GetDoor(int instance)
        {
            return
                this.Statels.FirstOrDefault(
                    x => (x.Identity.Type == IdentityType.Door) && (x.Identity.Instance == instance));
        }

        #endregion
    }
}