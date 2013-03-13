/***********************************************************************
 * Module:  Cliente.cs
 * Author:  Paloschi
 * Purpose: Definition of the Class Cliente
 ***********************************************************************/

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Hotel.Models.poco
{
    [Table("tb_cliente")]
    public class Cliente
    {

        [Key]
        public long CliId { get; set; }
        public string CliNome { get; set; }
        public string CliTelefone { get; set; }
        public string CliCpf { get; set; }
        public string CliRg { get; set; }
        public DateTime CliDtRegistro { get; set; }
        public DateTime CliDtNascimento { get; set; }
        public string CliSexo { get; set; }
        public string CliEmail { get; set; }
        public string CliEndereco { get; set; }
        public string CliBairro { get; set; }

        public HashSet<Checkin> CliCheckinsRealizados { get; set; }
   
        /// <pdGenerated>default getter</pdGenerated>
        public HashSet<Checkin> GetCliCheckinsRealizados()
        {
            if (CliCheckinsRealizados == null)
                CliCheckinsRealizados = new HashSet<Checkin>();
            return CliCheckinsRealizados;
        }
   
        /// <pdGenerated>default setter</pdGenerated>
        public void SetCliCheckinsRealizados(HashSet<Checkin> newCheckin)
        {
            RemoveAllCheckin();
            foreach (Checkin oCheckin in newCheckin)
                AddCheckin(oCheckin);
        }
   
        /// <pdGenerated>default Add</pdGenerated>
        public void AddCheckin(Checkin newCheckin)
        {
            if (newCheckin == null)
                return;
            if (this.CliCheckinsRealizados == null)
                this.CliCheckinsRealizados = new HashSet<Checkin>();
            if (!this.CliCheckinsRealizados.Contains(newCheckin))
                this.CliCheckinsRealizados.Add(newCheckin);
        }
   
        /// <pdGenerated>default Remove</pdGenerated>
        public void RemoveCheckin(Checkin oldCheckin)
        {
            if (oldCheckin == null)
                return;
            if (this.CliCheckinsRealizados != null)
                if (this.CliCheckinsRealizados.Contains(oldCheckin))
                    this.CliCheckinsRealizados.Remove(oldCheckin);
        }
   
        /// <pdGenerated>default removeAll</pdGenerated>
        public void RemoveAllCheckin()
        {
            if (CliCheckinsRealizados != null)
                CliCheckinsRealizados.Clear();
        }


    }
}