﻿// =============================================================
// DFeBR - Documentos Fiscais Eletrônicos em .Net
// Projeto: DFeBR.NFe
// Autores: 
// Valnei Filho  e-mail: vmarinpietri@yahoo.com.br;
// Marco Polo  e-mail: marcopoloviana@hotmail.com
// Data Criação:26/03/2019
// Todos os direitos reservados
// =============================================================


#region

using DFeBR.EmissorNFe.Dominio.NotaFiscalEletronica.Informacoes.Detalhe.Tributacao.Estadual;
using DFeBR.EmissorNFe.Dominio.NotaFiscalEletronica.Informacoes.Detalhe.Tributacao.Federal;
using DFeBR.EmissorNFe.Dominio.NotaFiscalEletronica.Informacoes.Detalhe.Tributacao.Municipal;
using DFeBR.EmissorNFe.Utilidade;

#endregion

namespace DFeBR.EmissorNFe.Dominio.NotaFiscalEletronica.Informacoes.Detalhe.Tributacao
{
    public class imposto
    {
        #region Propriedades

        /// <summary>
        ///     M02 - Valor estimado total de impostos federais, estaduais e municipais
        /// </summary>
        public decimal? vTotTrib
        {
            get { return _vTotTrib.Arredondar(2); }
            set { _vTotTrib = value.Arredondar(2); }
        }

        /// <summary>
        ///     N01 - Dados do ICMS Normal e ST
        /// </summary>
        public ICMS ICMS { get; set; }

        /// <summary>
        ///     U01 - Grupo ISSQN
        /// </summary>
        public ISSQN ISSQN { get; set; }

        /// <summary>
        ///     O01 - Grupo IPI
        /// </summary>
        public IPI IPI { get; set; }

        /// <summary>
        ///     P01 - Grupo Imposto de Importação
        /// </summary>
        public II II { get; set; }

        /// <summary>
        ///     Q01 - Grupo PIS
        /// </summary>
        public PIS PIS { get; set; }

        /// <summary>
        ///     R01 - Grupo PIS Substituição Tributária
        /// </summary>
        public PISST PISST { get; set; }

        /// <summary>
        ///     S01 - Grupo COFINS
        /// </summary>
        public COFINS COFINS { get; set; }

        /// <summary>
        ///     T01 - Grupo COFINS Substituição Tributária
        /// </summary>
        public COFINSST COFINSST { get; set; }

        /// <summary>
        ///     NA01 - Informação do ICMS Interestadua
        /// </summary>
        public ICMSUFDest ICMSUFDest { get; set; }

        #endregion

        #region Variaveis Globais

        private decimal? _vTotTrib;

        #endregion

        public bool ShouldSerializevTotTrib()
        {
            return vTotTrib.HasValue;
        }
    }
}