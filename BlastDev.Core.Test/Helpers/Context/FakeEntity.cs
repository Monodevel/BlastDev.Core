using BlastDev.Core.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlastDev.Core.Test.Helpers.Context
{
    public class FakeEntity :IEntityLong<string>
    {
        public long Id { get; set; }
        /// <summary>
        /// Fake Name
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Estado del registro
        /// </summary>
        public bool State { get; set; }
        /// <summary>
        /// Id del usuario que creo el registro
        /// </summary>
        public string IdUserCreator { get; set; }
        /// <summary>
        /// Fecha de creación del registro
        /// </summary>
        public DateTime DateCreated { get; set; }
    }
}
