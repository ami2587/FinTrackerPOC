using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessObjectLayer
{
    internal static class IdFetcher
    {
        static uint nextId = 0;

        /// <summary>
        /// Set the nextId when a file is read from database
        /// </summary>
        /// <param name="newId"></param>
        public static void SetNextId(uint newId)
        {
            nextId = newId;
        }

        public static uint GetNextId()
        {
            return nextId++;
        }
    }
}
