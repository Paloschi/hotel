/***********************************************************************
 * Module:  Checkin.cs
 * Author:  Paloschi
 * Purpose: Definition of the Class Checkin
 ***********************************************************************/

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Hotel.Models.poco
{
    [Table("tb_checkin")]
    public class Checkin
    {
        [Key]
        public long ChId { get; set; }
        public DateTime ChData { get; set; }
        public int ChPrevisao { get; set; }
        public DateTime ChSaida { get; set; }
        public float ChValor { get; set; }

        [InverseProperty("FunCheckinsRealizados")]
        public Funcionario ChFuncionario { get; set; }
        
        [InverseProperty("CliCheckinsRealizados")]
        public Cliente ChCliente { get; set; }
 
        public HashSet<Quarto> ChQuartos  { get; set; }
   

        /// <pdGenerated>default getter</pdGenerated>

        public HashSet<Quarto> GetQuarto()
        {
            if (ChQuartos == null)
                ChQuartos = new HashSet<Quarto>();
            return ChQuartos;
        }
   
        /// <pdGenerated>default setter</pdGenerated>
        public void SetQuarto(HashSet<Quarto> newQuarto)
        {
            RemoveAllQuarto();
            foreach (Quarto oQuarto in newQuarto)
                AddQuarto(oQuarto);
        }
   
        /// <pdGenerated>default Add</pdGenerated>
        public void AddQuarto(Quarto newQuarto)
        {
            if (newQuarto == null)
                return;
            if (this.ChQuartos == null)
                this.ChQuartos = new HashSet<Quarto>();
            if (!this.ChQuartos.Contains(newQuarto))
                this.ChQuartos.Add(newQuarto);
        }
   
        /// <pdGenerated>default Remove</pdGenerated>
        public void RemoveQuarto(Quarto oldQuarto)
        {
            if (oldQuarto == null)
                return;
            if (this.ChQuartos != null)
                if (this.ChQuartos.Contains(oldQuarto))
                    this.ChQuartos.Remove(oldQuarto);
        }
   
        /// <pdGenerated>default removeAll</pdGenerated>
        public void RemoveAllQuarto()
        {
            if (ChQuartos != null)
                ChQuartos.Clear();
        }



    }
}