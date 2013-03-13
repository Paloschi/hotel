/***********************************************************************
 * Module:  StatusQuarto.cs
 * Author:  Paloschi
 * Purpose: Definition of the Class StatusQuarto
 ***********************************************************************/

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.JScript;

namespace Hotel.Models.poco
{
    [Table("tb_status_quarto")]
    public class StatusQuarto
    {
        [Key]
        public long StId { get; set; }
        public string StDescridao { get; set; }
        public bool StFlAlugavel { get; set; }
        [NotMapped]
        public StatusQuarto INSTANCE { get; set; }

        public StatusQuarto()
        {
            this.INSTANCE = this;
        }
        
        public System.Collections.ArrayList quarto;
   
        /// <pdGenerated>default getter</pdGenerated>
        public System.Collections.ArrayList GetQuarto()
        {
            if (quarto == null)
                quarto = new System.Collections.ArrayList();
            return quarto;
        }
   
        /// <pdGenerated>default setter</pdGenerated>
        public void SetQuarto(System.Collections.ArrayList newQuarto)
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
            if (this.quarto == null)
                this.quarto = new System.Collections.ArrayList();
            if (!this.quarto.Contains(newQuarto))
                this.quarto.Add(newQuarto);
        }
   
        /// <pdGenerated>default Remove</pdGenerated>
        public void RemoveQuarto(Quarto oldQuarto)
        {
            if (oldQuarto == null)
                return;
            if (this.quarto != null)
                if (this.quarto.Contains(oldQuarto))
                    this.quarto.Remove(oldQuarto);
        }
   
        /// <pdGenerated>default removeAll</pdGenerated>
        public void RemoveAllQuarto()
        {
            if (quarto != null)
                quarto.Clear();
          
        }

        [Override]
        public string toString()
        {
            return this.StDescridao;
        }

    }
}