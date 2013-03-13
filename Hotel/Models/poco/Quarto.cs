/***********************************************************************
 * Module:  Quarto.cs
 * Author:  Paloschi
 * Purpose: Definition of the Class Quarto
 ***********************************************************************/

using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Hotel.Models.poco
{
    [Table("tb_quarto")]
    public class Quarto
    {
        [Key]
        public long QuarId { get; set; }
        public string QuarNumero { get; set; }
        public string QuarDescricao { get; set; }
        public float QuarValorDia { get; set; }
        public StatusQuarto QuarStatus { get; set; }




        public HashSet<Checkin> QuarCheckinsRealizados { get; set; }

        /// <pdGenerated>default getter</pdGenerated>
        public HashSet<Checkin> GetCliCheckinsRealizados()
        {
            if (QuarCheckinsRealizados == null)
                QuarCheckinsRealizados = new HashSet<Checkin>();
            return QuarCheckinsRealizados;
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
            if (this.QuarCheckinsRealizados == null)
                this.QuarCheckinsRealizados = new HashSet<Checkin>();
            if (!this.QuarCheckinsRealizados.Contains(newCheckin))
                this.QuarCheckinsRealizados.Add(newCheckin);
        }

        /// <pdGenerated>default Remove</pdGenerated>
        public void RemoveCheckin(Checkin oldCheckin)
        {
            if (oldCheckin == null)
                return;
            if (this.QuarCheckinsRealizados != null)
                if (this.QuarCheckinsRealizados.Contains(oldCheckin))
                    this.QuarCheckinsRealizados.Remove(oldCheckin);
        }

        /// <pdGenerated>default removeAll</pdGenerated>
        public void RemoveAllCheckin()
        {
            if (QuarCheckinsRealizados != null)
                QuarCheckinsRealizados.Clear();

           
        }

        public string toString()
        {
            return this.QuarDescricao;
        }

        
    }
}