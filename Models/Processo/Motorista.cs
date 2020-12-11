﻿using FreteFree.Models.Enum;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FreteFree.Models.Motorista
{
    public class Motorista
    {
        public Motorista( )
        {
          
        }
        [Key]
         [Display(Name = "ID")]
        public int MotoristaId { get; set; }

        //============ Proprietario Caminhão ===================
        [Required(ErrorMessage = "Preencha o Nome do Proprietario do Caminhão")]
        [Display(Name = "Nome Proprietario Caminhão")]
        public string CaminhaoProprietario { get; set; }

        [Required(ErrorMessage = "Preencha Endereço do Proprietario do Caminhão")]
        [Display(Name = "Endereço Proprietario Caminhão")]
        public string EnderecoProprietario { get; set; }

        [Required(ErrorMessage = "Preencha Telefone do Proprietario do Caminhão")]
        [Display(Name = "Telefone Proprietario Caminhão")]
        public decimal TelefoneProprietario { get; set; }

       
        

        [Required(ErrorMessage = "Preencha o Tipo Caminhão")]
        [Display(Name = "Tipo Caminhão")]
        public TipoCaminhao TipoCaminhao { get; set; }

        [Required(ErrorMessage = "Preencha o campo Nome Cliente")]
        [Display(Name = "Cliente")]
        public string PlacaCavalo { get; set; }

        [Required(ErrorMessage = "Preencha o campo Nome Cliente")]
        [Display(Name = "Cliente")]
        public string CidadeCavalo { get; set; }

        [Required(ErrorMessage = "Preencha o campo Nome Cliente")]
        [Display(Name = "Cliente")]
        public string EstadoCavalo { get; set; }

        [Required(ErrorMessage = "Preencha o campo Nome Cliente")]
        [Display(Name = "Cliente")]
        public string PlacaCarreta { get; set; }

        [Required(ErrorMessage = "Preencha o campo Nome Cliente")]
        [Display(Name = "Cliente")]
        public string CidadeCarreta { get; set; }
        public string EstadoCarreta { get; set; }

        //============ Motorista Caminhão ===================
        [Required(ErrorMessage = "Preencha o campo Nome do Motorista")]
        [Display(Name = "Nome Motorista")]
        public string NomeMotorista { get; set; }

        [Required(ErrorMessage = "Preencha o campo Endereço do Motorista")]
        [Display(Name = "Endereço Motorista")]
        public string EnderecoMotorista { get; set; }

        [Required(ErrorMessage = "Preencha o campo Telefone do Motorista")]
        [Display(Name = "Telefone Movel Motorista")]
        public decimal TelefoneMovel { get; set; }

        //[Required(ErrorMessage = "Preencha o campo Nome do Motorista")]
        [Display(Name = "Telefone Fixo Motorista")]
        public decimal TelefoneFixo { get; set; }

        [Required(ErrorMessage = "Preencha o campo Cidade do Motorista")]
        [Display(Name = "Cidade Motorista")]
        public string CidadeMotorista { get; set; }

        [Required(ErrorMessage = "Preencha o campo UF do Motorista")]
        [Display(Name = "UF Motorista")]
        public UF UF { get; set; }

        [Required(ErrorMessage = "Preencha o campo CPF do Motorista")]
        [Display(Name = "CPF Motorista")]
        public decimal CPFMotorista { get; set; }

        [Required(ErrorMessage = "Preencha o campo RG do Motorista")]
        [Display(Name = "RG Motorista")]
        public decimal RGMotorista { get; set; }

        [Required(ErrorMessage = "Preencha o campo CNPJ do Motorista")]
        [Display(Name = "CNPJ Motorista")]
        public decimal CNPJ { get; set; }

  
     //   public virtual ICollection<Motorista> motorista { get; set; }
    
        
    }
}