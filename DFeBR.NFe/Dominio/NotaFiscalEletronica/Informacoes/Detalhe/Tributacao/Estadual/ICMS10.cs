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

using System.Xml.Serialization;
using DFeBR.EmissorNFe.Dominio.NotaFiscalEletronica.Informacoes.Detalhe.Tributacao.Estadual.Tipos;
using DFeBR.EmissorNFe.Utilidade;

#endregion

namespace DFeBR.EmissorNFe.Dominio.NotaFiscalEletronica.Informacoes.Detalhe.Tributacao.Estadual
{
    public class ICMS10 : ICMSBasico
    {
        #region Propriedades

        /// <summary>
        ///     N11 - Origem da Mercadoria
        /// </summary>
        [XmlElement(Order = 1)]
        public OrigemMercadoria orig { get; set; }

        /// <summary>
        ///     N12- Situação Tributária
        /// </summary>
        [XmlElement(Order = 2)]
        public Csticms CST { get; set; }

        /// <summary>
        ///     N13 - Modalidade de determinação da BC do ICMS
        /// </summary>
        [XmlElement(Order = 3)]
        public DeterminacaoBaseIcms modBC { get; set; }

        /// <summary>
        ///     N15 - Valor da BC do ICMS
        /// </summary>
        [XmlElement(Order = 4)]
        public decimal vBC
        {
            get { return _vBc.Arredondar(2); }
            set { _vBc = value.Arredondar(2); }
        }

        /// <summary>
        ///     N16 - Alíquota do imposto
        /// </summary>
        [XmlElement(Order = 5)]
        public decimal pICMS
        {
            get { return _pIcms.Arredondar(4); }
            set { _pIcms = value.Arredondar(4); }
        }

        /// <summary>
        ///     N17 - Valor do ICMS
        /// </summary>
        [XmlElement(Order = 6)]
        public decimal vICMS
        {
            get { return _vIcms.Arredondar(2); }
            set { _vIcms = value.Arredondar(2); }
        }

        /// <summary>
        ///     N17a - Valor da Base de Cálculo do FCP
        ///     Versão 4.00
        /// </summary>
        [XmlElement(Order = 7)]
        public decimal? vBCFCP
        {
            get { return _vBcfcp.Arredondar(2); }
            set { _vBcfcp = value.Arredondar(2); }
        }

        public bool vBCFCPSpecified
        {
            get { return vBCFCP.HasValue; }
        }

        /// <summary>
        ///     N17b - Percentual do Fundo de Combate à Pobreza (FCP)
        ///     Versão 4.00
        /// </summary>
        [XmlElement(Order = 8)]
        public decimal? pFCP
        {
            get { return _pFcp.Arredondar(4); }
            set { _pFcp = value.Arredondar(4); }
        }

        public bool pFCPSpecified
        {
            get { return pFCP.HasValue; }
        }

        /// <summary>
        ///     N17c - Valor do Fundo de Combate à Pobreza (FCP)
        ///     Versão 4.00
        /// </summary>
        [XmlElement(Order = 9)]
        public decimal? vFCP
        {
            get { return _vFcp.Arredondar(2); }
            set { _vFcp = value.Arredondar(2); }
        }

        public bool vFCPSpecified
        {
            get { return vFCP.HasValue; }
        }

        /// <summary>
        ///     N18 - Modalidade de determinação da BC do ICMS ST
        /// </summary>
        [XmlElement(Order = 10)]
        public DeterminacaoBaseIcmsSt modBCST { get; set; }

        /// <summary>
        ///     N19 - Percentual da margem de valor Adicionado do ICMS ST
        /// </summary>
        [XmlElement(Order = 11)]
        public decimal? pMVAST
        {
            get { return _pMvast.Arredondar(4); }
            set { _pMvast = value.Arredondar(4); }
        }

        /// <summary>
        ///     N20 - Percentual da Redução de BC do ICMS ST
        /// </summary>
        [XmlElement(Order = 12)]
        public decimal? pRedBCST
        {
            get { return _pRedBcst.Arredondar(4); }
            set { _pRedBcst = value.Arredondar(4); }
        }

        /// <summary>
        ///     N21 - Valor da BC do ICMS ST
        /// </summary>
        [XmlElement(Order = 13)]
        public decimal vBCST
        {
            get { return _vBcst.Arredondar(2); }
            set { _vBcst = value.Arredondar(2); }
        }

        /// <summary>
        ///     N22 - Alíquota do imposto do ICMS ST
        /// </summary>
        [XmlElement(Order = 14)]
        public decimal pICMSST
        {
            get { return _pIcmsst.Arredondar(4); }
            set { _pIcmsst = value.Arredondar(4); }
        }

        /// <summary>
        ///     N23 - Valor do ICMS ST
        /// </summary>
        [XmlElement(Order = 15)]
        public decimal vICMSST
        {
            get { return _vIcmsst.Arredondar(2); }
            set { _vIcmsst = value.Arredondar(2); }
        }

        /// <summary>
        ///     N23a - Valor da Base de Cálculo do FCP retido por Substituição Tributária
        ///     Versão 4.00
        /// </summary>
        [XmlElement(Order = 16)]
        public decimal? vBCFCPST
        {
            get { return _vBcfcpst.Arredondar(2); }
            set { _vBcfcpst = value.Arredondar(2); }
        }

        public bool vBCFCPSTSpecified
        {
            get { return vBCFCPST.HasValue; }
        }

        /// <summary>
        ///     N23b - Percentual do FCP retido por Substituição Tributária
        ///     Versão 4.00
        /// </summary>
        [XmlElement(Order = 17)]
        public decimal? pFCPST
        {
            get { return _pFcpst.Arredondar(4); }
            set { _pFcpst = value.Arredondar(4); }
        }

        public bool pFCPSTSpecified
        {
            get { return pFCPST.HasValue; }
        }

        /// <summary>
        ///     N23d - Valor do FCP retido por Substituição Tributária
        ///     Versão 4.00
        /// </summary>
        [XmlElement(Order = 18)]
        public decimal? vFCPST { get; set; }

        public bool vFCPSTSpecified
        {
            get { return vFCPST.HasValue; }
        }

        #endregion

        #region Variaveis Globais

        private decimal? _pFcp;
        private decimal? _pFcpst;
        private decimal _pIcms;
        private decimal _pIcmsst;
        private decimal? _pMvast;
        private decimal? _pRedBcst;
        private decimal _vBc;
        private decimal? _vBcfcp;
        private decimal? _vBcfcpst;
        private decimal _vBcst;
        private decimal? _vFcp;
        private decimal _vIcms;
        private decimal _vIcmsst;

        #endregion

        public bool ShouldSerializepMVAST()
        {
            return pMVAST.HasValue;
        }

        public bool ShouldSerializepRedBCST()
        {
            return pRedBCST.HasValue;
        }
    }
}