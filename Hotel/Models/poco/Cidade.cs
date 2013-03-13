/***********************************************************************
 * Module:  Cidade.cs
 * Author:  Paloschi
 * Purpose: Definition of the Class Cidade
 ***********************************************************************/

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Hotel.Models.poco
{
    [Table("tb_cidade")]
    public class Cidade
    {

        [Key]
        public long CidId { get; set; }
        public string CidDescricao { get; set; }
        public string CidEstado { get; set; }
        public string CidEstadoAb { get; set; }

        public System.Collections.ArrayList funcionario  { get; set; }
   
        /// <pdGenerated>default getter</pdGenerated>
        public System.Collections.ArrayList GetFuncionario()
        {
            if (funcionario == null)
                funcionario = new System.Collections.ArrayList();
            return funcionario;
        }
   
        /// <pdGenerated>default setter</pdGenerated>
        public void SetFuncionario(System.Collections.ArrayList newFuncionario)
        {
            RemoveAllFuncionario();
            foreach (Funcionario oFuncionario in newFuncionario)
                AddFuncionario(oFuncionario);
        }
   
        /// <pdGenerated>default Add</pdGenerated>
        public void AddFuncionario(Funcionario newFuncionario)
        {
            if (newFuncionario == null)
                return;
            if (this.funcionario == null)
                this.funcionario = new System.Collections.ArrayList();
            if (!this.funcionario.Contains(newFuncionario))
                this.funcionario.Add(newFuncionario);
        }
   
        /// <pdGenerated>default Remove</pdGenerated>
        public void RemoveFuncionario(Funcionario oldFuncionario)
        {
            if (oldFuncionario == null)
                return;
            if (this.funcionario != null)
                if (this.funcionario.Contains(oldFuncionario))
                    this.funcionario.Remove(oldFuncionario);
        }
   
        /// <pdGenerated>default removeAll</pdGenerated>
        public void RemoveAllFuncionario()
        {
            if (funcionario != null)
                funcionario.Clear();
        }
        public System.Collections.ArrayList cliente;
   
        /// <pdGenerated>default getter</pdGenerated>
        public System.Collections.ArrayList GetCliente()
        {
            if (cliente == null)
                cliente = new System.Collections.ArrayList();
            return cliente;
        }
   
        /// <pdGenerated>default setter</pdGenerated>
        public void SetCliente(System.Collections.ArrayList newCliente)
        {
            RemoveAllCliente();
            foreach (Cliente oCliente in newCliente)
                AddCliente(oCliente);
        }
   
        /// <pdGenerated>default Add</pdGenerated>
        public void AddCliente(Cliente newCliente)
        {
            if (newCliente == null)
                return;
            if (this.cliente == null)
                this.cliente = new System.Collections.ArrayList();
            if (!this.cliente.Contains(newCliente))
                this.cliente.Add(newCliente);
        }
   
        /// <pdGenerated>default Remove</pdGenerated>
        public void RemoveCliente(Cliente oldCliente)
        {
            if (oldCliente == null)
                return;
            if (this.cliente != null)
                if (this.cliente.Contains(oldCliente))
                    this.cliente.Remove(oldCliente);
        }
   
        /// <pdGenerated>default removeAll</pdGenerated>
        public void RemoveAllCliente()
        {
            if (cliente != null)
                cliente.Clear();
        }



    }
}