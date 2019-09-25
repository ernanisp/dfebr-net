﻿// ==================================================================
// DFeBR - Documentos Fiscais Eletrônicos em .Net
// Projeto: DFeBR.Emissor
// Autores: 
// Valnei Filho  e-mail: vmarinpietri@yahoo.com.br por DSBR Brasil Tecnologia www.DSBRBRASIL.com.br;
// Marco Polo  e-mail: marcopoloviana@hotmail.com 
// Data Criação:15/05/2019
// Todos os direitos reservados
// ===================================================================


#region

using System;

#endregion

namespace DFeBR.EmissorNFe.Utilidade.Exceptions
{
    public class FalhaTransmissaoDadosException : Exception
    {
        #region Construtor

        public FalhaTransmissaoDadosException()
        {
        }

        public FalhaTransmissaoDadosException(string message) : base(message)
        {
        }

        public FalhaTransmissaoDadosException(string message, Exception innerException) : base(message, innerException)
        {
        }

        #endregion
    }
}