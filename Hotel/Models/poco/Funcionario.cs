/***********************************************************************
 * Module:  Funcionario.cs
 * Author:  Paloschi
 * Purpose: Definition of the Class Funcionario
 ***********************************************************************/

using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Hotel.Models.poco
{
    [Table("tb_funcionario")]
    public class Funcionario
    {

        [Key]
        public long FunId { get; set; }
        
        public string FunNome { get; set; }
        public string FunTelefone { get; set; }
        public string FunCpf { get; set; }
        public string FunRg { get; set; }
        public DateTime FunDtRegistro { get; set; }
        public DateTime FunDtNascimento { get; set; }
        public string FunSexo { get; set; }
        public string FunEmail { get; set; }
        public string FunEndereco { get; set; }
        public string FunBairro { get; set; }
        public string FunLogin { get; set; }
        public string FunSenha { get; set; }


        public HashSet<Checkin> FunCheckinsRealizados { get; set; }

        /// <pdGenerated>default getter</pdGenerated>
        public HashSet<Checkin> GetFunCheckinsRealizados()
        {
            if (FunCheckinsRealizados == null)
                FunCheckinsRealizados = new HashSet<Checkin>();
            return  FunCheckinsRealizados;
        }
   
        /// <pdGenerated>default setter</pdGenerated>
        public void SetFunCheckinsRealizados(HashSet<Checkin> newCheckin)
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
            if (this.FunCheckinsRealizados == null)
                this.FunCheckinsRealizados = new HashSet<Checkin>();
            if (!this.FunCheckinsRealizados.Contains(newCheckin))
                this.FunCheckinsRealizados.Add(newCheckin);
        }
   
        /// <pdGenerated>default Remove</pdGenerated>
        public void RemoveCheckin(Checkin oldCheckin)
        {
            if (oldCheckin == null)
                return;
            if (this.FunCheckinsRealizados != null)
                if (this.FunCheckinsRealizados.Contains(oldCheckin))
                    this.FunCheckinsRealizados.Remove(oldCheckin);
        }
   
        /// <pdGenerated>default removeAll</pdGenerated>
        public void RemoveAllCheckin()
        {
            if (FunCheckinsRealizados != null)
                FunCheckinsRealizados.Clear();
        }


    }
}